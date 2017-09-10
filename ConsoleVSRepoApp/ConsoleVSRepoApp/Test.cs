using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace ConsoleVSRepoApp
{
    class Test
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void doIt()
        {
            Shared.Method();
        }
    }
}
