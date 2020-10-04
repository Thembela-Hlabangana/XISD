namespace TABA_FMIS
{
    partial class Client_List
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
            this.lblSelectClient = new System.Windows.Forms.Label();
            this.btnViewClient = new System.Windows.Forms.Button();
            this.cbxClientList = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectClient
            // 
            this.lblSelectClient.AutoSize = true;
            this.lblSelectClient.Location = new System.Drawing.Point(153, 72);
            this.lblSelectClient.Name = "lblSelectClient";
            this.lblSelectClient.Size = new System.Drawing.Size(90, 17);
            this.lblSelectClient.TabIndex = 0;
            this.lblSelectClient.Text = "Select Client:";
            // 
            // btnViewClient
            // 
            this.btnViewClient.Location = new System.Drawing.Point(208, 405);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(111, 37);
            this.btnViewClient.TabIndex = 5;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // cbxClientList
            // 
            this.cbxClientList.FormattingEnabled = true;
            this.cbxClientList.Items.AddRange(new object[] {
            "Trip1 (CUS001)",
            "Trip2 (CUS003)",
            "Trip3 (CUS005)",
            "Trip4  (CUS012)",
            "Trip5 (CUS110)"});
            this.cbxClientList.Location = new System.Drawing.Point(94, 102);
            this.cbxClientList.Name = "cbxClientList";
            this.cbxClientList.Size = new System.Drawing.Size(240, 106);
            this.cbxClientList.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(79, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Client_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 478);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbxClientList);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.lblSelectClient);
            this.Name = "Client_List";
            this.Text = "Client_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.Button btnViewClient;
        private System.Windows.Forms.CheckedListBox cbxClientList;
        private System.Windows.Forms.Button btnBack;
    }
}