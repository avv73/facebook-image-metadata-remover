using System;
using System.Collections.Generic;
using System.Text;

namespace FBMetadataRemover.Interfaces
{
    public interface IImageHandler
    {
        string FilePath { get; }
        string FetchTag();
        void RemoveTag();
    }
}
