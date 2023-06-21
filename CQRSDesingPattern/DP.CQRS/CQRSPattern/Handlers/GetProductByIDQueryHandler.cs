using DP.CQRS.CQRSPattern.Queries;
using DP.CQRS.CQRSPattern.Results;
using DP.CQRS.DAL;
using System;

namespace DP.CQRS.CQRSPattern.Handlers
{
	public class GetProductByIDQueryHandler
	{
		private readonly Context _context;

		public GetProductByIDQueryHandler(Context context)
		{
			_context = context;
		}
		public GetProductByIDQueryResult Handle(GetProductByIdQuery model)
		{
			var values = _context.Set<Product>().Find(model.Id);
			return new GetProductByIDQueryResult
			{
				Name = values.Name,
				Price = values.Price,
				ProductID = values.ProductID,
				Stock=values.Stock
			};
		}
	}
}
