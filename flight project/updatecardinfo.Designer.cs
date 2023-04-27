
namespace flight_project
{
    partial class updatecardinfo
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
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cardcount = new System.Windows.Forms.Label();
            this.deletecard = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(211, 183);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(281, 22);
            this.clientNameTextBox.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Card info";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(119, 433);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(196, 42);
            this.updateBtn.TabIndex = 39;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "client Name";
            // 
            // cardcount
            // 
            this.cardcount.AutoSize = true;
            this.cardcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardcount.Location = new System.Drawing.Point(43, 124);
            this.cardcount.Name = "cardcount";
            this.cardcount.Size = new System.Drawing.Size(136, 20);
            this.cardcount.TabIndex = 46;
            this.cardcount.Text = "number of card";
            this.cardcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // deletecard
            // 
            this.deletecard.Location = new System.Drawing.Point(723, 434);
            this.deletecard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletecard.Name = "deletecard";
            this.deletecard.Size = new System.Drawing.Size(209, 41);
            this.deletecard.TabIndex = 47;
            this.deletecard.Text = "delete";
            this.deletecard.UseVisualStyleBackColor = true;
            this.deletecard.Click += new System.EventHandler(this.deletecard_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(215, 242);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(281, 22);
            this.date.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "expiry date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(215, 122);
            this.cardNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(281, 22);
            this.cardNumTextBox.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::flight_project.Properties.Resources.output_onlinepngtools;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatecardinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardNumTextBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletecard);
            this.Controls.Add(this.cardcount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updatecardinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updatecardinfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.updatecardinfo_FormClosed);
            this.Load += new System.EventHandler(this.updatecardinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cardcount;
        private System.Windows.Forms.Button deletecard;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardNumTextBox;
        private System.Windows.Forms.Button button1;
    }
}