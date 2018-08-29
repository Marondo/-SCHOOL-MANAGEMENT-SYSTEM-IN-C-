namespace SGE_em_CSharp_fx_06_018.Bag_frms
{
    partial class Jogo_fx
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
            this.btn1 = new System.Windows.Forms.Button();
            this.chkl2 = new System.Windows.Forms.CheckedListBox();
            this.chkl3 = new System.Windows.Forms.CheckedListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.chkl1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 148);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(199, 52);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "AQUI";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // chkl2
            // 
            this.chkl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkl2.FormattingEnabled = true;
            this.chkl2.Location = new System.Drawing.Point(217, 12);
            this.chkl2.Name = "chkl2";
            this.chkl2.Size = new System.Drawing.Size(200, 130);
            this.chkl2.TabIndex = 12;
            this.chkl2.SelectedIndexChanged += new System.EventHandler(this.chkl2_SelectedIndexChanged);
            // 
            // chkl3
            // 
            this.chkl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkl3.FormattingEnabled = true;
            this.chkl3.Location = new System.Drawing.Point(423, 12);
            this.chkl3.Name = "chkl3";
            this.chkl3.Size = new System.Drawing.Size(200, 130);
            this.chkl3.TabIndex = 16;
            this.chkl3.SelectedIndexChanged += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(217, 148);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(199, 52);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "AQUI";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(424, 148);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(199, 52);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "AQUI";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(12, 206);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(611, 35);
            this.btnLimp.TabIndex = 19;
            this.btnLimp.Text = "Limpar tudo";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // chkl1
            // 
            this.chkl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkl1.FormattingEnabled = true;
            this.chkl1.Location = new System.Drawing.Point(12, 12);
            this.chkl1.Name = "chkl1";
            this.chkl1.Size = new System.Drawing.Size(199, 130);
            this.chkl1.TabIndex = 11;
            this.chkl1.SelectedIndexChanged += new System.EventHandler(this.chkl1_SelectedIndexChanged);
            // 
            // Jogo_fx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 250);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.chkl3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.chkl2);
            this.Controls.Add(this.chkl1);
            this.Name = "Jogo_fx";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jogo_fx";
            this.Load += new System.EventHandler(this.Jogo_fx_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckedListBox chkl2;
        private System.Windows.Forms.CheckedListBox chkl3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.CheckedListBox chkl1;
    }
}