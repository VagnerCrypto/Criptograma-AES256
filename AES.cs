using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoForms
{
    /// <summary>
    /// Implementa o algoritmo simétrico de criptografia AES (Advanced Encryption Standard)
    /// </summary>
    class AES
    {
        /// <summary>
        /// Criptografa dados com a cifra AES
        /// </summary>
        /// <param name="PlainText">O texto claro a ser criptografado</param>
        /// <param name="Key">A chave secreta responsável pela encriptação</param>
        /// <param name="IV">Vetor de inicialização do AES/CBC mode</param>
        /// <returns></returns>
        public static byte[] Encrypt(string PlainText, byte[] Key, byte[] IV)
        {
            byte[] CipherText;

            //Verifica possíveis erros
            try
            {
                //Inicia a instância do AES
                using (Aes AES256 = Aes.Create())
                {
                    AES256.Key = Key;
                    AES256.IV = IV;

                    //Inicia a encriptação AES passando a chave e o IV
                    ICryptoTransform crypto = AES256.CreateEncryptor(AES256.Key, AES256.IV);

                    //Armazena espaço na memória para um texto cifrado
                    using (var memory = new MemoryStream())
                    {
                        //Indica a operação criptografica a ser feita e o tipo de fluxo
                        using (var cryptoStream = new CryptoStream(memory, crypto, CryptoStreamMode.Write))
                        {
                            //Responsável por escrever o texto cifrado no buffer
                            using (var writer = new StreamWriter(cryptoStream))
                            {
                                //Escreve o texto cifrado
                                writer.Write(PlainText);

                                writer.Close();
                            }

                            //Envia todos os bytes cifrados ao array de bytes
                            CipherText = memory.ToArray();

                            cryptoStream.Close();
                        }

                        memory.Close();
                    }

                    //Fecha todo o fluxo criptográfico
                    AES256.Dispose();
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Erro de criptografia: " + ex.Message,
                                "Erro criptográfico!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return null;
            }

            //Retorna o texto cifrado
            return CipherText;
        }

        /// <summary>
        /// Realiza a decriptação de dados com a cifra AES
        /// </summary>
        /// <param name="CipherText">O texto cifrado a ser decriptado</param>
        /// <param name="Key">A chave secreta usada na encriptação</param>
        /// <param name="IV">O Vetor de inicialização (IV) usado na encriptação</param>
        /// <returns></returns>
        public static string  Decrypt(byte[] CipherText, byte[] Key, byte[] IV)
        {
            string PlainText = null;

            try
            {
                using (Aes AES256 = Aes.Create())
                {
                    AES256.Key = Key;
                    AES256.IV = IV;

                    //Inicia a decriptação com AES, passando chave e o IV
                    ICryptoTransform crypto = AES256.CreateDecryptor(AES256.Key, AES256.IV);

                    //Localiza o local onde estava o texto cifrado na memória
                    using (var memory = new MemoryStream(CipherText))
                    {
                        using (var cryptoStream = new CryptoStream(memory, crypto, CryptoStreamMode.Read))
                        {
                            //Lê o texto decriptado
                            using (var reader = new StreamReader(cryptoStream))
                            {
                                //Leitura completa do texto claro e o passando para a string
                                PlainText = reader.ReadToEnd();

                                reader.Close();
                            }

                            cryptoStream.Close();
                        }

                        memory.Close();
                    }

                    AES256.Dispose();
                }

            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Erro de descriptografia: " + ex.Message,
                                "Erro criptográfico!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return null;
            }

            //Retorna o texto claro
            return PlainText;
        }

        /// <summary>
        /// Inicia a função Hash SHA-256 para integridade e autenticidade de dados
        /// </summary>
        /// <param name="data">Dado a ser feito um Hash</param>
        /// <returns></returns>
        public static string HashSHA256(string data)
        {
            //StringBuilder para poder alterar e concatenar strings
            var builder = new StringBuilder();

            try
            {
                //Inicia a instância do SHA-256
                using (SHA256 sha256 = SHA256.Create())
                {
                    //Realiza o cálculo do Hash com a codificação utf-8 e envia para um array de bytes
                    byte[] HASH = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));

                    //Loop por todo o array hash
                    //Envia o hash para o stringBuilder em forma de hexadecimal
                    for (int i = 0; i < HASH.Length; i++)
                        builder.Append(HASH[i].ToString("X2"));
                }
            }
            catch(CryptographicException ex)
            {
                MessageBox.Show("Não foi possível calcular o HASH\n" + ex.Message,
                                "SHA-256 ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            //Retorna o Hash
            return builder.ToString();
        }
    }
}
