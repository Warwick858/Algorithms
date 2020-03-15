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
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
	public static class MergeSort
	{
		public static List<int> SortAscending(List<int> unsorted)
		{
			List<int> left = new List<int>();
			List<int> right = new List<int>();

			if (unsorted.Count <= 1)
				return unsorted;

			int middle = unsorted.Count / 2;

			for (int i = 0; i < middle; i++)  //Dividing the unsorted list
				left.Add(unsorted[i]);

			for (int i = middle; i < unsorted.Count; i++)
				right.Add(unsorted[i]);

			left = SortAscending(left);
			right = SortAscending(right);
			return MergeAscending(left, right);
		} // end method

		private static List<int> MergeAscending(List<int> left, List<int> right)
		{
			List<int> result = new List<int>();

			while (left.Count > 0 || right.Count > 0)
			{
				if (left.Count > 0 && right.Count > 0)
				{
					if (left.First() <= right.First()) //Comparing First two elements to see which is smaller
					{
						result.Add(left.First());
						left.Remove(left.First()); //Rest of the list minus the first element
					}
					else
					{
						result.Add(right.First());
						right.Remove(right.First());
					}
				} // end if
				else if (left.Count > 0)
				{
					result.Add(left.First());
					left.Remove(left.First());
				}
				else if (right.Count > 0)
				{
					result.Add(right.First());
					right.Remove(right.First());
				}
			} // end while

			return result;
		} // end method

		public static List<int> SortDescending(List<int> unsorted)
		{
			List<int> left = new List<int>();
			List<int> right = new List<int>();

			if (unsorted.Count <= 1)
				return unsorted;

			int middle = unsorted.Count / 2;

			for (int i = 0; i < middle; i++)  //Dividing the unsorted list
				left.Add(unsorted[i]);

			for (int i = middle; i < unsorted.Count; i++)
				right.Add(unsorted[i]);

			left = SortDescending(left);
			right = SortDescending(right);
			return MergeDescending(left, right);
		} // end method

		private static List<int> MergeDescending(List<int> left, List<int> right)
		{
			List<int> result = new List<int>();

			while (left.Count > 0 || right.Count > 0)
			{
				if (left.Count > 0 && right.Count > 0)
				{
					if (left.First() >= right.First()) //Comparing First two elements to see which is smaller
					{
						result.Add(left.First());
						left.Remove(left.First()); //Rest of the list minus the first element
					}
					else
					{
						result.Add(right.First());
						right.Remove(right.First());
					}
				} // end if
				else if (left.Count > 0)
				{
					result.Add(left.First());
					left.Remove(left.First());
				}
				else if (right.Count > 0)
				{
					result.Add(right.First());
					right.Remove(right.First());
				}
			} // end while

			return result;
		} // end method
	} // end class
} // end namespace
