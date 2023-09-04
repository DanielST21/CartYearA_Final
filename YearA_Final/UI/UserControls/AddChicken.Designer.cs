namespace YearA_Final.UI.UserControls
{
    partial class AddChicken
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxChickenType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonAddChicken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxChickenType
            // 
            this.comboBoxChickenType.FormattingEnabled = true;
            this.comboBoxChickenType.Location = new System.Drawing.Point(25, 30);
            this.comboBoxChickenType.Name = "comboBoxChickenType";
            this.comboBoxChickenType.Size = new System.Drawing.Size(190, 21);
            this.comboBoxChickenType.TabIndex = 0;
            this.comboBoxChickenType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChickenType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expiry Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calories:";
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(135, 95);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.ReadOnly = true;
            this.textBoxExpDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpDate.TabIndex = 4;
            this.textBoxExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(135, 140);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 5;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(125, 217);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.ReadOnly = true;
            this.textBoxCalories.Size = new System.Drawing.Size(121, 20);
            this.textBoxCalories.TabIndex = 8;
            this.textBoxCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(135, 180);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 9;
            // 
            // buttonAddChicken
            // 
            this.buttonAddChicken.Location = new System.Drawing.Point(160, 265);
            this.buttonAddChicken.Name = "buttonAddChicken";
            this.buttonAddChicken.Size = new System.Drawing.Size(75, 23);
            this.buttonAddChicken.TabIndex = 10;
            this.buttonAddChicken.Text = "Add";
            this.buttonAddChicken.UseVisualStyleBackColor = true;
            this.buttonAddChicken.Click += new System.EventHandler(this.buttonAddChicken_Click);
            // 
            // AddChicken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddChicken);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChickenType);
            this.Name = "AddChicken";
            this.Size = new System.Drawing.Size(250, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChickenType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonAddChicken;
    }
}
