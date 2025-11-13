namespace Inventory_Bautista_IT13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtItemName = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            I = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            txtItemID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(230, 84, 99);
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 231, 200);
            label1.Location = new Point(29, 119);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Item ID:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(230, 84, 99);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 231, 200);
            label2.Location = new Point(29, 149);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Item Name:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(230, 84, 99);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(29, 179);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(230, 84, 99);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(252, 231, 200);
            label4.Location = new Point(29, 209);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(230, 84, 99);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(252, 231, 200);
            label5.Location = new Point(29, 239);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(119, 149);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 6;
            txtItemName.TextChanged += txtItemName_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(119, 179);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 209);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(119, 239);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(389, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.Location = new Point(255, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnUpdate.Location = new Point(255, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(255, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Cursor = Cursors.No;
            btnClear.ForeColor = SystemColors.WindowText;
            btnClear.Location = new Point(255, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 192, 255);
            btnSearch.Location = new Point(599, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.Location = new Point(389, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 200);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 84, 99);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 57);
            panel1.TabIndex = 17;
            // 
            // I
            // 
            I.AutoSize = true;
            I.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            I.ForeColor = Color.FromArgb(252, 231, 200);
            I.Location = new Point(70, 11);
            I.Name = "I";
            I.Size = new Size(219, 32);
            I.TabIndex = 0;
            I.Text = "Inventory System";
            I.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 84, 99);
            panel2.Controls.Add(I);
            panel2.Location = new Point(19, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 225);
            panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(359, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 57);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(119, 119);
            txtItemID.Name = "txtItemID";
            txtItemID.ReadOnly = true;
            txtItemID.Size = new Size(100, 23);
            txtItemID.TabIndex = 5;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(252, 231, 200);
            ClientSize = new Size(941, 306);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtItemID);
            Controls.Add(txtItemName);
            Controls.Add(txtDescription);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Inventory Transaction System - Bautista";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtItemName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label I;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtItemID;
    }
}