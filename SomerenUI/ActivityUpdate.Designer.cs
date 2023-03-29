namespace SomerenUI
{
    partial class ActivityUpdate
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
            btnUpdate = new System.Windows.Forms.Button();
            txtActivitynameUpd = new System.Windows.Forms.TextBox();
            txtActivityidUpd = new System.Windows.Forms.TextBox();
            dateTimeStartUpd = new System.Windows.Forms.DateTimePicker();
            dateTimeEndUpd = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(83, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Activity ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(83, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Activity Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(83, 205);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(83, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "End Time";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(107, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(313, 52);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtActivitynameUpd
            // 
            txtActivitynameUpd.Location = new System.Drawing.Point(331, 121);
            txtActivitynameUpd.Name = "txtActivitynameUpd";
            txtActivitynameUpd.Size = new System.Drawing.Size(150, 31);
            txtActivitynameUpd.TabIndex = 5;
            // 
            // txtActivityidUpd
            // 
            txtActivityidUpd.Location = new System.Drawing.Point(331, 40);
            txtActivityidUpd.Name = "txtActivityidUpd";
            txtActivityidUpd.Size = new System.Drawing.Size(150, 31);
            txtActivityidUpd.TabIndex = 6;
            // 
            // dateTimeStartUpd
            // 
            dateTimeStartUpd.Location = new System.Drawing.Point(301, 205);
            dateTimeStartUpd.Name = "dateTimeStartUpd";
            dateTimeStartUpd.Size = new System.Drawing.Size(218, 31);
            dateTimeStartUpd.TabIndex = 7;
            // 
            // dateTimeEndUpd
            // 
            dateTimeEndUpd.Location = new System.Drawing.Point(301, 274);
            dateTimeEndUpd.Name = "dateTimeEndUpd";
            dateTimeEndUpd.Size = new System.Drawing.Size(218, 31);
            dateTimeEndUpd.TabIndex = 8;
            // 
            // ActivityUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(582, 431);
            Controls.Add(dateTimeEndUpd);
            Controls.Add(dateTimeStartUpd);
            Controls.Add(txtActivityidUpd);
            Controls.Add(txtActivitynameUpd);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActivityUpdate";
            Text = "ActivityUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtActivitynameUpd;
        private System.Windows.Forms.TextBox txtActivityidUpd;
        private System.Windows.Forms.DateTimePicker dateTimeStartUpd;
        private System.Windows.Forms.DateTimePicker dateTimeEndUpd;
    }
}