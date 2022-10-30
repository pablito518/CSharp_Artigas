using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Array
            string[] nomes = new string[3];
            nomes[0] = "Pablo";
            nomes[1] = "Rodrigo";
            nomes[2] = "Escobar";

            //Lista genérica
            List<string> nomes2 = new List<string>();
            nomes2.Add("Jonathan");
            nomes2.Add("Joseph");
            nomes2.Add("Jotaro");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Jotaro"))
            //{
            //    MessageBox.Show("Jotaro Removido");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível remover");
            //}

            //lista.Items.Add(nomes2[0]);
            //lista.Items.Add(nomes2[1]);
            //lista.Items.Add(nomes2[2]);
            //lista.Items.Add(nomes2[3]);
            //lista.Items.Add(nomes2[4]);
            //lista.Items.Add(nomes2[5]);

            //if (nomes2.Contains("Pablo"))
            //{
            //    MessageBox.Show("Contém", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Não Contém", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //MessageBox.Show($"Número de elementos: {nomes2.Count()}");

            //nomes2.Sort();

            //MessageBox.Show($"Pablo está no índice: {nomes2.IndexOf("Pablo")}");

            //nomes2.Insert(0, "João");

            //nomes2.RemoveAt(4);

            //nomes2.Clear();

            nomes2.Add("Jonathan");

            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro",
                "Moto",
                "Avião",
                "Helicóptero",
                "Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //veiculos = new HashSet<string>();

            //if (veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item Adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains("Carro"))
            //{
            //    MessageBox.Show("Contém");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém");
            //}

            //veiculos.Remove("Carro");
            //int num = veiculos.Count();
            //veiculos.Clear();
            //MessageBox.Show(veiculos.First());
            //MessageBox.Show(veiculos.Last());
            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Pablo"}, 
                {200, "Jonathan"},
                {80,  "Pablo"}
            };

            alunos.Add(100, "Rodrigo");
            //alunos.ContainsKey(80);

            //if (alunos.ContainsValue("Jonathan"))
            //{
            //    MessageBox.Show("Contém o aluno Jonathan");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém o aluno Jonathan");
            //}

            //alunos.Remove(80);
            //alunos.Clear();

            //KeyValuePair<int, string> primeiro = alunos.First();
            //MessageBox.Show($"Primeiro {primeiro.Key} {primeiro.Value}");

            //MessageBox.Show($"Último {alunos.Last().Key} {alunos.Last().Value}");

            foreach (KeyValuePair<int,string> item in alunos)
            {
                //lista.Items.Add(item); [150, Pablo]
                //lista.Items.Add(item.Value); //Pablo
                //lista.Items.Add(item.Key); //150
                lista.Items.Add($"{item.Key} = {item.Value}");
            }

            //MessageBox.Show($"Quantidade de alunos {alunos.Count()}");
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {27, "Rodrigo" },
                {10, "John" },
                {17, "José" }
            };

            alunos.Add(14, "Glória");

            //alunos.Reverse()
            //foreach (KeyValuePair<int, string> item in alunos.Reverse())
            //{
            //    lista.Items.Add($"{item.Key} {item.Value}");
            //}

            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.Count();
            //alunos.ContainsKey(50);
            //alunos.ContainsValue("Glória");

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add($"{item.Key} {item.Value}");
            }


        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {4512, "Gabriel" },
                {1542, "Rafael" },
                {2145, "Julia" },
            };

            alunos.Add(5478, "Flávio");

            //alunos.Remove(120);
            //alunos.Count();
            //alunos.Clear();
            //alunos.ContainsKey(1542);
            //alunos.ContainsValue("Julia");
            //MessageBox.Show(alunos.ElementAt(1).ToString());

            foreach (KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Pablo", "Escobar", "José", "João", "Camila"
            };

            if (!nomes.Add("Lusca"))
            {
                MessageBox.Show("Não podes repetir o valor.");
            }

            //nomes.Remove("Escobar");
            //nomes.ElementAt(2);
            //nomes.Reverse();
            //nomes.First();
            //nomes.Last();
            //nomes.Count();
            //nomes.Clear();

            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Gabriel");
            fila.Enqueue("Danny");
            fila.Enqueue("Arthur");

            //MessageBox.Show(fila.Count().ToString());

            //MessageBox.Show($"Primeiro da fila {fila.Dequeue()}");
            //MessageBox.Show(fila.Count().ToString());

            //MessageBox.Show($"Primeiro da fila {fila.First()}");
            //MessageBox.Show(fila.Count().ToString());

            //MessageBox.Show($"Primeiro da fila {fila.Last()}");
            //MessageBox.Show(fila.Count().ToString());

            //fila.Clear();

            while (fila.Count > 0)
            {
                MessageBox.Show($"Primeiro da fila {fila.Dequeue()}");
                MessageBox.Show(fila.Count().ToString());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }
            //MessageBox.Show($"Primeiro da fila {fila.Peek()}");
            //MessageBox.Show(fila.Count().ToString());
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Pablo");
            pilha.Push("Danny");
            pilha.Push("Arthur");

            MessageBox.Show(pilha.Count.ToString());

            foreach (string item in pilha)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show($"Elemento no topo {pilha.Peek()}");
            //MessageBox.Show(pilha.Count.ToString());

            //MessageBox.Show($"Elemento no topo {pilha.Pop()}");
            //MessageBox.Show(pilha.Count.ToString());


            pilha.Clear();

            while (pilha.Count() > 0)
            {
                MessageBox.Show($"Elemento no topo {pilha.Pop()}");
                MessageBox.Show(pilha.Count.ToString());
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }
        }
    }
}
