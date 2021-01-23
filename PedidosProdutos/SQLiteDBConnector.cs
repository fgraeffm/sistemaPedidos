using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SistemaPedidos {
	public class SQLiteDBConnector {
		static string dbPath = Application.StartupPath + @"\DB";
		static string dbFile = Application.StartupPath + @"\DB\DBSQLite.db";
		static string strConnection = @"Data Source = " + dbFile + "; Version = 3";

		public static SQLiteConnection SQLiteConnect() {

			if (!File.Exists(dbFile)){
				Directory.CreateDirectory(dbPath);
				SQLiteConnection.CreateFile(dbFile);
			}

			return new SQLiteConnection(strConnection);
		}

		public static void CreateTables() {
			string query = "CREATE TABLE IF NOT EXISTS pedidos (" +
					"id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
					"numero INT," +
					"data VARCHAR(50)," +
					"descricao VARCHAR(600)," +
					"situacao VARCHAR(50))";

			SQLCommandNonQuery(query);

			query = "CREATE TABLE IF NOT EXISTS itens (" +
				"id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
				"pedidoNumero INTEGER NOT NULL," +
				"codigo VARCHAR(8)," +
				"quantidade INT," +
				"valorUnitario FLOAT," +
				"desconto FLOAT)";

			SQLCommandNonQuery(query);
		}

		public static void SQLCommandNonQuery(string query) {
			SQLiteCommand command = new SQLiteCommand();
			command.Connection = SQLiteConnect();
			try {
				command.Connection.Open();
				command.CommandText = query;
			
				command.ExecuteNonQuery();

			} catch (Exception ex) {
				SQLError(ex);
				throw;
			} finally {
				command.Connection.Close();
				command.Dispose();
			}
			
		}

		public static void SQLSelectData(string query, ref DataTable data) {
			SQLiteCommand command = new SQLiteCommand();
			command.Connection = SQLiteConnect();

			SQLiteDataAdapter da = null;

			try {
				command.Connection.Open();

				command.CommandText = query;
				da = new SQLiteDataAdapter(command.CommandText, command.Connection);
				da.Fill(data);
			} catch (Exception ex) {
				SQLError(ex);
				throw;
			} finally {
				command.Connection.Close();
				command.Dispose();
			}
			
		}

		public static void SQLError(Exception ex) {
			MessageBox.Show("Erro SQLite: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

	}
}
