namespace DP.IteratorDesignPattern.IteratorPattern
{
	public class VisitRouteMover : IMover<VisitRoute>
	{
		public List<VisitRoute> visitRoutes = new List<VisitRoute>();
		public void AddVisitRoute(VisitRoute visitRoute)
		{
			visitRoutes.Add(visitRoute);//gezilen rotaları eklemek için
		}
		public int VisitRouteCount { get => visitRoutes.Count; }//kaç tane yer gezdiğimizi sayacak
		public IIterator<VisitRoute> CreateIterator()//her seferinde kendi içinde dönüş yapmasını sağlar
		{
			return new VisitRouteItarator(this);
		}
	}
}
