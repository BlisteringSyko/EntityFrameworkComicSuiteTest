namespace EntityFrameworkComicSuiteTest
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).BeginInit();
            this.panelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(2, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(148, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password1";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(2, 90);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "sa";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(2, 51);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(148, 20);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.Text = "DCDCKYCST008";
            // 
            // cboDatabase
            // 
            this.cboDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(3, 207);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(148, 21);
            this.cboDatabase.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(2, 248);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 22);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect?";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.numTimeOut);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Controls.Add(this.txtServerName);
            this.panelContent.Controls.Add(this.btnConnect);
            this.panelContent.Controls.Add(this.cboDatabase);
            this.panelContent.Controls.Add(this.txtPassword);
            this.panelContent.Controls.Add(this.txtUserName);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(164, 291);
            this.panelContent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time out";
            // 
            // numTimeOut
            // 
            this.numTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTimeOut.Location = new System.Drawing.Point(3, 168);
            this.numTimeOut.Name = "numTimeOut";
            this.numTimeOut.Size = new System.Drawing.Size(148, 20);
            this.numTimeOut.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.labelWindowTitle);
            this.panelControlBox.Controls.Add(this.buttonClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(164, 22);
            this.panelControlBox.TabIndex = 9;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(129, 22);
            this.labelWindowTitle.TabIndex = 1;
            this.labelWindowTitle.Text = "label1";
            this.labelWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(129, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 22);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 291);
            this.Controls.Add(this.panelContent);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect?";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOut)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}