using DP.DataAccess.Abstract;
using DP.DataAccess.Concrete;
using DP.DataAccess.Repositories;
using DP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DataAccess.EntityFramework
{
	public class EfCustomerDal : GenericRepository<Customer>,ICustomerDal
	{
		public EfCustomerDal(Context context) : base(context)
		{
		}
	}
}
