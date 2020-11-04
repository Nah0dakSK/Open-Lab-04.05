using System;
using System.Linq;
using System.Text;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            return new String(Enumerable.Range(0, n).SelectMany(x => orig).ToArray());
        }
    }
}
