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
using System.Diagnostics;

namespace Algorithms.Logging
{
	public static class Logger
	{
		private static string _logPath = @"D:\Documents\Computer Science\Algorithms\C#\Algorithms\Algorithms\Logs\log.txt";

		public static void Write(string msg)
		{
			TextWriterTraceListener output = new TextWriterTraceListener(_logPath, "log");
			output.Write(msg);
			output.Flush();
			output.Dispose();
		}

		public static void WriteLine(string msg)
		{
			TextWriterTraceListener output = new TextWriterTraceListener(_logPath, "log");
			output.WriteLine(msg);
			output.Flush();
			output.Dispose();
		}
	}
}
