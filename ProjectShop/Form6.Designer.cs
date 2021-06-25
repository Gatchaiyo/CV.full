
namespace ProjectShop
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addtobasketBut = new System.Windows.Forms.Button();
            this.showbasketBut = new System.Windows.Forms.Button();
            this.complsBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "เมนูสำหรับลูกค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "กรุณาเลือกเมนูที่ต้องการ";
            // 
            // addtobasketBut
            // 
            this.addtobasketBut.BackColor = System.Drawing.Color.PaleGreen;
            this.addtobasketBut.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtobasketBut.Location = new System.Drawing.Point(349, 280);
            this.addtobasketBut.Name = "addtobasketBut";
            this.addtobasketBut.Size = new System.Drawing.Size(232, 50);
            this.addtobasketBut.TabIndex = 2;
            this.addtobasketBut.Text = "📥เลือกซื้อสินค้า📥";
            this.addtobasketBut.UseVisualStyleBackColor = false;
            this.addtobasketBut.Click += new System.EventHandler(this.addtobasketBut_Click);
            // 
            // showbasketBut
            // 
            this.showbasketBut.BackColor = System.Drawing.Color.Pink;
            this.showbasketBut.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbasketBut.Location = new System.Drawing.Point(349, 367);
            this.showbasketBut.Name = "showbasketBut";
            this.showbasketBut.Size = new System.Drawing.Size(232, 50);
            this.showbasketBut.TabIndex = 3;
            this.showbasketBut.Text = "🛒ตะกร้าสินค้า🛒";
            this.showbasketBut.UseVisualStyleBackColor = false;
            this.showbasketBut.Click += new System.EventHandler(this.showbasketBut_Click);
            // 
            // complsBut
            // 
            this.complsBut.BackColor = System.Drawing.Color.LightSalmon;
            this.complsBut.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complsBut.Location = new System.Drawing.Point(349, 459);
            this.complsBut.Name = "complsBut";
            this.complsBut.Size = new System.Drawing.Size(232, 50);
            this.complsBut.TabIndex = 4;
            this.complsBut.Text = "💸เช็คบิล💸";
            this.complsBut.UseVisualStyleBackColor = false;
            this.complsBut.Click += new System.EventHandler(this.complsBut_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(43, 561);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(129, 54);
            this.backBut.TabIndex = 5;
            this.backBut.Text = "🔙กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // userbox
            // 
            this.userbox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(771, 21);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(141, 35);
            this.userbox.TabIndex = 68;
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 50);
            this.button1.TabIndex = 69;
            this.button1.Text = "💾ประวัติการขาย💾";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(924, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.complsBut);
            this.Controls.Add(this.showbasketBut);
            this.Controls.Add(this.addtobasketBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "เมนูสำหรับลูกค้า";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addtobasketBut;
        private System.Windows.Forms.Button showbasketBut;
        private System.Windows.Forms.Button complsBut;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Button button1;
    }
}