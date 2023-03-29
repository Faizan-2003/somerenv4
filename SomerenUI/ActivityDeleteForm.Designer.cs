namespace SomerenUI
{
    partial class ActivityDeleteForm
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
            btnDelete = new System.Windows.Forms.Button();
            txtactivityIDdel = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(86, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Activity ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(103, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(257, 46);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtactivityIDdel
            // 
            txtactivityIDdel.Location = new System.Drawing.Point(293, 65);
            txtactivityIDdel.Name = "txtactivityIDdel";
            txtactivityIDdel.Size = new System.Drawing.Size(150, 31);
            txtactivityIDdel.TabIndex = 2;
            // 
            // ActivityDeleteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(528, 238);
            Controls.Add(txtactivityIDdel);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "ActivityDeleteForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtactivityIDdel;
    }
}