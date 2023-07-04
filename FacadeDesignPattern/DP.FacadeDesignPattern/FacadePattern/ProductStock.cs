using DP.FacadeDesignPattern.DAL;

namespace DP.FacadeDesignPattern.FacadePattern
{
	public class ProductStock
	{
		Context context = new Context();
		public void StockDecrease(int id,int amount)
		{
			var values = context.Products.Find(id);
			values.ProductStock-=amount;
			context.SaveChanges();
		}
	}
}
