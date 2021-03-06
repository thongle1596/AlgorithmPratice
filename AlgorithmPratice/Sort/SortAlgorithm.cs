namespace AlgorithmPratice.Sort
{
    class SortAlgorithm
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #region InterchangeSort
        public static void InterchangeSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for( int j = i + 1; j < n ; j++)
                {
                    if(a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        #endregion
        #region BubbleSort
        public static void BubbleSort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        Swap(ref a[j], ref a[j - 1]);
                    }
                }
            }
        }
        #endregion
        #region InsertionSort
        public static void InsertionSort(int[] a, int n)
        {
            int pos, x;
            for(int i = 1; i < n; i++)
            {
                pos = i;
                x = a[i];
                while(pos > 0 && x < a[pos - 1])
                {
                    a[pos] = a[pos - 1];
                    pos--;
                }
                a[pos] = x;
            }
        }
        #endregion
        #region SelectionSort
        public static void SelectionSort(int[] a, int n)
        {
            int min;
            for(int i = 0; i < n - 1; i++)
            {
                min = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                if(min != i)
                {
                    Swap(ref a[min], ref a[i]);
                }
            }
        }
        #endregion
        #region QuickSort
        public static int Partition(int[] a, int left, int right)
        {
            int pivot = a[left];
            while(true)
            {
                while(a[left] < pivot)
                {
                    left++;
                }
                while(a[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(ref a[right], ref a[left]);
                }
                else
                {
                    return right;
                }
            }
        }
        public static void QuickSort(int[] a, int left, int right)
        {
            int pivot;
            if(left < right)
            {
                pivot = Partition(a, left, right);
                if(pivot > 1)
                {
                    QuickSort(a, left, pivot - 1);
                }
                if(pivot + 1 < right)
                {
                    QuickSort(a, pivot + 1, right);
                }
            }
        }
        #endregion
    }
}
