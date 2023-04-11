
namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtKonu = new System.Windows.Forms.TextBox();
            this.TxtMesaj = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(135, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(128, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(128, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj:";
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtMail.Location = new System.Drawing.Point(180, 143);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(220, 24);
            this.TxtMail.TabIndex = 3;
            // 
            // TxtKonu
            // 
            this.TxtKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtKonu.Location = new System.Drawing.Point(180, 173);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Size = new System.Drawing.Size(220, 24);
            this.TxtKonu.TabIndex = 4;
            // 
            // TxtMesaj
            // 
            this.TxtMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtMesaj.Location = new System.Drawing.Point(180, 203);
            this.TxtMesaj.Name = "TxtMesaj";
            this.TxtMesaj.Size = new System.Drawing.Size(220, 228);
            this.TxtMesaj.TabIndex = 5;
            this.TxtMesaj.Text = "";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::Ticari_Otomasyon.Properties.Resources.mail_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(180, 437);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(220, 30);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 113);
            this.panel1.TabIndex = 7;
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TxtMesaj);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMail";
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKonu;
        private System.Windows.Forms.RichTextBox TxtMesaj;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
    }
}