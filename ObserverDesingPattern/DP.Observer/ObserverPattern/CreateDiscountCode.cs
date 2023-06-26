using DP.Observer.DAL;

namespace DP.Observer.ObserverPattern
{
	public class CreateDiscountCode:IObserver
	{
		private readonly IServiceProvider _serviceProvider;
		Context context = new Context();

		public CreateDiscountCode(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		void IObserver.CreateAppUser(AppUser appUser)
		{
			context.Discounts.Add(new Discount
			{
			DiscountCode="DergiTemmuz",
			DiscountAmount=40,
			DiscountCodeStatus=true
			});
			context.SaveChanges();
		}
	}
}
