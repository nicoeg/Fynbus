using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fynbus.Models {
    class Firm {
        public int CVRNR { get; set; }
        public string Name { get; set; }
        public int Telephone { get; set; }

        public Firm(int CVRNR, string Name, int Telephone) {
            this.CVRNR = CVRNR;
            this.Name = Name;
            this.Telephone = Telephone;
        }
    }
}
