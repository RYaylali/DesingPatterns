using DP.FacadeDesignPattern.DAL;

namespace DP.FacadeDesignPattern.FacadePattern
{
	public class AddOrder
	{
		Context context= new Context();
        public void AddNewOrder(Order order)
		{
			order.OrderDate = DateTime.Now;
			context.Orders.Add(order);
			context.SaveChanges();
		}
    }
}
