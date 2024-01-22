	# GA_SelectionSort_ArmanSahota

	int arrayLength - array. length // get the length of the array

	for ( int current index = 0; current index < array length -1; currentIndex++)

	// the current index is 0 (the first number in the list) current index should be less than the array length -1,
	//each time we go threw the loop the index goes up 1
	// This is because if it doesn't go up 1 its an infinite loop and the array length is minus 1 because if we start with index 0.

	{ int minimum Index = currentIndex;

	// we do this as a temporary minimum index until we find the next smallest index
	for (int unsorted Index = currentIndex + 1; unsorted Index < arrayLength; unsortedIndex++)

	// this forloop creates a temporary index called unsorted index which is the index infront of the current one
	// this loop runs as long as the unsorted index is smaller than the length of the array\
	// each time the loop runs the unsorted index moves on to the next index
			{
				if (array [unsortedIndex] < array [minimum Index])
				{
					minimum Index = unsortedIndex; 
	// if the unsorted index is smaller than the minimum index the minimum index becomes the unsorted index
				}
			}
		
			int temporary = array [minimum Index];
			array [minimum Index] = array [current Index];
			array [current Index] = temporary;
	// the temporary index becomes the minimum index,
	// minimum index becomes the current index
	// and the current index becomes the temporary
	// this makes sure that the smallest index is in the minimum index place


			 Console.Write($"Iteration {currentIndex + 1}: ");
			 PrintArray(arr);
	//This is just to show the iterations each time the for loop runs it shows the changes

	  }
	}