﻿using System;
using Gtk;

namespace SGM
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow window = new MainWindow ();
			window.Show ();
			Application.Run ();
		}
	}
}
