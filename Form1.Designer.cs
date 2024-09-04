namespace konsep_UI.net_Brigitaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.picbiodata = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbiodata)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "BIODATA";
            // 
            // picbiodata
            // 
            this.picbiodata.Image = ((System.Drawing.Image)(resources.GetObject("picbiodata.Image")));
            this.picbiodata.Location = new System.Drawing.Point(284, 79);
            this.picbiodata.Name = "picbiodata";
            this.picbiodata.Size = new System.Drawing.Size(189, 133);
            this.picbiodata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbiodata.TabIndex = 9;
            this.picbiodata.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "USERNAME";
            // 
            // txtusername
            // 
            this.txtusername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtusername.Location = new System.Drawing.Point(284, 243);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(189, 26);
            this.txtusername.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "PASSWORD";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(284, 310);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(189, 26);
            this.txtpassword.TabIndex = 13;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Info;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.Location = new System.Drawing.Point(245, 360);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 47);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(393, 360);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(101, 47);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbiodata);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Biodata";
            ((System.ComponentModel.ISupportInitialize)(this.picbiodata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picbiodata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
    }
}

