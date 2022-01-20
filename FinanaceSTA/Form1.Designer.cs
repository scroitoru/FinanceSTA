
namespace FinanaceSTA
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.dateTitleLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromTb = new System.Windows.Forms.TextBox();
            this.toTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tickerLbl = new System.Windows.Forms.Label();
            this.tickerTb = new System.Windows.Forms.TextBox();
            this.dgvDump = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDump)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(288, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(239, 61);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Daily PNL";
            // 
            // dateTitleLbl
            // 
            this.dateTitleLbl.AutoSize = true;
            this.dateTitleLbl.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTitleLbl.Location = new System.Drawing.Point(28, 96);
            this.dateTitleLbl.Name = "dateTitleLbl";
            this.dateTitleLbl.Size = new System.Drawing.Size(423, 29);
            this.dateTitleLbl.TabIndex = 1;
            this.dateTitleLbl.Text = "Please enter your desired date range:";
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLbl.Location = new System.Drawing.Point(28, 141);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(68, 27);
            this.fromLbl.TabIndex = 2;
            this.fromLbl.Text = "From:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLbl.Location = new System.Drawing.Point(223, 143);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(41, 27);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "To:";
            // 
            // fromTb
            // 
            this.fromTb.Location = new System.Drawing.Point(103, 143);
            this.fromTb.Name = "fromTb";
            this.fromTb.Size = new System.Drawing.Size(100, 31);
            this.fromTb.TabIndex = 4;
            // 
            // toTb
            // 
            this.toTb.Location = new System.Drawing.Point(278, 141);
            this.toTb.Name = "toTb";
            this.toTb.Size = new System.Drawing.Size(100, 31);
            this.toTb.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(635, 141);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(136, 46);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // tickerLbl
            // 
            this.tickerLbl.AutoSize = true;
            this.tickerLbl.Font = new System.Drawing.Font("Trebuchet MS", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerLbl.Location = new System.Drawing.Point(403, 143);
            this.tickerLbl.Name = "tickerLbl";
            this.tickerLbl.Size = new System.Drawing.Size(78, 27);
            this.tickerLbl.TabIndex = 8;
            this.tickerLbl.Text = "Ticker:";
            // 
            // tickerTb
            // 
            this.tickerTb.Location = new System.Drawing.Point(487, 143);
            this.tickerTb.Name = "tickerTb";
            this.tickerTb.Size = new System.Drawing.Size(100, 31);
            this.tickerTb.TabIndex = 9;
            // 
            // dgvDump
            // 
            this.dgvDump.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDump.Location = new System.Drawing.Point(33, 214);
            this.dgvDump.Name = "dgvDump";
            this.dgvDump.RowHeadersWidth = 82;
            this.dgvDump.RowTemplate.Height = 33;
            this.dgvDump.Size = new System.Drawing.Size(713, 372);
            this.dgvDump.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.dgvDump);
            this.Controls.Add(this.tickerTb);
            this.Controls.Add(this.tickerLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.toTb);
            this.Controls.Add(this.fromTb);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.dateTitleLbl);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDump)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateTitleLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.TextBox fromTb;
        private System.Windows.Forms.TextBox toTb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label tickerLbl;
        private System.Windows.Forms.TextBox tickerTb;
        private System.Windows.Forms.DataGridView dgvDump;
    }
}

