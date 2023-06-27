using DP.DataAccess.Abstract;
using DP.DataAccess.Concrete;
using DP.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DataAccess.EntityFramework
{
	public class EfProcessDal : GenericRepository<Process>, IProcessDal
	{
		public EfProcessDal(Context context) : base(context)
		{
		}
	}
}
