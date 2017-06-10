
// This file has been generated by the GUI designer. Do not modify.
namespace Moi
{
	public partial class NodeWindow
	{
		private global::Gtk.VBox vbox9;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Label IdLabel;

		private global::Gtk.Entry IdEntry;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label NameLabel;

		private global::Gtk.Entry NameEntry;

		private global::Gtk.HBox hbox13;

		private global::Gtk.Label LatLabel;

		private global::Gtk.Entry LatEntry;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Label LonLabel;

		private global::Gtk.Entry LonEntry;

		private global::Gtk.HBox hbox15;

		private global::Gtk.EventBox eventbox2;

		private global::Gtk.Button CancelButton;

		private global::Gtk.EventBox eventbox1;

		private global::Gtk.Button CreateButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Moi.NodeWindow
			this.Name = "Moi.NodeWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("NodeWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Moi.NodeWindow.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 14;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.IdLabel = new global::Gtk.Label();
			this.IdLabel.Name = "IdLabel";
			this.IdLabel.LabelProp = global::Mono.Unix.Catalog.GetString("id");
			this.hbox11.Add(this.IdLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.IdLabel]));
			w1.Position = 1;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.IdEntry = new global::Gtk.Entry();
			this.IdEntry.CanFocus = true;
			this.IdEntry.Name = "IdEntry";
			this.IdEntry.IsEditable = true;
			this.IdEntry.InvisibleChar = '●';
			this.hbox11.Add(this.IdEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.IdEntry]));
			w2.Position = 2;
			this.vbox9.Add(this.hbox11);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox11]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.NameLabel = new global::Gtk.Label();
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Name");
			this.hbox12.Add(this.NameLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.NameLabel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.NameEntry = new global::Gtk.Entry();
			this.NameEntry.CanFocus = true;
			this.NameEntry.Name = "NameEntry";
			this.NameEntry.IsEditable = true;
			this.NameEntry.InvisibleChar = '●';
			this.hbox12.Add(this.NameEntry);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.NameEntry]));
			w5.Position = 2;
			this.vbox9.Add(this.hbox12);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox12]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.LatLabel = new global::Gtk.Label();
			this.LatLabel.Name = "LatLabel";
			this.LatLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Latitude");
			this.hbox13.Add(this.LatLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.LatLabel]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.LatEntry = new global::Gtk.Entry();
			this.LatEntry.CanFocus = true;
			this.LatEntry.Name = "LatEntry";
			this.LatEntry.IsEditable = true;
			this.LatEntry.InvisibleChar = '●';
			this.hbox13.Add(this.LatEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.LatEntry]));
			w8.Position = 2;
			this.vbox9.Add(this.hbox13);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox13]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.LonLabel = new global::Gtk.Label();
			this.LonLabel.Name = "LonLabel";
			this.LonLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Longitude");
			this.hbox14.Add(this.LonLabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.LonLabel]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.LonEntry = new global::Gtk.Entry();
			this.LonEntry.CanFocus = true;
			this.LonEntry.Name = "LonEntry";
			this.LonEntry.IsEditable = true;
			this.LonEntry.InvisibleChar = '●';
			this.hbox14.Add(this.LonEntry);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.LonEntry]));
			w11.Position = 2;
			this.vbox9.Add(this.hbox14);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox14]));
			w12.Position = 7;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.eventbox2 = new global::Gtk.EventBox();
			this.eventbox2.Name = "eventbox2";
			// Container child eventbox2.Gtk.Container+ContainerChild
			this.CancelButton = new global::Gtk.Button();
			this.CancelButton.CanFocus = true;
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.UseUnderline = true;
			this.CancelButton.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.eventbox2.Add(this.CancelButton);
			this.hbox15.Add(this.eventbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.eventbox2]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			w14.Padding = ((uint)(50));
			// Container child hbox15.Gtk.Box+BoxChild
			this.eventbox1 = new global::Gtk.EventBox();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.CreateButton = new global::Gtk.Button();
			this.CreateButton.CanFocus = true;
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.UseUnderline = true;
			this.CreateButton.Label = global::Mono.Unix.Catalog.GetString("Create");
			this.eventbox1.Add(this.CreateButton);
			this.hbox15.Add(this.eventbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.eventbox1]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			w16.Padding = ((uint)(50));
			this.vbox9.Add(this.hbox15);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox15]));
			w17.Position = 9;
			w17.Expand = false;
			w17.Fill = false;
			this.Add(this.vbox9);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 478;
			this.DefaultHeight = 302;
			this.Show();
			this.CancelButton.Clicked += new global::System.EventHandler(this.CancelButtonPressed);
			this.CreateButton.Clicked += new global::System.EventHandler(this.CreateButtonPressed);
		}
	}
}
