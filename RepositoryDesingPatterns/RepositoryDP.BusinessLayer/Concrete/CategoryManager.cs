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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TDelete(Category T)
		{
			_categoryDal.Delete(T);
		}

		public List<Category> TGetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category TGetByID(int id)
		{
			return _categoryDal.GetByID(id);
		}

		public void TInsert(Category t)
		{
			_categoryDal.Insert(t);
		}

		public void TUpdate(Category t)
		{
			_categoryDal.Update(t);
		}
	}
}
