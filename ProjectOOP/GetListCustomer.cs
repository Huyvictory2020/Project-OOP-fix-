using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Configuration;
namespace ProjectOOP
{
    interface IUseForGetlistcustomer
    {
        void InputListofCustomer();
        void OutputlistofCustomer();
    }
    class GetListCustomer :IUseForGetlistcustomer
    {
        protected List<Customer> ListofCustomer;
        public GetListCustomer()
        {
            ListofCustomer = new List<Customer>();
        }
        public GetListCustomer(List<Customer> listofcustomer)
        {
            this.ListofCustomer = listofcustomer;
        }
        public  virtual void InputListofCustomer()
        {
            Console.WriteLine("Type the number of customer ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Customer c1 = new Customer();
                ListofCustomer.Add(c1);
            }
            foreach(Customer c in ListofCustomer)
            {
                c.Input1person();
            }
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
        public void Outputnewlist()
        {
            using (TextWriter tw = new StreamWriter(@"E:\Customer1.txt"))
            {
                foreach (Customer c in ListofCustomer)
                {
                    tw.WriteLine(c.ToString());
                }
                Console.WriteLine("A new list with new customer has been creaated go check in the specific folder");
                tw.Close();
            }
        }
        public void OutputlistofCustomer()
        {
            foreach (Customer c in ListofCustomer)
            {
                c.Outputinformation();
            }
        }
    }
}
