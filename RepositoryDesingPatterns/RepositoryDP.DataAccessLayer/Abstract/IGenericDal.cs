using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDP.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T t);
		void Update(T t);
		void Delete(T T);
		List<T> GetAll();
		T GetByID(int id);
	}
}
