using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class JogoDaVelha : Form
    {
        public JogoDaVelha()
        {
            InitializeComponent();
        }

        string[,] mat = new string[3, 3];
        string jogador = "O";
        int rodadas = 1;

        private void JogoDaVelha_Load_1(object sender, EventArgs e)
        {
            AlteraJogador();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    lblJogo.Text += mat[i, j] + " | ";
                }
                lblJogo.Text += "\n";
            }
        }

        public void mostrarTab()
        {
            lblJogo.Text = "";
            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    lblJogo.Text += mat[i, j] + " | ";
                }
                lblJogo.Text += "\n";
            }
        }
        public void mostrarTabVazia()
        {
            lblJogo.Text = "";
            rodadas = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    lblJogo.Text += " | ";
                    mat[i, j] = "";
                    
                }
                lblJogo.Text += "\n";
            }
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (rodadas == 1)
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(0); j++)
                    {
                        mat[i, j] = "";
                    }
                }
            }

            
            int linha = int.Parse(txtLinha.Text);
            int coluna = int.Parse(txtColuna.Text);

            if (rodadas < 9) { 
            for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(0); j++)
                    {
                        if (mat[linha,coluna] == "")
                        {
                            mat[linha, coluna] = jogador;
                            rodadas++;
                        }                                              
                    }
                }
            }
            else
            {
                MessageBox.Show("Deu véia!");
                mostrarTabVazia();
            }
            
            


            mostrarTab();
            
            if (mat[0, 0] == "X" && mat[0, 1] == "X" && mat[0, 2] =="X")
            {       
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 0] == "O" && mat[0, 1] == "O" && mat[0, 2] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[1, 0] == "X" && mat[1, 1] == "X" && mat[1, 2] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[1, 0] == "O" && mat[1, 1] == "O" && mat[1, 2] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[2, 0] == "X" && mat[2, 1] == "X" && mat[2, 2] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[2, 0] == "O" && mat[2, 1] == "O" && mat[2, 2] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 0] == "X" && mat[1, 0] == "X" && mat[2, 0] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 0] == "O" && mat[1, 0] == "O" && mat[2, 0] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 1] == "X" && mat[1, 1] == "X" && mat[2, 1] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 1] == "O" && mat[1, 1] == "O" && mat[2, 1] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 2] == "X" && mat[1, 2] == "X" && mat[2, 2] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 2] == "O" && mat[1, 2] == "O" && mat[2, 2] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 0] == "X" && mat[1, 1] == "X" && mat[2, 2] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 0] == "O" && mat[1, 1] == "O" && mat[2, 2] == "O")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }

            else if (mat[0, 2] == "X" && mat[1, 1] == "X" && mat[2, 0] == "X")
            {
                MessageBox.Show("O jogador " + jogador + " é o vencedor!");
                mostrarTabVazia();
            }


            AlteraJogador();

            

            
        }

        private void AlteraJogador()
        {
            if(jogador == "X")
            {
                jogador = "O";
            }
            else
            {
                jogador = "X";
            }
            lblVez.Text = jogador;

        }
    }
}
