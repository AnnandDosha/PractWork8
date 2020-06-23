namespace PR_8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerformButton = new System.Windows.Forms.Button();
            this.imageformButton = new System.Windows.Forms.Button();
            this.tadcontrolButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerformButton
            // 
            this.timerformButton.Location = new System.Drawing.Point(120, 41);
            this.timerformButton.Name = "timerformButton";
            this.timerformButton.Size = new System.Drawing.Size(75, 23);
            this.timerformButton.TabIndex = 0;
            this.timerformButton.Text = "5.1";
            this.timerformButton.UseVisualStyleBackColor = true;
            this.timerformButton.Click += new System.EventHandler(this.button_Click);
            // 
            // imageformButton
            // 
            this.imageformButton.Location = new System.Drawing.Point(120, 70);
            this.imageformButton.Name = "imageformButton";
            this.imageformButton.Size = new System.Drawing.Size(75, 23);
            this.imageformButton.TabIndex = 1;
            this.imageformButton.Text = "5.2";
            this.imageformButton.UseVisualStyleBackColor = true;
            this.imageformButton.Click += new System.EventHandler(this.ImageformButton_Click);
            // 
            // tadcontrolButton
            // 
            this.tadcontrolButton.Location = new System.Drawing.Point(312, 41);
            this.tadcontrolButton.Name = "tadcontrolButton";
            this.tadcontrolButton.Size = new System.Drawing.Size(75, 23);
            this.tadcontrolButton.TabIndex = 2;
            this.tadcontrolButton.Text = "5.3";
            this.tadcontrolButton.UseVisualStyleBackColor = true;
            this.tadcontrolButton.Click += new System.EventHandler(this.tadcontrolButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "5.4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tadcontrolButton);
            this.Controls.Add(this.imageformButton);
            this.Controls.Add(this.timerformButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button timerformButton;
        private System.Windows.Forms.Button imageformButton;
        private System.Windows.Forms.Button tadcontrolButton;
        private System.Windows.Forms.Button button1;
    }
}

