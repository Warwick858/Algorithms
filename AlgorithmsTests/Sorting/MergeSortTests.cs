﻿// ******************************************************************************************************************
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;

namespace AlgorithmsTests.Sorting
{
	[TestFixture]
	public class MergeSortTests
	{
		private Stopwatch _stopWatch;

		[OneTimeSetUp]
		public void Setup()
		{
			_stopWatch = new Stopwatch();
		}

		[Test]
		[TestCase(new int[] { 5, 21, 43, 66, 43, 66, 21, 5, 2, 7, 7, 8, 1, 2, 3, 4, 4, 3, 2, 1 })]
		public void SortAscending(int[] data)
		{
			List<int> sorted = new List<int>();
			int[] ogData = new int[data.Length];
			Array.Copy(data, ogData, data.Length);

			_stopWatch.Start();
			sorted = MergeSort.SortAscending(new List<int>(data));
			_stopWatch.Stop();

			Logger.WriteLine($"**********************************************************************");
			Logger.WriteLine($"MergeSort | ascending");
			Logger.WriteLine($"Input: {JsonSerializer.Serialize(ogData)}");
			Logger.WriteLine($"Output: {JsonSerializer.Serialize(sorted)}");
			Logger.WriteLine($"Elapsed Time: {_stopWatch.Elapsed.ToString()}");
			Logger.WriteLine($"**********************************************************************");

			for (int i = 0; i < sorted.Count - 1; i++)
			{
				if (sorted[i] > sorted[i + 1])
					Assert.Fail();
			} // end foreach

			Assert.Pass();
		} // end method

		[Test]
		[TestCase(new int[] { 5, 21, 43, 66, 43, 66, 21, 5, 2, 7, 7, 8, 1, 2, 3, 4, 4, 3, 2, 1 })]
		public void SortDescending(int[] data)
		{
			List<int> sorted = new List<int>();
			int[] ogData = new int[data.Length];
			Array.Copy(data, ogData, data.Length);

			_stopWatch.Start();
			sorted = MergeSort.SortDescending(new List<int>(data));
			_stopWatch.Stop();

			Logger.WriteLine($"**********************************************************************");
			Logger.WriteLine($"MergeSort | descending");
			Logger.WriteLine($"Input: {JsonSerializer.Serialize(ogData)}");
			Logger.WriteLine($"Output: {JsonSerializer.Serialize(sorted)}");
			Logger.WriteLine($"Elapsed Time: {_stopWatch.Elapsed.ToString()}");
			Logger.WriteLine($"**********************************************************************");

			for (int i = 0; i < sorted.Count - 1; i++)
			{
				if (sorted[i] < sorted[i + 1])
					Assert.Fail();
			} // end foreach

			Assert.Pass();
		} // end method
	} // end class
} // end namespace
