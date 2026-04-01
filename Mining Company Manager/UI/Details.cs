using Microsoft.IdentityModel.Tokens;
using SmithyManager.Data;
using SmithyManager.Models;

namespace SmithyManager.UI {
	public partial class FrmDetails : Form {
		//=== Attributes ===\\
		private readonly MinesDB mineDB = new();
		private readonly ShopsDB shopDB = new();
		private readonly MinersDB minerDB = new();
		private readonly CraftsmenDB craftsmanDB = new();
		private readonly MineralsDB mineralDB = new();
		private readonly GemsDB gemDB = new();
		private string currButton = "";
		// this form can call the homeform using this var
		private FrmHome homeForm;

		//=== Constructors ===\\
		public FrmDetails(string button, FrmHome frmHome) {
			this.currButton = button;
			this.homeForm = frmHome;
			InitializeComponent();
		}

		//=== Event Handlers ===\\
		private void FrmDetials_Load(object sender, EventArgs e) {
			updateLsv();
		}
		private void btnMines_Click(object sender, EventArgs e) {
			currButton = "Mine";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void btnShops_Click(object sender, EventArgs e) {
			currButton = "Shop";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void btnMiners_Click(object sender, EventArgs e) {
			currButton = "Miner";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void btnCraftsmen_Click(object sender, EventArgs e) {
			currButton = "Craftsman";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void btnMinerals_Click(object sender, EventArgs e) {
			currButton = "Mineral";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void btnGems_Click(object sender, EventArgs e) {
			currButton = "Gem";
			this.chxFilter.Checked = false;
			updateLsv();
		}
		private void chxFilter_CheckedChanged(object sender, EventArgs e) {
			if (chxFilter.Checked) {
				FilterPerson filter = new();
				string sql = "";
				switch (this.currButton) {
					case "Miner":
						sql = filter.GetFilters(mineDB.GetIds(), "Miners", "Mine");
						break;
					case "Craftsman":
						sql = filter.GetFilters(shopDB.GetIds(), "Craftsmen", "Shop");
						break;
				}
				if (!sql.IsNullOrEmpty()) {
					updateLsv(sql);
				}
			}
			else {
				updateLsv();
			}
		}
		// CRUD buttons
		private void btnCreate_Click(object sender, EventArgs e) {
			// create mines, shops, miners, or craftsmen
			List<string> updatedVals = setupInputs();
			if (!updatedVals.IsNullOrEmpty()) {
				try {
					switch (this.currButton) {
						case "Mine":
							Mine newMine = new Mine() { Age = int.Parse(updatedVals[0]), Equip = int.Parse(updatedVals[1]) };
							this.homeForm.updateCost(int.Parse(updatedVals[1]));
							mineDB.CreateMine(newMine);
							break;
						case "Shop":
							Shop newShop = new Shop() { Size = int.Parse(updatedVals[0]), Name = updatedVals[1] };
							this.homeForm.updateCost(int.Parse(updatedVals[0]) * 10000);
							shopDB.CreateShop(newShop);
							break;
						case "Miner":
							Miner newMiner = new Miner() { Name = updatedVals[0], Pay = int.Parse(updatedVals[1]), Age = int.Parse(updatedVals[2]), MineId = int.Parse(updatedVals[3]) };
							minerDB.CreateMiner(newMiner);
							break;
						case "Craftsman":
							Craftsman newCraftsman = new Craftsman() { Name = updatedVals[0], Pay = int.Parse(updatedVals[1]), Age = int.Parse(updatedVals[2]), ShopId = int.Parse(updatedVals[3]) };
							craftsmanDB.CreateCraftsman(newCraftsman);
							break;
					}
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "Unable to Crate", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			updateLsv();
		}
		private void btnUpdate_Click(object sender, EventArgs e) {
			try {
				// get the selected Object
				String? selectedObj = lsvDetails.SelectedItems[0].Text;
				int selectedObjId = int.Parse(selectedObj);
				try {
					List<string> updatedVals = setupInputs();
					switch (this.currButton) {
						// if user is dealing with mines
						case "Mine":
							Mine updatedMine = this.mineDB.GetMine(selectedObjId);

							this.homeForm.updateCost(int.Parse(updatedVals[1]) - updatedMine.Equip);

							// save input
							updatedMine.Age = int.Parse(updatedVals[0]);
							updatedMine.Equip = int.Parse(updatedVals[1]);
							this.mineDB.UpdateMine(updatedMine);
							break;
						// if user is dealing with Shops
						case "Shop":
							Shop updatedShop = this.shopDB.GetShop(selectedObjId);

							this.homeForm.updateCost((int.Parse(updatedVals[0]) - updatedShop.Size) * 10000);

							// save input
							updatedShop.Size = int.Parse(updatedVals[0]);
							updatedShop.Name = updatedVals[1];
							this.shopDB.UpdateShop(updatedShop);
							break;
						// if user is dealing with Miners
						case "Miner":
							// save input
							Miner updatedMiner = this.minerDB.GetMiner(selectedObjId);
							updatedMiner.Name = updatedVals[0];
							updatedMiner.Pay = int.Parse(updatedVals[1]);
							updatedMiner.Age = int.Parse(updatedVals[2]);
							updatedMiner.MineId = int.Parse(updatedVals[3]);
							this.minerDB.UpdateMiner(updatedMiner);
							break;
						// if user is dealing with Craftsmen
						case "Craftsman":
							// save input
							Craftsman updatedCraftsman = this.craftsmanDB.GetCraftsman(selectedObjId);
							updatedCraftsman.Name = updatedVals[0];
							updatedCraftsman.Pay = int.Parse(updatedVals[1]);
							updatedCraftsman.Age = int.Parse(updatedVals[2]);
							updatedCraftsman.ShopId = int.Parse(updatedVals[3]);
							this.craftsmanDB.UpdateCraftsman(updatedCraftsman);
							break;
					}
				}
				catch (ArgumentOutOfRangeException) {
					;
				}
				catch (Exception ex) {
					if (ex.InnerException != null) {
						MessageBox.Show(ex.InnerException.Message, "Unable to update " + this.currButton, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else {
						MessageBox.Show(ex.Message, "Unable to update " + this.currButton, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				updateLsv();
			}
			catch {
				MessageBox.Show("Please select an " + this.currButton + " to update.", "Select " + this.currButton, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnDelete_Click(object sender, EventArgs e) {
			// delete objects
			try {
				int? selectedObjId = int.Parse(lsvDetails.SelectedItems[0].Text);
				DialogResult responce = MessageBox.Show("Are you sure you want to delete this " + this.currButton + "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (responce == DialogResult.Yes) {
					try {
						switch (this.currButton) {
							case "Mine":
								// get some of the equipment back if user deletes mine
								this.homeForm.updateCost(mineDB.GetMine((int)selectedObjId).Equip / -2);

								this.mineDB.DeleteMine((int)selectedObjId);
								break;
							case "Shop":
								this.homeForm.updateCost(shopDB.GetShop((int)selectedObjId).Size * 1100);
								this.shopDB.DeleteShop((int)selectedObjId);
								break;
							case "Miner":
								this.minerDB.DeleteMiner((int)selectedObjId);
								break;
							case "Craftsman":
								this.craftsmanDB.DeleteCraftsman((int)selectedObjId);
								break;
						}
					}
					catch (Exception ex) {
						MessageBox.Show(ex.Message, "Unable to delete " + this.currButton, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					updateLsv();
				}
			}
			catch {
				MessageBox.Show("Please select an " + this.currButton + " to Delete.", "Select " + this.currButton, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		// go back to the home window
		private void label1_Click(object sender, EventArgs e) {
			this.Close();
		}

		//=== Methods ===\\
		private void updateLsv() {
			// setup form elements
			this.btnCreate.Enabled = true;
			this.btnUpdate.Enabled = true;
			this.btnDelete.Enabled = true;
			this.chxFilter.Enabled = false;
			this.chxFilter.Visible = false;
			int i = 0;
			this.lsvDetails.Items.Clear();
			this.lsvDetails.Columns.Clear();

			// setup DB objects
			List<Mine> mines = mineDB.GetMines();
			List<Shop> shops = shopDB.GetShops();
			List<Miner> miners = minerDB.GetMiners();
			List<Craftsman> craftsmen = craftsmanDB.GetCraftsmen();
			List<Gem> gems = gemDB.GetGems();
			List<Mineral> minerals = mineralDB.GetMinerals();

			switch (this.currButton) {
				case "Mine":
					// setup buttons appropiately
					this.btnCreate.Text = "Buy";
					this.btnUpdate.Text = "Equip";
					this.btnDelete.Text = "Sell";
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Age", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Equipment Cost", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Number of Miners", 200, HorizontalAlignment.Center);

					// get the mines
					var mineDetails =
						from mine in mines
						join miner in miners on mine.Id equals miner.MineId into minersInMine
						select new { mine.Id, mine.Age, mine.Equip, minerCount = minersInMine.Count() };

					// display the mines' details
					foreach (var mine in mineDetails) {
						if (mine != null) {
							ListViewItem newMine = new(mine.Id.ToString(), i);
							this.lsvDetails.Items.Add(newMine);
							this.lsvDetails.Items[i].SubItems.Add(mine.Age.ToString() + " Years");
							this.lsvDetails.Items[i].SubItems.Add(mine.Equip.ToString("C"));
							this.lsvDetails.Items[i].SubItems.Add(mine.minerCount.ToString());
						}
						i++;
					}
					break;
				case "Shop":
					// setup buttons appropriately
					this.btnCreate.Text = "Buy";
					this.btnUpdate.Text = "Edit";
					this.btnDelete.Text = "Sell";
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Size", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Name", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Number of Craftsmen", 200, HorizontalAlignment.Center);

					// get the shops
					var shopDetails =
						from shop in shops
						join craftsman in craftsmen on shop.Id equals craftsman.ShopId into workersInShop
						select new { shop.Id, shop.Size, shop.Name, workerCount = workersInShop.Count()};

					// display the shops' details
					foreach (var shop in shopDetails) {
						if (shop != null) {
							this.lsvDetails.Items.Add(shop.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(shop.Size.ToString());
							this.lsvDetails.Items[i].SubItems.Add(shop.Name);
							this.lsvDetails.Items[i].SubItems.Add(shop.workerCount.ToString());
						}
						i++;
					}
					break;
				case "Miner":
					// setup buttons and checkbox appropiately
					this.btnCreate.Text = "Hire";
					this.btnUpdate.Text = "Edit";
					this.btnDelete.Text = "Fire";
					this.chxFilter.Visible = true;
					this.chxFilter.Enabled = true;
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Name", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Pay", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Age", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Mine", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Minerals Currently Mined", 200, HorizontalAlignment.Center);

					// get the miners
					var minerDetails =
						from miner in miners
						join mineral in minerals on miner.Id equals mineral.MinerId into mineralsMined
						select new { miner.Id, miner.Name, miner.Pay, miner.Age, miner.MineId, numMinerals = mineralsMined.Count() };

					// display the miners' details
					foreach (var miner in minerDetails) {
						if (miner != null) {
							this.lsvDetails.Items.Add(miner.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(miner.Name);
							this.lsvDetails.Items[i].SubItems.Add(miner.Pay.ToString("C"));
							this.lsvDetails.Items[i].SubItems.Add(miner.Age.ToString());
							this.lsvDetails.Items[i].SubItems.Add(miner.MineId.ToString());
							this.lsvDetails.Items[i].SubItems.Add(miner.numMinerals.ToString());
						}
						i++;
					}
					break;
				case "Craftsman":
					// setup buttons and checkbox appropriately
					this.btnCreate.Text = "Hire";
					this.btnUpdate.Text = "Edit";
					this.btnDelete.Text = "Fire";
					this.chxFilter.Visible = true;
					this.chxFilter.Enabled = true;
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Name", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Pay", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Age", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Shop", 100, HorizontalAlignment.Center);

					// get the gems
					var craftsmanDetails =
						from craftsman in craftsmen
						select new { craftsman.Id, craftsman.Name, craftsman.Pay, craftsman.Age, craftsman.ShopId };

					// display the gems's details
					foreach (var craftsman in craftsmanDetails) {
						if (craftsman != null) {
							this.lsvDetails.Items.Add(craftsman.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Name);
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Pay.ToString("C"));
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Age.ToString());
							this.lsvDetails.Items[i].SubItems.Add(craftsman.ShopId.ToString());
						}
						i++;
					}
					break;
				case "Gem":
					// setup buttons appropriately
					this.btnCreate.Text = "";
					this.btnUpdate.Text = "";
					this.btnDelete.Text = "";
					this.btnCreate.Enabled = false;
					this.btnUpdate.Enabled = false;
					this.btnDelete.Enabled = false;
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Type", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Amount", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Cost", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Miner", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Shop", 100, HorizontalAlignment.Center);

					// get the gems
					var gemDetails =
						from gem in gems
						select new { gem.Id, gem.Type, gem.Amount, gem.Cost, gem.MinerId, gem.ShopId };

					// display the gems' details
					foreach (var gem in gemDetails) {
						if (gem != null) {
							this.lsvDetails.Items.Add(gem.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(gem.Type.ToString());
							this.lsvDetails.Items[i].SubItems.Add(gem.Amount.ToString());
							this.lsvDetails.Items[i].SubItems.Add(gem.Cost.ToString());
							this.lsvDetails.Items[i].SubItems.Add(gem.MinerId.ToString());
							this.lsvDetails.Items[i].SubItems.Add(gem.ShopId.ToString());
						}
						i++;
					}
					break;
				case "Mineral":
					// setup buttons appropriately
					this.btnCreate.Text = "";
					this.btnUpdate.Text = "";
					this.btnDelete.Text = "";
					this.btnCreate.Enabled = false;
					this.btnUpdate.Enabled = false;
					this.btnDelete.Enabled = false;
					// setup the listview appropriately
					this.lsvDetails.Items.Clear();
					this.lsvDetails.Columns.Clear();
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Type", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Amount", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Miner", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Shop", 100, HorizontalAlignment.Center);

					// get the gems
					var mineralDetails =
						from mineral in minerals
						select new { mineral.Id, mineral.Type, mineral.Amount, mineral.MinerId, mineral.ShopId };

					// display the gems' details
					foreach (var mineral in mineralDetails) {
						if (mineral != null) {
							this.lsvDetails.Items.Add(mineral.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(mineral.Type.ToString());
							this.lsvDetails.Items[i].SubItems.Add(mineral.Amount.ToString());
							this.lsvDetails.Items[i].SubItems.Add(mineral.MinerId.ToString());
							this.lsvDetails.Items[i].SubItems.Add(mineral.ShopId.ToString());
						}
						i++;
					}
					break;
				default:
					break;
			}
		}
		private void updateLsv(string filter) {
			this.btnCreate.Enabled = true;
			this.btnUpdate.Enabled = true;
			this.btnDelete.Enabled = true;
			this.chxFilter.Enabled = true;
			this.chxFilter.Visible = true;
			this.btnCreate.Text = "Hire";
			this.btnUpdate.Text = "Edit";
			this.btnDelete.Text = "Fire";

			int i = 0;
			this.lsvDetails.Items.Clear();
			this.lsvDetails.Columns.Clear();
			switch (this.currButton) {
				// miners
				case "Miner":
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Name", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Pay", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Age", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Mine", 100, HorizontalAlignment.Center);
					// filter the miners
					List<Miner> miners = minerDB.GetMiners(filter);

					// get the miners
					var minerDetails =
						from miner in miners
						select new { miner.Id, miner.Name, miner.Pay, miner.Age, miner.MineId };

					// display the miners' details
					foreach (var miner in minerDetails) {
						if (miner != null) {
							this.lsvDetails.Items.Add(miner.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(miner.Name);
							this.lsvDetails.Items[i].SubItems.Add(miner.Pay.ToString("C"));
							this.lsvDetails.Items[i].SubItems.Add(miner.Age.ToString());
							this.lsvDetails.Items[i].SubItems.Add(miner.MineId.ToString());
						}
						i++;
					}
					break;
				// craftsmen
				case "Craftsman":
					// setup the listview appropriately
					this.lsvDetails.Columns.Add("Id", 50, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Name", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Pay", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Age", 100, HorizontalAlignment.Center);
					this.lsvDetails.Columns.Add("Shop", 100, HorizontalAlignment.Center);
					// filter the craftsmen
					List<Craftsman> craftsmen = craftsmanDB.GetCraftsmen(filter);

					// get the gems
					var craftsmanDetails =
						from craftsman in craftsmen
						select new { craftsman.Id, craftsman.Name, craftsman.Pay, craftsman.Age, craftsman.ShopId };

					// display the gems's details
					foreach (var craftsman in craftsmanDetails) {
						if (craftsman != null) {
							this.lsvDetails.Items.Add(craftsman.Id.ToString());
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Name);
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Pay.ToString("C"));
							this.lsvDetails.Items[i].SubItems.Add(craftsman.Age.ToString());
							this.lsvDetails.Items[i].SubItems.Add(craftsman.ShopId.ToString());
						}
						i++;
					}
					break;
				default:
					break;
			}
		}
		private List<string> setupInputs() {
			// sets-up CU_2Input and CU_4Input to contain the correct text
			List<string> updateVals = new List<string>();

			switch (this.currButton) {
				// if user is dealing with Mines
				case "Mine":
					// get input
					CU_2Input updateMineForm = new();
					updateVals = updateMineForm.getVals(new List<string> { "Mine", "Age", "Equip" });
					// validate input
					if (!updateVals.IsNullOrEmpty()) {
						if (int.TryParse(updateVals[0], out _) && int.TryParse(updateVals[1], out _)) {
							return updateVals;
						}
						else {
							MessageBox.Show("Unable to parse Input to integer", "Unable to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					break;
				// if user is dealing with Shops
				case "Shop":
					// get input
					CU_2Input updateShopForm = new();
					updateVals = updateShopForm.getVals(new List<string> { "Shop", "Size", "Name" });
					// validate input
					if (!updateVals.IsNullOrEmpty()) {
						if (int.TryParse(updateVals[0], out _)) {
							return updateVals;
						}
						else {
							MessageBox.Show("Unable to parse Input to integer", "Unable to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}

					return updateVals;
				// if user is dealing with Miners
				case "Miner":
					// get input
					CU_4Input updateMinersForm = new();
					updateVals = updateMinersForm.getVals(new List<String> { "Miner", "Name", "Pay", "Age", "MineId" }, mineDB.GetIds());
					// validate input
					if (!updateVals.IsNullOrEmpty()) {
						if (int.TryParse(updateVals[1], out _) && int.TryParse(updateVals[2], out _) && int.TryParse(updateVals[3], out _)) {
							return updateVals;
						}
						else {
							MessageBox.Show("Unable to parse Input to integer", "Unable to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					break;
				// if user is dealing with Craftsmen
				case "Craftsman":
					// get input
					CU_4Input updateCraftsmenForm = new();
					updateVals = updateCraftsmenForm.getVals(new List<String> { "Craftsman", "Name", "Pay", "Age", "ShopId" }, shopDB.GetIds());
					// validate input
					if (!updateVals.IsNullOrEmpty()) {
						if (int.TryParse(updateVals[1], out _) && int.TryParse(updateVals[2], out _) && int.TryParse(updateVals[3], out _)) {
							return updateVals;
						}
						else {
							MessageBox.Show("Unable to parse Input to integer", "Unable to update", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					break;
			}
			return updateVals;
		}
	}
}
