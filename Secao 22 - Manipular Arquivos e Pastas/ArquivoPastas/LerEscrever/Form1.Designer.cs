
namespace LerEscrever
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
            this.btnEscreverTxt = new System.Windows.Forms.Button();
            this.btnLerTxt = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.btnLerBinary = new System.Windows.Forms.Button();
            this.btnEscreverBinary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEscreverTxt
            // 
            this.btnEscreverTxt.Location = new System.Drawing.Point(12, 317);
            this.btnEscreverTxt.Name = "btnEscreverTxt";
            this.btnEscreverTxt.Size = new System.Drawing.Size(158, 63);
            this.btnEscreverTxt.TabIndex = 1;
            this.btnEscreverTxt.Text = "Escrever Txt";
            this.btnEscreverTxt.UseVisualStyleBackColor = true;
            this.btnEscreverTxt.Click += new System.EventHandler(this.btnEscreverTxt_Click);
            // 
            // btnLerTxt
            // 
            this.btnLerTxt.Location = new System.Drawing.Point(176, 317);
            this.btnLerTxt.Name = "btnLerTxt";
            this.btnLerTxt.Size = new System.Drawing.Size(158, 63);
            this.btnLerTxt.TabIndex = 2;
            this.btnLerTxt.Text = "Ler Txt";
            this.btnLerTxt.UseVisualStyleBackColor = true;
            this.btnLerTxt.Click += new System.EventHandler(this.btnLerTxt_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(12, 12);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConteudo.Size = new System.Drawing.Size(684, 298);
            this.txtConteudo.TabIndex = 3;
            this.txtConteudo.Text = "";
            // 
            // btnLerBinary
            // 
            this.btnLerBinary.Location = new System.Drawing.Point(340, 316);
            this.btnLerBinary.Name = "btnLerBinary";
            this.btnLerBinary.Size = new System.Drawing.Size(158, 63);
            this.btnLerBinary.TabIndex = 4;
            this.btnLerBinary.Text = "Ler Binary";
            this.btnLerBinary.UseVisualStyleBackColor = true;
            this.btnLerBinary.Click += new System.EventHandler(this.btnLerBinary_Click);
            // 
            // btnEscreverBinary
            // 
            this.btnEscreverBinary.Location = new System.Drawing.Point(504, 316);
            this.btnEscreverBinary.Name = "btnEscreverBinary";
            this.btnEscreverBinary.Size = new System.Drawing.Size(158, 63);
            this.btnEscreverBinary.TabIndex = 5;
            this.btnEscreverBinary.Text = "Escrever Binary";
            this.btnEscreverBinary.UseVisualStyleBackColor = true;
            this.btnEscreverBinary.Click += new System.EventHandler(this.btnEscreverBinary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 399);
            this.Controls.Add(this.btnEscreverBinary);
            this.Controls.Add(this.btnLerBinary);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnLerTxt);
            this.Controls.Add(this.btnEscreverTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEscreverTxt;
        private System.Windows.Forms.Button btnLerTxt;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.Button btnLerBinary;
        private System.Windows.Forms.Button btnEscreverBinary;
    }
}

