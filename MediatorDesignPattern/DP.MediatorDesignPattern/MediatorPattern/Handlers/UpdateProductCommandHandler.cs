using DP.MediatorDesignPattern.DAL;
using DP.MediatorDesignPattern.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DP.MediatorDesignPattern.MediatorPattern.Handlers
{
	public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
	{
		private readonly Context _context;

		public UpdateProductCommandHandler(Context context)
		{
			_context = context;
		}

		public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
		{
			var values = await _context.Products.FindAsync(request.ProductID);
			values.ProductName=request.ProductName;
			values.ProductPrice=request.ProductPrice;
			values.ProductStock=request.ProductStock;
			values.ProductCategory=request.ProductCategory;
			values.ProductStockType=request.ProductStockType;
			await _context.SaveChangesAsync();
		}
	}
}
