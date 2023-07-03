using MediatR;

namespace DP.MediatorDesignPattern.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveProductCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
