﻿
using Nortwind.Entities.Concrete;
using Nortwind.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.ServiceClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Product  product= WcfProxy<IProductService1>.CreateChannel().GetById(1);
            Console.WriteLine(product.ProductName);
            Console.ReadLine();
        }
    }
}
