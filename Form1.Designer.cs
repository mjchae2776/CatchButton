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
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnTarget
            // 
            btnTarget.AutoSize = true;
            btnTarget.BackColor = SystemColors.ActiveCaption;
            btnTarget.Font = new Font("함초롬돋움 확장", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTarget.Location = new Point(96, 124);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(400, 150);
            btnTarget.TabIndex = 0;
            btnTarget.TabStop = false;
            btnTarget.Text = "나를 잡아봐";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += button1_Click;
            btnTarget.MouseEnter += btnTarget_MouseEnter;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Gainsboro;
            btnReset.Font = new Font("함초롬바탕 확장", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.Location = new Point(294, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(248, 86);
            btnReset.TabIndex = 1;
            btnReset.Text = "다시 시작";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTarget;
        private ColorDialog colorDialog1;
        private Button btnReset;
    }
}
