using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    interface IOutputproduct
    {
        void OutputlistofProduct();
    }
    class Product : IOutputproduct
    {
        protected string _nameofProduct;
        protected string _serialnumber;
        protected string  _type;
        protected string _price;
        public string Nameofproduct
        {
            get { return this._nameofProduct; }
            set { this._nameofProduct = value; }
        }
        public string Serialnumber
        {
            get { return this._serialnumber; }
            set { this._serialnumber = value; }
        }
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        public string Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public Product()
        {

        }
        public Product(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE)
        {
            this._nameofProduct = Nameofproduct;
            this._serialnumber = SeRialnumber;
            this._type = TYPE;
            this._price = PRICE;
        }
        public virtual void OutputlistofProduct()
        {
            Console.WriteLine("Name of Product: " + this._nameofProduct);
            Console.WriteLine("Serial Number: " + this._serialnumber);
            Console.WriteLine("Type: " + this._type);
            Console.WriteLine("Price: " + this._price);
        }
    }
}
