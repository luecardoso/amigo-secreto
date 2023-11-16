using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    internal class Persistencia
    {
        private static bool arquivo = false;
        private static int id = 0;
        
        public static int QuantidadeParticipantes(string nomeArquivo)
        {
            int quantidade = 0;
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    leitor.ReadLine();
                    quantidade++;
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bem-Vindo ao amigo secreto, adicione participantes para começar!", "Sorteio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return quantidade;
        }

        /// <summary>
        /// metodo de classe que le um arquivo csv e exibe os dados cadastrados
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void lerArquivo(string nomeArquivo, ListView lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email]
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    lista.Items.Add(new ListViewItem(vetorLinha));
                    arquivo = true;
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                if (arquivo)
                {
                    MessageBox.Show("Problemas com o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public static void gravarSimples(Pessoa pessoa, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email);

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }

        }

        public static void remover()
        {
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email]
                string linha;
                Pessoa tmp;
                do
                {
                    linha = leitor.ReadLine();//Leandro Di Nardo Lazarin;lazarin@ufn.edu.br;12/12/1990
                    vetorLinha = linha.Split(";"); //[Leandro Di Nardo Lazarin, lazarin@ufn.edu.br, 12/12/1990]
                    tmp = new Pessoa(vetorLinha[0], vetorLinha[1]);
                    if (!lista.Contains(tmp))
                    {
                        lista.Add(tmp);
                    }
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo); //sempre o arquivo é criado do zero
                                                                       //StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //possibilidade de adionar dados no arquivo
                foreach (var item in lista)
                {
                    escritor.WriteLine(item.Nome + ";" + item.Email);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void gerarArquivoAmigoSecreto(List<Pessoa> lista, List<Pessoa> listaTmp)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("secreto.csv");

                for (int i = 0; i < lista.Count; i++)
                {
                    escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                }

                escritor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com o arquivo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
