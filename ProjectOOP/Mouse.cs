using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Mouse :Product
    {
        private string _quality;
        public string Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }
        public Mouse () :base()
        {

        }
        public Mouse(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE, string quality) : base(Nameofproduct, SeRialnumber, TYPE, PRICE)
        {
            this._quality = quality;
        }
        public override void OutputlistofProduct()
        {
            base.OutputlistofProduct();
            Console.WriteLine("Quality: " + this._quality);
        }
    }
}
