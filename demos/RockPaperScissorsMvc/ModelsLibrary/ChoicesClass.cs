﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary
{
	public class ChoicesClass
	{
		//public int ChoiceClassId { get; set; }
		//public int MyProperty { get; set; }
		//an enum is a custom data type that you decide the types for.
		public enum RpsChoice
		{
			//without specifying the number equivalent of the enum type, the numbers default to start at 0.
			Rock = 1,//equivalent to 1
			Paper = 2,//equivalent to 2
			Scissors = 3//equivalent to 3
		}
	}
}
