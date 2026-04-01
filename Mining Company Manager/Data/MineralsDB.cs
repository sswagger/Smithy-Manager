using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class MineralsDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Mineral> minerals = [];

		//=== Methods ===\\
		// create
		public void CreateMineral(Mineral mineral) {
			string insertStatement = "INSERT Minerals (Type, Amount, MinerId, ShopId) VALUES (@Type, @Amount, @MinerId, @ShopId)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			cmd.Parameters.AddWithValue("@Type", mineral.Type);
			cmd.Parameters.AddWithValue("@Amount", mineral.Amount);
			cmd.Parameters.AddWithValue("@MinerId", mineral.MinerId);
			cmd.Parameters.AddWithValue("@ShopId", mineral.ShopId);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMinerals();
		}

		// read
		public List<Mineral> GetMinerals() {
			this.minerals = new SmithyManagerContext().Minerals.ToList();

			return new List<Mineral>(this.minerals);
		}
		public List<Mineral> GetMinerals(string filter) {
			List<Mineral> filteredMiners = [];
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(filter, connection);

			connection.Open();
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				filteredMiners.Add(new Mineral() {
					Id = (int)reader["Id"],
					Type = (MineralType)reader["Type"],
					Amount = (int)reader["Amount"],
					MinerId = (int)reader["MinerId"],
					ShopId = (int)reader["ShopId"]
				});
			}
			return filteredMiners;
		}
		public List<string> GetIds() {
			List<string> mineralIds = [];
			string selectStatement = "SELECT Id FROM Minerals";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				mineralIds.Add(reader[0].ToString());
			}

			return mineralIds;
		}

		// update
		public void UpdateMineral(Mineral mineral) {
			string updateStatement = "UPDATE Minerals SET Type = @Type, Amount = @Anount, MinerId = @MinerId, ShopId = @ShopId WHERE Id = @MineralId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			cmd.Parameters.AddWithValue("@Type", mineral.Type);
			cmd.Parameters.AddWithValue("@Amount", mineral.Amount);
			cmd.Parameters.AddWithValue("@MinerId", mineral.MinerId);
			cmd.Parameters.AddWithValue("@ShopId", mineral.ShopId);
			cmd.Parameters.AddWithValue("@MineralId", mineral.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMinerals();
		}

		// delete
		public void DeleteMineral(int id) {
			string deleteStatement = "DELETE FROM Minerals WHERE Id = @MineralId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@MineralId", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMinerals();
		}
	}
}
