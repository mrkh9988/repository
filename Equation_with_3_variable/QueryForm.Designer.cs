namespace csEquationSolver
{
    partial class QueryForm
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
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.cheklist = new System.Windows.Forms.CheckedListBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtmoadelet = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtresulte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtto
            // 
            this.txtto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtto.Location = new System.Drawing.Point(599, 144);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(270, 20);
            this.txtto.TabIndex = 14;
            // 
            // txtcity
            // 
            this.txtcity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcity.Location = new System.Drawing.Point(599, 82);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(270, 20);
            this.txtcity.TabIndex = 13;
            // 
            // txtlname
            // 
            this.txtlname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlname.Location = new System.Drawing.Point(599, 52);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(270, 20);
            this.txtlname.TabIndex = 12;
            // 
            // txtfname
            // 
            this.txtfname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfname.Location = new System.Drawing.Point(599, 20);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(270, 20);
            this.txtfname.TabIndex = 11;
            // 
            // cheklist
            // 
            this.cheklist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cheklist.BackColor = System.Drawing.SystemColors.Control;
            this.cheklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cheklist.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cheklist.FormattingEnabled = true;
            this.cheklist.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "شهر",
            "سن بالای یک مقدار",
            "سن کمتر از یک مقدار",
            "معادلات",
            "جواب معادلات"});
            this.cheklist.Location = new System.Drawing.Point(873, 13);
            this.cheklist.Name = "cheklist";
            this.cheklist.Size = new System.Drawing.Size(161, 217);
            this.cheklist.TabIndex = 19;
            // 
            // txtfrom
            // 
            this.txtfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfrom.Location = new System.Drawing.Point(599, 114);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(271, 20);
            this.txtfrom.TabIndex = 20;
            // 
            // txtmoadelet
            // 
            this.txtmoadelet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmoadelet.Location = new System.Drawing.Point(599, 175);
            this.txtmoadelet.Name = "txtmoadelet";
            this.txtmoadelet.Size = new System.Drawing.Size(270, 20);
            this.txtmoadelet.TabIndex = 22;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRun.Location = new System.Drawing.Point(462, 175);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(110, 55);
            this.btnRun.TabIndex = 26;
            this.btnRun.Text = "اجرا";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1155, 202);
            this.dataGridView1.TabIndex = 27;
            // 
            // txtresulte
            // 
            this.txtresulte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtresulte.Location = new System.Drawing.Point(599, 206);
            this.txtresulte.Name = "txtresulte";
            this.txtresulte.Size = new System.Drawing.Size(270, 20);
            this.txtresulte.TabIndex = 24;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtresulte);
            this.Controls.Add(this.txtmoadelet);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.cheklist);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.CheckedListBox cheklist;
        private System.Windows.Forms.TextBox txtfrom;
        public System.Windows.Forms.TextBox txtmoadelet;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txtresulte;
    }
}