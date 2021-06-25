
namespace ProjectShop
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.backBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.showdataanimal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.animalbut = new System.Windows.Forms.RadioButton();
            this.seedbut = new System.Windows.Forms.RadioButton();
            this.printbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showdataanimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(2, 594);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(133, 57);
            this.backBut.TabIndex = 21;
            this.backBut.Text = "กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.PaleGreen;
            this.addBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(904, 443);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(116, 43);
            this.addBut.TabIndex = 18;
            this.addBut.Text = "ค้นหา";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(518, 443);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(380, 43);
            this.nameBox.TabIndex = 12;
            // 
            // showdataanimal
            // 
            this.showdataanimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataanimal.Location = new System.Drawing.Point(198, 51);
            this.showdataanimal.Name = "showdataanimal";
            this.showdataanimal.RowHeadersWidth = 51;
            this.showdataanimal.RowTemplate.Height = 24;
            this.showdataanimal.Size = new System.Drawing.Size(901, 326);
            this.showdataanimal.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.animalbut);
            this.groupBox1.Controls.Add(this.seedbut);
            this.groupBox1.Location = new System.Drawing.Point(236, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 171);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(31, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(200, 38);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "แสดงสินค้าทั้งหมด";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "หมวดหมู่";
            // 
            // animalbut
            // 
            this.animalbut.AutoSize = true;
            this.animalbut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalbut.Location = new System.Drawing.Point(31, 127);
            this.animalbut.Name = "animalbut";
            this.animalbut.Size = new System.Drawing.Size(108, 38);
            this.animalbut.TabIndex = 31;
            this.animalbut.TabStop = true;
            this.animalbut.Text = "สัตว์🐾";
            this.animalbut.UseVisualStyleBackColor = true;
            this.animalbut.CheckedChanged += new System.EventHandler(this.animalbut_CheckedChanged);
            // 
            // seedbut
            // 
            this.seedbut.AutoSize = true;
            this.seedbut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedbut.Location = new System.Drawing.Point(31, 83);
            this.seedbut.Name = "seedbut";
            this.seedbut.Size = new System.Drawing.Size(146, 38);
            this.seedbut.TabIndex = 30;
            this.seedbut.TabStop = true;
            this.seedbut.Text = "เมล็ดพืช🥭";
            this.seedbut.UseVisualStyleBackColor = true;
            this.seedbut.CheckedChanged += new System.EventHandler(this.seedbut_CheckedChanged);
            // 
            // printbut
            // 
            this.printbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printbut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbut.Location = new System.Drawing.Point(659, 566);
            this.printbut.Name = "printbut";
            this.printbut.Size = new System.Drawing.Size(132, 52);
            this.printbut.TabIndex = 34;
            this.printbut.Text = "ปริ้น🖨";
            this.printbut.UseVisualStyleBackColor = false;
            this.printbut.Click += new System.EventHandler(this.printbut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "จำนวนสินค้าคงเหลือ";
            // 
            // numberbox
            // 
            this.numberbox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberbox.Location = new System.Drawing.Point(716, 503);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(182, 43);
            this.numberbox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 34);
            this.label3.TabIndex = 37;
            this.label3.Text = "ชิ้น";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1105, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "รีเฟส";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userbox
            // 
            this.userbox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(1096, 12);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(141, 35);
            this.userbox.TabIndex = 71;
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 654);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printbut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.showdataanimal);
            this.Name = "Form5";
            this.Text = "แก้ไขข้อมูลสัตว์";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdataanimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridView showdataanimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton animalbut;
        private System.Windows.Forms.RadioButton seedbut;
        private System.Windows.Forms.Button printbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userbox;
    }
}