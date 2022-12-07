namespace chapitre1.Projet
{
    partial class EmployeeForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInportInformation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientUserName = new System.Windows.Forms.TextBox();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.btnClearInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 202);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 24);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnInportInformation
            // 
            this.btnInportInformation.Location = new System.Drawing.Point(323, 156);
            this.btnInportInformation.Name = "btnInportInformation";
            this.btnInportInformation.Size = new System.Drawing.Size(143, 37);
            this.btnInportInformation.TabIndex = 0;
            this.btnInportInformation.Text = "Inport Information";
            this.btnInportInformation.UseVisualStyleBackColor = true;
            this.btnInportInformation.Click += new System.EventHandler(this.btnInportInformation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client LastName";
            // 
            // txtClientUserName
            // 
            this.txtClientUserName.Location = new System.Drawing.Point(119, 41);
            this.txtClientUserName.Name = "txtClientUserName";
            this.txtClientUserName.Size = new System.Drawing.Size(87, 20);
            this.txtClientUserName.TabIndex = 2;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(4, 73);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.Size = new System.Drawing.Size(461, 81);
            this.dataGridInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Username";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(361, 41);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(105, 20);
            this.txtClientLastName.TabIndex = 4;
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.Location = new System.Drawing.Point(174, 156);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(143, 37);
            this.btnClearInfo.TabIndex = 5;
            this.btnClearInfo.Text = "Clear Information";
            this.btnClearInfo.UseVisualStyleBackColor = true;
            this.btnClearInfo.Click += new System.EventHandler(this.btnClearInfo_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chapitre1.Properties.Resources.https_specials_images_forbesimg_com_imageserve_5f69d5c34f82e0fd92afc183_960x0_jpgfitscale;
            this.ClientSize = new System.Drawing.Size(469, 238);
            this.Controls.Add(this.btnClearInfo);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.dataGridInfo);
            this.Controls.Add(this.txtClientUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInportInformation);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInportInformation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientUserName;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Button btnClearInfo;
    }
}