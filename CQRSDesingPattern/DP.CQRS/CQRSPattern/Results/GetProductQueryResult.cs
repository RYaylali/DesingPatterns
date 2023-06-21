namespace DP.CQRS.CQRSPattern.Results
{
	public class GetProductQueryResult
	{
        public int ProductID { get; set; }
        public string ProductName { get; set; }//Entityle aynı isimde olması gerekmiyor
        public int Stock { get; set; }
        public decimal Price { get; set; }//er hangi bir şart bilerek koymuyorum
    }
}
