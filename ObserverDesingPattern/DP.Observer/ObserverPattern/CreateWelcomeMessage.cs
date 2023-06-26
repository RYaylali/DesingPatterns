using DP.Observer.DAL;

namespace DP.Observer.ObserverPattern
{
	public class CreateWelcomeMessage : IObserver
	{
		private readonly IServiceProvider _serviceProvider;
		Context context = new Context();

		public CreateWelcomeMessage(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		void IObserver.CreateAppUser(AppUser appUser)
		{
			context.WelcomeMessages.Add(new WelcomeMessage
			{
				NameSurname = appUser.Name + " " + appUser.Surname,
				Content="Kayıt İşleminiz Başarıyla Gerçekleştiridi"
			});
			context.SaveChanges();
		}
	}
}
