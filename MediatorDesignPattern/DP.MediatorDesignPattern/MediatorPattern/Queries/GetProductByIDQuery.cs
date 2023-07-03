using DP.MediatorDesignPattern.MediatorPattern.Result;
using MediatR;

namespace DP.MediatorDesignPattern.MediatorPattern.Queries
{
	public class GetProductByIDQuery:IRequest<GetProductByIDQueryProductResult>
	{
		public GetProductByIDQuery(int iD)
		{
			ID = iD;
		}

		public int ID { get; set; }
    }
}
