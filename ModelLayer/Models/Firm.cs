using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models {
    public class Firm {

        private int _CVRNR;
        private string _Name;
        private int _Telephone;

        public int CVRNR { get { return _CVRNR; } }
        public string Name { get { return _Name; } }
        public int Telephone { get { return _Telephone; } }

        public Firm(int CVRNR, string Name, int Telephone) {
            this._CVRNR = CVRNR;
            this._Name = Name;
            this._Telephone = Telephone;
        }
    }
}
