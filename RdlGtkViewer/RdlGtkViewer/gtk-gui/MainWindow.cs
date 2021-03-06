
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action OpenAction;
	private global::Gtk.Table table1;
	private global::Gtk.MenuBar menubar1;
	private global::fyiReporting.RdlGtkViewer.ReportViewer reportviewer1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
		w1.Add (this.OpenAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.table1.Add (this.menubar1);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.menubar1]));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.reportviewer1 = new global::fyiReporting.RdlGtkViewer.ReportViewer ();
		this.reportviewer1.WidthRequest = 0;
		this.reportviewer1.HeightRequest = 0;
		this.reportviewer1.Events = ((global::Gdk.EventMask)(256));
		this.reportviewer1.Name = "reportviewer1";
		this.reportviewer1.ShowErrors = false;
		this.reportviewer1.ShowParameters = false;
		this.table1.Add (this.reportviewer1);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.reportviewer1]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		this.Add (this.table1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 487;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.OpenAction.Activated += new global::System.EventHandler (this.OnFileOpen_Activated);
	}
}
