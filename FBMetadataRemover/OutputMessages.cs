
using System;

namespace FBMetadataRemover
{
    static class OutputMessages
    {
        public static string StartUpMessage = @" 
                      ===FACEBOOK METADATA IMAGE REMOVER===

GitHub: https://github.com/avv73


A simple tool to remove the annoying IPTC metadata tag from a Facebook image.
For more info, please read README.md in the Github repository.

Please input path to a IPTC-tagged Facebook image:
";
        public static string FileInputMessage = "Please input path to a IPTC-tagged Facebook image:";
        public static string TagFoundMessage = "[*] Found Facebook IPTC tag in the image: {0}";
        public static string RemovingMessage = "[*] Removing...";
        public static string SuccessMessage = "[*] Sucessfully removed IPTC Facebook tag from image. Press any key to terminate.";

        public static string FileNotFoundError = "[!] No such file exists.";
        public static string TagNotFoundError = "[!] No IPTC Facebook tag found in the image. Press any key to terminate.";
        public static string WriteError = "[!] Found an error while trying to remove tag: {0}" + Environment.NewLine + "[!] If you found a bug, please report it in the Github repository. Press any key to terminate.";


    }
}
