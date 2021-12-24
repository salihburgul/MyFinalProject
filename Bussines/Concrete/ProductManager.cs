﻿using Bussines.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IEnumerable<object> GetAllByCategoryId(int v)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategory(int id)
        {
           return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
