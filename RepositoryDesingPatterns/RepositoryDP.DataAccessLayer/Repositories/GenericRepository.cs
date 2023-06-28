﻿using RepositoryDP.DataAccessLayer.Abstract;
using RepositoryDP.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDP.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		private readonly Context _context;

		public GenericRepository(Context context)
		{
			_context = context;
		}

		public void Delete(T T)
		{
			_context.Remove(T);
			_context.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _context.Set<T>().ToList();	
		}

		public T GetByID(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public void Insert(T t)
		{
			_context.Add(t);
			_context.SaveChanges();
		}

		public void Update(T t)
		{
			_context.Update(t);
			_context.SaveChanges();
		}
	}
}
