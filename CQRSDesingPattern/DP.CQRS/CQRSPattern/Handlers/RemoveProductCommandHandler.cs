using DP.CQRS.CQRSPattern.Commands;
using DP.CQRS.DAL;

namespace DP.CQRS.CQRSPattern.Handlers
{
	public class RemoveProductCommandHandler
	{
		private readonly Context _context;

		public RemoveProductCommandHandler(Context context)
		{
			_context = context;
		}
		public void Handle(RemoveProductCommand product) 
		{ 
			var values = _context.Products.Find(product.Id);
			_context.Products.Remove(values);
			_context.SaveChanges();
		}
	}
}
