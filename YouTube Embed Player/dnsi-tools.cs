
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
        private const string dnsiLibsPath = "https://github.com/nquenault/dnsi/raw/master/libraries/";

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
            GetStreamByUri(uri, (s) => { callback(Bitmap.FromStream(s)); });
        }

        public static void GetIconByUri(Uri uri, Action<Icon> callback)
        {
            GetStreamByUri(uri, (s) => { callback(new Icon(s)); });
        }
    }
}
