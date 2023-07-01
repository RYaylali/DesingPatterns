namespace DP.Composite.CompositePattern
{
    public interface IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int TotalCount();//düğümden onra kaç tane dal olduğunu gösterecek
        string Display();//side barı oluşturacak html kodları tutatcak
    }
}
