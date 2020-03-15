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
	/// SHELL SORT
	/// Best used for
	/// Sorted, not sorted?
	/// etc
	/// </summary>
	public static class ShellSort
	{
		public static void SortAscending(ref int[] data)
		{
			//Cut the shell in half each time through
			for (int shell = ((data.Length + 1) / 2); shell > 0; shell /= 2)
			{
				//Increment shell through array until end (size) is reached
				for (int i = shell; i < data.Length; i++)
				{
					//Save j as i - Reduce j by shell length
					for (int j = i; j >= shell; j -= shell) // j -= shell
					{
						//If the right element is less than the left element
						if (data[i] < data[j - shell])
						{
							Swap(ref data[j], ref data[j - shell]);
						}
						else
							break;
					} // end for
				} // end for
			} // end for
		} // end method

		public static void SortDescending(ref int[] data)
		{
			//Cut the shell in half each time through
			for (int shell = ((data.Length + 1) / 2); shell > 0; shell /= 2)
			{
				//Increment shell through array until end (size) is reached
				for (int i = shell; i < data.Length; i++)
				{
					//Save j as i - Reduce j by shell length
					for (int j = i; j >= shell; j -= shell) // j -= shell
					{
						//If the right element is less than the left element
						if (data[i] > data[j - shell])
						{
							Swap(ref data[j], ref data[j - shell]);
						}
						else
							break;
					} // end for
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
