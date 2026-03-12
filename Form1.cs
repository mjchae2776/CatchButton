using System.Text.RegularExpressions;
using System.Media;

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
            //잡았을 때 '띠링' 하는 느낌의 소리
            SystemSounds.Asterisk.Play();

            // 1. 소리 재생
            SystemSounds.Asterisk.Play();

            // 2. 메시지 박스 출력
            MessageBox.Show("축하합니다~!");

            // 3. 게임 재시작 준비 (제목 표시줄 초기화)
            this.Text = "Catch the button version 1.2";
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

            //도망갈 때 '띵' 하는 가벼운 경고음
            SystemSounds.Beep.Play();
        }
    }
}
