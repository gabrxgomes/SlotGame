using System.Linq.Expressions;

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
        int a, b, c, move, wins, balance, loss, tempbalance;

        void Game_Result()
        {
            //if (System.Convert.ToInt32(a & b ) == c )
            //if (System.Convert.ToInt32(a & b) != c)
            if (System.Convert.ToInt32(a == b) != c)
                //if (System.Convert.ToInt32(a == b & a == c & b == c) == c)
                {
                wins++;
                lbl_win.Text = "Wins :" + wins;
                balance += 2;
                lbl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continue Playing...";
                lbl_cassino.Text = "You Won !!!..";



            }


            else if (System.Convert.ToInt32(b == c) != a)//1
            {
                wins++;
                lbl_win.Text = "Wins :" + wins;
                balance += 2;
                lbl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continue Playing...";
                lbl_cassino.Text = "You Won !!!..";
            }

            else if (System.Convert.ToInt32(c == a) != b)//2
            {
                wins++;
                lbl_win.Text = "Wins :" + wins;
                balance += 2;
                lbl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) * balance;
                btn_play.Text = "Continue Playing...";
                lbl_cassino.Text = "You Won !!!..";
            }
            
            /*if (balance >= 50) //tatica de roubar no jogo, definimos um teto para um balance saudavel mas ainda
                                //de forma mais burra, vamos ir estudando.
            {
                wins -= 1;
                pictureBox1.Image = Properties.Resources.dollar;
                pictureBox2.Image = Properties.Resources.dollar;
                pictureBox3.Image = Properties.Resources.dollar;
                lbl_cassino.Text = "Try Again";
                balance = 0;
                
            }*/

                    //ou

                    /*if (wins >= 5)
                    {
                        pictureBox1.Image = Properties.Resources.dollar;
                        pictureBox2.Image = Properties.Resources.dollar;
                        pictureBox3.Image = Properties.Resources.dollar;
                        lbl_cassino.Text = "Try Again";

                    }*/
            else
            {
                //wins--;
                lbl_cassino.Text = "Try Again";
                loss++;
                lbl_loss.Text = "Loss : "+loss;

                tempbalance = Convert.ToInt32(textBox1.Text) * balance - Convert.ToInt32(textBox1.Text);

                MessageBox.Show("Conta" + tempbalance);

                //lbl_balance.Text = "Balance : $" + Convert.ToInt32(textBox1.Text) * balance ;


                //balance -= 2;


                //lbl_balance.Text = "Balance : $ 0";
                //lbl_balance.Text = "Balance : $ 0";

                //tempbalance = balance - Convert.ToInt32(textBox1.Text);

                //tempbalance -= balance;



                lbl_balance.Text = "Balance : $" + tempbalance;

                //MessageBox.Show("Conta" + tempbalance); //saida de teste como messagebox

                //MessageBox.Show("Saiu Gold"); //saida de teste como messagebox

                //lbl_balance.Text = "Balance : $" + (Convert.ToInt32(textBox1.Text) - balance);


                textBox1.Text = "";
                btn_play.Enabled = false;
                pictureBox1.Image = Properties.Resources.dollar;
                pictureBox2.Image = Properties.Resources.dollar;
                pictureBox3.Image = Properties.Resources.dollar;
            }

        }
        private void btn_play_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the Bid Amount inside the textbox to play.. ");

            }



            
            else
            {
                timer1.Enabled = true;
                lbl_cassino.Text = "Casino";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Yellow; //se o meu textbox estiver vazio ele não muda de cor, mas
                                                   //caso esteja com um valor dentro ele muda de cor
            }                                      //para dar um efeito de bit lock (aposta feita)

        }

        private void btn_bid_Click(object sender, EventArgs e)
        {
            lbl_cassino.Text = "Casino";
            //balance = 0;
            
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "Play";

            //lbl_balance.Text = "Balance : $" + balance;

            //lbl_balance.Text = "Balance : $" + (Convert.ToInt32(textBox1.Text) - balance);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {
                a = rnd.Next(5);//de zero a 6
                b = rnd.Next(5);//de zero a 6
                c = rnd.Next(5);//de zero a 6

                //total de voltas do pictureBox1 com o random = 18!

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Gold;
                        //MessageBox.Show("Saiu Gold"); //saida de teste como messagebox
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.Silver;
                        //MessageBox.Show("Saiu Silver"); //saida de teste como messagebox
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.Bronze;
                        //MessageBox.Show("Saiu Bronze"); //saida de teste como messagebox
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Gold;
                        //MessageBox.Show("Saiu Gold"); //saida de teste como messagebox
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Silver;
                        //MessageBox.Show("Saiu Silver"); //saida de teste como messagebox
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.Bronze;
                        //MessageBox.Show("Saiu Bronze"); //saida de teste como messagebox
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.Gold;
                        //MessageBox.Show("Saiu Gold"); //saida de teste como messagebox
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.Silver;
                        //MessageBox.Show("Saiu Silver"); //saida de teste como messagebox
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.Bronze;
                        //MessageBox.Show("Saiu Bronze"); //saida de teste como messagebox
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
