
namespace Ticari_Otomasyon
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmbTown = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RchTxtAddress = new System.Windows.Forms.RichTextBox();
            this.MskTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtLastname = new DevExpress.XtraEditors.TextEdit();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TaskRchTxt = new System.Windows.Forms.RichTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1618, 882);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // CmbTown
            // 
            this.CmbTown.Location = new System.Drawing.Point(96, 244);
            this.CmbTown.Name = "CmbTown";
            this.CmbTown.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.CmbTown.Properties.Appearance.Options.UseFont = true;
            this.CmbTown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbTown.Size = new System.Drawing.Size(165, 24);
            this.CmbTown.TabIndex = 8;
            // 
            // CmbCity
            // 
            this.CmbCity.Location = new System.Drawing.Point(96, 214);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.CmbCity.Properties.Appearance.Options.UseFont = true;
            this.CmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbCity.Properties.SelectedIndexChanged += new System.EventHandler(this.CmbCity_Properties_SelectedIndexChanged);
            this.CmbCity.Size = new System.Drawing.Size(165, 24);
            this.CmbCity.TabIndex = 7;
            // 
            // RchTxtAddress
            // 
            this.RchTxtAddress.Location = new System.Drawing.Point(96, 274);
            this.RchTxtAddress.Name = "RchTxtAddress";
            this.RchTxtAddress.Size = new System.Drawing.Size(165, 96);
            this.RchTxtAddress.TabIndex = 10;
            this.RchTxtAddress.Text = "";
            // 
            // MskTxtTC
            // 
            this.MskTxtTC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTxtTC.Location = new System.Drawing.Point(96, 154);
            this.MskTxtTC.Mask = "00000000000";
            this.MskTxtTC.Name = "MskTxtTC";
            this.MskTxtTC.Size = new System.Drawing.Size(165, 25);
            this.MskTxtTC.TabIndex = 5;
            this.MskTxtTC.ValidatingType = typeof(int);
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
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(96, 184);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(165, 24);
            this.TxtMail.TabIndex = 6;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(96, 89);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtLastname.Properties.Appearance.Options.UseFont = true;
            this.TxtLastname.Size = new System.Drawing.Size(165, 24);
            this.TxtLastname.TabIndex = 2;
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
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(48, 273);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 18);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Adres:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(96, 651);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(165, 45);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(96, 598);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(165, 45);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(96, 547);
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
            this.labelControl9.Location = new System.Drawing.Point(62, 247);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(54, 217);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Şehir:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(61, 187);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Mail:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(66, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon:";
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TaskRchTxt);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.CmbTown);
            this.groupControl1.Controls.Add(this.CmbCity);
            this.groupControl1.Controls.Add(this.RchTxtAddress);
            this.groupControl1.Controls.Add(this.MskTxtTC);
            this.groupControl1.Controls.Add(this.MskTxtPhone);
            this.groupControl1.Controls.Add(this.TxtMail);
            this.groupControl1.Controls.Add(this.TxtLastname);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.BtnUpdate);
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.BtnSave);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1618, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(286, 882);
            this.groupControl1.TabIndex = 7;
            // 
            // TaskRchTxt
            // 
            this.TaskRchTxt.Location = new System.Drawing.Point(96, 376);
            this.TaskRchTxt.Name = "TaskRchTxt";
            this.TaskRchTxt.Size = new System.Drawing.Size(165, 123);
            this.TaskRchTxt.TabIndex = 11;
            this.TaskRchTxt.Text = "";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(62, 375);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(28, 18);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "Not:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::Ticari_Otomasyon.Properties.Resources.clearall;
            this.simpleButton1.Location = new System.Drawing.Point(96, 702);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(165, 45);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Temizle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 881);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbTown;
        private DevExpress.XtraEditors.ComboBoxEdit CmbCity;
        private System.Windows.Forms.RichTextBox RchTxtAddress;
        private System.Windows.Forms.MaskedTextBox MskTxtTC;
        private System.Windows.Forms.MaskedTextBox MskTxtPhone;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtLastname;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox TaskRchTxt;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}