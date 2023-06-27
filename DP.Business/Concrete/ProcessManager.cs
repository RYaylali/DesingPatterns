using DP.Business.Abstract;
using DP.DataAccess.Abstract;
using DP.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Business.Concrete
{
	public class ProcessManager : IProcessService
	{
		private readonly IProcessDal _processDal;
		private readonly IUowDal _uowDal;

		public ProcessManager(IUowDal uowDal, IProcessDal processDal)
		{
			_uowDal = uowDal;
			_processDal = processDal;
		}

		public void TDelete(Process t)
		{
			_processDal.Delete(t);
			_uowDal.Save();
		}

		public Process TGetByID(int id)
		{
			return _processDal.GetByID(id);
		}

		public List<Process> TGetList(Process t)
		{
			return _processDal.GetList(t);
		}

		public void TInsert(Process t)
		{
			_processDal.Insert(t);
			_uowDal.Save();
		}

		public void TMultiUpdate(List<Process> t)
		{
			_processDal.MultiUpdate(t);
			_uowDal.Save();
		}

		public void TUpdate(Process t)
		{
			_processDal.Update(t);
			_uowDal.Save();
		}
	}
}
