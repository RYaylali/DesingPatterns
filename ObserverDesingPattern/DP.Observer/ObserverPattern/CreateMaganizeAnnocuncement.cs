using DP.Observer.DAL;

namespace DP.Observer.ObserverPattern
{
	public class CreateMaganizeAnnocuncement:IObserver
	{
		private readonly IServiceProvider _serviceProvider;
		Context context = new Context();

		public CreateMaganizeAnnocuncement(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		void IObserver.CreateAppUser(AppUser appUser)
		{
			context.UserProcesses.Add(new UserProcess
			{
				NameSurname = appUser.Name + " " + appUser.Surname,
				Magazine="Dergi1",
				Content = "Derginiz elinize ulaşacaktır"
			});
			context.SaveChanges();
		}
	}
}
