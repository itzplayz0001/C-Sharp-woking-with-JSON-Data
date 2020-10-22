namespace JSON1
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
            this.idNo = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sHobbies = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idNo
            // 
            this.idNo.Location = new System.Drawing.Point(173, 54);
            this.idNo.Name = "idNo";
            this.idNo.Size = new System.Drawing.Size(131, 20);
            this.idNo.TabIndex = 0;
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Location = new System.Drawing.Point(31, 57);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(58, 13);
            this.idTxt.TabIndex = 1;
            this.idTxt.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(173, 80);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(131, 20);
            this.sName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Hobbies";
            // 
            // sHobbies
            // 
            this.sHobbies.Location = new System.Drawing.Point(173, 106);
            this.sHobbies.Name = "sHobbies";
            this.sHobbies.Size = new System.Drawing.Size(131, 20);
            this.sHobbies.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(87, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Manager";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(229, 142);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 7;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 182);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sHobbies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.idNo);
            this.Name = "Form1";
            this.Text = "JSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idNo;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sHobbies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create;
    }
}

