namespace SomerenUI
{
    partial class DrinkUpdate
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
            this.textBox_VAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_DrinkType = new System.Windows.Forms.TextBox();
            this.textBox_DrinkName = new System.Windows.Forms.TextBox();
            this.textBox_DrinkID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_VAT
            // 
            this.textBox_VAT.Location = new System.Drawing.Point(324, 246);
            this.textBox_VAT.Name = "textBox_VAT";
            this.textBox_VAT.Size = new System.Drawing.Size(125, 27);
            this.textBox_VAT.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Drink ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(361, 29);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(324, 205);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(125, 27);
            this.textBox_Stock.TabIndex = 22;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(324, 166);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(125, 27);
            this.textBox_Price.TabIndex = 21;
            // 
            // textBox_DrinkType
            // 
            this.textBox_DrinkType.Location = new System.Drawing.Point(324, 129);
            this.textBox_DrinkType.Name = "textBox_DrinkType";
            this.textBox_DrinkType.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkType.TabIndex = 20;
            // 
            // textBox_DrinkName
            // 
            this.textBox_DrinkName.Location = new System.Drawing.Point(324, 89);
            this.textBox_DrinkName.Name = "textBox_DrinkName";
            this.textBox_DrinkName.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkName.TabIndex = 19;
            // 
            // textBox_DrinkID
            // 
            this.textBox_DrinkID.Location = new System.Drawing.Point(324, 51);
            this.textBox_DrinkID.Name = "textBox_DrinkID";
            this.textBox_DrinkID.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Drink Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Drink Name";
            // 
            // DrinkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 370);
            this.Controls.Add(this.textBox_VAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_DrinkType);
            this.Controls.Add(this.textBox_DrinkName);
            this.Controls.Add(this.textBox_DrinkID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DrinkUpdate";
            this.Text = "DrinkUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_VAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_DrinkType;
        private System.Windows.Forms.TextBox textBox_DrinkName;
        private System.Windows.Forms.TextBox textBox_DrinkID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}