using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core
{
    public class LightAvailability
    {
        private double _status = 0;
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public double Status {
            get {
                return _status;
            } set {
                if (value > 1 || value < 0) throw new InvalidOperationException("Status must between 0 and 1");
                _status = value;
            } }
    }
}
