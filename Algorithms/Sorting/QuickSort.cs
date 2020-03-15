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
	/// QUICK SORT
	/// Quick sort is a comparison sort, meaning that it can sort items of any type for which a "less-than" relation.
	/// QuickSort is a Divide and Conquer algorithm.
	/// It picks an element as pivot and partitions the given array around the picked pivot.
	/// ******************************************************
	/// There are many different versions of quickSort that pick pivot in different ways:
	/// -Always pick first element as pivot.
	/// -Always pick last element as pivot.
	/// -Pick a random element as pivot.
	/// -Pick median as pivot.
	/// </summary>
	public static class QuickSort
	{
		public static void SortAscending(ref int[] data)
		{
			SortAscending_Recursive(ref data, 0, data.Length - 1);
		} // end method

		public static void SortAscending_Recursive(ref int[] data, int left, int right)
		{
			if (left < right)
			{
				int pivot = PartitionAscending(ref data, left, right);

				SortAscending_Recursive(ref data, left, pivot - 1);
				SortAscending_Recursive(ref data, pivot + 1, right);
			}
		} // end method

		public static int PartitionAscending(ref int[] data, int left, int right)
		{
			int pivot = data[right];
			int i = (left - 1);

			for (int j = left; j <= right - 1; j++)
			{
				// If current element is smaller than the pivot
				if (data[j] < pivot)
				{
					i++;
					Swap(ref data[i], ref data[j]);
				}
			} // end for

			Swap(ref data[i + 1], ref data[right]);
			return (i + 1);
		} // end method

		public static void SortDescending(ref int[] data)
		{
			SortDescending_Recursive(ref data, 0, data.Length - 1);
		} // end method

		public static void SortDescending_Recursive(ref int[] data, int left, int right)
		{
			if (left < right)
			{
				int pivot = PartitionDescending(ref data, left, right);

				SortDescending_Recursive(ref data, left, pivot - 1);
				SortDescending_Recursive(ref data, pivot + 1, right);
			}
		} // end method

		public static int PartitionDescending(ref int[] data, int left, int right)
		{
			int pivot = data[right];
			int i = (left - 1);

			for (int j = left; j <= right - 1; j++)
			{
				if (data[j] > pivot)
				{
					i++;
					Swap(ref data[i], ref data[j]);
				}
			} // end for

			Swap(ref data[i + 1], ref data[right]);
			return (i + 1);
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
