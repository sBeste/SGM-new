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

		protected void shutdown (object sender, EventArgs e)
		{
			System.Environment.Exit(1);
		}
	}
}

