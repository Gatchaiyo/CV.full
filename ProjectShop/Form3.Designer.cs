
namespace ProjectShop
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seedBut = new System.Windows.Forms.Button();
            this.animalBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.userbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "กรุณาเลือกหมวดหมู่ที่ต้องการแก้ไข";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "เมนูสำหรับผู้ให้บริการ";
            // 
            // seedBut
            // 
            this.seedBut.BackColor = System.Drawing.Color.PaleGreen;
            this.seedBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedBut.Location = new System.Drawing.Point(368, 255);
            this.seedBut.Name = "seedBut";
            this.seedBut.Size = new System.Drawing.Size(253, 55);
            this.seedBut.TabIndex = 3;
            this.seedBut.Text = "แก้ไขสินค้าในร้าน🥭";
            this.seedBut.UseVisualStyleBackColor = false;
            this.seedBut.Click += new System.EventHandler(this.seedBut_Click);
            // 
            // animalBut
            // 
            this.animalBut.BackColor = System.Drawing.Color.Pink;
            this.animalBut.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalBut.Location = new System.Drawing.Point(368, 353);
            this.animalBut.Name = "animalBut";
            this.animalBut.Size = new System.Drawing.Size(253, 54);
            this.animalBut.TabIndex = 4;
            this.animalBut.Text = "ค้นหาสินค้า🐾";
            this.animalBut.UseVisualStyleBackColor = false;
            this.animalBut.Click += new System.EventHandler(this.animalBut_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBut.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBut.Location = new System.Drawing.Point(47, 569);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(156, 57);
            this.backBut.TabIndex = 5;
            this.backBut.Text = "🔙กลับ";
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.LightSalmon;
            this.history.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(368, 453);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(253, 54);
            this.history.TabIndex = 6;
            this.history.Text = "💾ประวัติการขาย💾";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // userbox
            // 
            this.userbox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbox.Location = new System.Drawing.Point(853, 39);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(141, 35);
            this.userbox.TabIndex = 70;
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 670);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.history);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.animalBut);
            this.Controls.Add(this.seedBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Adminpage";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seedBut;
        private System.Windows.Forms.Button animalBut;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.TextBox userbox;
    }
}