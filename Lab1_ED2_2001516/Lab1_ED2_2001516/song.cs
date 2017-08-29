using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ED2_2001516
{
    class Song : IComparable<Song>
    {
        public string name { get; set; }
        public string artist { get; set; }
        public double duration { get; set; }
        public string album { get; set; }
        public string file { get; set; }

        public int CompareTo(Song other)
        {
            if (this.duration > other.duration)
            {
                return 1;
            }else if (this.duration < other.duration)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }

        
    }
}
