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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            lbl_win.Location = new Point(87, 318);
            lbl_win.Name = "lbl_win";
            lbl_win.Size = new Size(56, 20);
            lbl_win.TabIndex = 5;
            lbl_win.Text = "Wins: 0";
            lbl_win.Click += label1_Click;
            // 
            // lbl_loss
            // 
            lbl_loss.AutoSize = true;
            lbl_loss.Location = new Point(87, 356);
            lbl_loss.Name = "lbl_loss";
            lbl_loss.Size = new Size(52, 20);
            lbl_loss.TabIndex = 6;
            lbl_loss.Text = "Loss: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 318);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "Bid-Amoun";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 353);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(87, 391);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(162, 34);
            btn_play.TabIndex = 9;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click_1;
            // 
            // btn_bid
            // 
            btn_bid.Location = new Point(326, 391);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 610);
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
    }
}
