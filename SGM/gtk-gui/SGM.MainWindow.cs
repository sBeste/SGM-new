
// This file has been generated by the GUI designer. Do not modify.
namespace SGM
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action SGMAction;
		
		private global::Gtk.Action deleteAction;
		
		private global::Gtk.Action restart;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubar1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget SGM.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.SGMAction = new global::Gtk.Action ("SGMAction", global::Mono.Unix.Catalog.GetString ("SGM"), null, null);
			this.SGMAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test");
			w1.Add (this.SGMAction, null);
			this.deleteAction = new global::Gtk.Action ("deleteAction", global::Mono.Unix.Catalog.GetString ("Beenden"), null, "gtk-delete");
			this.deleteAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Beenden");
			w1.Add (this.deleteAction, null);
			this.restart = new global::Gtk.Action ("restart", global::Mono.Unix.Catalog.GetString ("Neustarten"), null, "gtk-refresh");
			this.restart.ShortLabel = global::Mono.Unix.Catalog.GetString ("Neustarten");
			w1.Add (this.restart, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "SGM.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SGM");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SGM.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='SGMAction' action='SGMAction'><menuitem name='deleteAction' action='deleteAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 503;
			this.DefaultHeight = 300;
			this.Show ();
			this.deleteAction.Activated += new global::System.EventHandler (this.shutdown);
		}
	}
}