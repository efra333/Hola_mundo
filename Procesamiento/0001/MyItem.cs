using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0001
{
    public class MyItem
    {
        string name;
        public string Tag;

        public MyItem(string name,string completeName)
        {
            this.name = name;
            this.Tag = completeName;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
