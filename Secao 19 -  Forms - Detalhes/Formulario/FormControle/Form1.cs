using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label lbl1;
        Button btn1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1 = new Label();
            lbl1.Location = new Point(100, 50);
            lbl1.AutoSize = false;
            lbl1.Size = new Size(200, 100);
            lbl1.BackColor = Color.Crimson;
            lbl1.ForeColor = Color.Firebrick;
            lbl1.Font = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Text = "Label criada por código";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;

            btn1 = new Button();
            btn1.Location = new Point(300, 50);
            btn1.Size = new Size(250, 150);
            btn1.Text = "Botão Código";
            btn1.Font = new Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point);

            //btn1.Click;
            btn1.Click += Btn1_Click;

            this.Controls.Add(lbl1);
            this.Controls.Add(btn1);

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Clicou no botão";
        }
    }
}
