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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addflightbtn
            // 
            this.addflightbtn.Location = new System.Drawing.Point(47, 62);
            this.addflightbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addflightbtn.Name = "addflightbtn";
            this.addflightbtn.Size = new System.Drawing.Size(267, 123);
            this.addflightbtn.TabIndex = 0;
            this.addflightbtn.Text = "Add Flight";
            this.addflightbtn.UseVisualStyleBackColor = true;
            this.addflightbtn.Click += new System.EventHandler(this.addflightbtn_Click);
            // 
            // editflightinfo
            // 
            this.editflightinfo.Location = new System.Drawing.Point(47, 218);
            this.editflightinfo.Margin = new System.Windows.Forms.Padding(4);
            this.editflightinfo.Name = "editflightinfo";
            this.editflightinfo.Size = new System.Drawing.Size(267, 123);
            this.editflightinfo.TabIndex = 1;
            this.editflightinfo.Text = "Edit/Delete Flight";
            this.editflightinfo.UseVisualStyleBackColor = true;
            this.editflightinfo.Click += new System.EventHandler(this.editflightinfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 123);
            this.button2.TabIndex = 3;
            this.button2.Text = "view flight info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editflightinfo);
            this.Controls.Add(this.addflightbtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addflightbtn;
        private System.Windows.Forms.Button editflightinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}