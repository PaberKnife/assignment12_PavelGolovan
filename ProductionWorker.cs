using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12_PavelGolovan
{
    class ProductionWorker : Employee
    {
        private int _shift;
        private double _pay_rate;

        public ProductionWorker()
        {
            _shift = -1;
            _pay_rate = -1;
        }

        public string Show()
        {
            if (_shift == 1)
            {
                return "Selected employee:\n\nJob: Production Worker\n\nName: " + Name + ";\nNumber: " + Number.ToString() + ";\nShift: Day;\nHourly pay rate: " + PayRate.ToString("C") + ".";
            }
            else
            {
                return "Selected employee:\n\nJob: Production Worker\n\nName: " + Name + ";\nNumber: " + Number.ToString() + ";\nShift: Night;\nHourly pay rate: " + PayRate.ToString("C") + ".";
            }
        }

        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public double PayRate
        {
            get { return _pay_rate; }
            set { _pay_rate = value; }
        }
    }
}