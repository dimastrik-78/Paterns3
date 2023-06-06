using System.Collections.Generic;

namespace Task06._06.Observer1
{
    public class Recipe : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        private string _name;
        private string _resource;
        private int _count;

        public Recipe(string name, string resource, int count)
        {
            _name = name;
            _resource = resource;
            _count = count;
        }

        public void RemadeNameRecipe(string name)
        {
            _name = name;
            NotifyObserver();
        }
        
        public void RemadeResourceRecipe(string resource)
        {
            _resource = resource;
            NotifyObserver();
        }
        
        public void RemadeCountRecipe(int count)
        {
            _count = count;
            NotifyObserver();
        }

        public override string ToString()
        {
            return $"Для приготовления {_name} нужен рессурс {_resource} в количестве {_count}";
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var item in _observers)
            {
                item.Update("Рецепт изменён");
            }
        }
    }
}