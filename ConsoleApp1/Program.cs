using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var now = DateTime.Now;
			DateTime dt2 = now.GetParkingTime();
			Console.WriteLine(dt2);
		}
		}

	public static class ParkingTime
	{
		public static DateTime GetParkingTime(this DateTime value)
		{
			return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0);
		}
	}
	}


