namespace CurrencyStatistics
{
    public interface ICurrency
    {
        string Name { get; }
        void AddValues(float values);
        void AddValues(int values);
        void AddValues(string values);
        Statistics GetStatistics();
    }
}
