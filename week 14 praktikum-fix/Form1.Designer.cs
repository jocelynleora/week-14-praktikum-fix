﻿namespace week_14_praktikum_fix
{
    partial class Form1
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
            this.dataGridView_last5match = new System.Windows.Forms.DataGridView();
            this.labelWorst = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonPrev2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_last5match)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_last5match
            // 
            this.dataGridView_last5match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_last5match.Location = new System.Drawing.Point(40, 247);
            this.dataGridView_last5match.Name = "dataGridView_last5match";
            this.dataGridView_last5match.Size = new System.Drawing.Size(389, 191);
            this.dataGridView_last5match.TabIndex = 44;
            // 
            // labelWorst
            // 
            this.labelWorst.AutoSize = true;
            this.labelWorst.Location = new System.Drawing.Point(132, 222);
            this.labelWorst.Name = "labelWorst";
            this.labelWorst.Size = new System.Drawing.Size(41, 13);
            this.labelWorst.TabIndex = 43;
            this.labelWorst.Text = "label10";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(132, 193);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(35, 13);
            this.labelTopScorer.TabIndex = 42;
            this.labelTopScorer.Text = "label9";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(132, 159);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(35, 13);
            this.labelStadium.TabIndex = 41;
            this.labelStadium.Text = "label8";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(132, 128);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(35, 13);
            this.labelManager.TabIndex = 40;
            this.labelManager.Text = "label7";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(132, 98);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(35, 13);
            this.labelTeamName.TabIndex = 39;
            this.labelTeamName.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Worst Discipline :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Top Scorer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Stadium :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Manager :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Team Name :";
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(239, 31);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(67, 44);
            this.buttonNext2.TabIndex = 33;
            this.buttonNext2.Text = ">>";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(173, 31);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(67, 44);
            this.buttonNext.TabIndex = 32;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(107, 31);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(67, 44);
            this.buttonPrev.TabIndex = 31;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonPrev2
            // 
            this.buttonPrev2.Location = new System.Drawing.Point(41, 31);
            this.buttonPrev2.Name = "buttonPrev2";
            this.buttonPrev2.Size = new System.Drawing.Size(67, 44);
            this.buttonPrev2.TabIndex = 30;
            this.buttonPrev2.Text = "<<";
            this.buttonPrev2.UseVisualStyleBackColor = true;
            this.buttonPrev2.Click += new System.EventHandler(this.buttonPrev2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_last5match);
            this.Controls.Add(this.labelWorst);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonPrev2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_last5match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_last5match;
        private System.Windows.Forms.Label labelWorst;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonPrev2;
    }
}

