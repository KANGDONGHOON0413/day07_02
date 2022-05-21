
namespace MyWinform02
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
            this.BTN_COPY = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TXT_SHOW_PERSENT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_COPY
            // 
            this.BTN_COPY.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_COPY.Location = new System.Drawing.Point(280, 81);
            this.BTN_COPY.Name = "BTN_COPY";
            this.BTN_COPY.Size = new System.Drawing.Size(352, 113);
            this.BTN_COPY.TabIndex = 1;
            this.BTN_COPY.Text = "파일 복사 시작하기";
            this.BTN_COPY.UseVisualStyleBackColor = true;
            this.BTN_COPY.Click += new System.EventHandler(this.BTN_COPY_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(833, 33);
            this.progressBar1.TabIndex = 2;
            // 
            // TXT_SHOW_PERSENT
            // 
            this.TXT_SHOW_PERSENT.AutoSize = true;
            this.TXT_SHOW_PERSENT.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_SHOW_PERSENT.Location = new System.Drawing.Point(451, 330);
            this.TXT_SHOW_PERSENT.Name = "TXT_SHOW_PERSENT";
            this.TXT_SHOW_PERSENT.Size = new System.Drawing.Size(19, 23);
            this.TXT_SHOW_PERSENT.TabIndex = 3;
            this.TXT_SHOW_PERSENT.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 457);
            this.Controls.Add(this.TXT_SHOW_PERSENT);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BTN_COPY);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_COPY;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label TXT_SHOW_PERSENT;
    }
}

