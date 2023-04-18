
namespace flight_project
{
    partial class signinform
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nav_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "sign in";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "password";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(232, 145);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(323, 22);
            this.txt_email.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(232, 235);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(323, 22);
            this.txt_pass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nav_signup
            // 
            this.nav_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_signup.Location = new System.Drawing.Point(660, 45);
            this.nav_signup.Name = "nav_signup";
            this.nav_signup.Size = new System.Drawing.Size(126, 39);
            this.nav_signup.TabIndex = 6;
            this.nav_signup.Text = "sign up";
            this.nav_signup.UseVisualStyleBackColor = true;
            this.nav_signup.Click += new System.EventHandler(this.nav_signup_Click);
            // 
            // signinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nav_signup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signinform";
            this.Text = "signinform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nav_signup;
    }
}

