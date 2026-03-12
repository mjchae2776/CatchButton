using System.Text.RegularExpressions;
using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int missCount = 0;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
            this.Text = "Catch the button version 1.2";
        }

        private void ResetGame()
        {
            score = 0;
            missCount = 0;

            btnTarget.Visible = true;

            btnTarget.Enabled = true; 
            btnTarget.Size = new Size(400,150);
            btnTarget.Text = "나를 잡아봐!";
            btnTarget.Font = new Font(btnTarget.Font.FontFamily, 48f); 

            btnReset.Visible = false; 
            this.Text = "Catch the button v1.2";
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
            missCount++;
            score -= 10;

            
            if (missCount >= 20)
            {
                GameOver();
                return; 
            }

            Random rd = new Random();
            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;
            int nextX = rd.Next(0, Math.Max(1, maxX));
            int nextY = rd.Next(0, Math.Max(1, maxY));

            btnTarget.Location = new Point(nextX, nextY);
            this.Text = $"점수: {score} | 놓친 횟수: {missCount}/20";
            SystemSounds.Beep.Play();
        }
        private void GameOver()
        {
            MessageBox.Show("Game Over");
            btnTarget.Visible = false;
            btnReset.Visible = true;   
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame(); 
        }
    }
}
