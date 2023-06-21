using DP.CQRS.CQRSPattern.Commands;
using DP.CQRS.DAL;

namespace DP.CQRS.CQRSPattern.Handlers
{
	public class CreateProductCommandHandler
	{
		private readonly Context _context;

		public CreateProductCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(CreateProductCommand model)
		{
			_context.Products.Add(new Product
			{
				Name = model.Name,
				Price = model.Price,
				Description = model.Description,
				Status=true,
				Stock=model.Stock,
			});
			_context.SaveChanges();
		}
	}
}
