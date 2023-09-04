namespace YearA_Final.UI.UserControls
{
    partial class AddDrinks
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
            this.labelExoDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelAddZero = new System.Windows.Forms.Label();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.checkBoxAddZero = new System.Windows.Forms.CheckBox();
            this.buttonAddDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExoDate
            // 
            this.labelExoDate.AutoSize = true;
            this.labelExoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExoDate.Location = new System.Drawing.Point(10, 80);
            this.labelExoDate.Name = "labelExoDate";
            this.labelExoDate.Size = new System.Drawing.Size(91, 16);
            this.labelExoDate.TabIndex = 2;
            this.labelExoDate.Text = "Expiry Date:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(10, 120);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 16);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(10, 160);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(67, 16);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalories.Location = new System.Drawing.Point(10, 200);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(69, 16);
            this.labelCalories.TabIndex = 5;
            this.labelCalories.Text = "Calories:";
            // 
            // labelAddZero
            // 
            this.labelAddZero.AutoSize = true;
            this.labelAddZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddZero.Location = new System.Drawing.Point(10, 240);
            this.labelAddZero.Name = "labelAddZero";
            this.labelAddZero.Size = new System.Drawing.Size(102, 16);
            this.labelAddZero.TabIndex = 6;
            this.labelAddZero.Text = "To Add Zero?";
            this.labelAddZero.Visible = false;
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(135, 80);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.ReadOnly = true;
            this.textBoxExpDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpDate.TabIndex = 7;
            this.textBoxExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(135, 120);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(135, 160);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(125, 200);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.ReadOnly = true;
            this.textBoxCalories.Size = new System.Drawing.Size(121, 20);
            this.textBoxCalories.TabIndex = 11;
            this.textBoxCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAddZero
            // 
            this.checkBoxAddZero.AutoSize = true;
            this.checkBoxAddZero.Location = new System.Drawing.Point(177, 240);
            this.checkBoxAddZero.Name = "checkBoxAddZero";
            this.checkBoxAddZero.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAddZero.TabIndex = 12;
            this.checkBoxAddZero.UseVisualStyleBackColor = true;
            this.checkBoxAddZero.Visible = false;
            this.checkBoxAddZero.CheckedChanged += new System.EventHandler(this.checkBoxAddZero_CheckedChanged);
            // 
            // buttonAddDrink
            // 
            this.buttonAddDrink.Location = new System.Drawing.Point(160, 265);
            this.buttonAddDrink.Name = "buttonAddDrink";
            this.buttonAddDrink.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDrink.TabIndex = 13;
            this.buttonAddDrink.Text = "Add";
            this.buttonAddDrink.UseVisualStyleBackColor = true;
            this.buttonAddDrink.Click += new System.EventHandler(this.buttonAddDrink_Click);
            // 
            // AddDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddDrink);
            this.Controls.Add(this.checkBoxAddZero);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.labelAddZero);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelExoDate);
            this.Name = "AddDrinks";
            this.Size = new System.Drawing.Size(250, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelExoDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelAddZero;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.CheckBox checkBoxAddZero;
        private System.Windows.Forms.Button buttonAddDrink;
    }
}
