using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var account = new Account("AAA", "Allem", 100);

		}
	}

	class Account
	
	{
		public string ID { get; private set; }

		public string Name { get; private set; }

		public int Balance { get; private set; }

		public Account(string id, string name, int balance)
		{

			ID = id;
			Name = name;
			Balance = balance;
		}

		public void Deposit(int amount)
		{
			Balance += amount;
		}

		public void Withdraw(int amount)
		{
			Balance -= amount;
		}
		}

	}
	
		
	

