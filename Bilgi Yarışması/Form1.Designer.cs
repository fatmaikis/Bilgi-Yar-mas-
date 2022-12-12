namespace Bilgi_Yarışması
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbtn = new System.Windows.Forms.Button();
            this.cbtn = new System.Windows.Forms.Button();
            this.bbtn = new System.Windows.Forms.Button();
            this.abtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dogrulbl = new System.Windows.Forms.Label();
            this.yanlislbl = new System.Windows.Forms.Label();
            this.baslatbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbtn);
            this.panel1.Controls.Add(this.cbtn);
            this.panel1.Controls.Add(this.bbtn);
            this.panel1.Controls.Add(this.abtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 219);
            this.panel1.TabIndex = 0;
            // 
            // dbtn
            // 
            this.dbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.dbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn.Location = new System.Drawing.Point(385, 157);
            this.dbtn.Name = "dbtn";
            this.dbtn.Size = new System.Drawing.Size(219, 49);
            this.dbtn.TabIndex = 5;
            this.dbtn.Text = "D";
            this.dbtn.UseVisualStyleBackColor = false;
            this.dbtn.Click += new System.EventHandler(this.DortButon);
            // 
            // cbtn
            // 
            this.cbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbtn.Location = new System.Drawing.Point(15, 157);
            this.cbtn.Name = "cbtn";
            this.cbtn.Size = new System.Drawing.Size(215, 49);
            this.cbtn.TabIndex = 4;
            this.cbtn.Text = "C";
            this.cbtn.UseVisualStyleBackColor = false;
            this.cbtn.Click += new System.EventHandler(this.DortButon);
            // 
            // bbtn
            // 
            this.bbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.bbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bbtn.Location = new System.Drawing.Point(385, 90);
            this.bbtn.Name = "bbtn";
            this.bbtn.Size = new System.Drawing.Size(219, 52);
            this.bbtn.TabIndex = 3;
            this.bbtn.Text = "B";
            this.bbtn.UseVisualStyleBackColor = false;
            this.bbtn.Click += new System.EventHandler(this.DortButon);
            // 
            // abtn
            // 
            this.abtn.BackColor = System.Drawing.Color.SkyBlue;
            this.abtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.abtn.Location = new System.Drawing.Point(15, 90);
            this.abtn.Name = "abtn";
            this.abtn.Size = new System.Drawing.Size(215, 52);
            this.abtn.TabIndex = 2;
            this.abtn.Text = "A";
            this.abtn.UseVisualStyleBackColor = false;
            this.abtn.Click += new System.EventHandler(this.DortButon);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dogrulbl);
            this.panel2.Controls.Add(this.yanlislbl);
            this.panel2.Location = new System.Drawing.Point(18, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 158);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // dogrulbl
            // 
            this.dogrulbl.AutoSize = true;
            this.dogrulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulbl.Location = new System.Drawing.Point(25, 22);
            this.dogrulbl.Name = "dogrulbl";
            this.dogrulbl.Size = new System.Drawing.Size(76, 25);
            this.dogrulbl.TabIndex = 3;
            this.dogrulbl.Text = "Doğru :";
            // 
            // yanlislbl
            // 
            this.yanlislbl.AutoSize = true;
            this.yanlislbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlislbl.Location = new System.Drawing.Point(25, 64);
            this.yanlislbl.Name = "yanlislbl";
            this.yanlislbl.Size = new System.Drawing.Size(81, 25);
            this.yanlislbl.TabIndex = 2;
            this.yanlislbl.Text = "Yanlış : ";
            // 
            // baslatbtn
            // 
            this.baslatbtn.BackColor = System.Drawing.Color.SeaShell;
            this.baslatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatbtn.Location = new System.Drawing.Point(261, 275);
            this.baslatbtn.Name = "baslatbtn";
            this.baslatbtn.Size = new System.Drawing.Size(231, 57);
            this.baslatbtn.TabIndex = 2;
            this.baslatbtn.Text = "Başlat";
            this.baslatbtn.UseVisualStyleBackColor = false;
            this.baslatbtn.Click += new System.EventHandler(this.baslatbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(783, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(701, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Süre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(579, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.baslatbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dbtn;
        private System.Windows.Forms.Button cbtn;
        private System.Windows.Forms.Button bbtn;
        private System.Windows.Forms.Button abtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button baslatbtn;
        private System.Windows.Forms.Label dogrulbl;
        private System.Windows.Forms.Label yanlislbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

