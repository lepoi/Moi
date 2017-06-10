using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Moi {
	public partial class NodeWindow : Gtk.Window {

		List<Node> nodes;
		MySqlConnection Dbcon;
		MySqlCommand Dbcmd;
		IDataReader reader;
		string ConnectionString, query;

		public NodeWindow(List<Node> nodes, double lat, double lon) : base(Gtk.WindowType.Toplevel) {


			ConnectionString = 
				"Server=localhost;" +
				"Database=Grafo;" +
				"User ID=poi;" +
				"Password=poi;" +
				"Pooling=false";
			query = "INSERT INTO Nodo VALUES (@id, @name, @lat, @lon);";
			Dbcon = new MySqlConnection(ConnectionString);

			this.nodes = nodes;

			Gtk.Application.Invoke((object o, EventArgs args) => {
				LatEntry.Text = lat.ToString();
				LonEntry.Text = lon.ToString();
			});

			this.Build();
		}
		protected void CancelButtonPressed(object o, EventArgs args) {
			this.Destroy();
		}
		protected void CreateButtonPressed(object o, EventArgs args) {
			try {
				Dbcon.Open();
				Dbcmd = new MySqlCommand(query, Dbcon);
				Dbcmd.Parameters.AddWithValue("@id", IdEntry.Text);
				Dbcmd.Parameters.AddWithValue("@name", NameEntry.Text);
				Dbcmd.Parameters.AddWithValue("@lat", LatEntry.Text);
				Dbcmd.Parameters.AddWithValue("@lon", LonEntry.Text);
				Dbcmd.ExecuteNonQuery();
				Gtk.MessageDialog msg = new Gtk.MessageDialog(this, Gtk.DialogFlags.DestroyWithParent, Gtk.MessageType.Info, Gtk.ButtonsType.Ok, "Nodo insertado exitosamente");
				msg.Run();
				msg.Destroy();
				this.Destroy();
			} catch (Exception e) {
				Gtk.MessageDialog msg = new Gtk.MessageDialog(this, Gtk.DialogFlags.DestroyWithParent, Gtk.MessageType.Error, Gtk.ButtonsType.Ok, "Error al insertar el Nodo\n" + e.StackTrace);
				msg.Run();
				msg.Destroy();
			}
		}
	}
}