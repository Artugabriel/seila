using MySql.Data.MySqlClient;
using MySqlX;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        bool sidebarDex;
        bool sidebarDex2;
        //Dictionary<string, int> cargos = new Dictionary<string, int>();


        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarDex)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarDex = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarDex = true;
                    sidebarTime.Stop();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
            sidebarLay.Start();
        }

        private void sidebarLay_Tick(object sender, EventArgs e)
        {

            if (sidebarDex2)
            {
                sidebar2.Width -= 10;
                if (sidebar2.Width == sidebar2.MinimumSize.Width)
                {
                    sidebarDex2 = false;
                    sidebarLay.Stop();
                }
            }
            else
            {
                sidebar2.Width += 10;
                if (sidebar2.Width == sidebar2.MaximumSize.Width)
                {
                    sidebarDex2 = true;
                    sidebarLay.Stop();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void sidebar2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            InserirFuncionario();
            if (comCargo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cargo.");
                return;
            }
            string nomeSelecionado = comCargo.SelectedItem.ToString();
            int idCargoSelecionado = cargos[nomeSelecionado];

            Banco.Conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO funcionario (id_cargo) VALUES(@cargo)", Banco.conexao);
            cmd.Parameters.AddWithValue("@cargo", idCargoSelecionado);

        }
        private void InserirFuncionario()
        {
            Banco.Conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO funcionarios (nome, cpf, id_cargo, salario) VALUES (@nome, @cpf, @salario)", Banco.conexao);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@salario", txtSalario.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir funcionário: " + ex.Message);
            }
            finally
            {
                Banco.Desconectar();
            }
        }
        //Vai selecionar o cargo do funcionário
        Dictionary<string, int> cargos = new Dictionary<string, int>(); // fora do método, global

        private void Cargo()
        {
            Banco.Conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT id_cargo, nome FROM cargo", Banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            comCargo.Items.Clear(); // Limpa antes de preencher 
            cargos.Clear();         // Limpa o dicionário também

            while (reader.Read())
            {
                string nomeCargo = reader["nome"].ToString();
                int idCargo = Convert.ToInt32(reader["id_cargo"]);

                comCargo.Items.Add(nomeCargo);
                cargos[nomeCargo] = idCargo;
            }

            reader.Close();
            Banco.Desconectar();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
