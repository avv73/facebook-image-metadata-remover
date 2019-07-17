using System;
using System.Collections.Generic;
using System.Text;

namespace FBMetadataRemover.Interfaces
{
    public interface IOutputHandler
    {
        void Write(string message);
        void WriteLine(string message);
        string Read();
        void Hold();
    }
}
