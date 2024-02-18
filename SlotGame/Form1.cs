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
        int a, b, c, d, e1, f, g1, h1, i1, move, wins, balance, loss, tempbalance, comboCount;
        void Game_Result()
        {
            int valorEntrada = Convert.ToInt32(textBox1.Text);

            if (a != b && b != c && a != c && d != e1 && e1 != f && d != f && a != e1 && e1 != c)
            {
                comboCount = 0;
                loss++;
                lbl_cassino.Text = "Você perdeu!!!";
                lbl_loss.Text = "Derrotas: " + loss;
                tempbalance = balance - valorEntrada;
                MessageBox.Show("Saldo: $" + tempbalance);
                lbl_balance.Text = "Saldo: $" + tempbalance;
                textBox1.Text = "";
                btn_play.Enabled = false;
                MessageBox.Show("todos diferentes");
            }
            else
            {
                if (a == b && b == c)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na primeira linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na primeira linha!!!";
                    MessageBox.Show("(a == b && b == c)");
                }
                else if (a == b || b == c || a == c)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na primeira linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na primeira linha!!!";
                    MessageBox.Show("Combinação na fileira 1");
                }

                if (d == e1 && e1 == f)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na segunda linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na segunda linha!!!";
                    MessageBox.Show("d == e1 && e1 == f");
                }
                else if (d == e1 || e1 == f || d == f)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na segunda linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na segunda linha!!!";
                    MessageBox.Show("Combinação na fileira 2");
                }

                if (g1 == h1 && h1 == i1)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na terceira linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na terceira linha!!!";
                    MessageBox.Show("g1 == h1 && h1 == i1");
                }
                else if (g1 == h1 || h1 == i1 || g1 == i1)
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar na terceira linha
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou na terceira linha!!!";
                    MessageBox.Show("Combinação na fileira 3");
                }

                if ((a == d && d == g1) || (b == e1 && e1 == h1) || (c == f && f == i1) || (e1 == h1 && h1 == i1))
                {
                    comboCount++;
                    wins++;
                    lbl_win.Text = "Vitórias: " + wins;
                    balance += valorEntrada; // Adiciona o valor de entrada ao balance ao ganhar em todas as linhas
                    lbl_balance.Text = "Saldo: $" + balance;
                    btn_play.Text = "Continuar jogando...";
                    lbl_cassino.Text = "Você ganhou em todas as linhas!!!";
                    MessageBox.Show("Combinação entre todas as fileiras");
                }
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