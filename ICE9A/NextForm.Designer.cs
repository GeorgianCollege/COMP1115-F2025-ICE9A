namespace ICE9A
{
    partial class NextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_Back = new Button();
            Button_Next = new Button();
            SuspendLayout();
            // 
            // Button_Back
            // 
            Button_Back.Font = new Font("Calibri", 16F);
            Button_Back.Location = new Point(41, 364);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(130, 50);
            Button_Back.TabIndex = 0;
            Button_Back.Text = "Back";
            Button_Back.UseVisualStyleBackColor = true;
            Button_Back.Click += Button_Back_Click;
            // 
            // Button_Next
            // 
            Button_Next.Font = new Font("Calibri", 16F);
            Button_Next.Location = new Point(629, 364);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(130, 50);
            Button_Next.TabIndex = 1;
            Button_Next.Text = "Next";
            Button_Next.UseVisualStyleBackColor = true;
            Button_Next.Click += Button_Next_Click;
            // 
            // NextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Next);
            Controls.Add(Button_Back);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NextForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Back;
        private Button Button_Next;
    }
}