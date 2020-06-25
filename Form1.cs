using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CryptoForms
{
    /// <summary>
    /// Classe que controla todo o formulário
    /// </summary>
    public partial class AES256 : Form
    {
        //Váriaveis globais que armazenam o texto cifrado, chave e IV
        private static byte[] cipher;
        private static byte[] key;
        private static byte[] iv;
        private bool control = false;
        public AES256()
        {
            InitializeComponent();
        }

        //Método de evento para o clique no botão "Criptografar"
        private void Encrypt_Click(object sender, EventArgs e)
        {
            //Intância para escrever em um arquivo
            StreamWriter w;

            //Recebe o que foi digitado na caixa de texto
            string text = plain_text.Text;
            control = false;
            //Limpa as caixas
            CipherText.Clear();
            TextHash.Clear();
            this.Encrypt.Enabled = false;

            //Verifica se a caixa de texto foi preenchida e se está preenhcida só com caracteres de espaço
            if(!String.IsNullOrEmpty(text) && !String.IsNullOrWhiteSpace(text))
            {

                //Inicia uma instância do AES
                using(Aes AES256 = Aes.Create())
                {
                    //Abre ou cria um arquivo com o nome e extensão passados
                    using (w = File.AppendText("Crypto.txt"))
                    {
                        //Tamanho da chave criptográfica em bits
                        AES256.KeySize = 256;

                        //Envia chave e IV para as variaveis globais
                        key = AES256.Key;
                        iv = AES256.IV;

                        //Envia o texto cifrado para o array de bytes global
                        cipher = AES.Encrypt(text, key, iv);

                        if (cipher == null)
                            this.Encrypt.Enabled = true;
                        //Percorre todo o texto cifrado
                        //Envia cada caractere cifrado para a caixa de texto em Hexadecimal
                        for (int i = 0; i < cipher.Length; i++)
                            CipherText.Text += cipher[i].ToString("X2") + " ";

                        //Desativa o botão "Descriptografar"
                        this.Decrypt.Enabled = true;

                        //Realiza o HASH e o envia para a caixa de texto do HASH em maiúsculo
                        TextHash.Text = AES.HashSHA256(plain_text.Text).ToUpper();

                        //Escreve o texto cifrado e o Hash no arquivo
                        w.WriteLine("Texto cifrado: " + CipherText.Text);
                        w.WriteLine("");
                        w.WriteLine("Hash do texto claro: " +TextHash.Text);
                        w.WriteLine("==================================================================================================\n");

                        //Fecha o arquivo
                        w.Close();
                    }


                    AES256.Dispose();
                }
            }
            else
            {
                //Em caso de dados incorretos, apresenta uma mensagem, limpa as caixas
                //e coloca o mouse na primeira caixa de texto
                MessageBox.Show("Digite algo para criptografar!", "Caixa de texto vazia!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CipherText.Clear();
                plain_text.Clear();
                TextHash.Clear();

                plain_text.Focus();

                this.Encrypt.Enabled = true;
            }
        }

        //Controla o fluxo inicial do app, com um start
        private void AES256_Load(object sender, EventArgs e)
        {

      
            //O app abre centralizado
            this.CenterToScreen();

            //Desativa a maximização do app, até pelo mouse
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Desativa o botão "Descriptografar"
            this.Decrypt.Enabled = false;
           
            //Desativa a caixa de texto do Hash
            this.TextHash.Enabled = false;
        }

        //Método de evento para o clique no botão "Descriptografar"
        private void Decrypt_Click(object sender, EventArgs e)
        {
            this.Encrypt.Enabled = true;
            control = true;
            //Verifica se a caixa do texto cifrado não está vazia
            if (cipher.Length != 0)
            {
                //O texto descriptografado é enviado para uma string
                string plain = AES.Decrypt(cipher, key, iv);

                //A caixa de texto recebe o texto descriptografado que está na string
                CipherText.Text = plain;

                //Desativa o botão "Descriptografar"
                this.Decrypt.Enabled = false;
            }
            else
            {
                MessageBox.Show("criptografe algo para poder descriptografar!", "Caixa de texto vazia!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CipherText.Clear();
                plain_text.Clear();

                plain_text.Focus();
            }
        }

        //Método de evento para o clique no botão "Limpar"
        private void Clear_Click(object sender, EventArgs e)
        {
            //Limpa todas as caixas de texto
            CipherText.Clear();
            plain_text.Clear();
            TextHash.Clear();

            //Foca o mouse na primeira caixa
            plain_text.Focus();

            this.Encrypt.Enabled = true;
        }

        //Método de evento para o clicar no botão "Sair"
        private void Exit_Click(object sender, EventArgs e)
        {
            //Fecha o app
            Application.Exit();
        }

        private void CipherText_TextChanged(object sender, EventArgs e)
        {
           
            int len = CipherText.TextLength;

            CaracteresCipher.Text = "Caracteres: " +len.ToString();


            int len2 = CipherText.TextLength/2;

            if (!control)
                CaracteresHexa.Text = "Em Hexa: " + len2.ToString();
            else
                CaracteresHexa.Text = "Em Hexa: " +0;

        }

        private void plain_text_TextChanged(object sender, EventArgs e)
        {

            int len = plain_text.TextLength;

            CaracteresPlain.Text = "Caracteres: " + len.ToString();

        }

        private void TextHash_TextChanged(object sender, EventArgs e)
        {

            int len = TextHash.TextLength;

            CaracteresHash.Text = "Caracteres: " + len.ToString();


            int len2 = TextHash.TextLength/2;

            HashHexa.Text = "Em Hexa: " + len2.ToString();
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
