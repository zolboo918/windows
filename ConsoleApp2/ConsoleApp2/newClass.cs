using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolboo
{
    namespace Lab1
    {
        class newClass
        {
            private String name;
            public String ner
            {
                get
                {
                    return name;
                }
                set
                {
                    name = ner;
                }
            }

            public void print()
            {
                Console.WriteLine(this.name);
            }
            public void setName(String ner)
            {
                this.name = ner;
            }
        }
    }
}
