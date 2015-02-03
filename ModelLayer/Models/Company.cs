using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class Company
    {

        private string _Name;
        private int _id;

        public int id { get { return _id; } }
        public string Name { get { return _Name; } }

        public Company()
        {

        }

        public Company(int id, string Name)
        {
            this._Name = Name;
        }
    }
}
