using System;

namespace SGM
{
	public class Customer
	{
		public string Name {get; private set;}
		public string FirstName {get; private set;}
		public double CreditBalance {get; private set;}

		public Customer (string FirstName, string Name, double CreditBalance)
		{
			this.FirstName = FirstName;
			this.Name = Name;
			this.CreditBalance = CreditBalance;
		}

		public double pay (double amount) {
			this.CreditBalance = this.CreditBalance - amount;

			return this.CreditBalance;
		}
	}
}
