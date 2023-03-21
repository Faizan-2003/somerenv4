namespace SomerenUI
{
    partial class DrinkAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DrinkID = new System.Windows.Forms.TextBox();
            this.textBox_DrinkName = new System.Windows.Forms.TextBox();
            this.textBox_DrinkType = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_VAT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drink Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "VAT";
            // 
            // textBox_DrinkID
            // 
            this.textBox_DrinkID.Location = new System.Drawing.Point(267, 32);
            this.textBox_DrinkID.Name = "textBox_DrinkID";
            this.textBox_DrinkID.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkID.TabIndex = 5;
            // 
            // textBox_DrinkName
            // 
            this.textBox_DrinkName.Location = new System.Drawing.Point(267, 70);
            this.textBox_DrinkName.Name = "textBox_DrinkName";
            this.textBox_DrinkName.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkName.TabIndex = 6;
            // 
            // textBox_DrinkType
            // 
            this.textBox_DrinkType.Location = new System.Drawing.Point(267, 110);
            this.textBox_DrinkType.Name = "textBox_DrinkType";
            this.textBox_DrinkType.Size = new System.Drawing.Size(125, 27);
            this.textBox_DrinkType.TabIndex = 7;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(267, 147);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(125, 27);
            this.textBox_Price.TabIndex = 8;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(267, 186);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(125, 27);
            this.textBox_Stock.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(31, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(361, 29);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drink ID";
            // 
            // textBox_VAT
            // 
            this.textBox_VAT.Location = new System.Drawing.Point(267, 227);
            this.textBox_VAT.Name = "textBox_VAT";
            this.textBox_VAT.Size = new System.Drawing.Size(125, 27);
            this.textBox_VAT.TabIndex = 12;
            // 
            // DrinkAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 337);
            this.Controls.Add(this.textBox_VAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSubmit);
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
            this.Name = "DrinkAdd";
            this.Text = "DrinkAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DrinkID;
        private System.Windows.Forms.TextBox textBox_DrinkName;
        private System.Windows.Forms.TextBox textBox_DrinkType;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_VAT;
    }
}