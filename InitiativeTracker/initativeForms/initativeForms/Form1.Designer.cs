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
            this.removeButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyNumeric)).BeginInit();
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
            this.addButton.Location = new System.Drawing.Point(12, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add to list";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // killButton
            // 
            this.killButton.Enabled = false;
            this.killButton.Location = new System.Drawing.Point(13, 274);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(168, 23);
            this.killButton.TabIndex = 10;
            this.killButton.Text = "Kill";
            this.killButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(14, 245);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(167, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next turn";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(13, 216);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start combat";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(13, 326);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(168, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(187, 326);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(196, 23);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove from list";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(109, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(274, 23);
            this.connectButton.TabIndex = 16;
            this.connectButton.Text = "Connect to Arduino";
            this.connectButton.UseVisualStyleBackColor = true;
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
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(187, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(196, 274);
            this.listBox.TabIndex = 18;
            // 
            // initiativeTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 354);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.removeButton);
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
        private Button removeButton;
        private Button connectButton;
        private Label connectionLabel;
        private ListBox listBox;
    }
}