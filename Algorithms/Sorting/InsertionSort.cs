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
	/// INSERTION SORT
	/// Best used for
	/// Sorted, not sorted?
	/// etc
	/// </summary>
	public static class InsertionSort
	{
		public static void SortAscending(ref int[] data)
		{
			for (int j = 1; j < data.Length; j++)
			{
				for (int i = j; i >= 1; i--)
				{
					//If element i-1 is GREATER than element i
					if (data[i - 1] > data[i])
						Swap(ref data[i - 1], ref data[i]);
					else // element i-1 is LESS than element i
						break;
				} // end for
			} // end for
		} // end method

		public static void SortDescending(ref int[] data)
		{
			for (int j = 1; j < data.Length; j++)
			{
				for (int i = j; i >= 1; i--)
				{
					//If element i-1 is LESS than element i
					if (data[i - 1] < data[i])
						Swap(ref data[i - 1], ref data[i]);
					else // element i-1 is GREATER than element i
						break;
				} // end for
			} // end for
		} // end method

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		} // end method
	} // end class
} // end namespace
