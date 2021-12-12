using System.Collections;
using System.Diagnostics;

namespace Sort_O_Matic
{
    internal interface ISorter 
    {
        // The Sort function should return an enumerable sorting function that returns execution
        // on every swap in the algorithm
        IEnumerable Sort(int[] array);

        // Stopwatch is used to track the time needed to complete the sorting algorithm
        Stopwatch Stopwatch { get; }
    }

    internal abstract class BaseSorter : ISorter
    {
        public Stopwatch Stopwatch { get; set; }

        public BaseSorter()
        {
            Stopwatch = new Stopwatch();
        }

        public abstract IEnumerable Sort(int[] array);
    }
    internal class BubbleSorter: BaseSorter
    {
        public override IEnumerable Sort(int[] array)
        {
            Stopwatch.Restart();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        yield return new int[] { j, j+1 };
                    }

                }
            }
            Stopwatch.Stop();
        }

        public override string ToString()
        {
            return "Bubble Sort";
        }
    }
    internal class InsertionSorter: BaseSorter 
    {
        public override IEnumerable Sort(int[] array)
        {
            Stopwatch.Restart();

            int key, j;
            for (int i = 0; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    yield return new int[] { j, j+1 };
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            Stopwatch.Stop();
        }

        public override string ToString()
        {
            return "Insertion Sort";
        }
    }
    internal class SelectionSorter: BaseSorter 
    {
        public override IEnumerable Sort(int[] array)
        {
            Stopwatch.Restart();

            int min_idx;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min_idx = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_idx])
                    {
                        min_idx = j;
                    }
                }

                // Sleep for 1ms so that the algorithm does not seem too fast compared to others
                System.Threading.Thread.Sleep(1);

                (array[min_idx], array[i]) = (array[i], array[min_idx]);
                yield return new int[] { min_idx, i };
            }
            Stopwatch.Stop();
        }

        public override string ToString()
        {
            return "Selection Sort";
        }
    }

    internal class CocktailSorter: BaseSorter
    {
        public override IEnumerable Sort(int[] array)
        {
            Stopwatch.Restart();

            bool swapped = true;
            int start = 0;
            int end = array.Length - 1; 
            while(swapped)
            {
                swapped = false;
                for(int i = start; i  < end; i++)
                {
                    if(array[i] > array[i+1])
                    {
                        (array[i], array[i+1]) = (array[i+1], array[i]);
                        swapped = true;
                        yield return new int[] { i, i + 1 };
                    }

                }

                if (!swapped)
                    break;

                swapped = false;
                end--;

                for(int i = end - 1; i >= start; i--)
                {
                    if(array[i] > array[i+1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        swapped = true;
                        yield return new int[] { i, i + 1 };
                    }
                }

                start++;
            }
            Stopwatch.Stop();
        }

        public override string ToString()
        {
            return "Cocktail Sort";
        }
    }
}
