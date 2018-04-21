using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void x00Label_Click(object sender, EventArgs e)
        {
            taken00Label.Text = "X";
            x00Label.Visible = false;
            o00Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o00Label_Click(object sender, EventArgs e)
        {
            taken00Label.Text = "O";
            x00Label.Visible = false;
            o00Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x01Label_Click(object sender, EventArgs e)
        {
            taken01Label.Text = "X";
            x01Label.Visible = false;
            o01Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o01Label_Click(object sender, EventArgs e)
        {
            taken01Label.Text = "O";
            x01Label.Visible = false;
            o01Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x02Label_Click(object sender, EventArgs e)
        {
            taken02Label.Text = "X";
            x02Label.Visible = false;
            o02Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o02Label_Click(object sender, EventArgs e)
        {
            taken02Label.Text = "O";
            x02Label.Visible = false;
            o02Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x10Label_Click(object sender, EventArgs e)
        {
            taken10Label.Text = "X";
            x10Label.Visible = false;
            o10Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o10Label_Click(object sender, EventArgs e)
        {
            taken10Label.Text = "O";
            x10Label.Visible = false;
            o10Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x11Label_Click(object sender, EventArgs e)
        {
            taken11Label.Text = "X";
            x11Label.Visible = false;
            o11Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o11Label_Click(object sender, EventArgs e)
        {
            taken11Label.Text = "O";
            x11Label.Visible = false;
            o11Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x12Label_Click(object sender, EventArgs e)
        {
            taken12Label.Text = "X";
            x12Label.Visible = false;
            o12Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o12Label_Click(object sender, EventArgs e)
        {
            taken12Label.Text = "O";
            x12Label.Visible = false;
            o12Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x20Label_Click(object sender, EventArgs e)
        {
            taken20Label.Text = "X";
            x20Label.Visible = false;
            o20Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o20Label_Click(object sender, EventArgs e)
        {
            taken20Label.Text = "O";
            x20Label.Visible = false;
            o20Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x21Label_Click(object sender, EventArgs e)
        {
            taken21Label.Text = "X";
            x21Label.Visible = false;
            o21Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o21Label_Click(object sender, EventArgs e)
        {
            taken21Label.Text = "O";
            x21Label.Visible = false;
            o21Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void x22Label_Click(object sender, EventArgs e)
        {
            taken22Label.Text = "X";
            x22Label.Visible = false;
            o22Label.Visible = false;
            turnLabel.Text = "Os Turn";

            x00Label.Enabled = false;
            x01Label.Enabled = false;
            x02Label.Enabled = false;
            x10Label.Enabled = false;
            x11Label.Enabled = false;
            x12Label.Enabled = false;
            x20Label.Enabled = false;
            x21Label.Enabled = false;
            x22Label.Enabled = false;

            o00Label.Enabled = true;
            o01Label.Enabled = true;
            o02Label.Enabled = true;
            o10Label.Enabled = true;
            o11Label.Enabled = true;
            o12Label.Enabled = true;
            o20Label.Enabled = true;
            o21Label.Enabled = true;
            o22Label.Enabled = true;
        }

        private void o22Label_Click(object sender, EventArgs e)
        {
            taken22Label.Text = "O";
            x22Label.Visible = false;
            o22Label.Visible = false;
            turnLabel.Text = "Xs Turn";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;
        }

        private void fileExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Reset the game.
        private void fileNewMenuItem_Click(object sender, EventArgs e)
        {
            x00Label.Visible = true;
            o00Label.Visible = true;
            x01Label.Visible = true;
            o01Label.Visible = true;
            x02Label.Visible = true;
            o02Label.Visible = true;
            x10Label.Visible = true;
            o10Label.Visible = true;
            x11Label.Visible = true;
            o11Label.Visible = true;
            x12Label.Visible = true;
            o12Label.Visible = true;
            x20Label.Visible = true;
            o20Label.Visible = true;
            x21Label.Visible = true;
            o21Label.Visible = true;
            x22Label.Visible = true;
            o22Label.Visible = true;

            taken00Label.Text = "";
            taken01Label.Text = "";
            taken02Label.Text = "";
            taken10Label.Text = "";
            taken11Label.Text = "";
            taken12Label.Text = "";
            taken20Label.Text = "";
            taken21Label.Text = "";
            taken22Label.Text = "";

            x00Label.Enabled = true;
            x01Label.Enabled = true;
            x02Label.Enabled = true;
            x10Label.Enabled = true;
            x11Label.Enabled = true;
            x12Label.Enabled = true;
            x20Label.Enabled = true;
            x21Label.Enabled = true;
            x22Label.Enabled = true;

            o00Label.Enabled = false;
            o01Label.Enabled = false;
            o02Label.Enabled = false;
            o10Label.Enabled = false;
            o11Label.Enabled = false;
            o12Label.Enabled = false;
            o20Label.Enabled = false;
            o21Label.Enabled = false;
            o22Label.Enabled = false;

            turnLabel.Text = "Xs Turn";
        }
    }
}
