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
using System;
using System.Collections.Generic;
using System.Text;

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
		}

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
			for (int j = 0; j < data.Length - 1; j++)
			{
				for (int i = 0; i < data.Length - 1; i++)
				{
					if (data[i] < data[i + 1])
					{
						Swap(ref data[i], ref data[i + 1]);
					}
				} // end for
			} // end for
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
				{
					left++; // get next left
				} // end while

				//While right element is greater than pivot
				while (data[right] > pivot)
				{
					right--; // get next right
				} // end while

				//Is left is less than right, swap and increment
				if (left <= right)
				{
					Swap(ref data[right], ref data[left]);
					left++;
					right--;
				} // end if
			} // end while

			//Return last left index
			return left;
		} // end function partition()

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
