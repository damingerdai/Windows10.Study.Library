using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows10.Study.Library.Background
{
    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
