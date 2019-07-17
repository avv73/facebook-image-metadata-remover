using FBMetadataRemover.Interfaces;
using System;
using System.IO;

namespace FBMetadataRemover
{
    class Program
    {

        static void Main(string[] args)
        {
            IOutputHandler outputHandler = new OutputHandler();

            outputHandler.Write(OutputMessages.StartUpMessage);
            string taggedImagePath = outputHandler.Read();

            IImageHandler imageHandler = new ImageHandler(taggedImagePath);

            while (imageHandler.FilePath is null)
            {
                outputHandler.WriteLine(OutputMessages.FileNotFoundError);
                outputHandler.WriteLine(OutputMessages.FileInputMessage);

                imageHandler = new ImageHandler(outputHandler.Read());
            }

            string imageTag;
            try
            {
                imageTag = imageHandler.FetchTag();
            }
            catch (Exception ex)
            {
                outputHandler.WriteLine(ex.Message);
                outputHandler.Hold();
                return;
            }

            outputHandler.WriteLine(string.Format(OutputMessages.TagFoundMessage, imageTag));
            outputHandler.WriteLine(OutputMessages.RemovingMessage);

            try
            {
                imageHandler.RemoveTag();
            }
            catch (Exception ex)
            {
                outputHandler.WriteLine(string.Format(OutputMessages.WriteError, ex.Message));
                outputHandler.Hold();
                return;
            }

            outputHandler.WriteLine(OutputMessages.SuccessMessage);
            outputHandler.Hold();
        }
    }
}


