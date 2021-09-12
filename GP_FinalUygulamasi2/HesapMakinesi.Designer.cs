namespace GP_FinalUygulamasi2
{
    partial class HesapMakinesi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapMakinesi));
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIsaret = new System.Windows.Forms.Button();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnTextTemizle = new System.Windows.Forms.Button();
            this.lblKalip1 = new System.Windows.Forms.Label();
            this.lblKalip2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKuvvet = new System.Windows.Forms.Button();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnKarekok = new System.Windows.Forms.Button();
            this.lblIslem = new System.Windows.Forms.Label();
            this.lblOnay = new System.Windows.Forms.Label();
            this.Sayac = new System.Windows.Forms.Timer(this.components);
            this.btnFaktoriyel = new System.Windows.Forms.Button();
            this.imgButon = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(22, 47);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(177, 21);
            this.txtMetin.TabIndex = 1;
            this.txtMetin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetin_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(64, 173);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(27, 25);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(97, 173);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(27, 25);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(130, 173);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(27, 25);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(64, 144);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(27, 25);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(97, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(27, 25);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(130, 144);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(27, 25);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(64, 115);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(27, 25);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(97, 115);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(27, 25);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(130, 115);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(27, 25);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(97, 202);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(27, 25);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnIsaret
            // 
            this.btnIsaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnIsaret.Location = new System.Drawing.Point(55, 202);
            this.btnIsaret.Name = "btnIsaret";
            this.btnIsaret.Size = new System.Drawing.Size(36, 25);
            this.btnIsaret.TabIndex = 13;
            this.btnIsaret.Text = "+/-";
            this.btnIsaret.UseVisualStyleBackColor = true;
            this.btnIsaret.Click += new System.EventHandler(this.btnIsaret_Click);
            // 
            // btnVirgul
            // 
            this.btnVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnVirgul.Location = new System.Drawing.Point(130, 202);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(36, 25);
            this.btnVirgul.TabIndex = 14;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = true;
            this.btnVirgul.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnEsittir.Location = new System.Drawing.Point(172, 202);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(27, 25);
            this.btnEsittir.TabIndex = 15;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.DarkRed;
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(163, 173);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(36, 25);
            this.btnTopla.TabIndex = 16;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnCikart.Location = new System.Drawing.Point(163, 144);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(36, 25);
            this.btnCikart.TabIndex = 17;
            this.btnCikart.Text = "-";
            this.btnCikart.UseVisualStyleBackColor = false;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.Color.DarkRed;
            this.btnCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(163, 115);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(36, 25);
            this.btnCarp.TabIndex = 18;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.DarkRed;
            this.btnBol.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnBol.Location = new System.Drawing.Point(163, 84);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(36, 25);
            this.btnBol.TabIndex = 19;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(22, 202);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(27, 25);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "C";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnTextTemizle
            // 
            this.btnTextTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnTextTemizle.Location = new System.Drawing.Point(22, 173);
            this.btnTextTemizle.Name = "btnTextTemizle";
            this.btnTextTemizle.Size = new System.Drawing.Size(36, 25);
            this.btnTextTemizle.TabIndex = 21;
            this.btnTextTemizle.Text = "CE";
            this.btnTextTemizle.UseVisualStyleBackColor = true;
            this.btnTextTemizle.Click += new System.EventHandler(this.btnTextTemizle_Click);
            // 
            // lblKalip1
            // 
            this.lblKalip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKalip1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKalip1.Location = new System.Drawing.Point(22, 84);
            this.lblKalip1.Name = "lblKalip1";
            this.lblKalip1.Size = new System.Drawing.Size(93, 25);
            this.lblKalip1.TabIndex = 22;
            this.lblKalip1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKalip2
            // 
            this.lblKalip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKalip2.ForeColor = System.Drawing.Color.Lime;
            this.lblKalip2.Location = new System.Drawing.Point(22, 84);
            this.lblKalip2.Name = "lblKalip2";
            this.lblKalip2.Size = new System.Drawing.Size(36, 85);
            this.lblKalip2.TabIndex = 23;
            this.lblKalip2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(121, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(36, 25);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "<--";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKuvvet
            // 
            this.btnKuvvet.BackColor = System.Drawing.Color.Transparent;
            this.btnKuvvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnKuvvet.Location = new System.Drawing.Point(97, 233);
            this.btnKuvvet.Name = "btnKuvvet";
            this.btnKuvvet.Size = new System.Drawing.Size(69, 22);
            this.btnKuvvet.TabIndex = 25;
            this.btnKuvvet.Text = "KUVVET";
            this.btnKuvvet.UseVisualStyleBackColor = false;
            this.btnKuvvet.Click += new System.EventHandler(this.btnKuvvet_Click);
            // 
            // btnKare
            // 
            this.btnKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnKare.Location = new System.Drawing.Point(22, 233);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(69, 22);
            this.btnKare.TabIndex = 26;
            this.btnKare.Text = "KARE";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.DarkRed;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMod.Location = new System.Drawing.Point(172, 233);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(27, 22);
            this.btnMod.TabIndex = 27;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnKarekok
            // 
            this.btnKarekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnKarekok.Location = new System.Drawing.Point(22, 261);
            this.btnKarekok.Name = "btnKarekok";
            this.btnKarekok.Size = new System.Drawing.Size(69, 22);
            this.btnKarekok.TabIndex = 28;
            this.btnKarekok.Text = "2√";
            this.btnKarekok.UseVisualStyleBackColor = true;
            this.btnKarekok.Click += new System.EventHandler(this.btnKarekok_Click);
            // 
            // lblIslem
            // 
            this.lblIslem.AutoSize = true;
            this.lblIslem.BackColor = System.Drawing.Color.Transparent;
            this.lblIslem.Location = new System.Drawing.Point(23, 20);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(0, 13);
            this.lblIslem.TabIndex = 30;
            // 
            // lblOnay
            // 
            this.lblOnay.BackColor = System.Drawing.Color.DarkRed;
            this.lblOnay.Location = new System.Drawing.Point(22, 151);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(36, 10);
            this.lblOnay.TabIndex = 31;
            // 
            // Sayac
            // 
            this.Sayac.Interval = 1000;
            this.Sayac.Tick += new System.EventHandler(this.Sayac_Tick);
            // 
            // btnFaktoriyel
            // 
            this.btnFaktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnFaktoriyel.Location = new System.Drawing.Point(97, 261);
            this.btnFaktoriyel.Name = "btnFaktoriyel";
            this.btnFaktoriyel.Size = new System.Drawing.Size(102, 22);
            this.btnFaktoriyel.TabIndex = 32;
            this.btnFaktoriyel.Text = "FAKTÖRİYEL";
            this.btnFaktoriyel.UseVisualStyleBackColor = true;
            this.btnFaktoriyel.Click += new System.EventHandler(this.btnFaktoriyel_Click);
            // 
            // imgButon
            // 
            this.imgButon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButon.ImageStream")));
            this.imgButon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButon.Images.SetKeyName(0, "exit.png");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnExit.ImageIndex = 0;
            this.btnExit.ImageList = this.imgButon;
            this.btnExit.Location = new System.Drawing.Point(188, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 33;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFaktoriyel);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.lblKalip1);
            this.Controls.Add(this.btnKarekok);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.btnKuvvet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTextTemizle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnVirgul);
            this.Controls.Add(this.btnIsaret);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.lblKalip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HesapMakinesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HesapMakinesi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HesapMakinesi_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HesapMakinesi_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIsaret;
        private System.Windows.Forms.Button btnVirgul;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnTextTemizle;
        private System.Windows.Forms.Label lblKalip1;
        private System.Windows.Forms.Label lblKalip2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKuvvet;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnKarekok;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label lblOnay;
        private System.Windows.Forms.Timer Sayac;
        private System.Windows.Forms.Button btnFaktoriyel;
        private System.Windows.Forms.ImageList imgButon;
        private System.Windows.Forms.Button btnExit;
    }
}

