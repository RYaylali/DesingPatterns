using RepositoryDP.DataAccessLayer.Abstract;
using RepositoryDP.DataAccessLayer.Concrete;
using RepositoryDP.DataAccessLayer.Repositories;
using RepositoryDP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDP.DataAccessLayer.EntityFramework
{
	public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EFCategoryDal(Context context) : base(context)
		{
		}
	}
}
