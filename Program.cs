using System;

internal class Program{
    //Arman Sahota
    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11, 36, 8, 42, 5, 38 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        SelectionSortArray(arr);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static void SelectionSortArray(int[] arr)
    {

        // Step 1 - Initialization
        int arrayLength = arr.Length;

        for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
        {
            // Step 3 - Assumption of Minimum
            int minIndex = currentIndex;
            // Step 4 - Inner Loop
            for (int unsortedIndex = currentIndex + 1; unsortedIndex < arrayLength; unsortedIndex++)
            {
                // Step 5 - Comparison
                if (arr[unsortedIndex] < arr[minIndex])
                {
                    minIndex = unsortedIndex;
                }
            }
            // Step 6 - Swap
            int temp = arr[minIndex];
            arr[minIndex] = arr[currentIndex];
            arr[currentIndex] = temp;

            // Step 7 - For this exercise : Display what is happening
            Console.Write($"Iteration {currentIndex + 1}: ");
            PrintArray(arr);

        }


    }









}
