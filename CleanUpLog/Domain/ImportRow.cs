using System;

namespace CleanUpLog.Domain
{
    public class ImportRow
    {
        public DateTime Time { get; set; }
        public string URL { get; set; }
        public double? TimeTaken { get; set; }
        public bool IsComparable { get; set; }
        public DateTime DateImported { get; set; }
    }
}