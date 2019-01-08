using System;
using System.Collections.Generic;
using System.Text;

namespace W04
{
    public class Folder : IComparable<Folder>
    {
        private string name;
        private string location;
        private DateTime modifyDate;
        private long size;
        private string author;

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public DateTime ModifyDate { get => modifyDate; set => modifyDate = value; }
        public long Size { get => size; set => size = value; }
        public string Author { get => author; set => author = value; }

        public Folder()
        {

        }

        public Folder(string name, string location, DateTime modifyDate, long size, string author)
        {
            this.name = name;
            this.location = location;
            this.modifyDate = modifyDate;
            this.size = size;
            this.author = author;
        }

        public override string ToString()
        {
            return Location + "; " + Name + "; " + ModifyDate.ToShortDateString() + "; " + Size + " KB; " + Author;
        }

        public int CompareTo(Folder other)
        {
            if (this.location.CompareTo(other.Location) == 0)
            {
                if (this.author.CompareTo(other.author) == 0)
                {
                    if (this.size.CompareTo(other.Size) == 0)
                    {
                        if (this.name.CompareTo(other.Name) == 0)
                        {
                            return this.modifyDate.CompareTo(other.ModifyDate);
                        }
                        return this.size.CompareTo(other.Size);
                    }
                    return this.size.CompareTo(other.Size);
                }
                return this.author.CompareTo(other.author);
            }
            return this.location.CompareTo(other.Location);
        }
    }
}
