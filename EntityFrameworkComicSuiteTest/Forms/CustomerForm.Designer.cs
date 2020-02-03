namespace EntityFrameworkComicSuiteTest
{
    partial class CustomerForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSubscriptions = new System.Windows.Forms.GroupBox();
            this.fOlvSubscriptions = new BrightIdeasSoftware.FastObjectListView();
            this.olvColSubSeriesCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubSeriesName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubAvtive = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubVarient = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSubCreated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbSubscriptionPostings = new System.Windows.Forms.GroupBox();
            this.fOlvSubPosting = new BrightIdeasSoftware.FastObjectListView();
            this.olvColSpItem = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSpQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSpDesc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSpStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gbSpecialOrders = new System.Windows.Forms.GroupBox();
            this.fOlvSpecialOrders = new BrightIdeasSoftware.FastObjectListView();
            this.olvColSoItem = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSoQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSoDesc = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSoStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblAccountOpened = new System.Windows.Forms.Label();
            this.lblTotalSavings = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalVisits = new System.Windows.Forms.Label();
            this.lblLastVisit = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxWindowicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSubscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSubscriptionPostings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSubPosting)).BeginInit();
            this.gbSpecialOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSpecialOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindowicon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 141);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSubscriptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(940, 309);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbSubscriptions
            // 
            this.gbSubscriptions.Controls.Add(this.fOlvSubscriptions);
            this.gbSubscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSubscriptions.Location = new System.Drawing.Point(0, 0);
            this.gbSubscriptions.Name = "gbSubscriptions";
            this.gbSubscriptions.Size = new System.Drawing.Size(940, 155);
            this.gbSubscriptions.TabIndex = 0;
            this.gbSubscriptions.TabStop = false;
            this.gbSubscriptions.Text = "Subscriptions";
            // 
            // fOlvSubscriptions
            // 
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubSeriesCode);
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubSeriesName);
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubQty);
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubAvtive);
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubVarient);
            this.fOlvSubscriptions.AllColumns.Add(this.olvColSubCreated);
            this.fOlvSubscriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fOlvSubscriptions.CellEditUseWholeCell = false;
            this.fOlvSubscriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSubSeriesCode,
            this.olvColSubSeriesName,
            this.olvColSubQty,
            this.olvColSubAvtive,
            this.olvColSubVarient,
            this.olvColSubCreated});
            this.fOlvSubscriptions.Cursor = System.Windows.Forms.Cursors.Default;
            this.fOlvSubscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fOlvSubscriptions.FullRowSelect = true;
            this.fOlvSubscriptions.HideSelection = false;
            this.fOlvSubscriptions.Location = new System.Drawing.Point(3, 16);
            this.fOlvSubscriptions.Name = "fOlvSubscriptions";
            this.fOlvSubscriptions.ShowGroups = false;
            this.fOlvSubscriptions.Size = new System.Drawing.Size(934, 136);
            this.fOlvSubscriptions.TabIndex = 0;
            this.fOlvSubscriptions.UseAlternatingBackColors = true;
            this.fOlvSubscriptions.UseCompatibleStateImageBehavior = false;
            this.fOlvSubscriptions.View = System.Windows.Forms.View.Details;
            this.fOlvSubscriptions.VirtualMode = true;
            // 
            // olvColSubSeriesCode
            // 
            this.olvColSubSeriesCode.AspectName = "SeriesCode";
            this.olvColSubSeriesCode.Text = "Series Code";
            this.olvColSubSeriesCode.Width = 90;
            // 
            // olvColSubSeriesName
            // 
            this.olvColSubSeriesName.FillsFreeSpace = true;
            this.olvColSubSeriesName.Text = "Series Name";
            this.olvColSubSeriesName.Width = 180;
            // 
            // olvColSubQty
            // 
            this.olvColSubQty.Text = "Qty";
            this.olvColSubQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSubQty.Width = 31;
            // 
            // olvColSubAvtive
            // 
            this.olvColSubAvtive.Text = "Active?";
            this.olvColSubAvtive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSubAvtive.Width = 48;
            // 
            // olvColSubVarient
            // 
            this.olvColSubVarient.Text = "Varient#";
            this.olvColSubVarient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSubVarient.Width = 55;
            // 
            // olvColSubCreated
            // 
            this.olvColSubCreated.Text = "Created";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSubscriptionPostings);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbSpecialOrders);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.splitContainer2.Size = new System.Drawing.Size(940, 150);
            this.splitContainer2.SplitterDistance = 468;
            this.splitContainer2.TabIndex = 1;
            // 
            // gbSubscriptionPostings
            // 
            this.gbSubscriptionPostings.Controls.Add(this.fOlvSubPosting);
            this.gbSubscriptionPostings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSubscriptionPostings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSubscriptionPostings.Location = new System.Drawing.Point(0, 0);
            this.gbSubscriptionPostings.Name = "gbSubscriptionPostings";
            this.gbSubscriptionPostings.Padding = new System.Windows.Forms.Padding(5);
            this.gbSubscriptionPostings.Size = new System.Drawing.Size(466, 150);
            this.gbSubscriptionPostings.TabIndex = 1;
            this.gbSubscriptionPostings.TabStop = false;
            this.gbSubscriptionPostings.Text = "Sub posting";
            // 
            // fOlvSubPosting
            // 
            this.fOlvSubPosting.AllColumns.Add(this.olvColSpItem);
            this.fOlvSubPosting.AllColumns.Add(this.olvColSpQty);
            this.fOlvSubPosting.AllColumns.Add(this.olvColSpDesc);
            this.fOlvSubPosting.AllColumns.Add(this.olvColSpStatus);
            this.fOlvSubPosting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fOlvSubPosting.CellEditUseWholeCell = false;
            this.fOlvSubPosting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSpItem,
            this.olvColSpQty,
            this.olvColSpDesc,
            this.olvColSpStatus});
            this.fOlvSubPosting.Cursor = System.Windows.Forms.Cursors.Default;
            this.fOlvSubPosting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fOlvSubPosting.FullRowSelect = true;
            this.fOlvSubPosting.HideSelection = false;
            this.fOlvSubPosting.Location = new System.Drawing.Point(5, 18);
            this.fOlvSubPosting.Name = "fOlvSubPosting";
            this.fOlvSubPosting.ShowGroups = false;
            this.fOlvSubPosting.Size = new System.Drawing.Size(456, 127);
            this.fOlvSubPosting.TabIndex = 0;
            this.fOlvSubPosting.UseAlternatingBackColors = true;
            this.fOlvSubPosting.UseCompatibleStateImageBehavior = false;
            this.fOlvSubPosting.View = System.Windows.Forms.View.Details;
            this.fOlvSubPosting.VirtualMode = true;
            // 
            // olvColSpItem
            // 
            this.olvColSpItem.Text = "Item";
            this.olvColSpItem.Width = 90;
            // 
            // olvColSpQty
            // 
            this.olvColSpQty.Text = "Qty";
            this.olvColSpQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSpQty.Width = 35;
            // 
            // olvColSpDesc
            // 
            this.olvColSpDesc.FillsFreeSpace = true;
            this.olvColSpDesc.Text = "Description";
            // 
            // olvColSpStatus
            // 
            this.olvColSpStatus.Text = "Status";
            this.olvColSpStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColSpStatus.Width = 100;
            // 
            // gbSpecialOrders
            // 
            this.gbSpecialOrders.Controls.Add(this.fOlvSpecialOrders);
            this.gbSpecialOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSpecialOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSpecialOrders.Location = new System.Drawing.Point(2, 0);
            this.gbSpecialOrders.Name = "gbSpecialOrders";
            this.gbSpecialOrders.Padding = new System.Windows.Forms.Padding(5);
            this.gbSpecialOrders.Size = new System.Drawing.Size(466, 150);
            this.gbSpecialOrders.TabIndex = 0;
            this.gbSpecialOrders.TabStop = false;
            this.gbSpecialOrders.Text = "Special Orders";
            // 
            // fOlvSpecialOrders
            // 
            this.fOlvSpecialOrders.AllColumns.Add(this.olvColSoItem);
            this.fOlvSpecialOrders.AllColumns.Add(this.olvColSoQty);
            this.fOlvSpecialOrders.AllColumns.Add(this.olvColSoDesc);
            this.fOlvSpecialOrders.AllColumns.Add(this.olvColSoStatus);
            this.fOlvSpecialOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fOlvSpecialOrders.CellEditUseWholeCell = false;
            this.fOlvSpecialOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSoItem,
            this.olvColSoQty,
            this.olvColSoDesc,
            this.olvColSoStatus});
            this.fOlvSpecialOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.fOlvSpecialOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fOlvSpecialOrders.FullRowSelect = true;
            this.fOlvSpecialOrders.HideSelection = false;
            this.fOlvSpecialOrders.Location = new System.Drawing.Point(5, 18);
            this.fOlvSpecialOrders.Name = "fOlvSpecialOrders";
            this.fOlvSpecialOrders.ShowGroups = false;
            this.fOlvSpecialOrders.Size = new System.Drawing.Size(456, 127);
            this.fOlvSpecialOrders.TabIndex = 0;
            this.fOlvSpecialOrders.UseAlternatingBackColors = true;
            this.fOlvSpecialOrders.UseCompatibleStateImageBehavior = false;
            this.fOlvSpecialOrders.View = System.Windows.Forms.View.Details;
            this.fOlvSpecialOrders.VirtualMode = true;
            // 
            // olvColSoItem
            // 
            this.olvColSoItem.Text = "Item";
            this.olvColSoItem.Width = 90;
            // 
            // olvColSoQty
            // 
            this.olvColSoQty.Text = "Qty";
            this.olvColSoQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColSoQty.Width = 35;
            // 
            // olvColSoDesc
            // 
            this.olvColSoDesc.FillsFreeSpace = true;
            this.olvColSoDesc.Text = "Description";
            this.olvColSoDesc.Width = 169;
            // 
            // olvColSoStatus
            // 
            this.olvColSoStatus.Text = "Status";
            this.olvColSoStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColSoStatus.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lblAccountOpened);
            this.panel1.Controls.Add(this.lblTotalSavings);
            this.panel1.Controls.Add(this.lblTotalSales);
            this.panel1.Controls.Add(this.lblTotalVisits);
            this.panel1.Controls.Add(this.lblLastVisit);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 116);
            this.panel1.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(239, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "label8";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(239, 35);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "label7";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtNotes);
            this.groupBox3.Location = new System.Drawing.Point(581, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(350, 56);
            this.txtNotes.TabIndex = 6;
            // 
            // lblAccountOpened
            // 
            this.lblAccountOpened.AutoSize = true;
            this.lblAccountOpened.Location = new System.Drawing.Point(8, 91);
            this.lblAccountOpened.Name = "lblAccountOpened";
            this.lblAccountOpened.Size = new System.Drawing.Size(35, 13);
            this.lblAccountOpened.TabIndex = 5;
            this.lblAccountOpened.Text = "label6";
            // 
            // lblTotalSavings
            // 
            this.lblTotalSavings.AutoSize = true;
            this.lblTotalSavings.Location = new System.Drawing.Point(8, 76);
            this.lblTotalSavings.Name = "lblTotalSavings";
            this.lblTotalSavings.Size = new System.Drawing.Size(35, 13);
            this.lblTotalSavings.TabIndex = 4;
            this.lblTotalSavings.Text = "label5";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(8, 62);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(35, 13);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "label4";
            // 
            // lblTotalVisits
            // 
            this.lblTotalVisits.AutoSize = true;
            this.lblTotalVisits.Location = new System.Drawing.Point(8, 49);
            this.lblTotalVisits.Name = "lblTotalVisits";
            this.lblTotalVisits.Size = new System.Drawing.Size(35, 13);
            this.lblTotalVisits.TabIndex = 2;
            this.lblTotalVisits.Text = "label3";
            // 
            // lblLastVisit
            // 
            this.lblLastVisit.AutoSize = true;
            this.lblLastVisit.Location = new System.Drawing.Point(8, 35);
            this.lblLastVisit.Name = "lblLastVisit";
            this.lblLastVisit.Size = new System.Drawing.Size(35, 13);
            this.lblLastVisit.TabIndex = 1;
            this.lblLastVisit.Text = "label2";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(6, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(76, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.splitContainer1);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(940, 450);
            this.panelContent.TabIndex = 8;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.labelWindowTitle);
            this.panelControlBox.Controls.Add(this.buttonMin);
            this.panelControlBox.Controls.Add(this.buttonMax);
            this.panelControlBox.Controls.Add(this.buttonClose);
            this.panelControlBox.Controls.Add(this.pictureBoxWindowicon);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(940, 25);
            this.panelControlBox.TabIndex = 9;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindowTitle.Location = new System.Drawing.Point(25, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(756, 25);
            this.labelWindowTitle.TabIndex = 2;
            this.labelWindowTitle.Text = "Label Title";
            this.labelWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMin
            // 
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMin.Location = new System.Drawing.Point(781, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(53, 25);
            this.buttonMin.TabIndex = 5;
            this.buttonMin.Text = "buttonMin";
            this.buttonMin.UseVisualStyleBackColor = true;
            // 
            // buttonMax
            // 
            this.buttonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMax.Location = new System.Drawing.Point(834, 0);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(53, 25);
            this.buttonMax.TabIndex = 4;
            this.buttonMax.Text = "buttonMax";
            this.buttonMax.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(887, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(53, 25);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWindowicon
            // 
            this.pictureBoxWindowicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxWindowicon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWindowicon.Name = "pictureBoxWindowicon";
            this.pictureBoxWindowicon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxWindowicon.TabIndex = 0;
            this.pictureBoxWindowicon.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.panelContent);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustForm";
            this.Load += new System.EventHandler(this.CustForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSubscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSubscriptions)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSubscriptionPostings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSubPosting)).EndInit();
            this.gbSpecialOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fOlvSpecialOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWindowicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbSubscriptions;
        private System.Windows.Forms.GroupBox gbSpecialOrders;
        private BrightIdeasSoftware.FastObjectListView fOlvSubscriptions;
        private BrightIdeasSoftware.OLVColumn olvColSubSeriesCode;
        private BrightIdeasSoftware.OLVColumn olvColSubSeriesName;
        private BrightIdeasSoftware.OLVColumn olvColSubQty;
        private BrightIdeasSoftware.OLVColumn olvColSubAvtive;
        private BrightIdeasSoftware.FastObjectListView fOlvSpecialOrders;
        private BrightIdeasSoftware.OLVColumn olvColSubVarient;
        private BrightIdeasSoftware.OLVColumn olvColSubCreated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAccountOpened;
        private System.Windows.Forms.Label lblTotalSavings;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalVisits;
        private System.Windows.Forms.Label lblLastVisit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotes;
        private BrightIdeasSoftware.OLVColumn olvColSoItem;
        private BrightIdeasSoftware.OLVColumn olvColSoQty;
        private BrightIdeasSoftware.OLVColumn olvColSoDesc;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxWindowicon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private BrightIdeasSoftware.FastObjectListView fOlvSubPosting;
        private System.Windows.Forms.GroupBox gbSubscriptionPostings;
        private BrightIdeasSoftware.OLVColumn olvColSpItem;
        private BrightIdeasSoftware.OLVColumn olvColSpQty;
        private BrightIdeasSoftware.OLVColumn olvColSpDesc;
        private BrightIdeasSoftware.OLVColumn olvColSoStatus;
        private BrightIdeasSoftware.OLVColumn olvColSpStatus;
    }
}