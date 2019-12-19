﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Computer :Product
    {
        protected string Cpu;
        public string CPU
        {
            get { return this.Cpu; }
            set { this.Cpu = value; }
        }
        public Computer (): base()
        {

        }
        public Computer(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE, string cpu): base(Nameofproduct, SeRialnumber, TYPE, PRICE)
        {
            this.Cpu = cpu;
        }
        public override void OutputlistofProduct()
        {
            base.OutputlistofProduct();
            Console.WriteLine("CPU: " + this.Cpu);
        }
    }
}
