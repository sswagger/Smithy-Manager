using SmithyManager.Data;
using SmithyManager.Models;
using System.Globalization;

namespace SmithyManager.UI {
	public partial class FrmHome : Form {
		//=== Attributes ===\\
		private readonly MinesDB mineDB = new();
		private readonly ShopsDB shopDB = new();
		private readonly MinersDB minerDB = new();
		private readonly CraftsmenDB craftsmanDB = new();
		private readonly MineralsDB mineralDB = new();
		private readonly GemsDB gemDB = new();
		private int profit = 0;
		private int money = 0;

		//=== Constructors ===\\
		public FrmHome() {
			InitializeComponent();
		}

		//=== Event Handlers ===\\
		private void btnMines_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Mine", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		private void btnShops_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Shop", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		private void btnMiners_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Miner", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		private void btnCraftsmen_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Craftsman", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		private void btnMinerals_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Mineral", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		private void btnGems_Click(object sender, EventArgs e) {
			FrmDetails productsForm = new("Gem", this) {
				StartPosition = FormStartPosition.CenterParent
			};
			productsForm.ShowDialog();
		}
		// open summary window
		private void btnSummary_Click(object sender, EventArgs e) {
			FrmSummary summaryForm = new() {
				StartPosition = FormStartPosition.CenterParent
			};
			summaryForm.ShowDialog();
		}
		// Timers
		private void tmrCalc_Tick(object sender, EventArgs e) {
			Random rand = new Random();
			List<Mine> numMines = mineDB.GetMines();
			List<Shop> numShops = shopDB.GetShops();
			List<Craftsman> numCraftsmen = craftsmanDB.GetCraftsmen();
			List<Miner> numMiner = minerDB.GetMiners();

			// sell minerals
			foreach (Shop shop in numShops) {
				List<Mineral> shopMinerals = mineralDB.GetMinerals("SELECT * FROM Minerals WHERE ShopId = " + shop.Id);
				List<Gem> shopGems = gemDB.GetGems("SELECT * FROM Gems WHERE ShopId = " + shop.Id);

				// calculate customers for the day (day = 5 sec)
				int customers = shop.Size * numCraftsmen.Count * rand.Next(1, 3);
				for (int i = 0; i < customers && i < shopGems.Count; i++) {
					Gem randGem = shopGems[rand.Next(0, shopGems.Count)];
					this.profit += randGem.Cost * randGem.Amount;
					gemDB.DeleteGem(randGem.Id);
				}
				for (int i = 0; i < customers && i < shopMinerals.Count; i++) {
					Mineral randMineral = shopMinerals[rand.Next(0, shopMinerals.Count)];
					this.profit += 5 * randMineral.Amount;
					mineralDB.DeleteMineral(randMineral.Id);
				}
			}

			// mine new minerals
			foreach (Mine mine in numMines) {
				List<Miner> minersWork = minerDB.GetMiners("SELECT * FROM miners WHERE MineId = " + mine.Id);
				List<string> ids = shopDB.GetIds();

				try {
					foreach (Miner miner in minersWork) {
						// mine gems
						if (rand.Next(1, 6) == 1) {
							Array Types = Enum.GetValues(typeof(GemType));
							GemType randGem = (GemType)Types.GetValue(rand.Next(Types.Length));

							gemDB.CreateGem(new Gem() {
								Type = randGem,
								Amount = (int)(miner.Pay * (rand.NextDouble() + 1)),
								Cost = (int)(rand.Next(25, 76)),
								MinerId = miner.Id,
								ShopId = int.Parse(ids[rand.Next(ids.Count())])
							});
						}
						// mine minerals
						else {
							Array Types = Enum.GetValues(typeof(MineralType));
							MineralType randMineral = (MineralType)Types.GetValue(rand.Next(Types.Length));

							mineralDB.CreateMineral(new Mineral() {
								Type = randMineral,
								Amount = (int)(miner.Pay * (rand.NextDouble() + 1)),
								MinerId = miner.Id,
								ShopId = int.Parse(ids[rand.Next(ids.Count())])
							});
						}
					}
				}
				catch (ArgumentOutOfRangeException) {
					;
				}
			}

			// Pay workers
			foreach (Miner miner in numMiner) {
				this.profit -= miner.Pay;
			}
			foreach (Craftsman craftsman in numCraftsmen) {
				this.profit -= craftsman.Pay;
			}

			this.money += this.profit;

			// show money using negative sign instead of parentheses
			CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
			culture.NumberFormat.CurrencyNegativePattern = 1;
			this.textBox1.Text = String.Format(culture, "{0:C}", this.profit);
			this.textBox2.Text = String.Format(culture, "{0:C}", this.money); ;
			profit = 0;
		}
		private void tmrHazzard_Tick(object sender, EventArgs e) {
			Random rand = new();

			// user has a 1/3 chance every 8 seconds of getting a hazzard
			if (rand.Next(1, 4) == 1) {
				string hazzard = "";
				int randHazzard = rand.Next(1, 5);

				// pick a random hazzard
				try {
					if (randHazzard == 1) {
						hazzard = "A Theif Stole $10,000!";
						this.profit -= 10000;
					}
					else if (randHazzard == 2) {
						hazzard = "A Shop Burned Down!";
						shopDB.DeleteShop(int.Parse(shopDB.GetIds()[rand.Next(0, shopDB.GetIds().Count - 1)]));
					}
					else if (randHazzard == 3) {
						hazzard = "One Of Your Miners Was Caught In An Explosion!";
						minerDB.DeleteMiner(int.Parse(minerDB.GetIds()[rand.Next(0, minerDB.GetIds().Count - 1)]));
					}
					else {
						hazzard = "A Theif Stole Some Your Gems!";
						gemDB.DeleteGem(int.Parse(gemDB.GetIds()[rand.Next(0, gemDB.GetIds().Count - 1)]));
					}
					// show hazzard
					MessageBox.Show(hazzard, "Hazzard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				catch (ArgumentOutOfRangeException) {
					// if there is nothing to delete, then don't do anything
					;
				}
			}
		}

		//=== Methods ===\\
		// a public function called by Details Form for when user buys or sells something
		public void updateCost(int cost) {
			this.profit -= cost;
		}
	}
}
