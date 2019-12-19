using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectOOP
{
    interface IUseForGetlistproduct
    {
        void Inputlistofproduct();
        void OutputlistofProduct();
    }
    class GetListProduct : IUseForGetlistproduct
    {
        protected List<Product> ListofProduct;
        public GetListProduct()
        {
            ListofProduct = new List<Product>();
        }
        public GetListProduct(List<Product> listofproduct)
        {
            this.ListofProduct = listofproduct;
        }
        public  void Inputlistofproduct()
        {
            var threefirstlines = File.ReadLines(@"E:\Product.txt").Take(3);
            foreach(var line in threefirstlines)
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
        {
            foreach (Product p in ListofProduct)
            {
                p.OutputlistofProduct();
            }
        }
    }
}
