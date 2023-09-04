namespace CurrencyStatistics
{
    public interface ICurrency
    {
        string Name { get; }
        void AddValues(float grade);
        void AddValues(int grade);
        void AddValues(string grade);
        Statistics GetStatistics();
    }
}
