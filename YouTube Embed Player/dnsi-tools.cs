
#define DNSI

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace dnsi
{
    sealed class Tools
    {
        public static void Base64ToStream(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            var ms = new MemoryStream(bytes, 0, bytes.Length);
        }

        public static Image StreamToImage(Stream stream) { return Bitmap.FromStream(stream); }
        public static Icon StreamToIcon(Stream stream) { return new Icon(stream); }

        public static void GetStreamByUri(Uri uri, Action<Stream> callback)
        {
            WebClient webClient = new WebClient();

            webClient.DownloadStringCompleted += (s, e) => {
                try
                {
                    string data = e.Result;
                    var stream = new StreamWriter(new MemoryStream(Encoding.Default.GetBytes(data)));
                    callback(stream.BaseStream);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error on download : " + ex.Message);
                }
            };

            webClient.DownloadStringAsync(uri);
        }

        public static void GetImageByUri(Uri uri, Action<Image> callback)
        {
            GetStreamByUri(uri, (s) => { callback(StreamToImage(s)); });
        }

        public static void GetIconByUri(Uri uri, Action<Icon> callback)
        {
            GetStreamByUri(uri, (s) => { callback(StreamToIcon(s)); });
        }
    }
}
