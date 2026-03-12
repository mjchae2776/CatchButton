namespace CatchButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTarget = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btnTarget
            // 
            btnTarget.BackColor = SystemColors.ActiveCaption;
            btnTarget.Font = new Font("함초롬돋움 확장", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTarget.Location = new Point(96, 124);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(400, 150);
            btnTarget.TabIndex = 0;
            btnTarget.Text = "나를 잡아봐";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += button1_Click;
            btnTarget.MouseEnter += btnTarget_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTarget;
        private ColorDialog colorDialog1;
    }
}
