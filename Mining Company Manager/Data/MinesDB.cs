using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class MinesDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Mine> mines = [];

		//=== Methods ===\\
		// create
		public void CreateMine(Mine mine) {
			string insertStatement = "INSERT Mines (Age, Equip) VALUES (@Age, @Equip)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			cmd.Parameters.AddWithValue("@Age", mine.Age);
			cmd.Parameters.AddWithValue("@Equip", mine.Equip);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMines();
		}

		// read
		public List<Mine> GetMines() {
			this.mines = new SmithyManagerContext().Mines.ToList();
			return new List<Mine>(this.mines);
		}
		public Mine? GetMine(int id) {
			if (this.mines.Count <= 0) {
				this.GetMines();
			}

			foreach (Mine mine in this.mines) {
				if (mine.Id == id) {
					return mine;
				}
			}

			return null;
		}
		public List<string> GetIds() {
			List<string> mineIds = [];
			string selectStatement = "SELECT Id FROM Mines";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				mineIds.Add(reader[0].ToString());
			}

			return mineIds;
		}

		// update
		public void UpdateMine(Mine mine) {
			string updateStatement = "UPDATE Mines SET Age = @Age, Equip = @Equip WHERE Id = @MineId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			cmd.Parameters.AddWithValue("@Age", mine.Age);
			cmd.Parameters.AddWithValue("@Equip", mine.Equip);
			cmd.Parameters.AddWithValue("@MineId", mine.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMines();
		}

		// delete
		public void DeleteMine(int id) {
			string deleteStatement = "DELETE FROM Mines WHERE Id = @MineId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@MineId", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMines();
		}
	}
}
