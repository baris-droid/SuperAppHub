using System;
using System.Runtime.InteropServices;

namespace SmartApp
{

    public interface IDiscordBackend : IDisposable
    {
        bool Connect(string clientId);
        void Update(string details, string state, string largeImage);
        void Disconnect();
    }

    public class DiscordNativeWrapper : IDiscordBackend
    {
        // Dışarıdan bağladığımız C kütüphanesinin adı
        private const string DllName = "DiscordBackend.dll";
        
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern bool ConnectToDiscord(string clientId);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void UpdatePresence(string details, string state, string largeImage);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern void DisconnectDiscord();

        public bool Connect(string clientId)
        {
            // Güvenlik: Boş metin gönderip C tarafında pointer hatasına yol açmayı engelliyoruz
            if (string.IsNullOrWhiteSpace(clientId)) return false;

            return ConnectToDiscord(clientId);
        }

        public void Update(string details, string state, string largeImage)
        {
            UpdatePresence(details ?? "", state ?? "", largeImage ?? "");
        }

        // Yönetilmeyen (Unmanaged) bellek temizliği
        public void Dispose()
        {
            DisconnectDiscord();

            // Performans: Garbage Collector'a (GC) "Ben bu nesneyi kendim temizledim, 
            // senin uğraşmana gerek yok" diyerek CPU yükünü hafifletiyoruz.
            GC.SuppressFinalize(this);
        }
        public void Disconnect()
        {
            DisconnectDiscord();
        }
    }
}