namespace ram_temizleme
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            fizikselBellek = new GroupBox();
            lblToplam = new Label();
            lblKullanılabilir = new Label();
            lblKullanılan = new Label();
            fizikselToplam = new Label();
            fizikselKullanılabilir = new Label();
            fizikselKullanılan = new Label();
            sanalBellek = new GroupBox();
            lblSanalToplam = new Label();
            lblSanalKullanılabilir = new Label();
            lblSanalKullanılan = new Label();
            sanalToplam = new Label();
            sanalKullanılabilir = new Label();
            sanalKullanilan = new Label();
            btnTemizle = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            fizikselBellek.SuspendLayout();
            sanalBellek.SuspendLayout();
            SuspendLayout();
            // 
            // fizikselBellek
            // 
            fizikselBellek.Controls.Add(lblToplam);
            fizikselBellek.Controls.Add(lblKullanılabilir);
            fizikselBellek.Controls.Add(lblKullanılan);
            fizikselBellek.Controls.Add(fizikselToplam);
            fizikselBellek.Controls.Add(fizikselKullanılabilir);
            fizikselBellek.Controls.Add(fizikselKullanılan);
            fizikselBellek.Location = new Point(89, 25);
            fizikselBellek.Name = "fizikselBellek";
            fizikselBellek.Size = new Size(250, 143);
            fizikselBellek.TabIndex = 0;
            fizikselBellek.TabStop = false;
            fizikselBellek.Text = "Fiziksel Bellek";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(148, 111);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(0, 20);
            lblToplam.TabIndex = 5;
            // 
            // lblKullanılabilir
            // 
            lblKullanılabilir.AutoSize = true;
            lblKullanılabilir.Location = new Point(148, 75);
            lblKullanılabilir.Name = "lblKullanılabilir";
            lblKullanılabilir.Size = new Size(0, 20);
            lblKullanılabilir.TabIndex = 4;
            // 
            // lblKullanılan
            // 
            lblKullanılan.AutoSize = true;
            lblKullanılan.Location = new Point(148, 36);
            lblKullanılan.Name = "lblKullanılan";
            lblKullanılan.Size = new Size(0, 20);
            lblKullanılan.TabIndex = 3;
            // 
            // fizikselToplam
            // 
            fizikselToplam.AutoSize = true;
            fizikselToplam.Location = new Point(23, 111);
            fizikselToplam.Name = "fizikselToplam";
            fizikselToplam.Size = new Size(59, 20);
            fizikselToplam.TabIndex = 2;
            fizikselToplam.Text = "Toplam";
            // 
            // fizikselKullanılabilir
            // 
            fizikselKullanılabilir.AutoSize = true;
            fizikselKullanılabilir.Location = new Point(23, 75);
            fizikselKullanılabilir.Name = "fizikselKullanılabilir";
            fizikselKullanılabilir.Size = new Size(92, 20);
            fizikselKullanılabilir.TabIndex = 1;
            fizikselKullanılabilir.Text = "Kullanılabilir";
            // 
            // fizikselKullanılan
            // 
            fizikselKullanılan.AutoSize = true;
            fizikselKullanılan.Location = new Point(26, 36);
            fizikselKullanılan.Name = "fizikselKullanılan";
            fizikselKullanılan.Size = new Size(74, 20);
            fizikselKullanılan.TabIndex = 0;
            fizikselKullanılan.Text = "Kullanılan";
            // 
            // sanalBellek
            // 
            sanalBellek.Controls.Add(lblSanalToplam);
            sanalBellek.Controls.Add(lblSanalKullanılabilir);
            sanalBellek.Controls.Add(lblSanalKullanılan);
            sanalBellek.Controls.Add(sanalToplam);
            sanalBellek.Controls.Add(sanalKullanılabilir);
            sanalBellek.Controls.Add(sanalKullanilan);
            sanalBellek.Location = new Point(89, 198);
            sanalBellek.Name = "sanalBellek";
            sanalBellek.Size = new Size(250, 149);
            sanalBellek.TabIndex = 1;
            sanalBellek.TabStop = false;
            sanalBellek.Text = "Sanal Bellek";
            // 
            // lblSanalToplam
            // 
            lblSanalToplam.AutoSize = true;
            lblSanalToplam.Location = new Point(148, 110);
            lblSanalToplam.Name = "lblSanalToplam";
            lblSanalToplam.Size = new Size(0, 20);
            lblSanalToplam.TabIndex = 5;
            // 
            // lblSanalKullanılabilir
            // 
            lblSanalKullanılabilir.AutoSize = true;
            lblSanalKullanılabilir.Location = new Point(148, 72);
            lblSanalKullanılabilir.Name = "lblSanalKullanılabilir";
            lblSanalKullanılabilir.Size = new Size(0, 20);
            lblSanalKullanılabilir.TabIndex = 4;
            // 
            // lblSanalKullanılan
            // 
            lblSanalKullanılan.AutoSize = true;
            lblSanalKullanılan.Location = new Point(148, 32);
            lblSanalKullanılan.Name = "lblSanalKullanılan";
            lblSanalKullanılan.Size = new Size(0, 20);
            lblSanalKullanılan.TabIndex = 3;
            // 
            // sanalToplam
            // 
            sanalToplam.AutoSize = true;
            sanalToplam.Location = new Point(26, 110);
            sanalToplam.Name = "sanalToplam";
            sanalToplam.Size = new Size(59, 20);
            sanalToplam.TabIndex = 2;
            sanalToplam.Text = "Toplam";
            // 
            // sanalKullanılabilir
            // 
            sanalKullanılabilir.AutoSize = true;
            sanalKullanılabilir.Location = new Point(26, 72);
            sanalKullanılabilir.Name = "sanalKullanılabilir";
            sanalKullanılabilir.Size = new Size(92, 20);
            sanalKullanılabilir.TabIndex = 1;
            sanalKullanılabilir.Text = "Kullanılabilir";
            // 
            // sanalKullanilan
            // 
            sanalKullanilan.AutoSize = true;
            sanalKullanilan.Location = new Point(26, 32);
            sanalKullanilan.Name = "sanalKullanilan";
            sanalKullanilan.Size = new Size(74, 20);
            sanalKullanilan.TabIndex = 0;
            sanalKullanilan.Text = "Kullanılan";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(89, 369);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(250, 29);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Enabled = true;
            timer5.Interval = 1000;
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Enabled = true;
            timer6.Interval = 1000;
            timer6.Tick += timer6_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 426);
            Controls.Add(btnTemizle);
            Controls.Add(sanalBellek);
            Controls.Add(fizikselBellek);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Memory Cleaner";
            fizikselBellek.ResumeLayout(false);
            fizikselBellek.PerformLayout();
            sanalBellek.ResumeLayout(false);
            sanalBellek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox fizikselBellek;
        private Label fizikselToplam;
        private Label fizikselKullanılabilir;
        private Label fizikselKullanılan;
        private GroupBox sanalBellek;
        private Button btnTemizle;
        private Label sanalToplam;
        private Label sanalKullanılabilir;
        private Label sanalKullanilan;
        private Label lblKullanılan;
        private System.Windows.Forms.Timer timer1;
        private Label lblKullanılabilir;
        private System.Windows.Forms.Timer timer2;
        private Label lblToplam;
        private System.Windows.Forms.Timer timer3;
        private Label lblSanalToplam;
        private Label lblSanalKullanılabilir;
        private Label lblSanalKullanılan;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}
