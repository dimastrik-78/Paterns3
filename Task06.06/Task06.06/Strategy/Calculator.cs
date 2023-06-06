namespace Task06._06.Strategy
{
    public class Calculator
    {
        public float ExecuteStrategy(Operation operation, float a, float b)
        {
            switch (operation)
            {
                case Operation.Sum:
                {
                    return new AddStrategy().Algoritm(a, b);
                }
                case Operation.Div:
                {
                    return new DivideStrategy().Algoritm(a, b);
                }
                case Operation.Mult:
                {
                    return new MultiplyStrategy().Algoritm(a, b);
                }
                case Operation.Dif:
                {
                    return new SubtractStrategy().Algoritm(a, b);
                }
            }

            return default;
        }
    }
}