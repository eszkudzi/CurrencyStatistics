namespace CurrencyStatistics
{
    public class CurrencyInMemory : CurrencyBase
    {
        private List<float> values = new List<float>();
        public CurrencyInMemory(string name) : base(name)
        {
        }

        public override void AddValues(float values)
        {
            this.values.Add(values);
        }


        public override Statistics GetStatistics()
        {
            var stats = new Statistics();
            foreach (var valueCurrency in this.values)
            {
                stats.AddValues(valueCurrency);
            }

            return stats;
        }
    }
}
