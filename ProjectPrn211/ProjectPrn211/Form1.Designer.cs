namespace ProjectPrn211
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbRice = new GroupBox();
            nudFish = new NumericUpDown();
            nudChicken = new NumericUpDown();
            nudFriedRice = new NumericUpDown();
            cbFish = new CheckBox();
            cbChicken = new CheckBox();
            cbFriedRice = new CheckBox();
            dbDrink = new GroupBox();
            nudCola = new NumericUpDown();
            nudBeer = new NumericUpDown();
            nudCoffee = new NumericUpDown();
            cbCola = new CheckBox();
            cbBeer = new CheckBox();
            cbCoffee = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            btAdd = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbTotal = new TextBox();
            lbTotal = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            BtOrder = new Button();
            tbNameTable = new TextBox();
            label2 = new Label();
            gbRice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFriedRice).BeginInit();
            dbDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBeer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCoffee).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbRice
            // 
            gbRice.Controls.Add(nudFish);
            gbRice.Controls.Add(nudChicken);
            gbRice.Controls.Add(nudFriedRice);
            gbRice.Controls.Add(cbFish);
            gbRice.Controls.Add(cbChicken);
            gbRice.Controls.Add(cbFriedRice);
            gbRice.Location = new Point(12, 110);
            gbRice.Name = "gbRice";
            gbRice.Size = new Size(293, 204);
            gbRice.TabIndex = 0;
            gbRice.TabStop = false;
            gbRice.Text = "Rice";
            gbRice.Enter += groupBox1_Enter;
            // 
            // nudFish
            // 
            nudFish.Location = new Point(123, 140);
            nudFish.Name = "nudFish";
            nudFish.Size = new Size(150, 27);
            nudFish.TabIndex = 5;
            // 
            // nudChicken
            // 
            nudChicken.Location = new Point(123, 79);
            nudChicken.Name = "nudChicken";
            nudChicken.Size = new Size(150, 27);
            nudChicken.TabIndex = 4;
            // 
            // nudFriedRice
            // 
            nudFriedRice.Location = new Point(123, 25);
            nudFriedRice.Name = "nudFriedRice";
            nudFriedRice.Size = new Size(150, 27);
            nudFriedRice.TabIndex = 3;
            // 
            // cbFish
            // 
            cbFish.AutoSize = true;
            cbFish.Location = new Point(21, 143);
            cbFish.Name = "cbFish";
            cbFish.Size = new Size(56, 24);
            cbFish.TabIndex = 2;
            cbFish.Text = "Fish";
            cbFish.UseVisualStyleBackColor = true;
            // 
            // cbChicken
            // 
            cbChicken.AutoSize = true;
            cbChicken.Location = new Point(21, 82);
            cbChicken.Name = "cbChicken";
            cbChicken.RightToLeft = RightToLeft.No;
            cbChicken.Size = new Size(82, 24);
            cbChicken.TabIndex = 1;
            cbChicken.Text = "Chicken";
            cbChicken.UseVisualStyleBackColor = true;
            // 
            // cbFriedRice
            // 
            cbFriedRice.AutoSize = true;
            cbFriedRice.Location = new Point(21, 26);
            cbFriedRice.Name = "cbFriedRice";
            cbFriedRice.Size = new Size(96, 24);
            cbFriedRice.TabIndex = 0;
            cbFriedRice.Text = "Fried Rice";
            cbFriedRice.UseVisualStyleBackColor = true;
            // 
            // dbDrink
            // 
            dbDrink.Controls.Add(nudCola);
            dbDrink.Controls.Add(nudBeer);
            dbDrink.Controls.Add(nudCoffee);
            dbDrink.Controls.Add(cbCola);
            dbDrink.Controls.Add(cbBeer);
            dbDrink.Controls.Add(cbCoffee);
            dbDrink.Location = new Point(322, 110);
            dbDrink.Name = "dbDrink";
            dbDrink.Size = new Size(266, 204);
            dbDrink.TabIndex = 1;
            dbDrink.TabStop = false;
            dbDrink.Text = "Drink";
            // 
            // nudCola
            // 
            nudCola.Location = new Point(102, 142);
            nudCola.Name = "nudCola";
            nudCola.Size = new Size(150, 27);
            nudCola.TabIndex = 5;
            nudCola.ValueChanged += nudCola_ValueChanged;
            // 
            // nudBeer
            // 
            nudBeer.Location = new Point(102, 82);
            nudBeer.Name = "nudBeer";
            nudBeer.Size = new Size(150, 27);
            nudBeer.TabIndex = 4;
            // 
            // nudCoffee
            // 
            nudCoffee.Location = new Point(102, 27);
            nudCoffee.Name = "nudCoffee";
            nudCoffee.Size = new Size(150, 27);
            nudCoffee.TabIndex = 3;
            // 
            // cbCola
            // 
            cbCola.AutoSize = true;
            cbCola.Location = new Point(21, 143);
            cbCola.Name = "cbCola";
            cbCola.Size = new Size(61, 24);
            cbCola.TabIndex = 2;
            cbCola.Text = "Cola";
            cbCola.UseVisualStyleBackColor = true;
            // 
            // cbBeer
            // 
            cbBeer.AutoSize = true;
            cbBeer.Location = new Point(21, 80);
            cbBeer.Name = "cbBeer";
            cbBeer.Size = new Size(61, 24);
            cbBeer.TabIndex = 1;
            cbBeer.Text = "Beer";
            cbBeer.UseVisualStyleBackColor = true;
            // 
            // cbCoffee
            // 
            cbCoffee.AutoSize = true;
            cbCoffee.Location = new Point(21, 28);
            cbCoffee.Name = "cbCoffee";
            cbCoffee.Size = new Size(75, 24);
            cbCoffee.TabIndex = 0;
            cbCoffee.Text = "Coffee";
            cbCoffee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 93);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 8);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 2);
            label1.Size = new Size(481, 67);
            label1.TabIndex = 3;
            label1.Text = "Order food and drinks";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(596, 340);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 3;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Number";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbTotal.Location = new Point(572, 464);
            tbTotal.Multiline = true;
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(152, 51);
            tbTotal.TabIndex = 5;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Red;
            lbTotal.Location = new Point(618, 436);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(54, 25);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Total";
            lbTotal.Click += lbTotal_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // BtOrder
            // 
            BtOrder.Location = new Point(596, 395);
            BtOrder.Name = "BtOrder";
            BtOrder.Size = new Size(94, 29);
            BtOrder.TabIndex = 7;
            BtOrder.Text = "Order";
            BtOrder.UseVisualStyleBackColor = true;
            BtOrder.Click += BtOrder_Click;
            // 
            // tbNameTable
            // 
            tbNameTable.Location = new Point(596, 138);
            tbNameTable.Name = "tbNameTable";
            tbNameTable.Size = new Size(125, 27);
            tbNameTable.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 110);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 9;
            label2.Text = "Name Table";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 527);
            Controls.Add(label2);
            Controls.Add(tbNameTable);
            Controls.Add(BtOrder);
            Controls.Add(lbTotal);
            Controls.Add(tbTotal);
            Controls.Add(dataGridView1);
            Controls.Add(btAdd);
            Controls.Add(panel1);
            Controls.Add(dbDrink);
            Controls.Add(gbRice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbRice.ResumeLayout(false);
            gbRice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFish).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFriedRice).EndInit();
            dbDrink.ResumeLayout(false);
            dbDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBeer).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCoffee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbRice;
        private CheckBox cbChicken;
        private CheckBox cbFriedRice;
        private NumericUpDown nudFish;
        private NumericUpDown nudChicken;
        private NumericUpDown nudFriedRice;
        private CheckBox cbFish;
        private GroupBox dbDrink;
        private NumericUpDown nudCola;
        private NumericUpDown nudBeer;
        private NumericUpDown nudCoffee;
        private CheckBox cbCola;
        private CheckBox cbBeer;
        private CheckBox cbCoffee;
        private Panel panel1;
        private Label label1;
        private Button btAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbTotal;
        private Label lbTotal;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button BtOrder;
        private TextBox tbNameTable;
        private Label label2;
    }
}