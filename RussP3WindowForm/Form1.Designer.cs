namespace RussP3WindowForm
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
            this.txbResults = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblNumberOfItems = new System.Windows.Forms.Label();
            this.txbOrderNumber = new System.Windows.Forms.TextBox();
            this.txbNumberOfItems = new System.Windows.Forms.TextBox();
            this.gbItemType = new System.Windows.Forms.GroupBox();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.btnSubmitForm = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.txbEngrave = new System.Windows.Forms.TextBox();
            this.lblEngrave = new System.Windows.Forms.Label();
            this.cbLogo = new System.Windows.Forms.CheckBox();
            this.txbNumberOfColor = new System.Windows.Forms.TextBox();
            this.lblNumberOfColors = new System.Windows.Forms.Label();
            this.gbItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(135, 334);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.Size = new System.Drawing.Size(370, 104);
            this.txbResults.TabIndex = 0;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderNumber.Location = new System.Drawing.Point(60, 25);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(99, 17);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // lblNumberOfItems
            // 
            this.lblNumberOfItems.AutoSize = true;
            this.lblNumberOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberOfItems.Location = new System.Drawing.Point(60, 68);
            this.lblNumberOfItems.Name = "lblNumberOfItems";
            this.lblNumberOfItems.Size = new System.Drawing.Size(111, 17);
            this.lblNumberOfItems.TabIndex = 2;
            this.lblNumberOfItems.Text = "Number of Items";
            // 
            // txbOrderNumber
            // 
            this.txbOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbOrderNumber.Location = new System.Drawing.Point(181, 25);
            this.txbOrderNumber.Name = "txbOrderNumber";
            this.txbOrderNumber.Size = new System.Drawing.Size(100, 23);
            this.txbOrderNumber.TabIndex = 3;
            // 
            // txbNumberOfItems
            // 
            this.txbNumberOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNumberOfItems.Location = new System.Drawing.Point(181, 65);
            this.txbNumberOfItems.Name = "txbNumberOfItems";
            this.txbNumberOfItems.Size = new System.Drawing.Size(100, 23);
            this.txbNumberOfItems.TabIndex = 4;
            // 
            // gbItemType
            // 
            this.gbItemType.Controls.Add(this.rbPen);
            this.gbItemType.Controls.Add(this.rbUSB);
            this.gbItemType.Controls.Add(this.rbMug);
            this.gbItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbItemType.Location = new System.Drawing.Point(314, 25);
            this.gbItemType.Name = "gbItemType";
            this.gbItemType.Size = new System.Drawing.Size(139, 131);
            this.gbItemType.TabIndex = 5;
            this.gbItemType.TabStop = false;
            this.gbItemType.Text = "Item Type";
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbPen.Location = new System.Drawing.Point(32, 81);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(51, 21);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbUSB.Location = new System.Drawing.Point(32, 58);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(54, 21);
            this.rbUSB.TabIndex = 1;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbMug.Location = new System.Drawing.Point(33, 36);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(53, 21);
            this.rbMug.TabIndex = 0;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // btnSubmitForm
            // 
            this.btnSubmitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmitForm.Location = new System.Drawing.Point(206, 305);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitForm.TabIndex = 6;
            this.btnSubmitForm.Text = "Submit";
            this.btnSubmitForm.UseVisualStyleBackColor = true;
            this.btnSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearForm.Location = new System.Drawing.Point(346, 305);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(93, 23);
            this.btnClearForm.TabIndex = 7;
            this.btnClearForm.Text = "Clear form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // txbEngrave
            // 
            this.txbEngrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbEngrave.Location = new System.Drawing.Point(277, 238);
            this.txbEngrave.Name = "txbEngrave";
            this.txbEngrave.Size = new System.Drawing.Size(302, 23);
            this.txbEngrave.TabIndex = 8;
            // 
            // lblEngrave
            // 
            this.lblEngrave.AutoSize = true;
            this.lblEngrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEngrave.Location = new System.Drawing.Point(64, 238);
            this.lblEngrave.Name = "lblEngrave";
            this.lblEngrave.Size = new System.Drawing.Size(189, 17);
            this.lblEngrave.TabIndex = 9;
            this.lblEngrave.Text = "Text to engrave the item with";
            // 
            // cbLogo
            // 
            this.cbLogo.AutoSize = true;
            this.cbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbLogo.Location = new System.Drawing.Point(94, 154);
            this.cbLogo.Name = "cbLogo";
            this.cbLogo.Size = new System.Drawing.Size(162, 21);
            this.cbLogo.TabIndex = 10;
            this.cbLogo.Text = "Would you like a logo";
            this.cbLogo.UseVisualStyleBackColor = true;
            // 
            // txbNumberOfColor
            // 
            this.txbNumberOfColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNumberOfColor.Location = new System.Drawing.Point(181, 108);
            this.txbNumberOfColor.Name = "txbNumberOfColor";
            this.txbNumberOfColor.Size = new System.Drawing.Size(100, 23);
            this.txbNumberOfColor.TabIndex = 11;
            // 
            // lblNumberOfColors
            // 
            this.lblNumberOfColors.AutoSize = true;
            this.lblNumberOfColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberOfColors.Location = new System.Drawing.Point(55, 108);
            this.lblNumberOfColors.Name = "lblNumberOfColors";
            this.lblNumberOfColors.Size = new System.Drawing.Size(116, 17);
            this.lblNumberOfColors.TabIndex = 12;
            this.lblNumberOfColors.Text = "Number of colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberOfColors);
            this.Controls.Add(this.txbNumberOfColor);
            this.Controls.Add(this.cbLogo);
            this.Controls.Add(this.lblEngrave);
            this.Controls.Add(this.txbEngrave);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnSubmitForm);
            this.Controls.Add(this.gbItemType);
            this.Controls.Add(this.txbNumberOfItems);
            this.Controls.Add(this.txbOrderNumber);
            this.Controls.Add(this.lblNumberOfItems);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.txbResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbItemType.ResumeLayout(false);
            this.gbItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblNumberOfItems;
        private System.Windows.Forms.TextBox txbOrderNumber;
        private System.Windows.Forms.TextBox txbNumberOfItems;
        private System.Windows.Forms.GroupBox gbItemType;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbUSB;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.Button btnSubmitForm;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.TextBox txbEngrave;
        private System.Windows.Forms.Label lblEngrave;
        private System.Windows.Forms.CheckBox cbLogo;
        private System.Windows.Forms.TextBox txbNumberOfColor;
        private System.Windows.Forms.Label lblNumberOfColors;
    }
}

