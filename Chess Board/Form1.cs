using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Board
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button [8,8];
            int left = 0;
            int top = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 60;
                    buttons[i, j].Width = 70;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left +=70;
                    this.Controls.Add(buttons[i, j]);

                    buttons[i, j].BackColor = ((i + j) % 2 == 0) ? Color.Black : Color.White;
                    
                   
                }
                left = 0;
                top += 60;
            }
           

        }
    }
}
