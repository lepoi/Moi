using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Moi {
	public partial class EdgeWindow : Gtk.Window {

		List<Node> nodes;
		MySqlConnection Dbcon;
		MySqlCommand Dbcmd;
		IDataReader reader;
		string ConnectionString, query;

		public EdgeWindow(List<Node> nodes) : base(Gtk.WindowType.Toplevel) {

			ConnectionString =
				"Server=localhost;" +
				"Database=Grafo;" +
				"User ID=poi;" +
				"Password=poi;" +
				"Pooling=false";
			query = "INSERT INTO Arista VALUES (@id1, @id2, @cost);";
			Dbcon = new MySqlConnection(ConnectionString);

			this.nodes = nodes;



			this.Build();
		}

		protected void CancelButtonClicked(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void AcceptButtonClicked(object sender, EventArgs e) {
			try {
				Dbcon.Open();
				Dbcmd = new MySqlCommand(query, Dbcon);
				Dbcmd.Parameters.AddWithValue("@id1", IniEntry.Text);
				Dbcmd.Parameters.AddWithValue("@id2", FinEntry.Text);
				Dbcmd.Parameters.AddWithValue("@cost", CostEntry.Text);
				Dbcmd.ExecuteNonQuery();
				Gtk.MessageDialog msg = new Gtk.MessageDialog(this, Gtk.DialogFlags.DestroyWithParent, Gtk.MessageType.Info, Gtk.ButtonsType.Ok, "Arista insertada exitosamente");
				msg.Run();
				msg.Destroy();
				this.Destroy();
			} catch (Exception ex) {
				Gtk.MessageDialog msg = new Gtk.MessageDialog(this, Gtk.DialogFlags.DestroyWithParent, Gtk.MessageType.Error, Gtk.ButtonsType.Ok, "Error al insertar la Arista\n" + ex.StackTrace);
				msg.Run();
				msg.Destroy();
			}
		}
	}
}
