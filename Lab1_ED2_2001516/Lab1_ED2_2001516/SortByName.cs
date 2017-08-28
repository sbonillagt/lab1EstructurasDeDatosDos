using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ED2_2001516
{
    class SortByName : IComparer<Song>
    {
          public int Compare(Song x, Song y)
            {
                return x.name.CompareTo(y.name);
            }
    }
}
