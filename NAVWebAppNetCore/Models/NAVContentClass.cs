using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAVWebAppNetCore.Models
{
    public class NAVContentClass
    {
        public string No { get; set; }
        public string Name { get; set; }

        public NAVContentClass(string no, string name)
        {
            No = no;
            Name = name;
        }
    }
}
