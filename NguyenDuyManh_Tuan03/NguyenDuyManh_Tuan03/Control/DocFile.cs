using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Control
{
    class DocFile
    {
        string dd;

        public string Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public DocFile(string duongdan)
        {
            dd = duongdan;
        }
    }
}
