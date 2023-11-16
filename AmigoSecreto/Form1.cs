namespace AmigoSecreto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Exibir();
        }

        List<Pessoa> lista = new List<Pessoa>();
        int pessoas;
        private void Inserir()
        {
            if (textBox_Nome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Adicione um participante", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] nomes = textBox_Nome.Text.Split(" ");

                if (nomes.Length >= 2)
                {
                    string nome = textBox_Nome.Text.ToUpper();
                    Pessoa pessoa = new Pessoa(nome);

                    if (!lista.Contains(pessoa))
                    {
                        label_Mensagem.Visible = false;
                        lista.Add(pessoa);
                        lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                        string[] itens = { pessoa.Nome, pessoa.Email };
                        listView_Participantes.Items.Add(new ListViewItem(itens));
                        Persistencia.gravarSimples(pessoa, "amigos.csv");

                        textBox_Nome.Text = string.Empty;
                        pessoas++;
                        label_Participantes.Text = pessoas.ToString();
                        textBox_Nome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Pessoa já cadastrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    label_Mensagem.Visible = true;
                    label_Mensagem.Text = "Insira nome e sobrenome";
                }
            }
        }

        private void Exibir()
        {
            textBox_Nome.Focus();
            pessoas = Persistencia.QuantidadeParticipantes("amigos.csv");
            label_Participantes.Text = pessoas.ToString();
            Persistencia.lerArquivo("amigos.csv", listView_Participantes);
            Persistencia.popularArquivoLista("amigos.csv", lista);
            //MessageBox.Show("lista = "+lista.Count);
        }

        private void GerarAmigoSecreto()
        {
            if (pessoas >= 2)
            {
                List<Pessoa> listaTmp = new List<Pessoa>();
                listaTmp.AddRange(lista);

                bool deuCerto;
                do
                {
                    deuCerto = true;
                    listaTmp = listaTmp.OrderBy(x => Random.Shared.Next()).ToList();

                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i] == listaTmp[i])
                        {
                            deuCerto = false;
                            listaTmp.Clear();
                            listaTmp.AddRange(lista);
                            break;
                        }
                    }
                } while (!deuCerto);

                Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);
                MessageBox.Show("Amigo secreto sorteado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adicione mais pessoas para gerar o sorteio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Inserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void button_GerarAmigo_Click(object sender, EventArgs e)
        {
            GerarAmigoSecreto();
        }

        private void buttonEnviarEmail_Click(object sender, EventArgs e)
        {

        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            if (listView_Participantes.Items.Count > 0)
            {
                if (listView_Participantes.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Selecione um participante para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string nome = listView_Participantes.SelectedItems[0].Text;
                    textBox_Nome.Text = nome;
                }

            }
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {

        }
    }
}