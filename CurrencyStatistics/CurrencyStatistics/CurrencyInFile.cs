﻿namespace CurrencyStatistics
{
    public class CurrencyInFile : CurrencyBase
    {
        private const string fileName = "currencyValues.txt";
        public CurrencyInFile(string name) : base(name)
        {
        }

        public override void AddValues(float values)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(values);
            }
        }

        public override Statistics GetStatistics()
        {
            var valuesFromFile = this.ReadValuesFromFile();
            var stats = new Statistics();
            foreach (var valueCurrency in valuesFromFile)
            {
                stats.AddValues(valueCurrency);
            }
            return stats;
        }
        private List<float> ReadValuesFromFile()
        {
            var values = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        values.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return values;
        }

        public void RemoveDataFromFile()
        {
            File.WriteAllText(fileName, "");
        }
    }
}
