namespace DP.IteratorDesignPattern.IteratorPattern
{
	public interface IIterator<T>
	{
		T CurrentItem { get; }
		bool NextLocation();
	}
}
