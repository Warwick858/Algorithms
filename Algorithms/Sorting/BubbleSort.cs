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
	/// BUBBLE SORT
	/// Worst and Average Case Time Complexity: O(n*n). Worst case occurs when array is reverse sorted.
	/// Best Case Time Complexity: O(n). Best case occurs when array is already sorted.
	/// ******************************************************
	/// Repeatedly steps through the list to be sorted, compares each pair of adjacent items and swaps them if they are in the wrong order.
	/// The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted.
	/// The algorithm, which is a comparison sort, is named for the way smaller elements "bubble" to the top of the list.
	/// Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort.
	/// </summary>
	public static class BubbleSort
	{
		public static void SortAscending(ref int[] data)
		{
			for (int j = 0; j < data.Length - 1; j++)
				for (int i = 0; i < data.Length - 1; i++)
					if (data[i] > data[i + 1])
						Swap(ref data[i], ref data[i + 1]);
		} // end method

		public static void SortDescending(ref int[] data)
		{
			for (int j = 0; j < data.Length - 1; j++)
				for (int i = 0; i < data.Length - 1; i++)
					if (data[i] < data[i + 1])
						Swap(ref data[i], ref data[i + 1]);
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
