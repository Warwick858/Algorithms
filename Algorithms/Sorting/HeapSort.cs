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
	/// HEAP SORT
	/// Time Complexity: O(nLogn).
	/// ******************************************************
	/// Similar to selection sort where we first find the maximum element and place the maximum element at the end.
	/// We repeat the same process for remaining element.
	/// </summary>
	public static class HeapSort
	{
		public static void SortAscending(ref int[] data, int n)
		{
			for (int i = n / 2 - 1; i >= 0; i--)
				SortAscending_Recursive(ref data, n, i);

			//Extract each element from the heap
			for (int i = n - 1; i >= 0; i--)
			{
				Swap(ref data[0], ref data[i]);
				SortAscending_Recursive(ref data, i, 0);
			}
		} // end method

		public static void SortAscending_Recursive(ref int[] data, int n, int i)
		{
			int largest = i;
			int left = 2 * i + 1;
			int right = 2 * i + 2;

			//If left child is larger than root
			if (left < n && data[left] > data[largest])
				largest = left;

			//If right child is larger than largest so far
			if (right < n && data[right] > data[largest])
				largest = right;

			//If largest is NOT root
			if (largest != i)
			{
				Swap(ref data[i], ref data[largest]);
				SortAscending_Recursive(ref data, n, largest);
			}
		} // end method

		public static void SortDescending(ref int[] data, int n)
		{
			for (int i = n / 2 - 1; i >= 0; i--)
				SortDescending_Recursive(ref data, n, i);

			//Extract each element from the heap
			for (int i = n - 1; i >= 0; i--)
			{
				Swap(ref data[0], ref data[i]);
				SortDescending_Recursive(ref data, i, 0);
			}
		} // end method

		public static void SortDescending_Recursive(ref int[] data, int n, int i)
		{
			int largest = i;
			int left = 2 * i + 1;
			int right = 2 * i + 2;

			//If left child is larger than root
			if (left < n && data[left] < data[largest])
				largest = left;

			//If right child is larger than largest so far
			if (right < n && data[right] < data[largest])
				largest = right;

			//If largest is NOT root
			if (largest != i)
			{
				Swap(ref data[i], ref data[largest]);
				SortDescending_Recursive(ref data, n, largest);
			}
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
