using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualisador_de_fotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // botao de limpar
            pictureBox1.Image = null;
        }

        //Mostra a caixa de diálogo Abrir arquivo. Se o usuário clicar em OK, carregue o
        //imagem que o usuário escolheu.
        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Mostra a caixa de diálogo de cores. Se o usuário clicar em OK, altere o
        // Fundo do controle PictureBox na cor escolhida pelo usuário.
        private void Backgroundbotton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário marcar a caixa de seleção Stretch, 
            // altera o PictureBox
            // Propriedade SizeMode para "Stretch". Se o usuário limpar 
            // a caixa de seleção, altere-a para "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
