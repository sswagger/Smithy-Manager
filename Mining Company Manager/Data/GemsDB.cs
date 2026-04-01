using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class GemsDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Gem> gems = [];

		//=== Methods ===\\
		// create
		public void CreateGem(Gem gem) {
			string insertStatement = "INSERT Gems (Type, Amount, Cost, MinerId, ShopId) VALUES (@Type, @Amount, @Cost, @MinerId, @ShopId)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			cmd.Parameters.AddWithValue("@Type", gem.Type);
			cmd.Parameters.AddWithValue("@Amount", gem.Amount);
			cmd.Parameters.AddWithValue("@Cost", gem.Cost);
			cmd.Parameters.AddWithValue("@MinerId", gem.MinerId);
			cmd.Parameters.AddWithValue("@ShopId", gem.ShopId);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetGems();
		}

		// read
		public List<Gem> GetGems() {
			this.gems = new SmithyManagerContext().Gems.ToList();

			return new List<Gem>(this.gems);
		}
		public List<Gem> GetGems(string filter) {
			List<Gem> filteredMiners = [];
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(filter, connection);

			connection.Open();
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				filteredMiners.Add(new Gem() {
					Id = (int)reader["Id"],
					Type = (GemType)reader["Type"],
					Amount = (int)reader["Amount"],
					Cost = (int)reader["Cost"],
					MinerId = (int)reader["MinerId"],
					ShopId = (int)reader["ShopId"]
				});
			}
			return filteredMiners;
		}
		public List<string> GetIds() {
			List<string> gemIds = [];
			string selectStatement = "SELECT Id FROM Gems";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				gemIds.Add(reader[0].ToString());
			}

			return gemIds;
		}

		// update
		public void UpdateGem(Gem gem) {
			string updateStatement = "UPDATE Gems SET Type = @Type, Amount = @Anount, Cost = @Cost, MinerId = @MinerId, ShopId = @ShopId WHERE Id = @MineralId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			cmd.Parameters.AddWithValue("@Type", gem.Type);
			cmd.Parameters.AddWithValue("@Amount", gem.Amount);
			cmd.Parameters.AddWithValue("@Cost", gem.Cost);
			cmd.Parameters.AddWithValue("@MinerId", gem.MinerId);
			cmd.Parameters.AddWithValue("@ShopId", gem.ShopId);
			cmd.Parameters.AddWithValue("@MineralId", gem.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetGems();
		}

		// delete
		public void DeleteGem(int id) {
			string deleteStatement = "DELETE FROM Gems WHERE Id = @GemId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@GemId", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetGems();
		}
	}
}
