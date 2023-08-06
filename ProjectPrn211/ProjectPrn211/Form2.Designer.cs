namespace ProjectPrn211
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btCooker = new Button();
            btOrder = new Button();
            SuspendLayout();
            // 
            // btCooker
            // 
            btCooker.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btCooker.Location = new Point(187, 166);
            btCooker.Name = "btCooker";
            btCooker.Size = new Size(160, 115);
            btCooker.TabIndex = 0;
            btCooker.Text = "Cooker";
            btCooker.UseVisualStyleBackColor = true;
            btCooker.Click += btCooker_Click;
            // 
            // btOrder
            // 
            btOrder.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btOrder.Location = new Point(417, 166);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(160, 115);
            btOrder.TabIndex = 1;
            btOrder.Text = "Order";
            btOrder.UseVisualStyleBackColor = true;
            btOrder.Click += btOrder_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btOrder);
            Controls.Add(btCooker);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btCooker;
        private Button btOrder;
    }
}