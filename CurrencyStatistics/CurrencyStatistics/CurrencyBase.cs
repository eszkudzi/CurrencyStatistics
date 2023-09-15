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
        public void AddValues(int values)
        {
            float result = (float)values;
            this.AddValues(result);
        }

        public void AddValues(string values)
        {
            if (float.TryParse(values, out float result))
            {
                this.AddValues(result);
            }
            else
            {
                throw new Exception("Invalid string value.");
            }
        }
        public abstract Statistics GetStatistics();
    }
}
