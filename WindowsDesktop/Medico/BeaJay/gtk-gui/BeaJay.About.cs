
// This file has been generated by the GUI designer. Do not modify.
namespace BeaJay
{
	public partial class About
	{
		private global::Gtk.ScrolledWindow aboutScrolledWindow;
		
		private global::Gtk.TextView aboutTextView;
		
		private global::Gtk.Button aboutBtnOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BeaJay.About
			this.Name = "BeaJay.About";
			this.Title = "Medico About Window";
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.DefaultWidth = 250;
			this.DefaultHeight = 250;
			// Internal child BeaJay.About.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "aboutVbox";
			w1.BorderWidth = ((uint)(2));
			// Container child aboutVbox.Gtk.Box+BoxChild
			this.aboutScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.aboutScrolledWindow.Name = "aboutScrolledWindow";
			this.aboutScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child aboutScrolledWindow.Gtk.Container+ContainerChild
			this.aboutTextView = new global::Gtk.TextView ();
			this.aboutTextView.CanFocus = true;
			this.aboutTextView.Name = "aboutTextView";
			this.aboutTextView.Editable = false;
			this.aboutTextView.CursorVisible = false;
			this.aboutTextView.AcceptsTab = false;
			this.aboutScrolledWindow.Add (this.aboutTextView);
			w1.Add (this.aboutScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.aboutScrolledWindow]));
			w3.Position = 0;
			// Internal child BeaJay.About.ActionArea
			global::Gtk.HButtonBox w4 = this.ActionArea;
			w4.Name = "aboutActionArea";
			w4.Spacing = 10;
			w4.BorderWidth = ((uint)(5));
			w4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child aboutActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.aboutBtnOk = new global::Gtk.Button ();
			this.aboutBtnOk.CanDefault = true;
			this.aboutBtnOk.CanFocus = true;
			this.aboutBtnOk.Name = "aboutBtnOk";
			this.aboutBtnOk.UseStock = true;
			this.aboutBtnOk.UseUnderline = true;
			this.aboutBtnOk.Label = "gtk-ok";
			this.AddActionWidget (this.aboutBtnOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4 [this.aboutBtnOk]));
			w5.Expand = false;
			w5.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.aboutBtnOk.Clicked += new global::System.EventHandler (this.OnButtonClick);
		}
	}
}
