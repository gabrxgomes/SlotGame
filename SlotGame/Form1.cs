using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlotGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        Random rnd = new Random();
        int a, b, c, d, e1, f, g1, h1, i1, move, wins, balance, loss, tempbalance;

        void Game_Result()
        {
            // Verifica se a, b e c são iguais
            if (a == b && b == c)
            {
                wins++;
                lbl_win.Text = "Vitórias: " + wins;
                balance += 2;
                lbl_balance.Text = "Saldo: $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continuar jogando...";
                lbl_cassino.Text = "Você ganhou!!!";
            }
            // Verifica se a e b são iguais
            else if (a == b)
            {
                wins++;
                lbl_win.Text = "Vitórias: " + wins;
                balance += 2;
                lbl_balance.Text = "Saldo: $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continuar jogando...";
                lbl_cassino.Text = "Você ganhou!!!";
                MessageBox.Show("a == b");
            }
            // Verifica se b e c são iguais
            else if (b == c)
            {
                wins++;
                lbl_win.Text = "Vitórias: " + wins;
                balance += 2;
                lbl_balance.Text = "Saldo: $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continuar jogando...";
                lbl_cassino.Text = "Você ganhou!!!";
                MessageBox.Show("b == c");
            }
            // Verifica se a, b ou c são iguais
            else if (a == c)
            {
                wins++;
                lbl_win.Text = "Vitórias: " + wins;
                balance += 2;
                lbl_balance.Text = "Saldo: $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continuar jogando...";
                lbl_cassino.Text = "Você ganhou!!!";
                MessageBox.Show("a == c");
            }
            // Verifica se a, b e c são diferentes
            else if (a != b && a != c && b != c)
            {
                loss++;
                lbl_cassino.Text = "Você perdeu!!!";
                lbl_loss.Text = "Derrotas: " + loss;
                tempbalance = Convert.ToInt32(textBox1.Text) * balance - Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Saldo: $" + tempbalance);
                lbl_balance.Text = "Saldo: $" + tempbalance;
                textBox1.Text = "";
                btn_play.Enabled = false;
                MessageBox.Show("todos diferentes");
            }
            else
            {
                loss++;
                lbl_cassino.Text = "Você ganhou!!!";
                lbl_loss.Text = "Derrotas: " + loss;
                tempbalance = Convert.ToInt32(textBox1.Text) * balance - Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Saldo: $" + tempbalance);
                lbl_balance.Text = "Saldo: $" + tempbalance;
                textBox1.Text = "";
                btn_play.Enabled = false;
                MessageBox.Show("todos diferentes");
            }
        }

        private void btn_play_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da aposta no campo de texto para jogar.");
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void btn_bid_Click(object sender, EventArgs e)
        {
            lbl_cassino.Text = "Cassino";
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "Jogar";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(3) + 1; // De 1 a 3
                b = rnd.Next(3) + 1; // De 1 a 3
                c = rnd.Next(3) + 1; // De 1 a 3
                d = rnd.Next(3) + 1; // De 1 a 3
                e1 = rnd.Next(3) + 1; // De 1 a 3
                f = rnd.Next(3) + 1; // De 1 a 3
                g1 = rnd.Next(3) + 1; // De 1 a 3
                h1 = rnd.Next(3) + 1; // De 1 a 3
                i1 = rnd.Next(3) + 1; // De 1 a 3

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (d)
                {
                    case 1:
                        pictureBox4.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox4.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (e1)
                {
                    case 1:
                        pictureBox5.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox5.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox5.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (f)
                {
                    case 1:
                        pictureBox6.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox6.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox6.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (g1)
                {
                    case 1:
                        pictureBox7.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox7.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox7.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (h1)
                {
                    case 1:
                        pictureBox8.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox8.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox8.Image = Properties.Resources.Bronze;
                        break;
                }

                switch (i1)
                {
                    case 1:
                        pictureBox9.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox9.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox9.Image = Properties.Resources.Bronze;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
                Game_Result();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}