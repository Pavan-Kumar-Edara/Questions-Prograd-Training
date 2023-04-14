namespace Array_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] intervals = new int[][] {
            new int[] {1, 3},
            new int[] {2, 6},
            new int[] {8, 10},
            new int[] {15, 18}
        };

            int[][] nonOverlappingIntervals = MergeIntervals(intervals);

            foreach (int[] interval in nonOverlappingIntervals)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");

            }

            static int[][] MergeIntervals(int[][] intervals)
            {
                if (intervals == null || intervals.Length == 0)
                {
                    return new int[0][];
                }

                List<int[]> mergedIntervals = new List<int[]>();


                Array.Sort(intervals, (x, y) => x[0] - y[0]);

                int[] currentInterval = intervals[0];
                mergedIntervals.Add(currentInterval);

                for (int iterator = 1; iterator < intervals.Length; iterator++)
                {
                    int[] interval = intervals[iterator];


                    if (currentInterval[1] >= interval[0])
                    {
                        currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
                    }

                    else
                    {
                        currentInterval = interval;
                        mergedIntervals.Add(currentInterval);
                    }
                }

                return mergedIntervals.ToArray();
            }
        }
    }
}
