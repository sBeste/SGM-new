﻿using System;

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
			CustomerCreate customerCreate = new CustomerCreate ();
			customerCreate.Show ();
		}
	}
}

