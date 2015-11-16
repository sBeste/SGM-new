using System;

namespace SGM
{
	public partial class MainWindow : Gtk.Window
	{
		public MainWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void onCreateCustomerClicked (object sender, EventArgs e)
		{
			Customer customer = new Customer("Jannick", "Fahlbusch", 100);

			Console.WriteLine(customer.FirstName);
		}
	}
}

