using System.Text.RegularExpressions;
using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Catch the button version 1.2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 100;

           
            btnTarget.Width = (int)(btnTarget.Width * 0.9);
            btnTarget.Height = (int)(btnTarget.Height * 0.9);

            
            float newSize = btnTarget.Font.Size * 0.9f;

           
            if (newSize > 5f)
            {
                btnTarget.Font = new Font(btnTarget.Font.FontFamily, newSize);
            }

            this.Text = $"Catch the button v1.2 | 점수: {score}";

            SystemSounds.Asterisk.Play();
            MessageBox.Show("축하합니다~!");
            this.ActiveControl = null;


        }

        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            

            SystemSounds.Beep.Play();

            Random rd = new Random();

            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;


            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            
            btnTarget.Location = new Point(nextX, nextY);
            
            this.Text = $"버튼위치: ({nextX}, {nextY})";

            //도망갈 때 '띵' 하는 가벼운 경고음
            SystemSounds.Beep.Play();

            score -= 10;

            

            btnTarget.Location = new Point(nextX, nextY);


            this.Text = $"점수: {score} | 버튼위치: ({nextX}, {nextY})";
        }
    }
}
