namespace SomerenUI
{
    partial class ActivityAdd
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
            btnSubmit = new System.Windows.Forms.Button();
            txtActivityidAdd = new System.Windows.Forms.TextBox();
            txtActivitynameAdd = new System.Windows.Forms.TextBox();
            dateTimeStartAdd = new System.Windows.Forms.DateTimePicker();
            dateTimeEndAdd = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(91, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Activity ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(91, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Activity Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(91, 186);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(91, 249);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "End Time";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(129, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(316, 49);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtActivityidAdd
            // 
            txtActivityidAdd.Location = new System.Drawing.Point(357, 47);
            txtActivityidAdd.Name = "txtActivityidAdd";
            txtActivityidAdd.Size = new System.Drawing.Size(150, 31);
            txtActivityidAdd.TabIndex = 7;
            // 
            // txtActivitynameAdd
            // 
            txtActivitynameAdd.Location = new System.Drawing.Point(357, 112);
            txtActivitynameAdd.Name = "txtActivitynameAdd";
            txtActivitynameAdd.Size = new System.Drawing.Size(150, 31);
            txtActivitynameAdd.TabIndex = 8;
            // 
            // dateTimeStartAdd
            // 
            dateTimeStartAdd.Location = new System.Drawing.Point(318, 180);
            dateTimeStartAdd.Name = "dateTimeStartAdd";
            dateTimeStartAdd.Size = new System.Drawing.Size(216, 31);
            dateTimeStartAdd.TabIndex = 9;
            // 
            // dateTimeEndAdd
            // 
            dateTimeEndAdd.Location = new System.Drawing.Point(318, 243);
            dateTimeEndAdd.Name = "dateTimeEndAdd";
            dateTimeEndAdd.Size = new System.Drawing.Size(216, 31);
            dateTimeEndAdd.TabIndex = 10;
            // 
            // ActivityAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(578, 402);
            Controls.Add(dateTimeEndAdd);
            Controls.Add(dateTimeStartAdd);
            Controls.Add(txtActivitynameAdd);
            Controls.Add(txtActivityidAdd);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActivityAdd";
            Text = "ActivityAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtActivityidAdd;
        private System.Windows.Forms.TextBox txtActivitynameAdd;
        private System.Windows.Forms.DateTimePicker dateTimeStartAdd;
        private System.Windows.Forms.DateTimePicker dateTimeEndAdd;
    }
}