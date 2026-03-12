namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {

            
            Random rd = new Random();
            
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;
            
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            
            btnTarget.Location = new Point(nextX, nextY);
            
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
