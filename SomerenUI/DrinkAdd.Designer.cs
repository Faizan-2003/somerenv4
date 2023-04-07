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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox_DrinkID = new System.Windows.Forms.TextBox();
            textBox_DrinkName = new System.Windows.Forms.TextBox();
            textBox_DrinkType = new System.Windows.Forms.TextBox();
            textBox_Price = new System.Windows.Forms.TextBox();
            textBox_Stock = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            textBox_VAT = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Drink Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Drink Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 189);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 227);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "VAT";
            // 
            // textBox_DrinkID
            // 
            textBox_DrinkID.Location = new System.Drawing.Point(267, 32);
            textBox_DrinkID.Name = "textBox_DrinkID";
            textBox_DrinkID.Size = new System.Drawing.Size(125, 27);
            textBox_DrinkID.TabIndex = 5;
            // 
            // textBox_DrinkName
            // 
            textBox_DrinkName.Location = new System.Drawing.Point(267, 70);
            textBox_DrinkName.Name = "textBox_DrinkName";
            textBox_DrinkName.Size = new System.Drawing.Size(125, 27);
            textBox_DrinkName.TabIndex = 6;
            // 
            // textBox_DrinkType
            // 
            textBox_DrinkType.Location = new System.Drawing.Point(267, 110);
            textBox_DrinkType.Name = "textBox_DrinkType";
            textBox_DrinkType.Size = new System.Drawing.Size(125, 27);
            textBox_DrinkType.TabIndex = 7;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new System.Drawing.Point(267, 147);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new System.Drawing.Size(125, 27);
            textBox_Price.TabIndex = 8;
            // 
            // textBox_Stock
            // 
            textBox_Stock.Location = new System.Drawing.Point(267, 186);
            textBox_Stock.Name = "textBox_Stock";
            textBox_Stock.Size = new System.Drawing.Size(125, 27);
            textBox_Stock.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(31, 271);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(361, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 35);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 20);
            label6.TabIndex = 11;
            label6.Text = "Drink ID";
            // 
            // textBox_VAT
            // 
            textBox_VAT.Location = new System.Drawing.Point(267, 227);
            textBox_VAT.Name = "textBox_VAT";
            textBox_VAT.Size = new System.Drawing.Size(125, 27);
            textBox_VAT.TabIndex = 12;
            // 
            // DrinkAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 337);
            Controls.Add(textBox_VAT);
            Controls.Add(label6);
            Controls.Add(btnSubmit);
            Controls.Add(textBox_Stock);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_DrinkType);
            Controls.Add(textBox_DrinkName);
            Controls.Add(textBox_DrinkID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DrinkAdd";
            Text = "DrinkAdd";
            ResumeLayout(false);
            PerformLayout();
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