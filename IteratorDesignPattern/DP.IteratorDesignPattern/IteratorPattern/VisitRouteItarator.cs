namespace DP.IteratorDesignPattern.IteratorPattern
{
	public class VisitRouteItarator : IIterator<VisitRoute>//taşıyıcı sınıf
	{
		private VisitRouteMover _routeMover;

		public VisitRouteItarator(VisitRouteMover routeMover)
		{
			_routeMover = routeMover;
		}
		private int currentIndex = 0;//Başlangıç indeksi
		public VisitRoute CurrentItem { get; set; }

		public bool NextLocation()
		{
			if (currentIndex<_routeMover.VisitRouteCount)//şarta göre sırayla bütün verileri dolaşması için döngü yazılıyor
			{
				CurrentItem = _routeMover.visitRoutes[currentIndex++];
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
