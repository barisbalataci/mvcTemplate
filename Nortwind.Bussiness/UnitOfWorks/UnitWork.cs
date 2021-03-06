﻿using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.DataAcces.Concrete.EntityFramework;
using Nortwind.DataAcces.Concrete.EntityFramework.Contexts;

namespace Nortwind.Bussiness.UnitOfWorks
{
    public class UnitWork : IUnitWork
    {
        //private NortwindContext _context = new ShopContext();
        private EfEntitityRepositoryBase<Category,NortwindContext> _categoryRepository;
        private EfEntitityRepositoryBase<Product, NortwindContext> _productRepository;
        private bool _disposed = false;
        public EfEntitityRepositoryBase<Category, NortwindContext> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new EfEntitityRepositoryBase<Category, NortwindContext>();
                return _categoryRepository;
            }
        }
        public EfEntitityRepositoryBase<Product, NortwindContext> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new EfEntitityRepositoryBase<Product, NortwindContext>();
                return _productRepository;
            }
        }
        public void Save()
        {
            //using (TransactionScope tScope = new TransactionScope())
            //{
            //    _context.SaveChanges();
            //    tScope.Complete();
            //}
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    //_context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
