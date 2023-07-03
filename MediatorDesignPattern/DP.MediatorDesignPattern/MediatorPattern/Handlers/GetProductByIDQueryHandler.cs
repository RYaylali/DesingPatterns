using DP.MediatorDesignPattern.DAL;
using DP.MediatorDesignPattern.MediatorPattern.Queries;
using DP.MediatorDesignPattern.MediatorPattern.Result;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DP.MediatorDesignPattern.MediatorPattern.Handlers
{
	public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryProductResult>
	{
		private readonly Context _context;

		public GetProductByIDQueryHandler(Context context)
		{
			_context = context;
		}

		public async Task<GetProductByIDQueryProductResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Products.FindAsync(request.ID);
			return new GetProductByIDQueryProductResult
			{
				ProductID = values.ProductID,
				ProductName = values.ProductName,
				ProductStock = values.ProductStock
			};
		}
	}
}
