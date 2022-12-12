namespace assignment12_PavelGolovan
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
            this.productionWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productionWorkerListBox = new System.Windows.Forms.ListBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.productionWorkerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionWorkerGroupBox
            // 
            this.productionWorkerGroupBox.Controls.Add(this.payRateLabel);
            this.productionWorkerGroupBox.Controls.Add(this.payRateTextBox);
            this.productionWorkerGroupBox.Controls.Add(this.numberLabel);
            this.productionWorkerGroupBox.Controls.Add(this.nameLabel);
            this.productionWorkerGroupBox.Controls.Add(this.shiftLabel);
            this.productionWorkerGroupBox.Controls.Add(this.shiftTextBox);
            this.productionWorkerGroupBox.Controls.Add(this.numberTextBox);
            this.productionWorkerGroupBox.Controls.Add(this.nameTextBox);
            this.productionWorkerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.productionWorkerGroupBox.Name = "productionWorkerGroupBox";
            this.productionWorkerGroupBox.Size = new System.Drawing.Size(354, 264);
            this.productionWorkerGroupBox.TabIndex = 19;
            this.productionWorkerGroupBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(6, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 28);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Employee name:";
            // 
            // shiftLabel
            // 
            this.shiftLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shiftLabel.Location = new System.Drawing.Point(6, 142);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(194, 28);
            this.shiftLabel.TabIndex = 6;
            this.shiftLabel.Text = "Shift number:";
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shiftTextBox.Location = new System.Drawing.Point(206, 139);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(142, 34);
            this.shiftTextBox.TabIndex = 2;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(206, 90);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(142, 34);
            this.numberTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(206, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 34);
            this.nameTextBox.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(192, 291);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 38);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(498, 390);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 38);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(435, 291);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(114, 38);
            this.showButton.TabIndex = 16;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(72, 291);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 38);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productionWorkerListBox
            // 
            this.productionWorkerListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionWorkerListBox.FormattingEnabled = true;
            this.productionWorkerListBox.ItemHeight = 28;
            this.productionWorkerListBox.Location = new System.Drawing.Point(372, 19);
            this.productionWorkerListBox.Name = "productionWorkerListBox";
            this.productionWorkerListBox.Size = new System.Drawing.Size(240, 256);
            this.productionWorkerListBox.TabIndex = 14;
            // 
            // numberLabel
            // 
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(6, 93);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(194, 28);
            this.numberLabel.TabIndex = 7;
            this.numberLabel.Text = "Employee number:";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payRateTextBox.Location = new System.Drawing.Point(206, 188);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(142, 34);
            this.payRateTextBox.TabIndex = 8;
            // 
            // payRateLabel
            // 
            this.payRateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payRateLabel.Location = new System.Drawing.Point(6, 191);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(194, 28);
            this.payRateLabel.TabIndex = 9;
            this.payRateLabel.Text = "Hourly pay rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.productionWorkerGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productionWorkerListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Employee and ProductionWorker Classes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.productionWorkerGroupBox.ResumeLayout(false);
            this.productionWorkerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productionWorkerGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox productionWorkerListBox;
        private System.Windows.Forms.Label payRateLabel;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.Label numberLabel;
    }
}

