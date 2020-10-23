namespace JSON1
{
    partial class View
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
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.Label();
            this.dProblem = new System.Windows.Forms.Label();
            this.dFix = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "View Record";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.save.Location = new System.Drawing.Point(302, 67);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(61, 26);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(33, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "FIX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(33, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Problem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // dName
            // 
            this.dName.AutoSize = true;
            this.dName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dName.Location = new System.Drawing.Point(154, 114);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(13, 18);
            this.dName.TabIndex = 16;
            this.dName.Text = "-";
            // 
            // dProblem
            // 
            this.dProblem.AutoSize = true;
            this.dProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dProblem.Location = new System.Drawing.Point(154, 148);
            this.dProblem.Name = "dProblem";
            this.dProblem.Size = new System.Drawing.Size(13, 18);
            this.dProblem.TabIndex = 17;
            this.dProblem.Text = "-";
            // 
            // dFix
            // 
            this.dFix.AutoSize = true;
            this.dFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dFix.Location = new System.Drawing.Point(154, 184);
            this.dFix.Name = "dFix";
            this.dFix.Size = new System.Drawing.Size(13, 18);
            this.dFix.TabIndex = 18;
            this.dFix.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(33, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // uName
            // 
            this.uName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.uName.Location = new System.Drawing.Point(103, 67);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(193, 26);
            this.uName.TabIndex = 20;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 237);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dFix);
            this.Controls.Add(this.dProblem);
            this.Controls.Add(this.dName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dName;
        private System.Windows.Forms.Label dProblem;
        private System.Windows.Forms.Label dFix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uName;
    }
}