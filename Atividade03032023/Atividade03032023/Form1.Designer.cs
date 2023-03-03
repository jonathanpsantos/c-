
namespace Atividade03032023
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPersonagem = new System.Windows.Forms.ListBox();
            this.comboBoxPersonagem = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listBoxPersonagem
            // 
            this.listBoxPersonagem.FormattingEnabled = true;
            this.listBoxPersonagem.Items.AddRange(new object[] {
            "Asta",
            "Saitama",
            "Senku",
            "Bakugou",
            "Deku",
            "Allmight"});
            this.listBoxPersonagem.Location = new System.Drawing.Point(95, 45);
            this.listBoxPersonagem.Name = "listBoxPersonagem";
            this.listBoxPersonagem.Size = new System.Drawing.Size(120, 95);
            this.listBoxPersonagem.TabIndex = 2;
            this.listBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.FormPersonagens_SelectedIndexChanged);
            // 
            // comboBoxPersonagem
            // 
            this.comboBoxPersonagem.FormattingEnabled = true;
            this.comboBoxPersonagem.Items.AddRange(new object[] {
            "Asta",
            "Saitama",
            "Senku",
            "Bakugou",
            "Deku",
            "Allmight"});
            this.comboBoxPersonagem.Location = new System.Drawing.Point(95, 222);
            this.comboBoxPersonagem.Name = "comboBoxPersonagem";
            this.comboBoxPersonagem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersonagem.TabIndex = 3;
            this.comboBoxPersonagem.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonagem_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atividade03032023.Properties.Resources.asta;
            this.pictureBox1.Location = new System.Drawing.Point(410, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPersonagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPersonagem);
            this.Controls.Add(this.listBoxPersonagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPersonagens";
            this.Text = "O Programa Personagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPersonagem;
        private System.Windows.Forms.ComboBox comboBoxPersonagem;
    }
}

