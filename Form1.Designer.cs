namespace erettsegi_20241128
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
            this.dtvtablazat = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magyar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idegennyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoismeretek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbinfoatlag = new System.Windows.Forms.Label();
            this.lblegjobb = new System.Windows.Forms.Label();
            this.chbujeredmeny = new System.Windows.Forms.CheckBox();
            this.lbnev = new System.Windows.Forms.Label();
            this.lbmagyar = new System.Windows.Forms.Label();
            this.lbmatek = new System.Windows.Forms.Label();
            this.lbtori = new System.Windows.Forms.Label();
            this.lbnyelv = new System.Windows.Forms.Label();
            this.lbinfo = new System.Windows.Forms.Label();
            this.cbinfo = new System.Windows.Forms.ComboBox();
            this.cbidegennyelv = new System.Windows.Forms.ComboBox();
            this.cbtori = new System.Windows.Forms.ComboBox();
            this.cbmatek = new System.Windows.Forms.ComboBox();
            this.cbmagyar = new System.Windows.Forms.ComboBox();
            this.txnev = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvtablazat)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvtablazat
            // 
            this.dtvtablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvtablazat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.magyar,
            this.matek,
            this.idegennyelv,
            this.infoismeretek});
            this.dtvtablazat.Location = new System.Drawing.Point(13, 13);
            this.dtvtablazat.Name = "dtvtablazat";
            this.dtvtablazat.Size = new System.Drawing.Size(568, 313);
            this.dtvtablazat.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // magyar
            // 
            this.magyar.HeaderText = "Magyar";
            this.magyar.Name = "magyar";
            this.magyar.ReadOnly = true;
            // 
            // matek
            // 
            this.matek.HeaderText = "Matematika";
            this.matek.Name = "matek";
            this.matek.ReadOnly = true;
            // 
            // idegennyelv
            // 
            this.idegennyelv.HeaderText = "Idegeny nyelv";
            this.idegennyelv.Name = "idegennyelv";
            this.idegennyelv.ReadOnly = true;
            // 
            // infoismeretek
            // 
            this.infoismeretek.HeaderText = "Informatikai ismeretek";
            this.infoismeretek.Name = "infoismeretek";
            this.infoismeretek.ReadOnly = true;
            // 
            // lbinfoatlag
            // 
            this.lbinfoatlag.AutoSize = true;
            this.lbinfoatlag.Location = new System.Drawing.Point(10, 412);
            this.lbinfoatlag.Name = "lbinfoatlag";
            this.lbinfoatlag.Size = new System.Drawing.Size(175, 13);
            this.lbinfoatlag.TabIndex = 1;
            this.lbinfoatlag.Text = "Informatika ismeretek átlaga: ";
            // 
            // lblegjobb
            // 
            this.lblegjobb.AutoSize = true;
            this.lblegjobb.Location = new System.Drawing.Point(10, 375);
            this.lblegjobb.Name = "lblegjobb";
            this.lblegjobb.Size = new System.Drawing.Size(138, 13);
            this.lblegjobb.TabIndex = 2;
            this.lblegjobb.Text = "Legjobb átlagú tanuló: ";
            // 
            // chbujeredmeny
            // 
            this.chbujeredmeny.AutoSize = true;
            this.chbujeredmeny.Location = new System.Drawing.Point(598, 13);
            this.chbujeredmeny.Name = "chbujeredmeny";
            this.chbujeredmeny.Size = new System.Drawing.Size(167, 17);
            this.chbujeredmeny.TabIndex = 3;
            this.chbujeredmeny.Text = "Új eredmények rögzítése";
            this.chbujeredmeny.UseVisualStyleBackColor = true;
            this.chbujeredmeny.CheckedChanged += new System.EventHandler(this.chbujeredmeny_CheckedChanged);
            // 
            // lbnev
            // 
            this.lbnev.AutoSize = true;
            this.lbnev.Location = new System.Drawing.Point(619, 62);
            this.lbnev.Name = "lbnev";
            this.lbnev.Size = new System.Drawing.Size(38, 13);
            this.lbnev.TabIndex = 4;
            this.lbnev.Text = "Név: ";
            this.lbnev.Visible = false;
            // 
            // lbmagyar
            // 
            this.lbmagyar.AutoSize = true;
            this.lbmagyar.Location = new System.Drawing.Point(619, 93);
            this.lbmagyar.Name = "lbmagyar";
            this.lbmagyar.Size = new System.Drawing.Size(56, 13);
            this.lbmagyar.TabIndex = 5;
            this.lbmagyar.Text = "Magyar: ";
            this.lbmagyar.Visible = false;
            // 
            // lbmatek
            // 
            this.lbmatek.AutoSize = true;
            this.lbmatek.Location = new System.Drawing.Point(619, 127);
            this.lbmatek.Name = "lbmatek";
            this.lbmatek.Size = new System.Drawing.Size(76, 13);
            this.lbmatek.TabIndex = 6;
            this.lbmatek.Text = "Matematika:";
            this.lbmatek.Visible = false;
            // 
            // lbtori
            // 
            this.lbtori.AutoSize = true;
            this.lbtori.Location = new System.Drawing.Point(619, 162);
            this.lbtori.Name = "lbtori";
            this.lbtori.Size = new System.Drawing.Size(74, 13);
            this.lbtori.TabIndex = 7;
            this.lbtori.Text = "Történelem:";
            this.lbtori.Visible = false;
            // 
            // lbnyelv
            // 
            this.lbnyelv.AutoSize = true;
            this.lbnyelv.Location = new System.Drawing.Point(619, 193);
            this.lbnyelv.Name = "lbnyelv";
            this.lbnyelv.Size = new System.Drawing.Size(84, 13);
            this.lbnyelv.TabIndex = 8;
            this.lbnyelv.Text = "Idegen nyelv:";
            this.lbnyelv.Visible = false;
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Location = new System.Drawing.Point(619, 227);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(136, 13);
            this.lbinfo.TabIndex = 9;
            this.lbinfo.Text = "Informatika ismeretek: ";
            this.lbinfo.Visible = false;
            // 
            // cbinfo
            // 
            this.cbinfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinfo.FormattingEnabled = true;
            this.cbinfo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbinfo.Location = new System.Drawing.Point(761, 224);
            this.cbinfo.Name = "cbinfo";
            this.cbinfo.Size = new System.Drawing.Size(51, 21);
            this.cbinfo.TabIndex = 10;
            this.cbinfo.Visible = false;
            // 
            // cbidegennyelv
            // 
            this.cbidegennyelv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidegennyelv.FormattingEnabled = true;
            this.cbidegennyelv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbidegennyelv.Location = new System.Drawing.Point(709, 190);
            this.cbidegennyelv.Name = "cbidegennyelv";
            this.cbidegennyelv.Size = new System.Drawing.Size(51, 21);
            this.cbidegennyelv.TabIndex = 11;
            this.cbidegennyelv.Visible = false;
            // 
            // cbtori
            // 
            this.cbtori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtori.FormattingEnabled = true;
            this.cbtori.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbtori.Location = new System.Drawing.Point(699, 162);
            this.cbtori.Name = "cbtori";
            this.cbtori.Size = new System.Drawing.Size(51, 21);
            this.cbtori.TabIndex = 12;
            this.cbtori.Visible = false;
            // 
            // cbmatek
            // 
            this.cbmatek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmatek.FormattingEnabled = true;
            this.cbmatek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbmatek.Location = new System.Drawing.Point(699, 127);
            this.cbmatek.Name = "cbmatek";
            this.cbmatek.Size = new System.Drawing.Size(51, 21);
            this.cbmatek.TabIndex = 13;
            this.cbmatek.Visible = false;
            // 
            // cbmagyar
            // 
            this.cbmagyar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmagyar.FormattingEnabled = true;
            this.cbmagyar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbmagyar.Location = new System.Drawing.Point(681, 90);
            this.cbmagyar.Name = "cbmagyar";
            this.cbmagyar.Size = new System.Drawing.Size(51, 21);
            this.cbmagyar.TabIndex = 14;
            this.cbmagyar.Visible = false;
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(660, 59);
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(217, 20);
            this.txnev.TabIndex = 15;
            this.txnev.Visible = false;
            this.txnev.TextChanged += new System.EventHandler(this.txnev_TextChanged);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(642, 268);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(196, 49);
            this.btsave.TabIndex = 16;
            this.btsave.Text = "Adatok mentése";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Visible = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.cbmagyar);
            this.Controls.Add(this.cbmatek);
            this.Controls.Add(this.cbtori);
            this.Controls.Add(this.cbidegennyelv);
            this.Controls.Add(this.cbinfo);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.lbnyelv);
            this.Controls.Add(this.lbtori);
            this.Controls.Add(this.lbmatek);
            this.Controls.Add(this.lbmagyar);
            this.Controls.Add(this.lbnev);
            this.Controls.Add(this.chbujeredmeny);
            this.Controls.Add(this.lblegjobb);
            this.Controls.Add(this.lbinfoatlag);
            this.Controls.Add(this.dtvtablazat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Érettségi eredmények";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvtablazat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvtablazat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn magyar;
        private System.Windows.Forms.DataGridViewTextBoxColumn matek;
        private System.Windows.Forms.DataGridViewTextBoxColumn idegennyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoismeretek;
        private System.Windows.Forms.Label lbinfoatlag;
        private System.Windows.Forms.Label lblegjobb;
        private System.Windows.Forms.CheckBox chbujeredmeny;
        private System.Windows.Forms.Label lbnev;
        private System.Windows.Forms.Label lbmagyar;
        private System.Windows.Forms.Label lbmatek;
        private System.Windows.Forms.Label lbtori;
        private System.Windows.Forms.Label lbnyelv;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.ComboBox cbinfo;
        private System.Windows.Forms.ComboBox cbidegennyelv;
        private System.Windows.Forms.ComboBox cbtori;
        private System.Windows.Forms.ComboBox cbmatek;
        private System.Windows.Forms.ComboBox cbmagyar;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.Button btsave;
    }
}

