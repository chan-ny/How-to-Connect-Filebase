namespace FriebaseApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະຫັດ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຊື່:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "ນາມສະກຸນ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "ທີ່ຢູ່:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "ເບີໂທ:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(232, 42);
            this.txtid.TabIndex = 5;
            this.txtid.Text = "txtid";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(168, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(232, 42);
            this.txtname.TabIndex = 6;
            this.txtname.Text = "txtname";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(168, 143);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(232, 42);
            this.txtlastname.TabIndex = 7;
            this.txtlastname.Text = "txtlastname";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(168, 185);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(232, 42);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.Text = "txtaddress";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(168, 227);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(232, 42);
            this.txttel.TabIndex = 9;
            this.txttel.Text = "txttel";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(64, 301);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "ບັນທຶກ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(168, 301);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 33);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "ແກ້ໄຂ";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(278, 301);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "ລຶບ";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 443);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
    }
}

