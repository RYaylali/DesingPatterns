using RepositoryDP.BusinessLayer.Abstract;
using RepositoryDP.DataAccessLayer.Abstract;
using RepositoryDP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDP.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TDelete(Product T)
		{
			_productDal.Delete(T);
		}

		public List<Product> TGetAll()
		{
			return _productDal.GetAll();
		}

		public Product TGetByID(int id)
		{
			return _productDal.GetByID(id);
		}

        public List<Product> TGetProductListWithCategory()
        {
			return _productDal.GetProductListWithCategory();
        }

        public void TInsert(Product t)
		{
			_productDal.Insert(t);
		}

		public void TUpdate(Product t)
		{
			_productDal.Update(t);	
		}
	}
}
