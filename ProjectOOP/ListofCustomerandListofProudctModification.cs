﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectOOP
{

    interface IUseForModifyCustomerAndProduct
    {
        void Findexchange();
        void Findname();
        void Maxmoneyspent();
    }
    //có 2 interfacedc thửa hường bởi class này, inputlistofproduct,inputlistofcustomer
    class ListofCustomerandListofProudctModification :  IUseForGetlistproduct, IUseForGetlistcustomer, IUseForModifyCustomerAndProduct
    {
        protected List<Product> ListofProduct;
        protected List<Customer> ListofCustomer;
        public ListofCustomerandListofProudctModification()
        {
            ListofProduct = new List<Product>();
            ListofCustomer = new List<Customer>();
        }
        public ListofCustomerandListofProudctModification(List<Product> listofproduct, List<Customer> listofcustomer)
        {
            this.ListofProduct = listofproduct;
            this.ListofCustomer = listofcustomer;
        }
        public void Inputlistofproduct()
        {
            var threefirstlines = File.ReadLines(@"E:\Product.txt").Take(3);
            foreach (var line in threefirstlines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Computer { Nameofproduct = splitline[0], Serialnumber = splitline.Length > 1 ? splitline[1] : null, Type = splitline.Length > 2 ? splitline[2] : null, Price = splitline.Length > 3 ? splitline[3] : null, CPU = splitline.Length > 4 ? splitline[4] : null });
                }
            }
            var threenextlines = File.ReadLines(@"E:\Product.txt").Skip(3).Take(3);
            foreach (var line in threenextlines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Mouse { Nameofproduct = splitline[0], Serialnumber = splitline.Length > 1 ? splitline[1] : null, Type = splitline.Length > 2 ? splitline[2] : null, Price = splitline.Length > 3 ? splitline[3] : null, Quality = splitline.Length > 4 ? splitline[4] : null });
                }
            }
            var lastthreelines = File.ReadLines(@"E:\Product.txt").Skip(6).Take(3);
            foreach (var line in lastthreelines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Keyboard { Nameofproduct = splitline[0], Serialnumber = splitline.Length > 1 ? splitline[1] : null, Type = splitline.Length > 2 ? splitline[2] : null, Price = splitline.Length > 3 ? splitline[3] : null, COlor = splitline.Length > 4 ? splitline[4] : null });
                }
            }
        }
        public void OutputlistofProduct()
        {}
        public void InputListofCustomer()
        {
            var alllines = File.ReadAllLines(@"E:\Customer.txt");
            foreach (var line in alllines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofCustomer.Add(new Customer { CUStomername = splitline[0], PHOnenumber = splitline.Length > 1 ? splitline[1] : null, MONeyspent = splitline.Length > 2 ? splitline[2] : null, NAMEofproductbought = splitline.Length > 3 ? splitline[3] : null, SERIALnumberofproductbought = splitline.Length > 4 ? splitline[4] : null });
                }
            }
        }
        public void OutputlistofCustomer()
        {}
        public void Findexchange()
        {
            Console.WriteLine("*********************");
            double exchange = 0;
            for (int i = 0; i < ListofProduct.Count; i++)
            {
                for (int j = 0; j < ListofCustomer.Count; j++)
                {
                    exchange = Convert.ToDouble(ListofCustomer[i].MONeyspent) - Convert.ToDouble(ListofProduct[i].Price);
                }
                Console.WriteLine("Exchange of customer {0} - {1}", i, exchange);
            }
            Console.WriteLine("*********************");
        }
        public void Findname()
        {
            Console.WriteLine("*********************");
            for (int i=0; i<ListofCustomer.Count; i++)
            {
                if (ListofCustomer[i].CUStomername == "Ben")
                {
                    ListofCustomer[i].Outputinformation();
                }
            }
            Console.WriteLine("*********************");
        }
        public Customer Greatestmoneyspent()
        {
            Customer max = this.ListofCustomer[0];
            for (int i=1; i<ListofCustomer.Count; i++)
            {
                if(Convert.ToDouble(max.MONeyspent) < Convert.ToDouble(ListofCustomer[i].MONeyspent))
                {
                    max = ListofCustomer[i];
                }
            }
            return max;
        }
        public void Maxmoneyspent()
        {
            Console.WriteLine("*********************");
            Greatestmoneyspent().Outputinformation();
            Console.WriteLine("*********************");
        }
    }
}
