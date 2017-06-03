namespace BpacBarcode
{
    partial class BarcodeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cntCopies = new System.Windows.Forms.NumericUpDown();
            this.timestamp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cntCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(16, 201);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(251, 25);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print label";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Timestamp";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(93, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(174, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(93, 64);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(174, 20);
            this.txtBarcode.TabIndex = 9;
            // 
            // cntCopies
            // 
            this.cntCopies.Location = new System.Drawing.Point(93, 112);
            this.cntCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cntCopies.Name = "cntCopies";
            this.cntCopies.Size = new System.Drawing.Size(174, 20);
            this.cntCopies.TabIndex = 9;
            this.cntCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timestamp
            // 
            this.timestamp.Checked = false;
            this.timestamp.CustomFormat = "dd.MM.yyyy HH:mm";
            this.timestamp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestamp.Location = new System.Drawing.Point(93, 160);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(174, 20);
            this.timestamp.TabIndex = 9;
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 238);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.cntCopies);
            this.Controls.Add(this.timestamp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BarcodeForm";
            this.Text = "bpac-barcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cntCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timestamp;
        private System.Windows.Forms.NumericUpDown cntCopies;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}

