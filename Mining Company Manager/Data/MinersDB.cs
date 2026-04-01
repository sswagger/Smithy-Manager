using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class MinersDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Miner> miners = [];

		//=== Methods ===\\
		// create
		public void CreateMiner(Miner miner) {
			string insertStatement = "INSERT Miners (Name, Pay, Age, MineId) VALUES (@Name, @Pay, @Age, @MineId)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			if (miner.Name != null) {
				cmd.Parameters.AddWithValue("@Name", miner.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			if (miner.Age != null) {
				cmd.Parameters.AddWithValue("@Age", miner.Age);
			}
			else {
				cmd.Parameters.AddWithValue("@Age", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Pay", miner.Pay);
			cmd.Parameters.AddWithValue("@MineId", miner.MineId);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMiners();
		}

		// read
		public List<Miner> GetMiners() {
			this.miners = new SmithyManagerContext().Miners.ToList();
			return new List<Miner>(this.miners);
		}
		public List<Miner> GetMiners(string filter) {
			List<Miner> filteredMiners = [];
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(filter, connection);

			connection.Open();
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				filteredMiners.Add(new Miner() {
					Id = (int)reader["Id"],
					Pay = (int)reader["Pay"],
					Age = (int)reader["Age"],
					Name = (string)reader["Name"],
					MineId = (int)reader["MineId"]
				});
			}
			return filteredMiners;
		}
		public Miner? GetMiner(int id) {
			if (this.miners.Count <= 0) {
				this.GetMiners();
			}

			foreach (Miner miner in this.miners) {
				if (miner.Id == id) {
					return miner;
				}
			}

			return null;
		}
		public List<string> GetIds() {
			List<string> minerIds = [];
			string selectStatement = "SELECT Id FROM Miners";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				minerIds.Add(reader[0].ToString());
			}

			return minerIds;
		}

		// update
		public void UpdateMiner(Miner miner) {
			string updateStatement = "UPDATE Miners SET Name = @Name, Pay = @Pay, Age = @Age, MineId = @MineId WHERE Id = @MinerId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			if (miner.Name != null) {
				cmd.Parameters.AddWithValue("@Name", miner.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			if (miner.Age != null) {
				cmd.Parameters.AddWithValue("@Age", miner.Age);
			}
			else {
				cmd.Parameters.AddWithValue("@Age", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Pay", miner.Pay);
			cmd.Parameters.AddWithValue("@MineId", miner.MineId);
			cmd.Parameters.AddWithValue("@MinerId", miner.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMiners();
		}

		// delete
		public void DeleteMiner(int id) {
			string deleteStatement = "DELETE FROM Miners WHERE Id = @Miners";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@Miners", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetMiners();
		}
	}
}
