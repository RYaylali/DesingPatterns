using DP.MediatorDesignPattern.DAL;
using DP.MediatorDesignPattern.MediatorPattern.Queries;
using DP.MediatorDesignPattern.MediatorPattern.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DP.MediatorDesignPattern.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandller : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {//miras verdiğimiz irequesthandler sınıfındaki ilk getallproductquery istek attığımız şeyleri gösterir list olan kısım ise geri aldığımız cevap 
        private readonly Context _context;

        public GetAllProductQueryHandller(Context context)
        {
            _context = context;
        }

         async Task<List<GetAllProductQueryResult>> IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>.Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType
            }).AsNoTracking().ToListAsync();
        }
        //cancellationtoken sınıfı işlem arkada devam ederken sonuç alınmadan sayfa kapatma olursa iptal edilip edilmemek istediğini sorar
    }
}
