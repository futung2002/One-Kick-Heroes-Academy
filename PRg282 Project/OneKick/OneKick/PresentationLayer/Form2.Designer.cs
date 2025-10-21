namespace OneKick.PresentationLayer
{
    partial class Form2
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
            this.btnAvgExamScore = new System.Windows.Forms.Button();
            this.btnAvgAge = new System.Windows.Forms.Button();
            this.btnNumOfSuperheroes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvgExamScore
            // 
            this.btnAvgExamScore.Location = new System.Drawing.Point(592, 56);
            this.btnAvgExamScore.Name = "btnAvgExamScore";
            this.btnAvgExamScore.Size = new System.Drawing.Size(166, 37);
            this.btnAvgExamScore.TabIndex = 0;
            this.btnAvgExamScore.Text = "Average Exam Score";
            this.btnAvgExamScore.UseVisualStyleBackColor = true;
            this.btnAvgExamScore.Click += new System.EventHandler(this.btnAvgExamScore_Click);
            // 
            // btnAvgAge
            // 
            this.btnAvgAge.Location = new System.Drawing.Point(52, 62);
            this.btnAvgAge.Name = "btnAvgAge";
            this.btnAvgAge.Size = new System.Drawing.Size(160, 31);
            this.btnAvgAge.TabIndex = 2;
            this.btnAvgAge.Text = "Average Age";
            this.btnAvgAge.UseVisualStyleBackColor = true;
            this.btnAvgAge.Click += new System.EventHandler(this.btnAvgAge_Click);
            // 
            // btnNumOfSuperheroes
            // 
            this.btnNumOfSuperheroes.Location = new System.Drawing.Point(286, 62);
            this.btnNumOfSuperheroes.Name = "btnNumOfSuperheroes";
            this.btnNumOfSuperheroes.Size = new System.Drawing.Size(216, 31);
            this.btnNumOfSuperheroes.TabIndex = 3;
            this.btnNumOfSuperheroes.Text = "Number of SuperHeroes";
            this.btnNumOfSuperheroes.UseMnemonic = false;
            this.btnNumOfSuperheroes.UseVisualStyleBackColor = true;
            this.btnNumOfSuperheroes.Click += new System.EventHandler(this.btnNumOfSuperheroes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumOfSuperheroes);
            this.Controls.Add(this.btnAvgAge);
            this.Controls.Add(this.btnAvgExamScore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvgExamScore;
        private System.Windows.Forms.Button btnAvgAge;
        private System.Windows.Forms.Button btnNumOfSuperheroes;
    }
}