using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace GameForm
{
    public partial class Form1 : Form
    {
        private GameData data1;
        public Form1()
        {
            InitializeComponent();
            data1 = new GameData();

            questionLabel.Text = data1.generateQuestion();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int randomNo = data1.getRandomNo();

            if (data1.checkSameMovie(player1Text.Text, player2Text.Text))
            {
                MessageBox.Show("Same movie entered as before, try again");
                player1Text.Text = "";
                player2Text.Text = "";
                resultLabel.Text = "";
                return;
            }
            if (randomNo == 1)
            resultLabel.Text = data1.evaluateIMDB(player1Text.Text, player2Text.Text);
            if (randomNo == 2)
            resultLabel.Text = data1.evaluateLenght(player1Text.Text, player2Text.Text);
            if (randomNo == 3)
            resultLabel.Text = data1.evaluateOlder(player1Text.Text, player2Text.Text);
            if (randomNo == 4)
                resultLabel.Text = data1.evaluateOscar(player1Text.Text, player2Text.Text);
            if (randomNo == 5)
                resultLabel.Text = data1.evaluateActor(player1Text.Text, player2Text.Text);
            if (randomNo == 6)
                resultLabel.Text = data1.evaluateGenre(player1Text.Text, player2Text.Text);

            player1CountLabel.Text = "" + data1.getPoint1();
            player2CountLabel.Text = "" + data1.getPoint2();

           // data1.fetchPhoto1(pictureBox1);
           // data1.fetchPhoto2(pictureBox2);

            

            if (data1.isEnd())
            {
                if (data1.getPoint1() > data1.getPoint2())
                {
                    MessageBox.Show("Player 1 won");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Player 2 won");
                    this.Hide();
                }
                    
               
            }
        }

        private void newQuestionBtn_Click(object sender, EventArgs e)
        {
            questionLabel.Text = data1.generateQuestion();
            player1Text.Text = "";
            player2Text.Text = "";
            pictureBox1 = null;
            pictureBox2 = null;
        }

    }
}
