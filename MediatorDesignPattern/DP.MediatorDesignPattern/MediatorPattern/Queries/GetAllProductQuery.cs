using DP.MediatorDesignPattern.MediatorPattern.Result;
using MediatR;

namespace DP.MediatorDesignPattern.MediatorPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
