using System.Collections;

namespace BigONotation
{


    public class TechnicalExamples
    {
        //Constant - O(1)
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        //Logarithmic - O(log n) 
        public int While(int n)
        {
            while (n > 1)
            {
                n = n / 2;
            }
            return n;
        }
        //other examples Binary Search or Finding the largest/smallest number ina  binary tree

        //Linear - O(n)
        public bool Contains(IList<int> elements, int value)
        {
            foreach (var element in elements)
            {
                if (element == value)
                    return true;
            }
            return false;
        }

        //Log linear - O(n log n)
        public void QuickSortExample()
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            QSort.Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }

        //Quadratic - O(n2)
        public void BubbleSort(int[] input)
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (var sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        var oldValue = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = oldValue;
                        hasSwapped = true;
                    }
                }
            } while (hasSwapped);
        }

        //Exponential - O(2n)
        public long Fibonacci(int number)
        {
            if (number <= 1)
                return number;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        //Factorial O(n!)
        /* O(n!) represents an algorithm which has to perform n! computations to solve a problem. 
         * These algorithms take a massive performance hit for each additional input element. 
         * For example, an algorithm that takes 2 seconds to compute 2 elements, 
         * will take 6 seconds to calculate 3 and 24 seconds to calculate 4 elements.
         */
}

internal static class QSort
{
public static void Quick_Sort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int pivot = Partition(arr, left, right);

        if (pivot > 1)
        {
            Quick_Sort(arr, left, pivot - 1);
        }
        if (pivot + 1 < right)
        {
            Quick_Sort(arr, pivot + 1, right);
        }
    }

}

public static int Partition(int[] arr, int left, int right)
{
    int pivot = arr[left];
    while (true)
    {

        while (arr[left] < pivot)
        {
            left++;
        }

        while (arr[right] > pivot)
        {
            right--;
        }

        if (left < right)
        {
            if (arr[left] == arr[right]) return right;

            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;


        }
        else
        {
            return right;
        }
    }
}
}
}