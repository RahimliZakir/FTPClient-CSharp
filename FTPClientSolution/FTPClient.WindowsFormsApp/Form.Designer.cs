namespace FTPClient.WindowsFormsApp
{
    partial class Form
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
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnCreateFolderAndUploadFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGetLising = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadFile.Location = new System.Drawing.Point(21, 111);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(167, 69);
            this.btnUploadFile.TabIndex = 1;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelStatus.Location = new System.Drawing.Point(318, 37);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(135, 37);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status...";
            // 
            // btnCreateFolderAndUploadFile
            // 
            this.btnCreateFolderAndUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFolderAndUploadFile.Location = new System.Drawing.Point(21, 207);
            this.btnCreateFolderAndUploadFile.Name = "btnCreateFolderAndUploadFile";
            this.btnCreateFolderAndUploadFile.Size = new System.Drawing.Size(167, 69);
            this.btnCreateFolderAndUploadFile.TabIndex = 3;
            this.btnCreateFolderAndUploadFile.Text = "Create Folder And Upload File";
            this.btnCreateFolderAndUploadFile.UseVisualStyleBackColor = true;
            this.btnCreateFolderAndUploadFile.Click += new System.EventHandler(this.btnCreateFolderAndUploadFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(325, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 164);
            this.listBox1.TabIndex = 4;
            // 
            // btnGetLising
            // 
            this.btnGetLising.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetLising.Location = new System.Drawing.Point(21, 323);
            this.btnGetLising.Name = "btnGetLising";
            this.btnGetLising.Size = new System.Drawing.Size(167, 69);
            this.btnGetLising.TabIndex = 5;
            this.btnGetLising.Text = "Fill To The List";
            this.btnGetLising.UseVisualStyleBackColor = true;
            this.btnGetLising.Click += new System.EventHandler(this.btnGetLising_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnGetLising);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCreateFolderAndUploadFile);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnUploadFile);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnCreateFolderAndUploadFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGetLising;
    }
}

