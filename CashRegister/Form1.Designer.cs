namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.computedway = new System.Windows.Forms.Label();
            this.numbox = new System.Windows.Forms.ComboBox();
            this.pricebox = new System.Windows.Forms.ComboBox();
            this.way = new System.Windows.Forms.ComboBox();
            this.receipt = new System.Windows.Forms.Button();
            this.recordlist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "单价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "数量";
            // 
            // computedway
            // 
            this.computedway.AutoSize = true;
            this.computedway.Location = new System.Drawing.Point(190, 148);
            this.computedway.Name = "computedway";
            this.computedway.Size = new System.Drawing.Size(53, 12);
            this.computedway.TabIndex = 1;
            this.computedway.Text = "计算方式";
            // 
            // numbox
            // 
            this.numbox.FormattingEnabled = true;
            this.numbox.Location = new System.Drawing.Point(255, 100);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(121, 20);
            this.numbox.TabIndex = 2;
            // 
            // pricebox
            // 
            this.pricebox.FormattingEnabled = true;
            this.pricebox.Location = new System.Drawing.Point(255, 58);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(121, 20);
            this.pricebox.TabIndex = 3;
            // 
            // way
            // 
            this.way.FormattingEnabled = true;
            this.way.Location = new System.Drawing.Point(255, 148);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(121, 20);
            this.way.TabIndex = 4;
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(532, 53);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(75, 23);
            this.receipt.TabIndex = 5;
            this.receipt.Text = "结算";
            this.receipt.UseVisualStyleBackColor = true;
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // recordlist
            // 
            this.recordlist.FormattingEnabled = true;
            this.recordlist.ItemHeight = 12;
            this.recordlist.Location = new System.Drawing.Point(192, 174);
            this.recordlist.Name = "recordlist";
            this.recordlist.Size = new System.Drawing.Size(415, 148);
            this.recordlist.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "总价：";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(253, 371);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(0, 12);
            this.sum.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 427);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recordlist);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.way);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.numbox);
            this.Controls.Add(this.computedway);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "总价";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label computedway;
        private System.Windows.Forms.ComboBox numbox;
        private System.Windows.Forms.ComboBox pricebox;
        private System.Windows.Forms.ComboBox way;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.ListBox recordlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sum;
    }
}

