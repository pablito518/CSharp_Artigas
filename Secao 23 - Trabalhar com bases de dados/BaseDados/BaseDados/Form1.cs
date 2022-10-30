using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Sql Server CE
using System.Data.SqlServerCe;

// SQLite
using System.Data.SQLite;

// MySQL
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string pasta = $@"{Application.StartupPath}\db";
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //if (!Directory.Exists(pasta))
            //{
            //    Directory.CreateDirectory(pasta);
            //}

            //SqlCeEngine db = new SqlCeEngine(strConnection);
            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();


            //SqlCeConnection conexao = new SqlCeConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    lblResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = $"Erro ao conectar Sql Server CE \n{ex.Message}";

            //}
            //finally
            //{
            //    conexao.Close();
            //}
            //conexao.Close();
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    lblResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = $"Erro ao conectar SQLite \n{ex.Message}";
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;password=vertrigo;SSL Mode=None";

            //MySqlConnection conexao = new MySqlConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    lblResultado.Text = "Conectado MySQL";

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db1";
            //    comando.ExecuteNonQuery();
            //    lblResultado.Text = "Base de dados criada com sucesso";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = $"Erro ao conectar MySQL \n{ex.Message}";
            //}
            //finally
            //{
            //    conexao.Close();
            //}


            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    //comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.CommandText = "CREATE TABLE pessoas (id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Tabela Criada SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Tabela Criada SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db1;password=vertrigo;SSL Mode=None";
            ////string strConnection = "server=127.0.0.1;User Id=root;password=vertrigo;SSL Mode=None";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL AUTO_INCREMENT, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Tabela Criada MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;
            //    //int id = new Random(DateTime.Now.Millisecond).Next(0,1000); //Usei o Identity(1,1) para não ter problemas com ID repetido

            //    comando.CommandText = $"INSERT INTO pessoas (nome,email) VALUES ('{nome}', '{email}')";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro inserido SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;
            //    comando.CommandText = $"INSERT INTO pessoas (nome,email) VALUES ('{nome}', '{email}')";

            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro inserido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db1;password=vertrigo;SSL Mode=None";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;
            //    comando.CommandText = $"INSERT INTO pessoas (nome,email) VALUES ('{nome}', '{email}')";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro Inserido MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lista.Rows.Clear();

            #region SQL Server CE
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = $"SELECT * FROM pessoas WHERE nome LIKE '{txtNome.Text}%'"; //Operador "%" junto ao LIKE para procurar valores que começam com o que foi escrito
            //    }

            //    DataTable dados = new DataTable();

            //    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, conexao);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = $"SELECT * FROM pessoas WHERE nome LIKE '{txtNome.Text}%'"; //Operador "%" junto ao LIKE para procurar valores que começam com o que foi escrito
            //    }

            //    DataTable dados = new DataTable();

            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexao);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db1;password=vertrigo;SSL Mode=None";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    string query = "SELECT * FROM pessoas";

            //    if (txtNome.Text != "")
            //    {
            //        query = $"SELECT * FROM pessoas WHERE nome LIKE '{txtNome.Text}%'"; //Operador "%" junto ao LIKE para procurar valores que começam com o que foi escrito
            //    }

            //    DataTable dados = new DataTable();

            //    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        lista.Rows.Add(linha.ItemArray);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lista.Rows.Clear();
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = '{id}'";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro excluido SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = Convert.ToInt32(lista.SelectedRows[0].Cells[0].Value.ToString());

            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = {id}";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro excluido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //    lblResultado.Text += $"\n {id}";
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db1;password=vertrigo;SSL Mode=None";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = Convert.ToInt32(lista.SelectedRows[0].Cells[0].Value.ToString());

            //    comando.CommandText = $"DELETE FROM pessoas WHERE id = {id}";
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro excluido SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //    lblResultado.Text += $"\n {id}";
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLServer.sdf";
            //string strConnection = $@"DataSource = {baseDados}; Password = 'abcd'";

            //SqlCeConnection conexao = new SqlCeConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;

            //    //string nome = txtNome.Text;
            //    //string email = txtEmail.Text;

            //    string query = $"UPDATE pessoas SET nome = '{txtNome.Text}', email = '{txtEmail.Text}' WHERE id LIKE '{id}'";

            //    comando.CommandText = query;
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro alterado SQL Server CE";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite
            //string baseDados = $@"{Application.StartupPath}\db\DBSQLite.db";
            //string strConnection = $@"Data Source = {baseDados}; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = Convert.ToInt32(lista.SelectedRows[0].Cells[0].Value.ToString());
            //    //    //string nome = txtNome.Text;
            //    //    //string email = txtEmail.Text;

            //     string query = $"UPDATE pessoas SET nome = '{txtNome.Text}', email = '{txtEmail.Text}' WHERE id LIKE '{id}'";

            //    comando.CommandText = query;
            //    comando.ExecuteNonQuery();

            //    lblResultado.Text = "Registro alterado SQLite";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //    lblResultado.Text += $"\n {id}";
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db1;password=vertrigo;SSL Mode=None";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = Convert.ToInt32(lista.SelectedRows[0].Cells[0].Value.ToString());

            //    //string nome = txtNome.Text;
            //    //string email = txtEmail.Text;

            //    string query = $"UPDATE pessoas SET nome = '{txtNome.Text}', email = '{txtEmail.Text}' WHERE id LIKE '{id}'";

            //comando.CommandText = query;
            //comando.ExecuteNonQuery();

            //lblResultado.Text = "Registro alterado MySql";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    lblResultado.Text = ex.Message;
            //    lblResultado.Text += $"\n {id}";
            //}
            //finally
            //{
            //    conexao.Close();
            //    txtNome.Text = "";
            //    txtEmail.Text = "";
            //}
            #endregion
        }
    }
}
