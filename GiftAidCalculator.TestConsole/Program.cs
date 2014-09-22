﻿using System;

namespace GiftAidCalculator.TestConsole
{
	public class GiftAidCalculator
	{
		private static decimal taxRate = 20.0m;

		public static decimal GiftAidFor(decimal donationAmount)
		{
			return donationAmount * GiftAidFactor();		
		}

		private static decimal GiftAidFactor()
		{
			return taxRate / (100 - taxRate);
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			// Calc Gift Aid Based on Previous
			Console.WriteLine("Please Enter donation amount:");
			Console.WriteLine(GiftAidAmount(decimal.Parse(Console.ReadLine())));
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}

		public static decimal GiftAidAmount(decimal donationAmount)
		{
			var gaRatio = 17.5m / (100 - 17.5m);
			return donationAmount * gaRatio;
		}
	}
}
