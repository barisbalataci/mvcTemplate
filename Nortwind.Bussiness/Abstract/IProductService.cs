﻿using Nortwind.Entities;
using Nortwind.Entities.ComplexType;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(ProductFilter productFilter);
        Product GetById(int id);
        List<Product> GetByCategory(int categoryId);
        List<Product> GetByProductName(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        int GetProductsCountByCategory(int? categoryId);

    }
}
