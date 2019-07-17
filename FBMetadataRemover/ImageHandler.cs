using FBMetadataRemover.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FBMetadataRemover
{
    public class ImageHandler : IImageHandler
    {
        private const string FB_TAG = "FBMD";

        public string FilePath { get; }

        public ImageHandler(string path)
        {
            this.FilePath = ValidateFile(path);
        }

        public string FetchTag()
        {
            byte[] imageTagArray = new byte[98];

            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(55, SeekOrigin.Begin);
                fs.Read(imageTagArray, 0, 98);

                string imageTag = Encoding.ASCII.GetString(imageTagArray);

                if (imageTag.Substring(0, 4) != FB_TAG)
                {
                    throw new Exception(OutputMessages.TagNotFoundError);
                }

                return imageTag;
            }
        }

        public void RemoveTag()
        {
            byte[] allNullArray = new byte[98];

            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Write))
            {
                fs.Seek(55, SeekOrigin.Begin);
                fs.Write(allNullArray, 0, 98);
            }

        }

        private string ValidateFile(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }

            return path;
        }
    }
}
