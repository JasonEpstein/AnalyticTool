using System.Collections.Generic;
using System.Linq;
using StatGenerator.Domain;

namespace StatGenerator
{
    public class StatGenerator
    {
        internal IEnumerable<ResultLine> GenerateStats(List<ImportRow> beforeRows, List<ImportRow> afterRows)
        {
            var beforeStats = beforeRows
                .GroupBy(row => row.URL)
                .Select(c1 => new ResultLine
                {
                    URL = c1.First().URL,
                    HitsBefore = c1.Count(),
                    SumBefore = c1.Sum(x => x.TimeTaken),
                    MaxBefore = c1.Max(x => x.TimeTaken),
                    Comparable = c1.First().IsComparable,
                    MinBefore = c1.Min(x => x.TimeTaken),

                })
                .OrderByDescending(x => x.Comparable)
                .ThenBy(x => x.URL);

            var afterStats = afterRows
                .GroupBy(row => row.URL)
                .Select(c1 => new ResultLine
                {
                    URL = c1.First().URL,
                    HitsAfter = c1.Count(),
                    SumAfter = c1.Sum(x => x.TimeTaken),
                    MaxAfter = c1.Max(x => x.TimeTaken),
                    Comparable = c1.First().IsComparable,
                    MinAfter = c1.Min(x => x.TimeTaken),
                })
                .OrderByDescending(x => x.Comparable)
                .ThenBy(x => x.URL);

            // Now merge two lists
            return (from beforeStat in beforeStats
                from afterStat in afterStats
                where afterStat.URL.ToString() == beforeStat.URL.ToString()
                select new ResultLine
                {
                    URL = beforeStat.URL,
                    Comparable = beforeStat.Comparable,
                    HitsBefore = beforeStat.HitsBefore,
                    HitsAfter = afterStat.HitsAfter,
                    MaxBefore = beforeStat.MaxBefore,
                    MaxAfter = afterStat.MaxAfter,
                    SumBefore = beforeStat.SumBefore,
                    SumAfter = afterStat.SumAfter,
                    MinBefore = beforeStat.MinBefore,
                    MinAfter = afterStat.MinAfter
                }).ToList();
        }
    }
}