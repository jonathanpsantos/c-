
namespace Aula030323
{
    partial class FormPersonagens
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
            this.pictureBoxPersonagem = new System.Windows.Forms.PictureBox();
            this.ltbPersonagem = new System.Windows.Forms.ListBox();
            this.cmbPersonagem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPersonagem
            // 
            this.pictureBoxPersonagem.Location = new System.Drawing.Point(444, 12);
            this.pictureBoxPersonagem.Name = "pictureBoxPersonagem";
            this.pictureBoxPersonagem.Size = new System.Drawing.Size(344, 426);
            this.pictureBoxPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPersonagem.TabIndex = 0;
            this.pictureBoxPersonagem.TabStop = false;
            // 
            // ltbPersonagem
            // 
            this.ltbPersonagem.FormattingEnabled = true;
            this.ltbPersonagem.Items.AddRange(new object[] {
            "Goku",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru"});
            this.ltbPersonagem.Location = new System.Drawing.Point(91, 33);
            this.ltbPersonagem.Name = "ltbPersonagem";
            this.ltbPersonagem.Size = new System.Drawing.Size(120, 186);
            this.ltbPersonagem.TabIndex = 1;
            this.ltbPersonagem.SelectedIndexChanged += new System.EventHandler(this.ltbPersonagem_SelectedIndexChanged);
            // 
            // cmbPersonagem
            // 
            this.cmbPersonagem.FormattingEnabled = true;
            this.cmbPersonagem.Items.AddRange(new object[] {
            "Goku ",
            "Vegeta",
            "Inuyasha",
            "Sesshoumaru"});
            this.cmbPersonagem.Location = new System.Drawing.Point(90, 235);
            this.cmbPersonagem.Name = "cmbPersonagem";
            this.cmbPersonagem.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonagem.TabIndex = 2;
            this.cmbPersonagem.SelectedIndexChanged += new System.EventHandler(this.cmbPersonagem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gabriel Victor Cepeda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jonathan Pereira Dos Santos";
            // 
            // FormPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPersonagem);
            this.Controls.Add(this.ltbPersonagem);
            this.Controls.Add(this.pictureBoxPersonagem);
            this.Name = "FormPersonagens";
            this.Text = "O Programa Personagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersonagem;
        private System.Windows.Forms.ListBox ltbPersonagem;
        private System.Windows.Forms.ComboBox cmbPersonagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

