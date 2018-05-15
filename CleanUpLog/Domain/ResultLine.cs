using LINQtoCSV;

namespace StatGenerator.Domain
{
    public class ResultLine
    {
        [CsvColumn(FieldIndex = 1)]
        public object URL { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public int HitsBefore { get; set; }

        [CsvColumn(FieldIndex = 3)]
        public double? SumBefore { get; set; }

        [CsvColumn(FieldIndex = 4)]
        public double? AvgBefore => (double) (SumBefore / HitsBefore);

        [CsvColumn(FieldIndex = 5)]
        public double? MaxBefore { get; set; }

        [CsvColumn(FieldIndex = 6)]
        public double? MinBefore { get; set; }

        [CsvColumn(FieldIndex = 7)]
        public bool Comparable { get; set; }

        [CsvColumn(FieldIndex = 8)]
        public int HitsAfter { get; set; }

        [CsvColumn(FieldIndex = 9)]
        public double? SumAfter { get; set; }

        [CsvColumn(FieldIndex = 10)]
        public double? AvgAfter => (double) (SumAfter / HitsAfter);

        [CsvColumn(FieldIndex = 11)]
        public double? MaxAfter { get; set; }

        [CsvColumn(FieldIndex = 12)]
        public double? MinAfter { get; set; }

        [CsvColumn(FieldIndex = 13, Name = "Improvement %")]
        public double? Improvement => (AvgBefore - AvgAfter) / AvgBefore * 100;

        [CsvColumn(FieldIndex = 14, Name = "Min Improvement %")]
        public double? MinImprovement => (MinBefore - MinAfter) / MinBefore * 100;        
    }
}