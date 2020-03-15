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
	/// Best used for
	/// Sorted, not sorted?
	/// etc
	/// </summary>
	public static class QuickSort
	{
		public static void SortAscending(ref int[] data)
		{
			SortAscending_Recursive(ref data, 0, data.Length - 1);
		} // end method

		public static void SortAscending_Recursive(ref int[] data, int left, int right)
		{
			//Partition vector and save last left index
			int index = Partition(ref data, left, right);

			//If the original left is less than last left-1
			if (left < index - 1)
			{
				//Pass again w/ alternate right
				SortAscending_Recursive(ref data, left, index - 1);
			} // end if

			//If the last left index is less than right
			if (index < right)
			{
				//Pass again w/ alternate left
				SortAscending_Recursive(ref data, index, right);
			} // end if
		} // end method

		public static void SortDescending(ref int[] data)
		{
			SortDescending_Recursive(ref data, 0, data.Length - 1);
		} // end method

		public static void SortDescending_Recursive(ref int[] data, int left, int right)
		{
			//Partition vector and save last left index
			int index = Partition(ref data, left, right);

			//If the original left is less than last left-1
			if (left > index - 1)
			{
				//Pass again w/ alternate right
				SortAscending_Recursive(ref data, index - 1, left);
			} // end if

			//If the last left index is less than right
			if (index > right)
			{
				//Pass again w/ alternate left
				SortAscending_Recursive(ref data, right, index);
			} // end if
		} // end method

		public static int Partition(ref int[] data, int left, int right)
		{
			//Get pivot element
			int pivot = data[(left + right) / 2];

			//While left is LESS than right
			while (left < right)
			{
				//While left element is less than pivot
				while (data[left] < pivot)
					left++; // get next left

				//While right element is greater than pivot
				while (data[right] > pivot)
					right--; // get next right

				//If left is less than right, swap and increment
				if (left <= right)
				{
					Swap(ref data[right], ref data[left]);
					left++;
					right--;
				}
			} // end while

			//Return last left index
			return left;
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
