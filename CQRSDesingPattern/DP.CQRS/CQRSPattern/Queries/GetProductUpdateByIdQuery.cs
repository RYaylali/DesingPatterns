namespace DP.CQRS.CQRSPattern.Queries
{
	public class GetProductUpdateByIdQuery
	{
		public GetProductUpdateByIdQuery(int ıd)
		{
			Id = ıd;
		}

		public int Id { get; set; }
    }
}
