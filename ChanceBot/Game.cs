using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ChanceBot
{
    public partial class Game : Form
    {
        int random, counter = 10;
        int min, max;
        int avrg = 550;

        List<int> find = new List<int>();

        public Game()
        {
            InitializeComponent();
        }

        public void avrgClass(int a, int b)
        {
            avrg = ((a + b) / 2);
            return;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 100; i < 1000; i++)
            {
                find.Add(i);
            }

            min = find.First();
            max = find.Last();

            Random rnd = new Random();
            random = rnd.Next(min, max);

            lblCounter.Text = ("You can try : " + counter.ToString() + " times");
            lblRandom.Text = random.ToString();
            submit.Enabled = false;

        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (counter == 10)
            {

            }
            else
            {
                if (random > avrg)
                {
                    for (int i = find.First(); i <= avrg; i++)
                    {
                        find.Remove(i);
                    }
                    avrgClass(find.First(), find.Last());
                }
                else if (random < avrg)
                {
                    for (int i = avrg; i <= find.Last(); i++)
                    {
                        find.Remove(i);
                    }
                    avrgClass(find.First(), find.Last());
                }
            }

            inputUser.Text = avrg.ToString();
            btnBot.Enabled = false;
            submit.Enabled = true;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                int UserInput = int.Parse(inputUser.Text);
                if (counter >= 1)
                {
                    if (UserInput > random)
                    {
                        MessageBox.Show("Your gust is GT");
                        btnBot.Enabled = true;
                    }
                    else if (UserInput == random)
                    {
                        MessageBox.Show("You Win");
                        btnBot.Enabled = false;
                        submit.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your gust is LT");
                        btnBot.Enabled = true;
                    }
                    counter--;

                    lblCounter.Text = ("You can try : " + counter.ToString() + " times");
                }
                else
                {
                    MessageBox.Show("You Lose");
                }

                listBox1.Items.Add(inputUser.Text);
                submit.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
