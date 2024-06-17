using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class InventoryForm : Form
    {
        IMongoCollection<MedicalInventory> inventoryCollection;

        public InventoryForm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            inventoryCollection = database.GetCollection<MedicalInventory>("Inventory");
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            try
            {
                var filterDefinition = Builders<MedicalInventory>.Filter.Empty;
                var inventoryItems = inventoryCollection.Find(filterDefinition).ToList();

                if (inventoryItems.Count == 0)
                {
                    MessageBox.Show("No items found in the inventory.");
                }
                else
                {
                    // Check for low stock items and alert if necessary
                    foreach (var item in inventoryItems)
                    {
                        if (item.Quantity <= item.Threshold)
                        {
                            MessageBox.Show($"Warning: {item.ItemName} stock is below the threshold level!");
                        }
                    }

                    dataGridView_Inventory.DataSource = inventoryItems.Select(i => new {
                        Id = i._id.ToString(),
                        i.ItemId,
                        i.ItemName,
                        i.Quantity,
                        i.Threshold
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory data: {ex.Message}");
            }
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            // Get info from user
            string itemName = txtItemName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int threshold = int.Parse(txtThreshold.Text);

            // Check if the item already exists
            if (!string.IsNullOrEmpty(itemName) && quantity > 0 && threshold >= 0)
            {
                var filter = Builders<MedicalInventory>.Filter.Eq("ItemName", itemName);
                var existingItem = inventoryCollection.Find(filter).FirstOrDefault();

                if (existingItem == null)
                {
                    // Create an instance of MedicalInventory
                    var newItem = new MedicalInventory
                    {
                        ItemId = new Random().Next(1, 1000), // Generate a random ItemId for demonstration
                        ItemName = itemName,
                        Quantity = quantity,
                        Threshold = threshold
                    };

                    // Add it to the database
                    inventoryCollection.InsertOne(newItem);
                    MessageBox.Show("Item added successfully!");
                    LoadInventoryData();
                }
                else
                {
                    MessageBox.Show("Item already exists, please update the item instead.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid item details.");
            }
        }

        private void button_UpdateItem_Click(object sender, EventArgs e)
        {
            // Get info from user
            string itemId = txtId.Text;
            string itemName = txtItemName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int threshold = int.Parse(txtThreshold.Text);

            // Check if the item exists and update it
            if (!string.IsNullOrEmpty(itemId) && !string.IsNullOrEmpty(itemName) && quantity > 0 && threshold >= 0)
            {
                var filter = Builders<MedicalInventory>.Filter.Eq("_id", ObjectId.Parse(itemId));
                var update = Builders<MedicalInventory>.Update
                    .Set("ItemName", itemName)
                    .Set("Quantity", quantity)
                    .Set("Threshold", threshold);

                var result = inventoryCollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Item updated successfully!");
                    LoadInventoryData();
                }
                else
                {
                    MessageBox.Show("Item not found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid item details.");
            }
        }

        private void button_DeleteItem_Click(object sender, EventArgs e)
        {
            // Get info from user
            string itemId = txtId.Text;

            // Check if the item exists and delete it
            if (!string.IsNullOrEmpty(itemId))
            {
                var filter = Builders<MedicalInventory>.Filter.Eq("_id", ObjectId.Parse(itemId));
                var result = inventoryCollection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Item deleted successfully!");
                    LoadInventoryData();
                }
                else
                {
                    MessageBox.Show("Item not found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid item ID.");
            }
        }

        private void button_BackToMain_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            Hospital_Management_System MainForm = new Hospital_Management_System();
            MainForm.Show();
            this.Hide();
        }
    }

    public class MedicalInventory
    {
        public ObjectId _id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Threshold { get; set; }
    }
}
