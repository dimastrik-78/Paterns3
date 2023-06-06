using System.Collections.Generic;

namespace Task06._06.Observer1
{
    public class DataRecipe : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly List<Recipe> _recipes = new List<Recipe>();

        public void SaveRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
            NotifyObserver();
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
                item.Update("Рецепт сохранён");
            }
        }
    }
}