
namespace FormMdi
{
    partial class FormTres
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
            this.btnDois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDois
            // 
            this.btnDois.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(299, 180);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(209, 69);
            this.btnDois.TabIndex = 1;
            this.btnDois.Text = "Form Dois";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // FormTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnDois);
            this.Name = "FormTres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDois;
    }
}