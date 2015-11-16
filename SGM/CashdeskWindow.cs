using System;
using Gtk;

namespace SGM
{
	public partial class CashdeskWindow : Gtk.Window
	{
		public CashdeskWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

