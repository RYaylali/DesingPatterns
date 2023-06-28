using Microsoft.EntityFrameworkCore;
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
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EFProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductListWithCategory()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }
    }
}
