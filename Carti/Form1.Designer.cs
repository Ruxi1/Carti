namespace Carti
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEcranizare = new System.Windows.Forms.Label();
            this.checkedListEcranizare = new System.Windows.Forms.CheckedListBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.checkedListAutor = new System.Windows.Forms.CheckedListBox();
            this.labelSubgen = new System.Windows.Forms.Label();
            this.checkedListSubgen = new System.Windows.Forms.CheckedListBox();
            this.checkedListGen = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Gen:";
            // 
            // buttonCauta
            // 
            this.buttonCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCauta.Location = new System.Drawing.Point(438, 440);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(133, 39);
            this.buttonCauta.TabIndex = 29;
            this.buttonCauta.Text = "CAUTĂ";
            this.buttonCauta.UseVisualStyleBackColor = false;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 60);
            this.label1.TabIndex = 28;
            this.label1.Text = "Choose your book";
            // 
            // labelEcranizare
            // 
            this.labelEcranizare.AutoSize = true;
            this.labelEcranizare.BackColor = System.Drawing.Color.Transparent;
            this.labelEcranizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEcranizare.ForeColor = System.Drawing.Color.White;
            this.labelEcranizare.Location = new System.Drawing.Point(864, 172);
            this.labelEcranizare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEcranizare.Name = "labelEcranizare";
            this.labelEcranizare.Size = new System.Drawing.Size(122, 25);
            this.labelEcranizare.TabIndex = 27;
            this.labelEcranizare.Text = "Ecranizare:";
            // 
            // checkedListEcranizare
            // 
            this.checkedListEcranizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkedListEcranizare.CheckOnClick = true;
            this.checkedListEcranizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListEcranizare.FormattingEnabled = true;
            this.checkedListEcranizare.Items.AddRange(new object[] {
            "da",
            "nu"});
            this.checkedListEcranizare.Location = new System.Drawing.Point(869, 199);
            this.checkedListEcranizare.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListEcranizare.Name = "checkedListEcranizare";
            this.checkedListEcranizare.Size = new System.Drawing.Size(160, 151);
            this.checkedListEcranizare.TabIndex = 26;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(570, 172);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(71, 25);
            this.labelAutor.TabIndex = 25;
            this.labelAutor.Text = "Autor:";
            // 
            // checkedListAutor
            // 
            this.checkedListAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkedListAutor.CheckOnClick = true;
            this.checkedListAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListAutor.FormattingEnabled = true;
            this.checkedListAutor.Items.AddRange(new object[] {
            "John Green",
            "Jenny Han",
            "Veronica Roth",
            "Andreea Russo",
            "Dan Brown",
            "Jules Verne",
            "Gayle Forman",
            "Suzanne Collins",
            "James Patterson",
            "Jojo Moyes",
            "Paula Hawkins",
            "Cassandra Clare",
            "Agnes Martin-Lugand"});
            this.checkedListAutor.Location = new System.Drawing.Point(575, 199);
            this.checkedListAutor.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListAutor.Name = "checkedListAutor";
            this.checkedListAutor.Size = new System.Drawing.Size(256, 151);
            this.checkedListAutor.TabIndex = 24;
            // 
            // labelSubgen
            // 
            this.labelSubgen.AutoSize = true;
            this.labelSubgen.BackColor = System.Drawing.Color.Transparent;
            this.labelSubgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubgen.ForeColor = System.Drawing.Color.White;
            this.labelSubgen.Location = new System.Drawing.Point(280, 170);
            this.labelSubgen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubgen.Name = "labelSubgen";
            this.labelSubgen.Size = new System.Drawing.Size(94, 25);
            this.labelSubgen.TabIndex = 23;
            this.labelSubgen.Text = "Subgen:";
            // 
            // checkedListSubgen
            // 
            this.checkedListSubgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkedListSubgen.CheckOnClick = true;
            this.checkedListSubgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListSubgen.FormattingEnabled = true;
            this.checkedListSubgen.Items.AddRange(new object[] {
            "drama",
            "comedie",
            "dragoste",
            "thriller",
            "sf",
            "psihologic"});
            this.checkedListSubgen.Location = new System.Drawing.Point(285, 199);
            this.checkedListSubgen.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListSubgen.Name = "checkedListSubgen";
            this.checkedListSubgen.Size = new System.Drawing.Size(252, 151);
            this.checkedListSubgen.TabIndex = 22;
            // 
            // checkedListGen
            // 
            this.checkedListGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkedListGen.CheckOnClick = true;
            this.checkedListGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListGen.FormattingEnabled = true;
            this.checkedListGen.Items.AddRange(new object[] {
            "dragoste",
            "sf",
            "mister",
            "aventura",
            "drama",
            "actiune",
            "fantezie"});
            this.checkedListGen.Location = new System.Drawing.Point(41, 199);
            this.checkedListGen.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListGen.Name = "checkedListGen";
            this.checkedListGen.Size = new System.Drawing.Size(209, 151);
            this.checkedListGen.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1071, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEcranizare);
            this.Controls.Add(this.checkedListEcranizare);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.checkedListAutor);
            this.Controls.Add(this.labelSubgen);
            this.Controls.Add(this.checkedListSubgen);
            this.Controls.Add(this.checkedListGen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEcranizare;
        private System.Windows.Forms.CheckedListBox checkedListEcranizare;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.CheckedListBox checkedListAutor;
        private System.Windows.Forms.Label labelSubgen;
        private System.Windows.Forms.CheckedListBox checkedListSubgen;
        private System.Windows.Forms.CheckedListBox checkedListGen;
    }
}

