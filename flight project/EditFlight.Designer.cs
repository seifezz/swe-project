
namespace flight_project
{
    partial class EditFlight
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_editflight = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_editflight
            // 
            this.txt_editflight.AutoSize = true;
            this.txt_editflight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editflight.Location = new System.Drawing.Point(53, 19);
            this.txt_editflight.Name = "txt_editflight";
            this.txt_editflight.Size = new System.Drawing.Size(139, 29);
            this.txt_editflight.TabIndex = 1;
            this.txt_editflight.Text = "Edit Flights";
            this.txt_editflight.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(609, 382);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(136, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply Changes";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_editflight);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditFlight";
            this.Text = "EditFlight";
            this.Load += new System.EventHandler(this.EditFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txt_editflight;
        private System.Windows.Forms.Button btn_apply;
    }
}