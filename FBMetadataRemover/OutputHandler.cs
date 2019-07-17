using FBMetadataRemover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBMetadataRemover
{
    public class OutputHandler : IOutputHandler
    {
        public OutputHandler()
        {

        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string Read()
        {
            return Console.ReadLine();
        }

        public void Hold()
        {
            Console.ReadKey();
        }
    }
}
