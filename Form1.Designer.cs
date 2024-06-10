namespace CSharp_List_name
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
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnhapten
            // 
            this.txtnhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapten.Location = new System.Drawing.Point(44, 137);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(233, 38);
            this.txtnhapten.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lsbketqua
            // 
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(30, 185);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(506, 225);
            this.lsbketqua.TabIndex = 7;
            this.lsbketqua.SelectedIndexChanged += new System.EventHandler(this.lsbketqua_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(327, 137);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(143, 42);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(476, 137);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 42);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "&XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(580, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 42);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}

