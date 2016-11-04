namespace RemClient
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
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtLastDeposit = new System.Windows.Forms.TextBox();
            this.txtLastWithdraw = new System.Windows.Forms.TextBox();
            this.btnInvokeRemote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(113, 15);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(348, 20);
            this.txtCustId.TabIndex = 0;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(113, 58);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(348, 20);
            this.txtCustName.TabIndex = 1;
            // 
            // txtLastDeposit
            // 
            this.txtLastDeposit.Location = new System.Drawing.Point(113, 95);
            this.txtLastDeposit.Name = "txtLastDeposit";
            this.txtLastDeposit.Size = new System.Drawing.Size(348, 20);
            this.txtLastDeposit.TabIndex = 2;
            // 
            // txtLastWithdraw
            // 
            this.txtLastWithdraw.Location = new System.Drawing.Point(113, 134);
            this.txtLastWithdraw.Name = "txtLastWithdraw";
            this.txtLastWithdraw.Size = new System.Drawing.Size(348, 20);
            this.txtLastWithdraw.TabIndex = 3;
            // 
            // btnInvokeRemote
            // 
            this.btnInvokeRemote.Location = new System.Drawing.Point(314, 163);
            this.btnInvokeRemote.Name = "btnInvokeRemote";
            this.btnInvokeRemote.Size = new System.Drawing.Size(134, 23);
            this.btnInvokeRemote.TabIndex = 4;
            this.btnInvokeRemote.Text = "GetDetails ( from Client )";
            this.btnInvokeRemote.UseVisualStyleBackColor = true;
            this.btnInvokeRemote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CustomerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastDeposit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "lastWithdraw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 195);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvokeRemote);
            this.Controls.Add(this.txtLastWithdraw);
            this.Controls.Add(this.txtLastDeposit);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtLastDeposit;
        private System.Windows.Forms.TextBox txtLastWithdraw;
        private System.Windows.Forms.Button btnInvokeRemote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

