namespace SaleCoSystem
{
    partial class frmProductAE
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
            label3 = new Label();
            lblheader = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            lblFooter = new Label();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCode = new TextBox();
            txtDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtQty = new TextBox();
            txtReorder = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label7 = new Label();
            txtDiscount = new TextBox();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(8, 34, 47);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(288, 2);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 31);
            label3.TabIndex = 10;
            label3.Text = "PRODUCT DETAILS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblheader
            // 
            lblheader.BackColor = Color.FromArgb(8, 34, 47);
            lblheader.Dock = DockStyle.Top;
            lblheader.Location = new Point(0, 0);
            lblheader.Margin = new Padding(4, 0, 4, 0);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(736, 37);
            lblheader.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(8, 34, 47);
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(6, 5);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(8, 34, 47);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(704, 13);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(16, 16);
            btnClose.SizeMode = PictureBoxSizeMode.AutoSize;
            btnClose.TabIndex = 11;
            btnClose.TabStop = false;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.FromArgb(248, 186, 15);
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Location = new Point(0, 320);
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(736, 11);
            lblFooter.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 37);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(0, 11, 0, 0);
            lblTitle.Size = new Size(736, 52);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "New Product";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(10, 146, 172);
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(736, 5);
            label1.TabIndex = 15;
            label1.Text = "Line";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 16;
            label2.Text = "Product Code:";
            // 
            // txtCode
            // 
            txtCode.BackColor = SystemColors.Control;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(161, 118);
            txtCode.Margin = new Padding(4, 3, 4, 3);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(157, 29);
            txtCode.TabIndex = 17;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Control;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(161, 159);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(561, 29);
            txtDescription.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 159);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 18;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 201);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 21;
            label5.Text = "Quantity:";
            // 
            // txtQty
            // 
            txtQty.BackColor = SystemColors.Control;
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(161, 198);
            txtQty.Margin = new Padding(4, 3, 4, 3);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(157, 29);
            txtQty.TabIndex = 22;
            txtQty.Text = "0";
            txtQty.TextAlign = HorizontalAlignment.Center;
            // 
            // txtReorder
            // 
            txtReorder.BackColor = SystemColors.Control;
            txtReorder.BorderStyle = BorderStyle.FixedSingle;
            txtReorder.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorder.Location = new Point(511, 197);
            txtReorder.Margin = new Padding(4, 3, 4, 3);
            txtReorder.Name = "txtReorder";
            txtReorder.Size = new Size(61, 29);
            txtReorder.TabIndex = 24;
            txtReorder.Text = "0";
            txtReorder.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 200);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 23;
            label6.Text = "Re-order Level:";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Control;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(161, 236);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(157, 29);
            txtPrice.TabIndex = 26;
            txtPrice.Text = "0.00";
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 239);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 25;
            label7.Text = "Price:";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = SystemColors.Control;
            txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtDiscount.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(511, 235);
            txtDiscount.Margin = new Padding(4, 3, 4, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(61, 29);
            txtDiscount.TabIndex = 28;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(340, 238);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 21);
            label8.TabIndex = 27;
            label8.Text = "Discount Rate (%):";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 165, 166);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(6, 84, 113);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 165, 166);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 145, 171);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(224, 224, 224);
            btnSave.Location = new Point(620, 43);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 42);
            btnSave.TabIndex = 32;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(238, 238, 238);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(6, 84, 113);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(238, 238, 238);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 212, 177);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancel.Location = new Point(514, 43);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 42);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProductAE
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 331);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDiscount);
            Controls.Add(label8);
            Controls.Add(txtPrice);
            Controls.Add(label7);
            Controls.Add(txtReorder);
            Controls.Add(label6);
            Controls.Add(txtQty);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblFooter);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(lblheader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmProductAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductAE";
            Load += frmProductAE_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public Label lblTitle;
    }
}