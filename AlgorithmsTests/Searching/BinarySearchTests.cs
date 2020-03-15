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
using Algorithms.Searching;
using NUnit.Framework;
using System.Diagnostics;
using System.Text.Json;

namespace AlgorithmsTests.Searching
{
	[TestFixture]
	public class BinarySearchTests
	{
		private Stopwatch _stopWatch;

		[SetUp]
		public void Setup()
		{
			_stopWatch = new Stopwatch();
		}

		[Test]
		//[TestCase(new int[] { 5, 21, 43, 66, 43, 66, 21, 5, 2, 7, 7, 8, 1, 2, 3, 4, 4, 3, 2, 1 })]
		[TestCase(new int[] { 1, 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 7, 7, 8, 21, 21, 43, 43, 66, 66 })]
		public void SearchRecursive(int[] data)
		{
			object result = 0;

			_stopWatch.Start();
			result = BinarySearch.SearchRecursive(data, 8, 0, data.Length - 1);
			_stopWatch.Stop();

			Logger.WriteLine($"**********************************************************************");
			Logger.WriteLine($"BinarySearch | recursive | index: {JsonSerializer.Serialize(result)}");
			Logger.WriteLine($"Elapsed Time: {_stopWatch.Elapsed.ToString()}");
			Logger.WriteLine($"**********************************************************************");

			Assert.IsTrue(int.TryParse(JsonSerializer.Serialize(result), out int num));
		} // end method

		[Test]
		//[TestCase(new int[] { 5, 21, 43, 66, 43, 66, 21, 5, 2, 7, 7, 8, 1, 2, 3, 4, 4, 3, 2, 1 })]
		[TestCase(new int[] { 1, 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 7, 7, 8, 21, 21, 43, 43, 66, 66 })]
		public void SearchIterative(int[] data)
		{
			object result = 0;

			_stopWatch.Start();
			result = BinarySearch.SearchIterative(data, 8);
			_stopWatch.Stop();

			Logger.WriteLine($"**********************************************************************");
			Logger.WriteLine($"BinarySearch | iterative | index: {JsonSerializer.Serialize(result)}");
			Logger.WriteLine($"Elapsed Time: {_stopWatch.Elapsed.ToString()}");
			Logger.WriteLine($"**********************************************************************");

			Assert.IsTrue(int.TryParse(JsonSerializer.Serialize(result), out int num));
		} // end method
	} // end class
} // end namespace
