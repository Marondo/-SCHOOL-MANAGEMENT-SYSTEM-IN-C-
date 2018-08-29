namespace SGE_em_CSharp_fx_06_018.Bag_frms
{
    partial class frmMover
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
            this.btnVend = new System.Windows.Forms.Button();
            this.chklV = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chklC = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevol = new System.Windows.Forms.Button();
            this.btnAnull = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVend
            // 
            this.btnVend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVend.Location = new System.Drawing.Point(266, 37);
            this.btnVend.Name = "btnVend";
            this.btnVend.Size = new System.Drawing.Size(234, 52);
            this.btnVend.TabIndex = 0;
            this.btnVend.Text = "Vender =>>>";
            this.btnVend.UseVisualStyleBackColor = true;
            this.btnVend.Click += new System.EventHandler(this.btnVend_Click);
            // 
            // chklV
            // 
            this.chklV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklV.FormattingEnabled = true;
            this.chklV.Location = new System.Drawing.Point(12, 37);
            this.chklV.Name = "chklV";
            this.chklV.Size = new System.Drawing.Size(199, 214);
            this.chklV.TabIndex = 1;
            this.chklV.SelectedIndexChanged += new System.EventHandler(this.chklV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENDEDOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(454, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicione elementos pra a venda";
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(8, 30);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(152, 26);
            this.txtAdd.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(177, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chklC
            // 
            this.chklC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklC.FormattingEnabled = true;
            this.chklC.Location = new System.Drawing.Point(565, 37);
            this.chklC.Name = "chklC";
            this.chklC.Size = new System.Drawing.Size(200, 214);
            this.chklC.TabIndex = 5;
            this.chklC.SelectedIndexChanged += new System.EventHandler(this.chklC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLIENTE";
            // 
            // btnDevol
            // 
            this.btnDevol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevol.Location = new System.Drawing.Point(266, 94);
            this.btnDevol.Name = "btnDevol";
            this.btnDevol.Size = new System.Drawing.Size(234, 52);
            this.btnDevol.TabIndex = 7;
            this.btnDevol.Text = "<<<= Devolver";
            this.btnDevol.UseVisualStyleBackColor = true;
            this.btnDevol.Click += new System.EventHandler(this.btnDevol_Click);
            // 
            // btnAnull
            // 
            this.btnAnull.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnull.Location = new System.Drawing.Point(266, 152);
            this.btnAnull.Name = "btnAnull";
            this.btnAnull.Size = new System.Drawing.Size(234, 52);
            this.btnAnull.TabIndex = 8;
            this.btnAnull.Text = "Anular ultima venda";
            this.btnAnull.UseVisualStyleBackColor = true;
            this.btnAnull.Click += new System.EventHandler(this.btnAnull_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(266, 210);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(234, 52);
            this.btnLimp.TabIndex = 9;
            this.btnLimp.Text = "Limpar tudo";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // frmMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 343);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnAnull);
            this.Controls.Add(this.btnDevol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chklC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chklV);
            this.Controls.Add(this.btnVend);
            this.Name = "frmMover";
            this.Text = "frmMover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVend;
        private System.Windows.Forms.CheckedListBox chklV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.CheckedListBox chklC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevol;
        private System.Windows.Forms.Button btnAnull;
        private System.Windows.Forms.Button btnLimp;
    }
}