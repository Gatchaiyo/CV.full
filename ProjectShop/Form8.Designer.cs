
namespace ProjectShop
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.backBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showdataseed = new System.Windows.Forms.DataGridView();
            this.userbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.animalbut = new System.Windows.Forms.RadioButton();
            this.seedbut = new System.Windows.Forms.RadioButton();
            this.Amountbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdataseed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(12, 642);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(139, 57);
            this.backBut.TabIndex = 32;
            this.backBut.Text = "🔙กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // addBut
            // 
            this.addBut.BackColor = System.Drawing.Color.Chartreuse;
            this.addBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(860, 565);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(231, 70);
            this.addBut.TabIndex = 29;
            this.addBut.Text = "เพิ่มสินค้าลงในตะกร้า";
            this.addBut.UseVisualStyleBackColor = false;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(838, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "กรุณาใส่จำนวนสินค้าที่ต้องการ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(833, 490);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(297, 43);
            this.numberBox.TabIndex = 24;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(460, 478);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(320, 43);
            this.nameBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "ราคาสินค้า/1ชิ้น";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(460, 572);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(320, 43);
            this.priceBox.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(631, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // showdataseed
            // 
            this.showdataseed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataseed.Location = new System.Drawing.Point(10, 41);
            this.showdataseed.Name = "showdataseed";
            this.showdataseed.RowHeadersWidth = 51;
            this.showdataseed.RowTemplate.Height = 24;
            this.showdataseed.Size = new System.Drawing.Size(617, 352);
            this.showdataseed.TabIndex = 36;
            this.showdataseed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdataseed_CellContentClick);
            this.showdataseed.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.showdataseed_DataError);
            // 
            // userbox
            // 
            this.userbox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(1094, 2);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(155, 35);
            this.userbox.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.animalbut);
            this.groupBox1.Controls.Add(this.seedbut);
            this.groupBox1.Location = new System.Drawing.Point(136, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 171);
            this.groupBox1.TabIndex = 69;
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
            this.seedbut.Text = "เมล็ดพืช🥭";
            this.seedbut.UseVisualStyleBackColor = true;
            this.seedbut.CheckedChanged += new System.EventHandler(this.seedbut_CheckedChanged);
            // 
            // Amountbox
            // 
            this.Amountbox.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountbox.Location = new System.Drawing.Point(463, 654);
            this.Amountbox.Name = "Amountbox";
            this.Amountbox.Size = new System.Drawing.Size(316, 39);
            this.Amountbox.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 34);
            this.label4.TabIndex = 71;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 719);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Amountbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.showdataseed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form8";
            this.Text = "เลือกซื้อเมล็ดพันธุ์";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdataseed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView showdataseed;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton animalbut;
        private System.Windows.Forms.RadioButton seedbut;
        private System.Windows.Forms.TextBox Amountbox;
        private System.Windows.Forms.Label label4;
    }
}