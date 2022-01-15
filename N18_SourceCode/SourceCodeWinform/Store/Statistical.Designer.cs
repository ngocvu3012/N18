
namespace Store
{
    partial class Statistical
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStatistical = new System.Windows.Forms.DateTimePicker();
            this.storeView = new System.Windows.Forms.DataGridView();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.InBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.cancleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MTO  Astro City", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(25, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MTO augie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Statistical ";
            // 
            // dateStatistical
            // 
            this.dateStatistical.CustomFormat = "yyyy/dd/mm";
            this.dateStatistical.Font = new System.Drawing.Font("MTO Canun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStatistical.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStatistical.Location = new System.Drawing.Point(96, 71);
            this.dateStatistical.Name = "dateStatistical";
            this.dateStatistical.Size = new System.Drawing.Size(222, 37);
            this.dateStatistical.TabIndex = 13;
            // 
            // storeView
            // 
            this.storeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeView.Location = new System.Drawing.Point(30, 137);
            this.storeView.Name = "storeView";
            this.storeView.RowHeadersWidth = 51;
            this.storeView.RowTemplate.Height = 24;
            this.storeView.Size = new System.Drawing.Size(810, 405);
            this.storeView.TabIndex = 14;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.LightGray;
            this.confirmBtn.Location = new System.Drawing.Point(514, 552);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(160, 70);
            this.confirmBtn.TabIndex = 17;
            this.confirmBtn.Text = "Receipt";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // InBtn
            // 
            this.InBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.InBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InBtn.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBtn.ForeColor = System.Drawing.Color.LightGray;
            this.InBtn.Location = new System.Drawing.Point(550, 66);
            this.InBtn.Name = "InBtn";
            this.InBtn.Size = new System.Drawing.Size(98, 48);
            this.InBtn.TabIndex = 18;
            this.InBtn.Text = "In";
            this.InBtn.UseVisualStyleBackColor = false;
            this.InBtn.Click += new System.EventHandler(this.InBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.outBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outBtn.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBtn.ForeColor = System.Drawing.Color.LightGray;
            this.outBtn.Location = new System.Drawing.Point(703, 63);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(98, 48);
            this.outBtn.TabIndex = 19;
            this.outBtn.Text = "Out";
            this.outBtn.UseVisualStyleBackColor = false;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleBtn.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.ForeColor = System.Drawing.Color.LightGray;
            this.cancleBtn.Location = new System.Drawing.Point(680, 552);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(160, 70);
            this.cancleBtn.TabIndex = 20;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 630);
            this.Controls.Add(this.cancleBtn);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.InBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.storeView);
            this.Controls.Add(this.dateStatistical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Statistical";
            this.Text = "Statistical";
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStatistical;
        private System.Windows.Forms.DataGridView storeView;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button InBtn;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button cancleBtn;
    }
}