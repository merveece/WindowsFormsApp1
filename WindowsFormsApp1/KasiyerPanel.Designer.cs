
namespace WindowsFormsApp1
{
    partial class KasiyerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btn_sebzemeyve = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.ImageKey = "et.ico";
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(45, 34);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(135, 141);
            this.btn_et.TabIndex = 0;
            this.btn_et.Text = "Et";
            this.btn_et.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // btn_sut
            // 
            this.btn_sut.ImageIndex = 3;
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(206, 34);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(132, 141);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.Text = "Süt";
            this.btn_sut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sut.UseVisualStyleBackColor = true;
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.ImageIndex = 0;
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(45, 198);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(135, 139);
            this.btn_baklagil.TabIndex = 2;
            this.btn_baklagil.Text = "B:aklagil";
            this.btn_baklagil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_baklagil.UseVisualStyleBackColor = true;
            // 
            // btn_sebzemeyve
            // 
            this.btn_sebzemeyve.ImageKey = "meyveAndsebze.ico";
            this.btn_sebzemeyve.ImageList = this.ımageList1;
            this.btn_sebzemeyve.Location = new System.Drawing.Point(206, 198);
            this.btn_sebzemeyve.Name = "btn_sebzemeyve";
            this.btn_sebzemeyve.Size = new System.Drawing.Size(132, 139);
            this.btn_sebzemeyve.TabIndex = 3;
            this.btn_sebzemeyve.Text = "Sebze Ve Meyve";
            this.btn_sebzemeyve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sebzemeyve.UseVisualStyleBackColor = true;
            this.btn_sebzemeyve.Click += new System.EventHandler(this.btn_sebzemeyve_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "baklagil.ico");
            this.ımageList1.Images.SetKeyName(1, "et.ico");
            this.ımageList1.Images.SetKeyName(2, "meyveAndsebze.ico");
            this.ımageList1.Images.SetKeyName(3, "süt.ico");
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(32, 375);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(87, 35);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 458);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sebzemeyve);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasiyerPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_sebzemeyve;
        private System.Windows.Forms.Button btn_cikis;
    }
}