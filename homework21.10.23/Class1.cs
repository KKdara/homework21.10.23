using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework21._10._23
{
    internal class Song
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Song Prev { get; set; }
        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            Prev = prev;
        }
        public string Title()
        {
            return Name + "-" + Author;
        }
        public override bool Equals(object d)
        {
            if (d == null || GetType().Equals(d.GetType()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
