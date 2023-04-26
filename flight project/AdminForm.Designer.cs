namespace flight_project
{
    partial class AdminForm
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
            this.addflightbtn = new System.Windows.Forms.Button();
            this.editflightinfo = new System.Windows.Forms.Button();
            this.deletefightbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addflightbtn
            // 
            this.addflightbtn.Location = new System.Drawing.Point(35, 50);
            this.addflightbtn.Name = "addflightbtn";
            this.addflightbtn.Size = new System.Drawing.Size(200, 100);
            this.addflightbtn.TabIndex = 0;
            this.addflightbtn.Text = "Add Flight";
            this.addflightbtn.UseVisualStyleBackColor = true;
            this.addflightbtn.Click += new System.EventHandler(this.addflightbtn_Click);
            // 
            // editflightinfo
            // 
            this.editflightinfo.Location = new System.Drawing.Point(35, 180);
            this.editflightinfo.Name = "editflightinfo";
            this.editflightinfo.Size = new System.Drawing.Size(200, 100);
            this.editflightinfo.TabIndex = 1;
            this.editflightinfo.Text = "Edit Flight";
            this.editflightinfo.UseVisualStyleBackColor = true;
            // 
            // deletefightbtn
            // 
            this.deletefightbtn.Location = new System.Drawing.Point(35, 310);
            this.deletefightbtn.Name = "deletefightbtn";
            this.deletefightbtn.Size = new System.Drawing.Size(200, 100);
            this.deletefightbtn.TabIndex = 2;
            this.deletefightbtn.Text = "Delete Flight";
            this.deletefightbtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletefightbtn);
            this.Controls.Add(this.editflightinfo);
            this.Controls.Add(this.addflightbtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addflightbtn;
        private System.Windows.Forms.Button editflightinfo;
        private System.Windows.Forms.Button deletefightbtn;
    }
}