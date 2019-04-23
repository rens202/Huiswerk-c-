using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsDeze
{
    public partial class Form1 : Form
    {
        private TicTacToeEngine engine;

        public Form1()
        {
            InitializeComponent();
            engine = new TicTacToeEngine();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            String token = engine.whosTurn();
            //System.Windows.Forms.MessageBox.Show("Er is geklikt!");
            if(sender == button1)
            {
                if (engine.ChooseCell(1)) { button1.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button2)
            {
                if (engine.ChooseCell(2)) { button2.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button3)
            {
                if (engine.ChooseCell(3)) { button3.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button4)
            {
                 if (engine.ChooseCell(4)) { button4.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button5)
            {
                 if (engine.ChooseCell(5)) { button5.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button6)
            {
                if (engine.ChooseCell(6)) { button6.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button7)
            {
                if (engine.ChooseCell(7)) { button7.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button8)
            {
                if (engine.ChooseCell(8)) { button8.Text = token;
                    checkWinner();
                }
            }
            else if (sender == button9)
            {
                if (engine.ChooseCell(9)) { button9.Text = token;
                    checkWinner();
                }
            }
            

        }

        public void checkWinner()
        {
            if (engine.isThereAWinner())
            {
                System.Windows.Forms.MessageBox.Show("De winaar is: " + engine.whosTurn());
                engine.reset();
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }

        }

     
    }
}