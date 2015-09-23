using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter2
{
    class Sorts
    {
        public int ID { get; private set; }
        public string SortName { get; private set; }
        public delegate int[] SortMethod(int[] arr);
        public event SortMethod sortEvent;

        public Sorts(int _ID, string _SortName)
        {
            ID = _ID;
            SortName = _SortName;
        }
    }
}
