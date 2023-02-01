namespace initativeForms
{
    partial class initiativeTrackerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.initiativeNumeric = new System.Windows.Forms.NumericUpDown();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.enemyLabel = new System.Windows.Forms.Label();
            this.enemyNumeric = new System.Windows.Forms.NumericUpDown();
            this.initialTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initiativeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Location = new System.Drawing.Point(12, 132);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(52, 15);
            this.initiativeLabel.TabIndex = 0;
            this.initiativeLabel.Text = "Initiative";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 46);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // typeCombobox
            // 
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "PC",
            "Enemy"});
            this.typeCombobox.Location = new System.Drawing.Point(105, 43);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(76, 23);
            this.typeCombobox.TabIndex = 2;
            this.typeCombobox.SelectedIndexChanged += new System.EventHandler(this.typeCombobox_SelectedIndexChanged);
            // 
            // initiativeNumeric
            // 
            this.initiativeNumeric.Enabled = false;
            this.initiativeNumeric.Location = new System.Drawing.Point(105, 130);
            this.initiativeNumeric.Name = "initiativeNumeric";
            this.initiativeNumeric.Size = new System.Drawing.Size(76, 23);
            this.initiativeNumeric.TabIndex = 3;
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Location = new System.Drawing.Point(12, 75);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(76, 15);
            this.initialsLabel.TabIndex = 4;
            this.initialsLabel.Text = "Player initials";
            // 
            // enemyLabel
            // 
            this.enemyLabel.AutoSize = true;
            this.enemyLabel.Location = new System.Drawing.Point(12, 103);
            this.enemyLabel.Name = "enemyLabel";
            this.enemyLabel.Size = new System.Drawing.Size(88, 15);
            this.enemyLabel.TabIndex = 5;
            this.enemyLabel.Text = "Enemy number";
            // 
            // enemyNumeric
            // 
            this.enemyNumeric.Enabled = false;
            this.enemyNumeric.Location = new System.Drawing.Point(105, 101);
            this.enemyNumeric.Name = "enemyNumeric";
            this.enemyNumeric.Size = new System.Drawing.Size(76, 23);
            this.enemyNumeric.TabIndex = 6;
            // 
            // initialTextbox
            // 
            this.initialTextbox.Enabled = false;
            this.initialTextbox.Location = new System.Drawing.Point(105, 72);
            this.initialTextbox.Name = "initialTextbox";
            this.initialTextbox.Size = new System.Drawing.Size(76, 23);
            this.initialTextbox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(105, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(76, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add to list";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(187, 297);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(162, 23);
            this.killButton.TabIndex = 10;
            this.killButton.Text = "Kill / Remove from list";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(12, 188);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(87, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next turn";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start combat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 217);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(169, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(109, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(240, 23);
            this.connectButton.TabIndex = 16;
            this.connectButton.Text = "Connect to Arduino";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(14, 9);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(89, 15);
            this.connectionLabel.TabIndex = 17;
            this.connectionLabel.Text = "Not connected!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.initiativeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(186, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(163, 250);
            this.dataGridView1.TabIndex = 18;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 60;
            // 
            // initiativeColumn
            // 
            this.initiativeColumn.HeaderText = "Initiative";
            this.initiativeColumn.Name = "initiativeColumn";
            this.initiativeColumn.ReadOnly = true;
            this.initiativeColumn.Width = 60;
            // 
            // initiativeTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.initialTextbox);
            this.Controls.Add(this.enemyNumeric);
            this.Controls.Add(this.enemyLabel);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.initiativeNumeric);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.initiativeLabel);
            this.Name = "initiativeTrackerForm";
            this.Text = "Initiative Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initiativeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label initiativeLabel;
        private Label typeLabel;
        private ComboBox typeCombobox;
        private NumericUpDown initiativeNumeric;
        private Label initialsLabel;
        private Label enemyLabel;
        private NumericUpDown enemyNumeric;
        private TextBox initialTextbox;
        private Button addButton;
        private Button killButton;
        private Button nextButton;
        private Button startButton;
        private Button resetButton;
        private Button connectButton;
        private Label connectionLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn initiativeColumn;
    }
}