using Microsoft.Data.SqlClient;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class ShopsDB {
		//=== Variables ===\\
		string ConnectionString = ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString;
		private List<Shop> shops = [];

		//=== Methods ===\\
		// create
		public void CreateShop(Shop shop) {
			string insertStatement = "INSERT Shops (Size, Name) VALUES (@Size, @Name)";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(insertStatement, connection);
			if (shop.Name != null) {
				cmd.Parameters.AddWithValue("@Name", shop.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Size", shop.Size);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetShops();
		}

		// read
		public List<Shop> GetShops() {
			this.shops = new SmithyManagerContext().Shops.ToList();
			return new List<Shop>(this.shops);
		}
		public Shop? GetShop(int id) {
			if (this.shops.Count <= 0) {
				this.GetShops();
			}

			foreach (Shop shop in this.shops) {
				if (shop.Id == id) {
					return shop;
				}
			}

			return null;
		}
		public List<string> GetIds() {
			List<string> shopIds = [];
			string selectStatement = "SELECT Id FROM Shops";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(selectStatement, connection);

			connection.Open();

			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {
				shopIds.Add(reader[0].ToString());
			}

			return shopIds;
		}

		// update
		public void UpdateShop(Shop shop) {
			string updateStatement = "UPDATE Shops SET Size = @Size, Name = @Name WHERE Id = @ShopId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(updateStatement, connection);
			if (shop.Name != null) {
				cmd.Parameters.AddWithValue("@Name", shop.Name);
			}
			else {
				cmd.Parameters.AddWithValue("@Name", DBNull.Value);
			}
			cmd.Parameters.AddWithValue("@Size", shop.Size);
			cmd.Parameters.AddWithValue("@ShopId", shop.Id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetShops();
		}

		// delete
		public void DeleteShop(int id) {
			string deleteStatement = "DELETE FROM Shops WHERE Id = @ShopId";
			using SqlConnection connection = new(this.ConnectionString);
			using SqlCommand cmd = new(deleteStatement, connection);
			cmd.Parameters.AddWithValue("@ShopId", id);

			connection.Open();
			cmd.ExecuteNonQuery();
			this.GetShops();
		}
	}
}
