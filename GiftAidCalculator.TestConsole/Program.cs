﻿using System;
using GiftAidCalculatorCollaborators;

namespace GiftAidCalculator.TestConsole
{
	public class GiftAidCalculator
	{
		private static decimal taxRate = 20.0m;
		private const int decimalPlaces = 2;

		public static decimal TaxRate 
		{
			get { return taxRate; }
		}

		public static void UpdateTaxRate(decimal newTaxRate, User user)
		{
			if(user.IsAdmin()) { taxRate = newTaxRate; }
		}

		public static decimal GiftAidFor(decimal donationAmount)
		{
			return Math.Round(RawGiftAidFor(donationAmount), decimalPlaces);		
		}

		private static decimal RawGiftAidFor(decimal donationAmount)
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