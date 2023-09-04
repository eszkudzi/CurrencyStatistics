using System.Diagnostics;

namespace CurrencyStatistics
{
    internal class CurrencyInMemory : CurrencyBase
    {
        private List<float> values = new List<float>();
        public CurrencyInMemory(string name) : base(name)
        {
        }

        public override void AddValues(float values)
        {
            this.values.Add(values);
        }

        public override void AddValues(int values)
        {
            float result = (float)values;
            this.AddValues(result);
        }

        public override void AddValues(string values)
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
