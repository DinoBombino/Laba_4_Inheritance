namespace Laba_4_Inheritance
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
            btnRefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            txtQueue = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(14, 16);
            btnRefill.Margin = new Padding(3, 4, 3, 4);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(305, 31);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(233, 107);
            btnGet.Margin = new Padding(3, 4, 3, 4);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(86, 128);
            btnGet.TabIndex = 1;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(14, 55);
            txtInfo.Margin = new Padding(3, 4, 3, 4);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(305, 44);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(14, 107);
            txtOut.Margin = new Padding(3, 4, 3, 4);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(212, 127);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // txtQueue
            // 
            txtQueue.Location = new Point(325, 55);
            txtQueue.Name = "txtQueue";
            txtQueue.Size = new Size(172, 182);
            txtQueue.TabIndex = 4;
            txtQueue.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Очередь";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 249);
            Controls.Add(label1);
            Controls.Add(txtQueue);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private RichTextBox txtQueue;
        private Label label1;
    }
}
