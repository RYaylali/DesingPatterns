namespace DP.IteratorDesignPattern.IteratorPattern
{
	public interface IMover<T>
	{
		IIterator<T> CreateIterator();
	}
}
