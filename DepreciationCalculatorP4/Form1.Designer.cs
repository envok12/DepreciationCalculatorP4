
namespace DepreciationCalculatorP4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.instructionTab = new System.Windows.Forms.TabPage();
            this.calculatorInstructionsTextBox = new System.Windows.Forms.TextBox();
            this.calculatorInstructionsTabLabel = new System.Windows.Forms.Label();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.lifetimeTextBox = new System.Windows.Forms.TextBox();
            this.endValueTextBox = new System.Windows.Forms.TextBox();
            this.startValueTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.removeSelectedItemButton = new System.Windows.Forms.Button();
            this.addFormButton = new System.Windows.Forms.Button();
            this.doubleDecliningRadioButton = new System.Windows.Forms.RadioButton();
            this.straightLineRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateOutOfInventoryLabel = new System.Windows.Forms.Label();
            this.dateInInventoryLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lifetimeYrsLabel = new System.Windows.Forms.Label();
            this.endValueLabel = new System.Windows.Forms.Label();
            this.startingValueLable = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inventoryTabListBox = new System.Windows.Forms.ListBox();
            this.summaryTab = new System.Windows.Forms.TabPage();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.calculateInventoryButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.instructionTab.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.summaryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.instructionTab);
            this.tabControl1.Controls.Add(this.inventoryTab);
            this.tabControl1.Controls.Add(this.summaryTab);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // instructionTab
            // 
            this.instructionTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.instructionTab.Controls.Add(this.calculatorInstructionsTextBox);
            this.instructionTab.Controls.Add(this.calculatorInstructionsTabLabel);
            this.instructionTab.Location = new System.Drawing.Point(4, 25);
            this.instructionTab.Name = "instructionTab";
            this.instructionTab.Padding = new System.Windows.Forms.Padding(3);
            this.instructionTab.Size = new System.Drawing.Size(826, 624);
            this.instructionTab.TabIndex = 0;
            this.instructionTab.Text = "Instructions";
            // 
            // calculatorInstructionsTextBox
            // 
            this.calculatorInstructionsTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.calculatorInstructionsTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorInstructionsTextBox.Location = new System.Drawing.Point(145, 117);
            this.calculatorInstructionsTextBox.Multiline = true;
            this.calculatorInstructionsTextBox.Name = "calculatorInstructionsTextBox";
            this.calculatorInstructionsTextBox.ReadOnly = true;
            this.calculatorInstructionsTextBox.Size = new System.Drawing.Size(443, 150);
            this.calculatorInstructionsTextBox.TabIndex = 1;
            this.calculatorInstructionsTextBox.Text = "Welcome to the Super Depreciation Calculator 3000. Enter your inventory in the in" +
    "ventory tab. Then go to the summary tab to \r\nfind the value of your inventory.";
            this.calculatorInstructionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculatorInstructionsTabLabel
            // 
            this.calculatorInstructionsTabLabel.AutoSize = true;
            this.calculatorInstructionsTabLabel.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorInstructionsTabLabel.Location = new System.Drawing.Point(140, 55);
            this.calculatorInstructionsTabLabel.Name = "calculatorInstructionsTabLabel";
            this.calculatorInstructionsTabLabel.Size = new System.Drawing.Size(448, 30);
            this.calculatorInstructionsTabLabel.TabIndex = 0;
            this.calculatorInstructionsTabLabel.Text = "Super Depreciation Calculator 3000";
            // 
            // inventoryTab
            // 
            this.inventoryTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inventoryTab.Controls.Add(this.lifetimeTextBox);
            this.inventoryTab.Controls.Add(this.endValueTextBox);
            this.inventoryTab.Controls.Add(this.startValueTextBox);
            this.inventoryTab.Controls.Add(this.titleTextBox);
            this.inventoryTab.Controls.Add(this.removeSelectedItemButton);
            this.inventoryTab.Controls.Add(this.addFormButton);
            this.inventoryTab.Controls.Add(this.doubleDecliningRadioButton);
            this.inventoryTab.Controls.Add(this.straightLineRadioButton);
            this.inventoryTab.Controls.Add(this.dateTimePicker2);
            this.inventoryTab.Controls.Add(this.dateOutOfInventoryLabel);
            this.inventoryTab.Controls.Add(this.dateInInventoryLabel);
            this.inventoryTab.Controls.Add(this.dateTimePicker1);
            this.inventoryTab.Controls.Add(this.lifetimeYrsLabel);
            this.inventoryTab.Controls.Add(this.endValueLabel);
            this.inventoryTab.Controls.Add(this.startingValueLable);
            this.inventoryTab.Controls.Add(this.titleLabel);
            this.inventoryTab.Controls.Add(this.inventoryTabListBox);
            this.inventoryTab.Location = new System.Drawing.Point(4, 25);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(826, 624);
            this.inventoryTab.TabIndex = 1;
            this.inventoryTab.Text = "Inventory";
            // 
            // lifetimeTextBox
            // 
            this.lifetimeTextBox.Location = new System.Drawing.Point(600, 206);
            this.lifetimeTextBox.Name = "lifetimeTextBox";
            this.lifetimeTextBox.Size = new System.Drawing.Size(200, 22);
            this.lifetimeTextBox.TabIndex = 16;
            // 
            // endValueTextBox
            // 
            this.endValueTextBox.Location = new System.Drawing.Point(600, 159);
            this.endValueTextBox.Name = "endValueTextBox";
            this.endValueTextBox.Size = new System.Drawing.Size(200, 22);
            this.endValueTextBox.TabIndex = 15;
            // 
            // startValueTextBox
            // 
            this.startValueTextBox.Location = new System.Drawing.Point(600, 114);
            this.startValueTextBox.Name = "startValueTextBox";
            this.startValueTextBox.Size = new System.Drawing.Size(200, 22);
            this.startValueTextBox.TabIndex = 14;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(600, 65);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 22);
            this.titleTextBox.TabIndex = 13;
            // 
            // removeSelectedItemButton
            // 
            this.removeSelectedItemButton.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedItemButton.Location = new System.Drawing.Point(37, 450);
            this.removeSelectedItemButton.Name = "removeSelectedItemButton";
            this.removeSelectedItemButton.Size = new System.Drawing.Size(307, 32);
            this.removeSelectedItemButton.TabIndex = 12;
            this.removeSelectedItemButton.Text = "Remove Selected Item From Inventory";
            this.removeSelectedItemButton.UseVisualStyleBackColor = true;
            this.removeSelectedItemButton.Click += new System.EventHandler(this.removeSelectedItemButton_Click);
            // 
            // addFormButton
            // 
            this.addFormButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFormButton.Location = new System.Drawing.Point(439, 450);
            this.addFormButton.Name = "addFormButton";
            this.addFormButton.Size = new System.Drawing.Size(303, 58);
            this.addFormButton.TabIndex = 11;
            this.addFormButton.Text = "Add Form Item to Inventory";
            this.addFormButton.UseVisualStyleBackColor = true;
            this.addFormButton.Click += new System.EventHandler(this.addFormButton_Click);
            // 
            // doubleDecliningRadioButton
            // 
            this.doubleDecliningRadioButton.AutoSize = true;
            this.doubleDecliningRadioButton.Location = new System.Drawing.Point(439, 399);
            this.doubleDecliningRadioButton.Name = "doubleDecliningRadioButton";
            this.doubleDecliningRadioButton.Size = new System.Drawing.Size(136, 21);
            this.doubleDecliningRadioButton.TabIndex = 10;
            this.doubleDecliningRadioButton.TabStop = true;
            this.doubleDecliningRadioButton.Text = "Double Declining";
            this.doubleDecliningRadioButton.UseVisualStyleBackColor = true;
            // 
            // straightLineRadioButton
            // 
            this.straightLineRadioButton.AutoSize = true;
            this.straightLineRadioButton.Location = new System.Drawing.Point(439, 357);
            this.straightLineRadioButton.Name = "straightLineRadioButton";
            this.straightLineRadioButton.Size = new System.Drawing.Size(109, 21);
            this.straightLineRadioButton.TabIndex = 9;
            this.straightLineRadioButton.TabStop = true;
            this.straightLineRadioButton.Text = "Straight Line";
            this.straightLineRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(600, 305);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateOutOfInventoryLabel
            // 
            this.dateOutOfInventoryLabel.AutoSize = true;
            this.dateOutOfInventoryLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutOfInventoryLabel.Location = new System.Drawing.Point(391, 306);
            this.dateOutOfInventoryLabel.Name = "dateOutOfInventoryLabel";
            this.dateOutOfInventoryLabel.Size = new System.Drawing.Size(185, 21);
            this.dateOutOfInventoryLabel.TabIndex = 7;
            this.dateOutOfInventoryLabel.Text = "Date out of Inventory";
            // 
            // dateInInventoryLabel
            // 
            this.dateInInventoryLabel.AutoSize = true;
            this.dateInInventoryLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInInventoryLabel.Location = new System.Drawing.Point(391, 254);
            this.dateInInventoryLabel.Name = "dateInInventoryLabel";
            this.dateInInventoryLabel.Size = new System.Drawing.Size(153, 21);
            this.dateInInventoryLabel.TabIndex = 6;
            this.dateInInventoryLabel.Text = "Date in Inventory";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lifetimeYrsLabel
            // 
            this.lifetimeYrsLabel.AutoSize = true;
            this.lifetimeYrsLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifetimeYrsLabel.Location = new System.Drawing.Point(395, 206);
            this.lifetimeYrsLabel.Name = "lifetimeYrsLabel";
            this.lifetimeYrsLabel.Size = new System.Drawing.Size(143, 21);
            this.lifetimeYrsLabel.TabIndex = 4;
            this.lifetimeYrsLabel.Text = "Lifetime (years)";
            // 
            // endValueLabel
            // 
            this.endValueLabel.AutoSize = true;
            this.endValueLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endValueLabel.Location = new System.Drawing.Point(395, 159);
            this.endValueLabel.Name = "endValueLabel";
            this.endValueLabel.Size = new System.Drawing.Size(110, 21);
            this.endValueLabel.TabIndex = 3;
            this.endValueLabel.Text = "End Value $";
            // 
            // startingValueLable
            // 
            this.startingValueLable.AutoSize = true;
            this.startingValueLable.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingValueLable.Location = new System.Drawing.Point(395, 114);
            this.startingValueLable.Name = "startingValueLable";
            this.startingValueLable.Size = new System.Drawing.Size(143, 21);
            this.startingValueLable.TabIndex = 2;
            this.startingValueLable.Text = "Starting Value $";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(391, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 21);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // inventoryTabListBox
            // 
            this.inventoryTabListBox.FormattingEnabled = true;
            this.inventoryTabListBox.ItemHeight = 16;
            this.inventoryTabListBox.Location = new System.Drawing.Point(37, 65);
            this.inventoryTabListBox.Name = "inventoryTabListBox";
            this.inventoryTabListBox.Size = new System.Drawing.Size(307, 356);
            this.inventoryTabListBox.TabIndex = 0;
            this.inventoryTabListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryTabListBox_SelectedIndexChanged);
            // 
            // summaryTab
            // 
            this.summaryTab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.summaryTab.Controls.Add(this.summaryTextBox);
            this.summaryTab.Controls.Add(this.calculateInventoryButton);
            this.summaryTab.Location = new System.Drawing.Point(4, 25);
            this.summaryTab.Name = "summaryTab";
            this.summaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTab.Size = new System.Drawing.Size(826, 624);
            this.summaryTab.TabIndex = 2;
            this.summaryTab.Text = "Summary";
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(171, 252);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(433, 123);
            this.summaryTextBox.TabIndex = 1;
            this.summaryTextBox.Visible = false;
            // 
            // calculateInventoryButton
            // 
            this.calculateInventoryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.calculateInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateInventoryButton.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateInventoryButton.Location = new System.Drawing.Point(229, 117);
            this.calculateInventoryButton.Name = "calculateInventoryButton";
            this.calculateInventoryButton.Size = new System.Drawing.Size(300, 91);
            this.calculateInventoryButton.TabIndex = 0;
            this.calculateInventoryButton.Text = "Calculate Inventory Value";
            this.calculateInventoryButton.UseVisualStyleBackColor = false;
            this.calculateInventoryButton.Click += new System.EventHandler(this.calculateInventoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Super Depreciation Calculator 3000";
            this.tabControl1.ResumeLayout(false);
            this.instructionTab.ResumeLayout(false);
            this.instructionTab.PerformLayout();
            this.inventoryTab.ResumeLayout(false);
            this.inventoryTab.PerformLayout();
            this.summaryTab.ResumeLayout(false);
            this.summaryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage instructionTab;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.TabPage summaryTab;
        private System.Windows.Forms.TextBox calculatorInstructionsTextBox;
        private System.Windows.Forms.Label calculatorInstructionsTabLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateOutOfInventoryLabel;
        private System.Windows.Forms.Label dateInInventoryLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lifetimeYrsLabel;
        private System.Windows.Forms.Label endValueLabel;
        private System.Windows.Forms.Label startingValueLable;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox inventoryTabListBox;
        private System.Windows.Forms.TextBox lifetimeTextBox;
        private System.Windows.Forms.TextBox endValueTextBox;
        private System.Windows.Forms.TextBox startValueTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button removeSelectedItemButton;
        private System.Windows.Forms.Button addFormButton;
        private System.Windows.Forms.RadioButton doubleDecliningRadioButton;
        private System.Windows.Forms.RadioButton straightLineRadioButton;
        private System.Windows.Forms.Button calculateInventoryButton;
        private System.Windows.Forms.TextBox summaryTextBox;
    }
}

