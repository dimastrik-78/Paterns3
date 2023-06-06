namespace Task06._06.Observer2
{
    public class Observer : IObserver
    {
        public string Notify(int x)
        {
            return x.ToString();
        }
    }
}