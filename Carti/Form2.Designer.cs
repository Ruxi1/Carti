namespace Carti
{
    partial class Form2
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
            this.Coperta = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCarteaPotrivita = new System.Windows.Forms.Label();
            this.labelChosenBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coperta
            // 
            this.Coperta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Coperta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coperta.Location = new System.Drawing.Point(31, 282);
            this.Coperta.Name = "Coperta";
            this.Coperta.Size = new System.Drawing.Size(119, 53);
            this.Coperta.TabIndex = 11;
            this.Coperta.Text = "COPERTĂ";
            this.Coperta.UseVisualStyleBackColor = false;
            this.Coperta.Click += new System.EventHandler(this.Coperta_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(31, 432);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 50);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // labelCarteaPotrivita
            // 
            this.labelCarteaPotrivita.AutoSize = true;
            this.labelCarteaPotrivita.BackColor = System.Drawing.Color.Transparent;
            this.labelCarteaPotrivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarteaPotrivita.ForeColor = System.Drawing.Color.White;
            this.labelCarteaPotrivita.Location = new System.Drawing.Point(22, 54);
            this.labelCarteaPotrivita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarteaPotrivita.Name = "labelCarteaPotrivita";
            this.labelCarteaPotrivita.Size = new System.Drawing.Size(914, 52);
            this.labelCarteaPotrivita.TabIndex = 9;
            this.labelCarteaPotrivita.Text = "Cartea potrivită pentru dumneavoastră este:";
            // 
            // labelChosenBook
            // 
            this.labelChosenBook.AutoSize = true;
            this.labelChosenBook.BackColor = System.Drawing.Color.Transparent;
            this.labelChosenBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChosenBook.ForeColor = System.Drawing.Color.White;
            this.labelChosenBook.Location = new System.Drawing.Point(18, 130);
            this.labelChosenBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChosenBook.Name = "labelChosenBook";
            this.labelChosenBook.Size = new System.Drawing.Size(169, 65);
            this.labelChosenBook.TabIndex = 8;
            this.labelChosenBook.Text = "None";
            this.labelChosenBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1071, 536);
            this.Controls.Add(this.Coperta);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelCarteaPotrivita);
            this.Controls.Add(this.labelChosenBook);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Coperta;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCarteaPotrivita;
        public System.Windows.Forms.Label labelChosenBook;
    }
}