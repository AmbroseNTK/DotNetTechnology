using System;
using System.Collections.Generic;
using System.Text;

namespace W07
{
    public delegate void FileEventHandle(string fileName);
    public class File
    {
        private string fileName;
        public event FileEventHandle FileOpenEvent;
        public event FileEventHandle FileSaveEvent;

        public string FileName
        {
            get => fileName;
            set => fileName = value;
        }

        public virtual void Open()
        {
            Console.WriteLine("Opening");
            FileOpenEvent(fileName);
        }

        public virtual void Save()
        {
            Console.WriteLine("Saving");
            FileSaveEvent(fileName);
        }

    }
}
