
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
            this.SuspendLayout();
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(158, 149);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.clientNameTextBox.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Card info";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(89, 352);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(147, 34);
            this.updateBtn.TabIndex = 39;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "client Name";
            // 
            // cardcount
            // 
            this.cardcount.AutoSize = true;
            this.cardcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardcount.Location = new System.Drawing.Point(32, 101);
            this.cardcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardcount.Name = "cardcount";
            this.cardcount.Size = new System.Drawing.Size(118, 17);
            this.cardcount.TabIndex = 46;
            this.cardcount.Text = "number of card";
            this.cardcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // deletecard
            // 
            this.deletecard.Location = new System.Drawing.Point(542, 353);
            this.deletecard.Margin = new System.Windows.Forms.Padding(2);
            this.deletecard.Name = "deletecard";
            this.deletecard.Size = new System.Drawing.Size(157, 33);
            this.deletecard.TabIndex = 47;
            this.deletecard.Text = "delete";
            this.deletecard.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(161, 197);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(212, 20);
            this.date.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "expiry date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(161, 99);
            this.cardNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(212, 20);
            this.cardNumTextBox.TabIndex = 51;
            // 
            // updatecardinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 440);
            this.Controls.Add(this.cardNumTextBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletecard);
            this.Controls.Add(this.cardcount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}