
namespace flight_project
{
    partial class SignupForm
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
            this.SignUp = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.nationalid = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_natid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btn_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(332, 9);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(139, 39);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "Sign Up";
            this.SignUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(12, 99);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 29);
            this.email.TabIndex = 1;
            this.email.Text = "Email Address";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate.Location = new System.Drawing.Point(12, 283);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(118, 29);
            this.birthdate.TabIndex = 2;
            this.birthdate.Text = "Birth Date";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(12, 237);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(176, 29);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone Number";
            // 
            // nationalid
            // 
            this.nationalid.AutoSize = true;
            this.nationalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalid.Location = new System.Drawing.Point(12, 191);
            this.nationalid.Name = "nationalid";
            this.nationalid.Size = new System.Drawing.Size(131, 29);
            this.nationalid.TabIndex = 4;
            this.nationalid.Text = "National ID";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 145);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 29);
            this.name.TabIndex = 5;
            this.name.Text = "Your Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 329);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 29);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(269, 103);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(365, 22);
            this.txt_email.TabIndex = 7;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(269, 241);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(365, 22);
            this.txt_phone.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(269, 333);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(365, 22);
            this.txt_password.TabIndex = 10;
            // 
            // txt_natid
            // 
            this.txt_natid.Location = new System.Drawing.Point(269, 195);
            this.txt_natid.Name = "txt_natid";
            this.txt_natid.Size = new System.Drawing.Size(365, 22);
            this.txt_natid.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(269, 149);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(365, 22);
            this.txt_name.TabIndex = 12;
            // 
            // date
            // 
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Location = new System.Drawing.Point(271, 288);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(363, 22);
            this.date.TabIndex = 13;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(613, 415);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(175, 23);
            this.btn_signup.TabIndex = 14;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_natid);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nationalid);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.email);
            this.Controls.Add(this.SignUp);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label nationalid;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_natid;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btn_signup;
    }
}