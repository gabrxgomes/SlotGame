namespace SlotGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_cassino = new Label();
            lbl_balance = new Label();
            lbl_win = new Label();
            lbl_loss = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_play = new Button();
            btn_bid = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Silver;
            pictureBox1.Location = new Point(87, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Silver;
            pictureBox2.Location = new Point(326, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Silver;
            pictureBox3.Location = new Point(558, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(162, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lbl_cassino
            // 
            lbl_cassino.AutoSize = true;
            lbl_cassino.Location = new Point(87, 39);
            lbl_cassino.Name = "lbl_cassino";
            lbl_cassino.Size = new Size(59, 20);
            lbl_cassino.TabIndex = 3;
            lbl_cassino.Text = "Cassino";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Location = new Point(87, 71);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(76, 20);
            lbl_balance.TabIndex = 4;
            lbl_balance.Text = "Balance: $";
            // 
            // lbl_win
            // 
            lbl_win.AutoSize = true;
            lbl_win.Location = new Point(87, 743);
            lbl_win.Name = "lbl_win";
            lbl_win.Size = new Size(56, 20);
            lbl_win.TabIndex = 5;
            lbl_win.Text = "Wins: 0";
            lbl_win.Click += label1_Click;
            // 
            // lbl_loss
            // 
            lbl_loss.AutoSize = true;
            lbl_loss.Location = new Point(87, 781);
            lbl_loss.Name = "lbl_loss";
            lbl_loss.Size = new Size(52, 20);
            lbl_loss.TabIndex = 6;
            lbl_loss.Text = "Loss: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 743);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 7;
            label1.Text = "Bid-Amount";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 778);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(87, 816);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(162, 34);
            btn_play.TabIndex = 9;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click_1;
            // 
            // btn_bid
            // 
            btn_bid.Location = new Point(326, 816);
            btn_bid.Name = "btn_bid";
            btn_bid.Size = new Size(162, 34);
            btn_bid.TabIndex = 10;
            btn_bid.Text = "New Bid";
            btn_bid.UseVisualStyleBackColor = true;
            btn_bid.Click += btn_bid_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Silver;
            pictureBox4.Location = new Point(87, 322);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(162, 170);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Silver;
            pictureBox5.Location = new Point(326, 322);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(162, 170);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Silver;
            pictureBox6.Location = new Point(558, 322);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(162, 170);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Silver;
            pictureBox7.Location = new Point(558, 521);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(162, 170);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Silver;
            pictureBox8.Location = new Point(326, 521);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(162, 170);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Silver;
            pictureBox9.Location = new Point(87, 521);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(162, 170);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 877);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btn_bid);
            Controls.Add(btn_play);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbl_loss);
            Controls.Add(lbl_win);
            Controls.Add(lbl_balance);
            Controls.Add(lbl_cassino);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_cassino;
        private Label lbl_balance;
        private Label lbl_win;
        private Label lbl_loss;
        private Label label1;
        private TextBox textBox1;
        private Button btn_play;
        private Button btn_bid;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}
