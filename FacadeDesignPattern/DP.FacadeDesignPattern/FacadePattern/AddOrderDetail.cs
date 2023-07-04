using DP.FacadeDesignPattern.DAL;

namespace DP.FacadeDesignPattern.FacadePattern
{
	public class AddOrderDetail
	{
		Context context = new Context();
		public void AddNewOrderDetail(OrderDetail orderDetail)
		{
			context.OrderDetails.Add(orderDetail);
			context.SaveChanges();
		}
	}
}
