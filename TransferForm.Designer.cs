namespace banking
{
    partial class TransferForm
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
            this.datelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromacctxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.desaccounttxt = new System.Windows.Forms.TextBox();
            this.transfertxt = new System.Windows.Forms.TextBox();
            this.detailsbtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(308, 70);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 16);
            this.datelbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Current Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount";
            // 
            // fromacctxt
            // 
            this.fromacctxt.Location = new System.Drawing.Point(250, 141);
            this.fromacctxt.Name = "fromacctxt";
            this.fromacctxt.Size = new System.Drawing.Size(273, 22);
            this.fromacctxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(250, 212);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(273, 22);
            this.nametxt.TabIndex = 8;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(250, 288);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(273, 22);
            this.amounttxt.TabIndex = 9;
            // 
            // desaccounttxt
            // 
            this.desaccounttxt.Location = new System.Drawing.Point(250, 365);
            this.desaccounttxt.Name = "desaccounttxt";
            this.desaccounttxt.Size = new System.Drawing.Size(273, 22);
            this.desaccounttxt.TabIndex = 10;
            // 
            // transfertxt
            // 
            this.transfertxt.Location = new System.Drawing.Point(250, 440);
            this.transfertxt.Name = "transfertxt";
            this.transfertxt.Size = new System.Drawing.Size(273, 22);
            this.transfertxt.TabIndex = 11;
            // 
            // detailsbtn
            // 
            this.detailsbtn.Location = new System.Drawing.Point(561, 129);
            this.detailsbtn.Name = "detailsbtn";
            this.detailsbtn.Size = new System.Drawing.Size(104, 46);
            this.detailsbtn.TabIndex = 12;
            this.detailsbtn.Text = "Show Details";
            this.detailsbtn.UseVisualStyleBackColor = true;
            this.detailsbtn.Click += new System.EventHandler(this.detailsbtn_Click);
            // 
            // transferbtn
            // 
            this.transferbtn.Location = new System.Drawing.Point(250, 529);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(144, 52);
            this.transferbtn.TabIndex = 13;
            this.transferbtn.Text = "Transfer Account";
            this.transferbtn.UseVisualStyleBackColor = true;
            this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 655);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.detailsbtn);
            this.Controls.Add(this.transfertxt);
            this.Controls.Add(this.desaccounttxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.fromacctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromacctxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.TextBox desaccounttxt;
        private System.Windows.Forms.TextBox transfertxt;
        private System.Windows.Forms.Button detailsbtn;
        private System.Windows.Forms.Button transferbtn;
    }
}