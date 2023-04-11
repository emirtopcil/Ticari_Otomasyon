
namespace Ticari_Otomasyon
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RchTxtAddress = new System.Windows.Forms.RichTextBox();
            this.MskTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtVergiDaire = new DevExpress.XtraEditors.TextEdit();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtSurname = new DevExpress.XtraEditors.TextEdit();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LblClear = new System.Windows.Forms.LinkLabel();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(96, 272);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEdit2.TabIndex = 8;
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(96, 242);
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.comboBoxEdit4.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Size = new System.Drawing.Size(165, 24);
            this.comboBoxEdit4.TabIndex = 7;
            this.comboBoxEdit4.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit4_SelectedIndexChanged);
            // 
            // RchTxtAddress
            // 
            this.RchTxtAddress.Location = new System.Drawing.Point(96, 330);
            this.RchTxtAddress.Name = "RchTxtAddress";
            this.RchTxtAddress.Size = new System.Drawing.Size(165, 96);
            this.RchTxtAddress.TabIndex = 10;
            this.RchTxtAddress.Text = "";
            // 
            // MskTxtTC
            // 
            this.MskTxtTC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTxtTC.Location = new System.Drawing.Point(96, 182);
            this.MskTxtTC.Mask = "00000000000";
            this.MskTxtTC.Name = "MskTxtTC";
            this.MskTxtTC.Size = new System.Drawing.Size(165, 25);
            this.MskTxtTC.TabIndex = 5;
            this.MskTxtTC.ValidatingType = typeof(int);
            // 
            // MskTxtPhone2
            // 
            this.MskTxtPhone2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTxtPhone2.Location = new System.Drawing.Point(96, 152);
            this.MskTxtPhone2.Mask = "(999) 000-0000";
            this.MskTxtPhone2.Name = "MskTxtPhone2";
            this.MskTxtPhone2.Size = new System.Drawing.Size(165, 25);
            this.MskTxtPhone2.TabIndex = 4;
            // 
            // MskTxtPhone
            // 
            this.MskTxtPhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTxtPhone.Location = new System.Drawing.Point(96, 122);
            this.MskTxtPhone.Mask = "(999) 000-0000";
            this.MskTxtPhone.Name = "MskTxtPhone";
            this.MskTxtPhone.Size = new System.Drawing.Size(165, 25);
            this.MskTxtPhone.TabIndex = 3;
            // 
            // TxtVergiDaire
            // 
            this.TxtVergiDaire.Location = new System.Drawing.Point(96, 302);
            this.TxtVergiDaire.Name = "TxtVergiDaire";
            this.TxtVergiDaire.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtVergiDaire.Properties.Appearance.Options.UseFont = true;
            this.TxtVergiDaire.Size = new System.Drawing.Size(165, 24);
            this.TxtVergiDaire.TabIndex = 9;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(96, 212);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(165, 24);
            this.TxtMail.TabIndex = 6;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(96, 89);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSurname.Properties.Appearance.Options.UseFont = true;
            this.TxtSurname.Size = new System.Drawing.Size(165, 24);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(96, 59);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(165, 24);
            this.TxtName.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(96, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(165, 24);
            this.TxtID.TabIndex = 24;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(6, 305);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(84, 18);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Vergi Dairesi:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEdit2);
            this.groupControl1.Controls.Add(this.comboBoxEdit4);
            this.groupControl1.Controls.Add(this.RchTxtAddress);
            this.groupControl1.Controls.Add(this.MskTxtTC);
            this.groupControl1.Controls.Add(this.MskTxtPhone2);
            this.groupControl1.Controls.Add(this.MskTxtPhone);
            this.groupControl1.Controls.Add(this.TxtVergiDaire);
            this.groupControl1.Controls.Add(this.TxtMail);
            this.groupControl1.Controls.Add(this.TxtSurname);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.LblClear);
            this.groupControl1.Controls.Add(this.BtnUpdate);
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1617, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(286, 882);
            this.groupControl1.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(48, 329);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 18);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Adres:";
            // 
            // LblClear
            // 
            this.LblClear.AutoSize = true;
            this.LblClear.LinkColor = System.Drawing.Color.Black;
            this.LblClear.Location = new System.Drawing.Point(12, 559);
            this.LblClear.Name = "LblClear";
            this.LblClear.Size = new System.Drawing.Size(42, 13);
            this.LblClear.TabIndex = 21;
            this.LblClear.TabStop = true;
            this.LblClear.Text = "Temizle";
            this.LblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblClear_LinkClicked);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(96, 543);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(165, 45);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(96, 490);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(165, 45);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(96, 439);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(165, 45);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(62, 275);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(54, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Şehir:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(61, 215);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(66, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Telefon 2:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon 1:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Soyad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1618, 882);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 881);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit4;
        private System.Windows.Forms.RichTextBox RchTxtAddress;
        private System.Windows.Forms.MaskedTextBox MskTxtTC;
        private System.Windows.Forms.MaskedTextBox MskTxtPhone2;
        private System.Windows.Forms.MaskedTextBox MskTxtPhone;
        private DevExpress.XtraEditors.TextEdit TxtVergiDaire;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtSurname;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.LinkLabel LblClear;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}