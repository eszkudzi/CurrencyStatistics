namespace CurrencyStatistics
{
    public abstract class CurrencyBase : ICurrency
    {
        public CurrencyBase(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public abstract void AddValues(float values);
        public abstract void AddValues(int values);
        public abstract void AddValues(string values);
        public abstract Statistics GetStatistics();
    }
}
