using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class CraftsmenDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Craftsman> craftsmen = [];

		//=== Methods ===\\
		// create
		public void CreateCraftsman(Craftsman craftsman) {
			string insertStatement = "INSERT Craftsmen (Name, Pay, Age, ShopId) VALUES (@Name, @Pay, @Age, @ShopId)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			if (craftsman.Name != null) {
				cmd.Parameters.AddWithValue("@Name", craftsman.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			if (craftsman.Age != null) {
				cmd.Parameters.AddWithValue("@Age", craftsman.Age);
			}
			else {
				cmd.Parameters.AddWithValue("@Age", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Pay", craftsman.Pay);
			cmd.Parameters.AddWithValue("@ShopId", craftsman.ShopId);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetCraftsmen();
		}

		// read
		public List<Craftsman> GetCraftsmen() {
			this.craftsmen = new SmithyManagerContext().Craftsmen.ToList();
			return new List<Craftsman>(this.craftsmen);
		}
		public List<Craftsman> GetCraftsmen(string filter) {
			List<Craftsman> filteredCraftsmen = [];
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(filter, connection);

			connection.Open();
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				filteredCraftsmen.Add(new Craftsman() {
					Id = (int)reader["Id"],
					Pay = (int)reader["Pay"],
					Age = (int)reader["Age"],
					Name = (string)reader["Name"],
					ShopId = (int)reader["ShopId"]
				});
			}
			return filteredCraftsmen;
		}
		public Craftsman? GetCraftsman(int id) {
			if (this.craftsmen.Count <= 0) {
				this.GetCraftsmen();
			}

			foreach (Craftsman craftsman in this.craftsmen) {
				if (craftsman.Id == id) {
					return craftsman;
				}
			}

			return null;
		}
		public List<string> GetIds() {
			List<string> craftsmanIds = [];
			string selectStatement = "SELECT Id FROM Craftsmen";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				craftsmanIds.Add(reader[0].ToString());
			}

			return craftsmanIds;
		}

		// update
		public void UpdateCraftsman(Craftsman craftsman) {
			string updateStatement = "UPDATE Craftsmen SET Name = @Name, Pay = @Pay, Age = @Age, ShopId = @ShopId WHERE Id = @CraftsmanId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			if (craftsman.Name != null) {
				cmd.Parameters.AddWithValue("@Name", craftsman.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			if (craftsman.Age != null) {
				cmd.Parameters.AddWithValue("@Age", craftsman.Age);
			}
			else {
				cmd.Parameters.AddWithValue("@Age", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Pay", craftsman.Pay);
			cmd.Parameters.AddWithValue("@ShopId", craftsman.ShopId);
			cmd.Parameters.AddWithValue("@CraftsmanId", craftsman.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetCraftsmen();
		}

		// delete
		public void DeleteCraftsman(int id) {
			string deleteStatement = "DELETE FROM Craftsmen WHERE Id = @CraftsmanId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@CraftsmanId", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetCraftsmen();
		}

	}
}
