using DP.CQRS.CQRSPattern.Queries;
using DP.CQRS.CQRSPattern.Results;
using DP.CQRS.DAL;

namespace DP.CQRS.CQRSPattern.Handlers
{
	public class GetProductUpdateByIdQueryHandler
	{
		private readonly Context _context;

		public GetProductUpdateByIdQueryHandler(Context context)
		{
			_context = context;
		}
		public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
		{
			var values = _context.Products.Find(query.Id);
			return new GetProductUpdateQueryResult
			{
				Name=values.Name,
				Price=values.Price,
				Stock=values.Stock,
				Description=values.Description,
				ProductID=values.ProductID
			};
		}
	}
}
