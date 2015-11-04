using System;
using System.Collections.Generic;

namespace SGM
{
	public class Cashdesk
	{
		public Queue<Customer> Queue = new Queue<Customer>();
		public Customer CurrentCustomer;
		public double Cash {get; private set;}

		public Cashdesk ()
		{
		}

		public int customerAmount()
		{
			return Queue.Count;
		}

		public Customer nextCustomer()
		{
			CurrentCustomer = Queue.Dequeue();
			return CurrentCustomer;
		}

		public void chargeCustomer(double amount)
		{
			CurrentCustomer.pay(amount);
		}
	}
}
