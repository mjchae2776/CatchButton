using System.Text.RegularExpressions;

namespace CatchButton
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Text = "Catch the button version 1.2";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            
            Random rd = new Random();

            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;


            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            
            btnTarget.Location = new Point(nextX, nextY);
            
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
