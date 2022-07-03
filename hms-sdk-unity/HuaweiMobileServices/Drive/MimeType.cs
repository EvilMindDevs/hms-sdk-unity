using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Drive
{
    public class MimeType
    {

        // Default File Type
        public static String DEFAULT = "*/*";

        // All cached MimeType types based on file suffixes
        public static IMap<String, String> MIME_TYPE_MAP = new HashMap<String, String>();

        private static void InitMap() 
        {
                MIME_TYPE_MAP.Put(".3gp", "video/3gpp");
                MIME_TYPE_MAP.Put(".apk", "application/vnd.android.package-archive");
                MIME_TYPE_MAP.Put(".asf", "video/x-ms-asf");
                MIME_TYPE_MAP.Put(".avi", "video/x-msvideo");
                MIME_TYPE_MAP.Put(".bin", "application/octet-stream");
                MIME_TYPE_MAP.Put(".bmp", "image/bmp");
                MIME_TYPE_MAP.Put(".c", "text/plain");
                MIME_TYPE_MAP.Put(".class", "application/octet-stream");
                MIME_TYPE_MAP.Put(".conf", "text/plain");
                MIME_TYPE_MAP.Put(".cpp", "text/plain");
                MIME_TYPE_MAP.Put(".doc", "application/msword");
                MIME_TYPE_MAP.Put(".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                MIME_TYPE_MAP.Put(".xls", "application/vnd.ms-excel");
                MIME_TYPE_MAP.Put(".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                MIME_TYPE_MAP.Put(".exe", "application/octet-stream");
                MIME_TYPE_MAP.Put(".gif", "image/gif");
                MIME_TYPE_MAP.Put(".gtar", "application/x-gtar");
                MIME_TYPE_MAP.Put(".gz", "application/x-gzip");
                MIME_TYPE_MAP.Put(".h", "text/plain");
                MIME_TYPE_MAP.Put(".htm", "text/html");
                MIME_TYPE_MAP.Put(".html", "text/html");
                MIME_TYPE_MAP.Put(".jar", "application/java-archive");
                MIME_TYPE_MAP.Put(".java", "text/plain");
                MIME_TYPE_MAP.Put(".jpeg", "image/jpeg");
                MIME_TYPE_MAP.Put(".jpg", "image/jpeg");
                MIME_TYPE_MAP.Put(".js", "application/x-javascript");
                MIME_TYPE_MAP.Put(".log", "text/plain");
                MIME_TYPE_MAP.Put(".m3u", "audio/x-mpegurl");
                MIME_TYPE_MAP.Put(".m4a", "audio/mp4a-latm");
                MIME_TYPE_MAP.Put(".m4b", "audio/mp4a-latm");
                MIME_TYPE_MAP.Put(".m4p", "audio/mp4a-latm");
                MIME_TYPE_MAP.Put(".m4u", "video/vnd.mpegurl");
                MIME_TYPE_MAP.Put(".m4v", "video/x-m4v");
                MIME_TYPE_MAP.Put(".mov", "video/quicktime");
                MIME_TYPE_MAP.Put(".mp2", "audio/x-mpeg");
                MIME_TYPE_MAP.Put(".mp3", "audio/x-mpeg");
                MIME_TYPE_MAP.Put(".mp4", "video/mp4");
                MIME_TYPE_MAP.Put(".mpc", "application/vnd.mpohun.certificate");
                MIME_TYPE_MAP.Put(".mpe", "video/mpeg");
                MIME_TYPE_MAP.Put(".mpeg", "video/mpeg");
                MIME_TYPE_MAP.Put(".mpg", "video/mpeg");
                MIME_TYPE_MAP.Put(".mpg4", "video/mp4");
                MIME_TYPE_MAP.Put(".mpga", "audio/mpeg");
                MIME_TYPE_MAP.Put(".msg", "application/vnd.ms-outlook");
                MIME_TYPE_MAP.Put(".ogg", "audio/ogg");
                MIME_TYPE_MAP.Put(".pdf", "application/pdf");
                MIME_TYPE_MAP.Put(".png", "image/png");
                MIME_TYPE_MAP.Put(".pps", "application/vnd.ms-powerpoint");
                MIME_TYPE_MAP.Put(".ppt", "application/vnd.ms-powerpoint");
                MIME_TYPE_MAP.Put(".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation");
                MIME_TYPE_MAP.Put(".prop", "text/plain");
                MIME_TYPE_MAP.Put(".rc", "text/plain");
                MIME_TYPE_MAP.Put(".rmvb", "audio/x-pn-realaudio");
                MIME_TYPE_MAP.Put(".rtf", "application/rtf");
                MIME_TYPE_MAP.Put(".sh", "text/plain");
                MIME_TYPE_MAP.Put(".tar", "application/x-tar");
                MIME_TYPE_MAP.Put(".tgz", "application/x-compressed");
                MIME_TYPE_MAP.Put(".txt", "text/plain");
                MIME_TYPE_MAP.Put(".wav", "audio/x-wav");
                MIME_TYPE_MAP.Put(".wma", "audio/x-ms-wma");
                MIME_TYPE_MAP.Put(".wmv", "audio/x-ms-wmv");
                MIME_TYPE_MAP.Put(".wps", "application/vnd.ms-works");
                MIME_TYPE_MAP.Put(".xml", "text/plain");
                MIME_TYPE_MAP.Put(".z", "application/x-compress");
                MIME_TYPE_MAP.Put(".zip", "application/x-zip-compressed");
        }

     /**
     * Match the MIMETYPE based on the file name suffix.
     *
     * @param suffix File Name suffix
     * @return MimeType
     */
        public static String MimeTypeFromSuffix(String suffix)
        {
            if (MIME_TYPE_MAP.Size()==0) 
            {
                InitMap();  
            }

            if (suffix.StartsWith("."))
            {
                return MIME_TYPE_MAP.Get(suffix);
            }
            else
            {
                Console.WriteLine("[HMS] MineType.cs MimeTypeFromSuffix using default value.");
                return DEFAULT;
            }
        }

    }
}
