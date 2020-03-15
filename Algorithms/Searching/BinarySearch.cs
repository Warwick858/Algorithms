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

namespace Algorithms.Searching
{
	/// <summary>
	/// BINARY SEARCH
	/// Time Complexity: O(n).
	/// ******************************************************
	/// Search a sorted array by repeatedly dividing the search interval in half.
	/// Begin with an interval covering the whole array.
	/// If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half.
	/// Otherwise narrow it to the upper half.
	/// Repeatedly check until the value is found or the interval is empty.
	/// </summary>
	public static class BinarySearch
	{
		public static object SearchRecursive(int[] data, int key, int left, int right)
		{
			if (left > right)
				return "unsorted";
			else
			{
				int mid = (left + right) / 2;

				if (key == data[mid])
					return ++mid;
				else if (key < data[mid])
					return SearchRecursive(data, key, left, mid - 1);
				else
					return SearchRecursive(data, key, mid + 1, right);
			} // end else
		} // end method

		public static object SearchIterative(int[] data, int key)
		{
			int min = 0;
			int max = data.Length - 1;

			while (min <= max)
			{
				int mid = (min + max) / 2;

				if (key == data[mid])
					return ++mid;
				else if (key < data[mid])
					max = mid - 1;
				else
					min = mid + 1;
			} // end while

			return "unsorted";
		} // end method
	} // end class
} // end namespace
