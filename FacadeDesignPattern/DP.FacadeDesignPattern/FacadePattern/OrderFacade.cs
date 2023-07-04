using DP.FacadeDesignPattern.DAL;

namespace DP.FacadeDesignPattern.FacadePattern
{
	public class OrderFacade
	{
		Order order = new Order();
		OrderDetail detail = new OrderDetail();
		ProductStock productStock = new ProductStock();

		AddOrder addOrder = new AddOrder();
		AddOrderDetail addorderDetail = new AddOrderDetail();
		public void CompleteOrder(int customerID,int productID, int orderID,int productCount,decimal productPrice)
		{
			order.CustomerID = customerID;
			addOrder.AddNewOrder(order);
			detail.OrderID = orderID;
			detail.CustomerID = customerID;
			detail.ProductID = productID;
			detail.ProductPrice = productPrice;
			detail.ProductCount = productCount;
			decimal totalProductPrice= productPrice*productCount;
			detail.ProductTotalPrice = totalProductPrice;
			addorderDetail.AddNewOrderDetail(detail);

			productStock.StockDecrease(productID,productCount);
		}


        public void CompleteOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
        }

    }
}
