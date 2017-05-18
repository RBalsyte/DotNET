namespace DotNet
{
    partial class Form1
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
            this.addressList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pingButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port8080 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelMaximumThreads = new System.Windows.Forms.Label();
            this.statusMaxWorkerThreads = new System.Windows.Forms.Label();
            this.labelPortThreads = new System.Windows.Forms.Label();
            this.statusAvailableWorkerThreads = new System.Windows.Forms.Label();
            this.labelAvailableThreads = new System.Windows.Forms.Label();
            this.labelAvailablePortThreads = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusMaxPortThreads = new System.Windows.Forms.Label();
            this.statusAvailablePortThreads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressList
            // 
            this.addressList.Location = new System.Drawing.Point(498, 39);
            this.addressList.Multiline = true;
            this.addressList.Name = "addressList";
            this.addressList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addressList.Size = new System.Drawing.Size(499, 99);
            this.addressList.TabIndex = 0;
            this.addressList.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Address(es)";
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(1003, 48);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(75, 23);
            this.pingButton.TabIndex = 2;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Status,
            this.Port80,
            this.Port8080,
            this.RoundTrip});
            this.dataGridView1.Location = new System.Drawing.Point(108, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 423);
            this.dataGridView1.TabIndex = 3;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Port80
            // 
            this.Port80.HeaderText = "Port 80";
            this.Port80.Name = "Port80";
            this.Port80.ReadOnly = true;
            // 
            // Port8080
            // 
            this.Port8080.HeaderText = "Port 8080";
            this.Port8080.Name = "Port8080";
            this.Port8080.ReadOnly = true;
            // 
            // RoundTrip
            // 
            this.RoundTrip.HeaderText = "Round Trip Time";
            this.RoundTrip.Name = "RoundTrip";
            this.RoundTrip.ReadOnly = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1003, 101);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelMaximumThreads
            // 
            this.labelMaximumThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaximumThreads.AutoSize = true;
            this.labelMaximumThreads.Location = new System.Drawing.Point(91, 1);
            this.labelMaximumThreads.Name = "labelMaximumThreads";
            this.labelMaximumThreads.Size = new System.Drawing.Size(80, 31);
            this.labelMaximumThreads.TabIndex = 5;
            this.labelMaximumThreads.Text = "Maximum Threads";
            this.labelMaximumThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusMaxWorkerThreads
            // 
            this.statusMaxWorkerThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusMaxWorkerThreads.AutoSize = true;
            this.statusMaxWorkerThreads.Location = new System.Drawing.Point(91, 33);
            this.statusMaxWorkerThreads.Name = "statusMaxWorkerThreads";
            this.statusMaxWorkerThreads.Size = new System.Drawing.Size(0, 34);
            this.statusMaxWorkerThreads.TabIndex = 6;
            this.statusMaxWorkerThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPortThreads
            // 
            this.labelPortThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPortThreads.AutoSize = true;
            this.labelPortThreads.Location = new System.Drawing.Point(4, 33);
            this.labelPortThreads.Name = "labelPortThreads";
            this.labelPortThreads.Size = new System.Drawing.Size(80, 34);
            this.labelPortThreads.TabIndex = 7;
            this.labelPortThreads.Text = "Worker";
            this.labelPortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusAvailableWorkerThreads
            // 
            this.statusAvailableWorkerThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusAvailableWorkerThreads.AutoSize = true;
            this.statusAvailableWorkerThreads.Location = new System.Drawing.Point(178, 33);
            this.statusAvailableWorkerThreads.Name = "statusAvailableWorkerThreads";
            this.statusAvailableWorkerThreads.Size = new System.Drawing.Size(82, 34);
            this.statusAvailableWorkerThreads.TabIndex = 8;
            this.statusAvailableWorkerThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvailableThreads
            // 
            this.labelAvailableThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvailableThreads.AutoSize = true;
            this.labelAvailableThreads.Location = new System.Drawing.Point(178, 1);
            this.labelAvailableThreads.Name = "labelAvailableThreads";
            this.labelAvailableThreads.Size = new System.Drawing.Size(82, 31);
            this.labelAvailableThreads.TabIndex = 9;
            this.labelAvailableThreads.Text = "Available Threads ";
            this.labelAvailableThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvailablePortThreads
            // 
            this.labelAvailablePortThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvailablePortThreads.AutoSize = true;
            this.labelAvailablePortThreads.Location = new System.Drawing.Point(4, 68);
            this.labelAvailablePortThreads.Name = "labelAvailablePortThreads";
            this.labelAvailablePortThreads.Size = new System.Drawing.Size(80, 31);
            this.labelAvailablePortThreads.TabIndex = 10;
            this.labelAvailablePortThreads.Text = "IO Completion Port";
            this.labelAvailablePortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.Window;
            this.statusPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.statusPanel.ColumnCount = 3;
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.statusPanel.Controls.Add(this.labelMaximumThreads, 1, 0);
            this.statusPanel.Controls.Add(this.statusAvailableWorkerThreads, 2, 1);
            this.statusPanel.Controls.Add(this.labelAvailablePortThreads, 0, 2);
            this.statusPanel.Controls.Add(this.statusMaxWorkerThreads, 1, 1);
            this.statusPanel.Controls.Add(this.labelAvailableThreads, 2, 0);
            this.statusPanel.Controls.Add(this.labelPortThreads, 0, 1);
            this.statusPanel.Controls.Add(this.statusMaxPortThreads, 1, 2);
            this.statusPanel.Controls.Add(this.statusAvailablePortThreads, 2, 2);
            this.statusPanel.Location = new System.Drawing.Point(108, 39);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.RowCount = 3;
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.statusPanel.Size = new System.Drawing.Size(264, 100);
            this.statusPanel.TabIndex = 11;
            // 
            // statusMaxPortThreads
            // 
            this.statusMaxPortThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusMaxPortThreads.AutoSize = true;
            this.statusMaxPortThreads.Location = new System.Drawing.Point(91, 68);
            this.statusMaxPortThreads.Name = "statusMaxPortThreads";
            this.statusMaxPortThreads.Size = new System.Drawing.Size(80, 31);
            this.statusMaxPortThreads.TabIndex = 11;
            this.statusMaxPortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusAvailablePortThreads
            // 
            this.statusAvailablePortThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusAvailablePortThreads.AutoSize = true;
            this.statusAvailablePortThreads.Location = new System.Drawing.Point(178, 68);
            this.statusAvailablePortThreads.Name = "statusAvailablePortThreads";
            this.statusAvailablePortThreads.Size = new System.Drawing.Size(82, 31);
            this.statusAvailablePortThreads.TabIndex = 12;
            this.statusAvailablePortThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 599);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port80;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port8080;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundTrip;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelMaximumThreads;
        private System.Windows.Forms.Label statusMaxWorkerThreads;
        private System.Windows.Forms.Label labelPortThreads;
        private System.Windows.Forms.Label statusAvailableWorkerThreads;
        private System.Windows.Forms.Label labelAvailableThreads;
        private System.Windows.Forms.Label labelAvailablePortThreads;
        private System.Windows.Forms.TableLayoutPanel statusPanel;
        private System.Windows.Forms.Label statusMaxPortThreads;
        private System.Windows.Forms.Label statusAvailablePortThreads;
    }
}

