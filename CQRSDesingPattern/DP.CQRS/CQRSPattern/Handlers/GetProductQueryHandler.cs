using DP.CQRS.CQRSPattern.Results;
using DP.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DP.CQRS.CQRSPattern.Handlers
{
	public class GetProductQueryHandler
	{
		private readonly Context _context;

		public GetProductQueryHandler(Context context)
		{
			_context = context;
		}
		public List<GetProductQueryResult> Handle()
		{
			var values=_context.Products.Select(x=> new GetProductQueryResult
			{
				ProductID = x.ProductID,
				Price= x.Price,
				ProductName=x.Name,
				Stock=x.Stock
			}).ToList();
			return values;
		}
	}
}
