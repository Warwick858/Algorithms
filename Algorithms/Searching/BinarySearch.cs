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

namespace Algorithms.Searching
{
	/// <summary>
	/// BINARY SEARCH
	/// Best used for
	/// Sorted, not sorted?
	/// etc
	/// </summary>
	public static class BinarySearch
	{
		public static object SearchRecursive(int[] inputArray, int key, int min, int max)
		{
			if (min > max)
			{
				return "Nil";
			}
			else
			{
				int mid = (min + max) / 2;
				if (key == inputArray[mid])
				{
					return ++mid;
				}
				else if (key < inputArray[mid])
				{
					return SearchRecursive(inputArray, key, min, mid - 1);
				}
				else
				{
					return SearchRecursive(inputArray, key, mid + 1, max);
				}
			}
		} // end method

		public static object SearchIterative(int[] inputArray, int key)
		{
			int min = 0;
			int max = inputArray.Length - 1;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (key == inputArray[mid])
				{
					return ++mid;
				}
				else if (key < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return "Nil";
		} // end method
	} // end class
} // end namespace
