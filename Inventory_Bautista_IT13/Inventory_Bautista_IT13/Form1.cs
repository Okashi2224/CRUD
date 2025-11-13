using DatabaseProject;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Bautista_IT13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInventory();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid numeric values for Quantity and Price.");
                return;
            }

            try
            {
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "INSERT INTO tbl_inventory_Bautista (ItemName, Description, Quantity, Price) VALUES (@name, @desc, @qty, @price)");
                cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);

                int rows = DbConnections.ExecuteQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show("Item added successfully!");
                    ClearFields();
                    LoadInventory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}");
            }
        }

        private void LoadInventory()
        {
            try
            {
                DataTable dt = DbConnections.ExecuteReader("SELECT * FROM tbl_inventory_Bautista");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Select an item to update.");
                return;
            }

            if (!int.TryParse(txtItemID.Text, out int itemId))
            {
                MessageBox.Show("Invalid Item ID.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid Quantity or Price.");
                return;
            }

            try
            {
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "UPDATE tbl_inventory_Bautista SET ItemName=@name, Description=@desc, Quantity=@qty, Price=@price WHERE ItemID=@id");

                // Convert ItemID to integer
                cmd.Parameters.AddWithValue("@id", itemId);
                cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);

                int rows = DbConnections.ExecuteQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show("Item updated successfully!");
                    ClearFields();
                    LoadInventory();
                }
                else
                {
                    MessageBox.Show("No item found with the specified ID. Please select an item from the grid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("Select an item to delete.");
                return;
            }

            try
            {
                Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("DELETE FROM tbl_inventory_Bautista WHERE ItemID=@id");
                cmd.Parameters.AddWithValue("@id", txtItemID.Text);

                int rows = DbConnections.ExecuteQuery(cmd);

                if (rows > 0)
                {
                    MessageBox.Show("Item deleted successfully!");
                    ClearFields();
                    LoadInventory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = $"SELECT * FROM tbl_inventory_Bautista WHERE ItemName LIKE '%{keyword}%' OR Description LIKE '%{keyword}%'";

            try
            {
                DataTable dt = DbConnections.ExecuteReader(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtSearch.Text = "";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtItemID.Text = row.Cells["ItemID"].Value.ToString();
                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}