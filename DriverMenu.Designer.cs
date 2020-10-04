namespace TABA_FMIS
{
    partial class Driver_Menu
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
            this.btnNextTrip = new System.Windows.Forms.Button();
            this.btnEndDay = new System.Windows.Forms.Button();
            this.btnCurrentTrip = new System.Windows.Forms.Button();
            this.lblDriverMenu = new System.Windows.Forms.Label();
            this.gbDriverMenu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbDriverMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextTrip
            // 
            this.btnNextTrip.Location = new System.Drawing.Point(84, 197);
            this.btnNextTrip.Name = "btnNextTrip";
            this.btnNextTrip.Size = new System.Drawing.Size(103, 41);
            this.btnNextTrip.TabIndex = 0;
            this.btnNextTrip.Text = "Next Trip";
            this.btnNextTrip.UseVisualStyleBackColor = true;
            // 
            // btnEndDay
            // 
            this.btnEndDay.Location = new System.Drawing.Point(84, 280);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Size = new System.Drawing.Size(103, 39);
            this.btnEndDay.TabIndex = 1;
            this.btnEndDay.Text = "End Day";
            this.btnEndDay.UseVisualStyleBackColor = true;
            // 
            // btnCurrentTrip
            // 
            this.btnCurrentTrip.Location = new System.Drawing.Point(84, 118);
            this.btnCurrentTrip.Name = "btnCurrentTrip";
            this.btnCurrentTrip.Size = new System.Drawing.Size(103, 37);
            this.btnCurrentTrip.TabIndex = 2;
            this.btnCurrentTrip.Text = "Current Trip";
            this.btnCurrentTrip.UseVisualStyleBackColor = true;
            // 
            // lblDriverMenu
            // 
            this.lblDriverMenu.AutoSize = true;
            this.lblDriverMenu.Location = new System.Drawing.Point(333, 75);
            this.lblDriverMenu.Name = "lblDriverMenu";
            this.lblDriverMenu.Size = new System.Drawing.Size(85, 17);
            this.lblDriverMenu.TabIndex = 3;
            this.lblDriverMenu.Text = "Driver Menu";
            // 
            // gbDriverMenu
            // 
            this.gbDriverMenu.Controls.Add(this.dataGridView1);
            this.gbDriverMenu.Location = new System.Drawing.Point(247, 118);
            this.gbDriverMenu.Name = "gbDriverMenu";
            this.gbDriverMenu.Size = new System.Drawing.Size(431, 257);
            this.gbDriverMenu.TabIndex = 5;
            this.gbDriverMenu.TabStop = false;
            this.gbDriverMenu.Text = "Driver Menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 230);
            this.dataGridView1.TabIndex = 6;
            // 
            // Driver_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDriverMenu);
            this.Controls.Add(this.lblDriverMenu);
            this.Controls.Add(this.btnCurrentTrip);
            this.Controls.Add(this.btnEndDay);
            this.Controls.Add(this.btnNextTrip);
            this.Name = "Driver_Menu";
            this.Text = "Driver_Menu";
            this.gbDriverMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextTrip;
        private System.Windows.Forms.Button btnEndDay;
        private System.Windows.Forms.Button btnCurrentTrip;
        private System.Windows.Forms.Label lblDriverMenu;
        private System.Windows.Forms.GroupBox gbDriverMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}