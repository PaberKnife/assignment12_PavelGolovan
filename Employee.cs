using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_PavelGolovan
{
    class Employee
    {
        private string _name;
        private int _number;

        public Employee()
        {
            _name = "";
            _number = -1;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}