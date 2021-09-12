using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_FinalUygulamasi2
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        //Değişkenler//
        bool move, sayi1, sayi2;
        int mouse_x, mouse_y;
        int sure = 0, s1, s2, basilantus;
        double sonuc, kuvvet;
        char islem;

        string islemTuru;


        //Olaylar//
        private void HesapMakinesi_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void HesapMakinesi_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void HesapMakinesi_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void txtMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı yazılmasını sağlar

            KlavyedenBolmeIslemi(sender,e);

            switch (e.KeyChar)
            {
                case '+':

                    islemTuru = "toplama";

                    if (sayi1 == true && sayi2 != true)
                    {
                        if (txtMetin.Text != "" && islemTuru == "toplama")
                        {
                            islemTuru = "toplama";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkGreen;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s2 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            if (lblIslem.Text == "")
                            {
                                sonuc = s1 + s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text = s1.ToString() + btnTopla.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                            else if (lblIslem.Text != "")
                            {
                                lblKalip1.Text = "";
                                lblKalip1.Text = lblIslem.Text;

                                sonuc = sonuc + s2;
                                lblIslem.Text = sonuc.ToString();

                                lblKalip1.Text += btnTopla.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                        }
                        else if(txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }
                    else if (sayi1 != true && sayi2 != true)
                    {
                        if(txtMetin.Text != "")
                        {
                            islemTuru = "toplama";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkGreen;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s1 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            lblOnay.BackColor = Color.DarkGreen;
                            Sayac.Enabled = true;

                            sayi1 = true;
                            sayi2 = false;
                        }
                        else if(txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }

                    break;
                case '-':

                    islemTuru = "cikartma";

                    if (sayi1 == true && sayi2 != true)
                    {
                        if(txtMetin.Text != "" && islemTuru == "cikartma")
                        {
                            islemTuru = "cikartma";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkGreen;
                            btnMod.BackColor = Color.DarkRed;

                            s2 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            if (lblIslem.Text == "")
                            {
                                sonuc = s1 - s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text = s1.ToString() + btnCikart.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                            else if (lblIslem.Text != "")
                            {
                                lblKalip1.Text = "";
                                lblKalip1.Text = lblIslem.Text;

                                sonuc = sonuc - s2;
                                lblIslem.Text = sonuc.ToString();

                                lblKalip1.Text += btnCikart.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                        }
                        else if (txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }
                    else if(sayi1 != true && sayi2 != true)
                    {
                        if(txtMetin.Text != "")
                        {
                            islemTuru = "cikartma";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkGreen;
                            btnMod.BackColor = Color.DarkRed;

                            s1 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            lblOnay.BackColor = Color.DarkGreen;
                            Sayac.Enabled = true;

                            sayi1 = true;
                            sayi2 = false;
                        }
                        else if(txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }

                    break;
                case '*':

                    islemTuru = "carpma";

                    if (sayi1 == true && sayi2 != true)
                    {
                        if(txtMetin.Text != "" && islemTuru == "carpma")
                        {
                            islemTuru = "carpma";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkGreen;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s2 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            if (lblIslem.Text == "")
                            {
                                sonuc = s1 * s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text = s1.ToString() + btnCarp.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                            else if (lblIslem.Text != "")
                            {
                                lblKalip1.Text = "";
                                lblKalip1.Text = lblIslem.Text;
                                sonuc = sonuc * s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text += btnCarp.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                        }
                        else if (txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }

                    }
                    else if(sayi1 != true && sayi2 != true)
                    {
                        if(txtMetin.Text != "")
                        {
                            islemTuru = "carpma";
                            btnBol.BackColor = Color.DarkRed;
                            btnCarp.BackColor = Color.DarkGreen;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s1 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            lblOnay.BackColor = Color.DarkGreen;
                            Sayac.Enabled = true;

                            sayi1 = true;
                            sayi2 = false;
                        }
                        else if (txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }

                    break;
            }
            switch (islem)
            {
                case 'b':

                    islemTuru = "bolme";

                    if (sayi1 == true && sayi2 != true)
                    {
                        if(txtMetin.Text != "" && islemTuru == "bolme")
                        {
                            islemTuru = "bolme";
                            btnBol.BackColor = Color.DarkGreen;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s2 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            if (lblIslem.Text == "")
                            {
                                sonuc = s1 / s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text = s1.ToString() + btnBol.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                            else if (lblIslem.Text != "")
                            {
                                lblKalip1.Text = "";
                                lblKalip1.Text = lblIslem.Text;
                                sonuc = sonuc / s2;
                                lblIslem.Text = sonuc.ToString();
                                lblKalip1.Text += btnBol.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                            }
                        }
                        else if (txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }
                    else if(sayi1 != true && sayi2 != true)
                    {
                        if(txtMetin.Text != "")
                        {
                            islemTuru = "bolme";
                            btnBol.BackColor = Color.DarkGreen;
                            btnCarp.BackColor = Color.DarkRed;
                            btnTopla.BackColor = Color.DarkRed;
                            btnCikart.BackColor = Color.DarkRed;
                            btnMod.BackColor = Color.DarkRed;

                            s1 = Convert.ToInt32(txtMetin.Text);
                            txtMetin.Text = "";
                            txtMetin.Focus();

                            lblOnay.BackColor = Color.DarkGreen;
                            Sayac.Enabled = true;

                            sayi1 = true;
                            sayi2 = false;
                        }
                        else if (txtMetin.Text == "") { MessageBox.Show("Önce bir sayı giriniz"); }
                    }

                    break;
            }
        }

        private void Sayac_Tick(object sender, EventArgs e)
        {
            sure++;
            if(sure == 1 && lblOnay.BackColor == Color.DarkGreen)
            {
                lblOnay.BackColor = Color.DarkRed;
                sure = 0;
                Sayac.Enabled = false;
            }
        }


        //Fonksiyonlar//

        private void EsittirIslemi()
        {
            if (txtMetin.Text == "")
            {
                MessageBox.Show("önce bir sayı giriniz");
            }
            else if (txtMetin.Text != "")
            {
                s2 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;

                if (islemTuru == "bolme")
                {
                    if (lblIslem.Text == "")
                    {
                        sonuc = s1 / s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text = s1.ToString() + btnBol.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";
                        lblKalip1.Text = lblIslem.Text;
                        sonuc = sonuc / s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text += btnBol.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                }
                else if (islemTuru == "carpma")
                {
                    if (lblIslem.Text == "")
                    {
                        sonuc = s1 * s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text = s1.ToString() + btnCarp.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";
                        lblKalip1.Text = lblIslem.Text;
                        sonuc = sonuc * s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text += btnCarp.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                }
                else if (islemTuru == "cikartma")
                {
                    if (lblIslem.Text == "")
                    {
                        sonuc = s1 - s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text = s1.ToString() + btnCikart.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";
                        lblKalip1.Text = lblIslem.Text;

                        sonuc = sonuc - s2;
                        lblIslem.Text = sonuc.ToString();

                        lblKalip1.Text += btnCikart.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                }
                else if (islemTuru == "toplama")
                {
                    if (lblIslem.Text == "")
                    {
                        sonuc = s1 + s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text = s1.ToString() + btnTopla.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";
                        lblKalip1.Text = lblIslem.Text;

                        sonuc = sonuc + s2;
                        lblIslem.Text = sonuc.ToString();

                        lblKalip1.Text += btnTopla.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                }
                else if (islemTuru == "mod")
                {
                    if (lblIslem.Text == "")
                    {
                        sonuc = s1 % s2;
                        lblIslem.Text = sonuc.ToString();
                        lblKalip1.Text = s1.ToString() + btnMod.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";
                        lblKalip1.Text = lblIslem.Text;

                        sonuc = sonuc % s2;
                        lblIslem.Text = sonuc.ToString();

                        lblKalip1.Text += btnMod.Text + s2.ToString() + btnEsittir.Text + sonuc.ToString();
                    }
                }
                else if (islemTuru == "kuvvet")
                {
                    if (lblIslem.Text == "")
                    {
                        kuvvet = Math.Pow(s1, s2);
                        sonuc = kuvvet;
                        lblIslem.Text = kuvvet.ToString();
                        lblKalip1.Text = s1.ToString() + " ^ " + s2.ToString() + btnEsittir.Text + kuvvet.ToString();
                    }
                    else if (lblIslem.Text != "")
                    {
                        lblKalip1.Text = "";

                        kuvvet = Math.Pow(s1, s2);
                        sonuc = kuvvet;
                        lblIslem.Text = kuvvet.ToString();

                        lblKalip1.Text = s1.ToString() + " ^ " + s2.ToString() + btnEsittir.Text + kuvvet.ToString();
                    }
                }
            }
        }
        private void BolmeIslemi()
        {
            islemTuru = "bolme";
            btnBol.BackColor = Color.DarkGreen;
            btnCarp.BackColor = Color.DarkRed;
            btnTopla.BackColor = Color.DarkRed;
            btnCikart.BackColor = Color.DarkRed;
            btnMod.BackColor = Color.DarkRed;

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;
                sayi1 = true;
                sayi2 = false;
            }
        }
        private void KlavyedenBolmeIslemi(object s, KeyPressEventArgs a)
        {
            basilantus = Convert.ToInt32(a.KeyChar);
            if (basilantus == 47)
            {
                islemTuru = "bolme";
                islem = 'b';
            }
            else if(basilantus  != 47)
            {
                islem = ' ';
            }
        }
        private void CarpmaIslemi()
        {
            islemTuru = "carpma";
            btnBol.BackColor = Color.DarkRed;
            btnCarp.BackColor = Color.DarkGreen;
            btnTopla.BackColor = Color.DarkRed;
            btnCikart.BackColor = Color.DarkRed;
            btnMod.BackColor = Color.DarkRed;

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;
                sayi1 = true;
                sayi2 = false;
            }
        }
        private void ToplamaIslemi()
        {
            islemTuru = "toplama";
            btnBol.BackColor = Color.DarkRed;
            btnCarp.BackColor = Color.DarkRed;
            btnTopla.BackColor = Color.DarkGreen;
            btnCikart.BackColor = Color.DarkRed;
            btnMod.BackColor = Color.DarkRed;

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;

                sayi1 = true;
                sayi2 = false;
            }
        }
        private void CikarmaIslemi()
        {
            islemTuru = "cikartma";
            btnBol.BackColor = Color.DarkRed;
            btnCarp.BackColor = Color.DarkRed;
            btnTopla.BackColor = Color.DarkRed;
            btnCikart.BackColor = Color.DarkGreen;
            btnMod.BackColor = Color.DarkRed;

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;
                sayi1 = true;
                sayi2 = false;
            }
        }
        private void ModAlmaIslemi()
        {
            islemTuru = "mod";
            btnBol.BackColor = Color.DarkRed;
            btnCarp.BackColor = Color.DarkRed;
            btnTopla.BackColor = Color.DarkRed;
            btnCikart.BackColor = Color.DarkRed;
            btnMod.BackColor = Color.DarkGreen;

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;
                sayi1 = true;
                sayi2 = false;
            }
        }
        private void KuvvetAlmaIslemi()
        {
            islemTuru = "kuvvet";

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;
                sayi1 = true;
                sayi2 = false;
            }
        }
        private void SilmeIslemi()
        {
            if (txtMetin.Text == "")
            {
                MessageBox.Show("Silinecek karakter bulunmamaktadır");
            }
            else if (txtMetin.Text != "")
            {
                string KalanMetin = txtMetin.Text.Substring(0, txtMetin.Text.Length - 1);
                //Yukarıdaki kodun açıklaması kalanmetin değişkenine orjinal metinin 0. karakterinden metnin
                //uzunluğundan 1 eksiltilerek oluşturulan aralık atanır.
                txtMetin.Text = KalanMetin;
            }
        }
        private void VirgulIslemi()
        {
            if(txtMetin.Text != "")
            {
                if (!txtMetin.Text.Contains(","))
                {
                    txtMetin.Text += ",";
                }
                else if (txtMetin.Text.Contains(","))
                {
                    //normal hesap makineleri de böyle çalışıyor bir virgül kondukdan sonra ikincisi konmaz 
                }
            }
            else if(txtMetin.Text == "")
            {
                txtMetin.Text += "0,";
            }
        }
        private void IsaretDegistirmeIslemi()
        {
            if (txtMetin.Text == "") { MessageBox.Show("İşareti değiştirilecek sayı yok"); }
            else if (txtMetin.Text != "")
            {
                double OrjinalSayi = Convert.ToDouble(txtMetin.Text);
                txtMetin.Text = (OrjinalSayi * (-1)).ToString();
            }
        }
        private void KaresiniAlma()
        {
            islemTuru = "kare";

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;

                if (lblIslem.Text == "")
                {
                    sonuc = Math.Pow(s1, 2);
                    lblIslem.Text = sonuc.ToString();
                    lblKalip1.Text = s1.ToString() + " ^ " + 2 + btnEsittir.Text + sonuc.ToString();
                }
                else if (lblIslem.Text != "")
                {
                    lblKalip1.Text = "";

                    sonuc = Math.Pow(s1, 2);
                    lblIslem.Text = sonuc.ToString();

                    lblKalip1.Text = s1.ToString() + " ^ " + 2 + btnEsittir.Text + sonuc.ToString();
                }
            }
            else if(txtMetin.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz");
            }
        }
        private void KarekokunuAlma()
        {
            islemTuru = "karekok";

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;

                if (lblIslem.Text == "")
                {
                    sonuc = Math.Sqrt(s1);
                    lblIslem.Text = sonuc.ToString();
                    lblKalip1.Text = btnKarekok.Text.Remove(0, 1) + s1.ToString() + btnEsittir.Text + sonuc.ToString();
                }
                else if (lblIslem.Text != "")
                {
                    lblKalip1.Text = "";

                    sonuc = Math.Sqrt(s1);
                    lblIslem.Text = sonuc.ToString();

                    lblKalip1.Text = btnKarekok.Text.Remove(0, 1) + s1.ToString() + btnEsittir.Text + sonuc.ToString();
                }
            }
            else if (txtMetin.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz");
            }
        }
        private void FaktoriyelAlma()
        {
            int faktoriyel = 1;
            islemTuru = "faktoriyel";

            if (txtMetin.Text != "")
            {
                s1 = Convert.ToInt32(txtMetin.Text);
                txtMetin.Text = "";
                txtMetin.Focus();

                lblOnay.BackColor = Color.DarkGreen;
                Sayac.Enabled = true;

                if (lblIslem.Text == "")
                {
                    for (int i = 2; i <= s1; i++)
                    {
                        faktoriyel *= i;
                    }
                    sonuc = faktoriyel;
                    lblIslem.Text = faktoriyel.ToString();
                    lblKalip1.Text = s1.ToString() + "!" + btnEsittir.Text + faktoriyel.ToString();
                }
                else if (lblIslem.Text != "")
                {
                    lblKalip1.Text = "";

                    for (int i = 2; i <= s1; i++)
                    {
                        faktoriyel *= i;
                    }
                    sonuc = faktoriyel;
                    lblIslem.Text = faktoriyel.ToString();

                    lblKalip1.Text = s1.ToString() + "!" + btnEsittir.Text + faktoriyel.ToString();
                }
            }
        }
        private void TemizlemeIslemi()
        {
            lblKalip1.Text = "";
            lblIslem.Text = "";
            txtMetin.Text = "";
            islemTuru = "";
            btnBol.BackColor = Color.DarkRed;
            btnCarp.BackColor = Color.DarkRed;
            btnTopla.BackColor = Color.DarkRed;
            btnCikart.BackColor = Color.DarkRed;
            btnMod.BackColor = Color.DarkRed;
        }
        private void TextiTemizlemeIslemi()
        {
            txtMetin.Text = "";
        }

        //Buton işlemleri//
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            EsittirIslemi();
        }
        private void btnBol_Click(object sender, EventArgs e)
        {
            BolmeIslemi();
        }
        private void btnCarp_Click(object sender, EventArgs e)
        {
            CarpmaIslemi();
        }
        private void btnCikart_Click(object sender, EventArgs e)
        {
            CikarmaIslemi();
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            ToplamaIslemi();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            ModAlmaIslemi();
        }
        private void btnKuvvet_Click(object sender, EventArgs e)
        {
            KuvvetAlmaIslemi();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SilmeIslemi();
        }
        private void btnVirgul_Click(object sender, EventArgs e)
        {
            VirgulIslemi();
        }
        private void btnIsaret_Click(object sender, EventArgs e)
        {
            IsaretDegistirmeIslemi();
        }
        private void btnKare_Click(object sender, EventArgs e)
        {
            KaresiniAlma();
        }
        private void btnKarekok_Click(object sender, EventArgs e)
        {
            KarekokunuAlma();
        }
        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            FaktoriyelAlma();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizlemeIslemi();
        }
        private void btnTextTemizle_Click(object sender, EventArgs e)
        {
            TextiTemizlemeIslemi();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Buton numara tıklama işlemleri
        private void btn0_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn0.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn1.Text;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn2.Text;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn3.Text;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn4.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn8.Text;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtMetin.Text += btn9.Text;
        }
    }
}