namespace dealCard
{
    partial class dealCardForm
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
            this.picCard = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Image = global::dealCard.Properties.Resources.QS;
            this.picCard.Location = new System.Drawing.Point(38, 12);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(186, 261);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(84, 299);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(91, 34);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal Card";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // dealCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.picCard);
            this.Name = "dealCardForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Button btnDeal;
    }
}

