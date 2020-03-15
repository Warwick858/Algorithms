// ******************************************************************************************************************
//  This file is part of Algorithms.
//
//  Algorithms - collection of various algorithms.
//  Copyright(C)  2020  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  Algorithms is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program. If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//

namespace Algorithms.Sorting
{
	/// <summary>
	/// SHELL SORT
	/// Time Complexity: O(n2)
	/// Shell Sort allows the exchange of items that are far apart in the array and then reduces the gap between them. 
	/// This is a sort of generalization of Insertion Sort.
	/// ******************************************************
	/// The method starts by sorting pairs of elements far apart from each other, then progressively reducing the gap between elements to be compared. 
	/// Starting with far apart elements can move some out-of-place elements into position faster than a simple nearest neighbor exchange.
	/// ******************************************************
	/// The subarrays that Shellsort operates on are initially short; later they are longer but almost ordered.
	/// Shellsort is unstable: it may change the relative order of elements with equal values. 
	/// It is an adaptive sorting algorithm in that it executes faster when the input is partially sorted.
	/// ******************************************************
	/// The running time of Shellsort is heavily dependent on the gap sequence it uses
	/// The idea is to arrange the list of elements so that, starting anywhere, considering every hth element gives a sorted list. 
	/// Such a list is said to be h-sorted. Equivalently, it can be thought of as h interleaved lists, each individually sorted.
	/// ******************************************************
	/// Examples:
	/// Shell size of 3: (a1, a4, a7, a10), (a2, a5, a8, a11), (a3, a6, a9, a12)
	/// Shell size of 5: (a1, a6, a11), (a2, a7, a12), (a3, a8), (a4, a9), (a5, a10)
	/// </summary>
	public static class ShellSort
	{
		/// <summary>
		/// This approach uses sorting by exchange, or by swap (like the bubble sort)
		/// </summary>
		public static void SortAscending(ref int[] data)
		{
			int size = data.Length;
			int shell = 3;
			int temp = 0;
			int i = 0;
			int j = 0;

			while (shell > 0)
			{
				for (i = 0; i < size; i++)
				{
					j = i;
					temp = data[i];

					while ((j >= shell) && (data[j - shell] > temp))
					{
						data[j] = data[j - shell];
						j -= shell;
					}

					data[j] = temp;
				} // end for

				if (shell / 2 != 0)
					shell /= 2;
				else if (shell == 1)
					shell = 0;
				else
					shell = 1;
			} // end while
		} // end method

		public static void SortDescending(ref int[] data)
		{
			int size = data.Length;
			int shell = 3;
			int temp = 0;
			int i = 0;
			int j = 0;

			while (shell > 0)
			{
				for (i = 0; i < size; i++)
				{
					j = i;
					temp = data[i];

					while ((j >= shell) && (data[j - shell] < temp))
					{
						data[j] = data[j - shell];
						j -= shell;
					}

					data[j] = temp;
				} // end for

				if (shell / 2 != 0)
					shell /= 2;
				else if (shell == 1)
					shell = 0;
				else
					shell = 1;
			} // end while
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace



//Approach using Marcin Ciura's gap sequence, with an inner insertion sort.
//Doesn't work quite right :(
//public static void SortAscending(ref int[] data)
//{
//	int size = data.Length;

//	//Cut the shell in half each time through
//	for (int shell = (size / 2); shell > 0; shell /= 2)
//	{
//		//Increment shell through array until end (size) is reached
//		for (int i = shell; i < size; i++)
//		{
//			//Save j as i - Reduce j by shell length
//			for (int j = i; j >= shell; j -= shell) // j -= shell
//			{
//				//If the right element is less than the left element
//				if (data[i] < data[j - shell])
//				{
//					Swap(ref data[j], ref data[j - shell]);
//				}
//				else
//					break;
//			} // end for
//		} // end for
//	} // end for
//} // end method

//public static void SortDescending(ref int[] data)
//{
//	//Cut the shell in half each time through
//	for (int shell = ((data.Length + 1) / 2); shell > 0; shell /= 2)
//	{
//		//Increment shell through array until end (size) is reached
//		for (int i = shell; i < data.Length; i++)
//		{
//			//Save j as i - Reduce j by shell length
//			for (int j = i; j >= shell; j -= shell) // j -= shell
//			{
//				//If the right element is less than the left element
//				if (data[i] > data[j - shell])
//				{
//					Swap(ref data[j], ref data[j - shell]);
//				}
//				else
//					break;
//			} // end for
//		} // end for
//	} // end for
//} // end method