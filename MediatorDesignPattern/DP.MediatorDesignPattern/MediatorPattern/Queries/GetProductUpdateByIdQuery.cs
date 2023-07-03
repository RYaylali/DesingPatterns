using DP.MediatorDesignPattern.MediatorPattern.Result;
using MediatR;

namespace DP.MediatorDesignPattern.MediatorPattern.Queries
{
	public class GetProductUpdateByIdQuery:IRequest<UpdateProductByIdQueryResult>
	{
        public int Id { get; set; }

		public GetProductUpdateByIdQuery(int id)
		{
			Id = id;
		}
	}
}
