using System;

namespace Task06._06.Observer1
{
    public class RecipeObserver : IObserver
    {
        public void Update(string text)
        {
            Console.WriteLine(text);
        }
    }
}