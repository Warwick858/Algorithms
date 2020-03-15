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
using Algorithms.Logging;
using Algorithms.Sorting;
using NUnit.Framework;
using System.Text.Json;

namespace AlgorithmsTests.Sorting
{
	[TestFixture]
	public class QuickSortTests
	{
		private int[] _data1;


		[OneTimeSetUp]
		public void Setup()
		{
			_data1 = new int[] { 5, 21, 43, 66, 43, 66, 21, 5, 2, 7, 7, 8, 1, 2, 3, 4, 4, 3, 2, 1 };
		}

		[Test]
		public void SortAscending()
		{
			int[] data = _data1;

			BubbleSort.SortAscending(ref data);

			Logger.WriteLine(JsonSerializer.Serialize(data));

			for (int i = 0; i < data.Length - 1; i++)
			{
				if (data[i] > data[i + 1])
					Assert.Fail();
			} // end foreach

			Assert.Pass();
		} // end method

		[Test]
		public void SortDescending()
		{
			int[] data = _data1;

			BubbleSort.SortDescending(ref data);

			Logger.WriteLine(JsonSerializer.Serialize(data));

			for (int i = 0; i < data.Length - 1; i++)
			{
				if (data[i] < data[i + 1])
					Assert.Fail();
			} // end foreach

			Assert.Pass();
		} // end method

		[Test]
		public void Swap()
		{
			int a = 7;
			int b = 2;

			BubbleSort.Swap(ref a, ref b);

			Assert.IsTrue(a == 2);
			Assert.IsTrue(b == 7);
		} // end method
	} // end class
} // end namespace
