using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pdv.cadastro
{
    public partial class frmFuncionario : Form
    {
        Conexao con = new Conexao();

        string foto;
        string alterouImagem="não";
        string id;
        string cpfAntigo;
        string nomeAntigo;
        string celularAntigo;

        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            ListarCargos();
            FormatarGD();
            alterouImagem = "não";
            cbCargo.Text = string.Empty;
        }

        private void FormatarGD()//Formatando os dados dentro da grid visivel.
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Celular";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Foto";

            grid.Columns[0].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[6].Visible = false;
        }

        private void DesabilitarCampos()//Desabilita os campos
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtCelular.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;
        }
        private void LimparCampos()//Limpa os dados anteriores
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            cbCargo.Text = "";
        }

        private void ListarCargos()//Metodo Lista os cargos registrados.
        {
            con.AbrirConexao();
            string sql = "SELECT * FROM cargos ORDER BY cargo asc";
            using (SqlCommand cmd = new SqlCommand(sql, con.conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbCargo.DataSource = dt;
                cbCargo.DisplayMember = "cargo";
                con.FecharConexao();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)//Novo cadastro
        {
            habilitarCampos();
            LimparCampos();
            txtNome.Focus();
        }

        private void Listar()//Listar e Atualizar os dados do banco na grid
        {
            con.AbrirConexao();
            string sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            using (SqlCommand cmd = new SqlCommand(sql, con.conn))
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();

            }
        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            string sql = "INSERT INTO funcionarios(nome, cpf, celular, cargo, endereco, foto) VALUES(@nome, @cpf, @celular, @cargo, @endereco, @foto)";

            using (SqlCommand cmd = new SqlCommand(sql, con.conn))//Validando os campos para não ser permitido deixar em branco
            {
                if (txtNome.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo Nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtNome.Focus();
                    return;
                }
                if (txtCPF.Text == "   ,   ,   -" || txtCPF.Text.Length < 14)
                {
                    MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCPF.Focus();
                    return;
                }
                if (txtCelular.Text == "(  )      -" || txtCelular.Text.Length < 14)
                {
                    MessageBox.Show("Preencha o campo Celular", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                    return;
                }


                // Adicionando os parâmentros à consulta
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@foto", img());

                cmd.ExecuteNonQuery();
                con.FecharConexao();

                LimparFoto();

                MessageBox.Show("Registro Salvo com Sucesso!", " Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

                LimparCampos();
                Listar();
                //Close();
                DesabilitarCampos();
            }
        }


        //função para pegar as imagens
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images(*.jpg; *.png) | *.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
                alterouImagem = "sim";
            }
            
        }

        private byte[] img() //este netodo é padrão, serve para enviar imagem pro banco
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;
        }
        private void LimparFoto()
        {
            image.Image = Properties.Resources.cebolinha;
            foto = "Imagens/cebolinha.jpg";
        }


        private void habilitarCampos()//Habilita os campos
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            txtCelular.Enabled = true;
            btnFoto.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)//Ao dar um click apenas na grid
        {
            if (e.RowIndex > -1)//tratamento para não pegar dados inexistentes
            {
                habilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                nomeAntigo = grid.CurrentRow.Cells[1].Value.ToString();
                txtCPF.Text = grid.CurrentRow.Cells[2].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                txtCelular.Text = grid.CurrentRow.Cells[3].Value.ToString();
                celularAntigo = grid.CurrentRow.Cells[3].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txtEndereco.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if (grid.CurrentRow.Cells[6].Value != DBNull.Value)//Verificando se o campo de foto é nulo
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[6].Value;//criar a var onde ira receber o campo [6] da imagem e converter para valor
                    MemoryStream ms = new MemoryStream(imagem);//receber a var byte

                    image.Image = System.Drawing.Image.FromStream(ms);//passando a imagem para a variavel ms
                }
                else
                {
                    image.Image = Properties.Resources.cebolinha;//colocar aquela imagem sem foto la do cebolinha padrão caso n acontecer de ter imagem.
                }

            }
            else
            {
                return;
            }

        }

        //Botão Cancelar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
        }

        //Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtCPF.Text == "   ,   ,   -" || txtCPF.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return;
            }

            //botão editar
            con.AbrirConexao();
            string sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, celular = @celular, cargo = @cargo, endereco = @endereco, foto = @foto where id = @id";

            using (SqlCommand cmd = new SqlCommand(sql, con.conn))//Validando os campos para não ser permitido deixar em branco
            {

                if (alterouImagem == "sim")
                {
                    cmd.Parameters.AddWithValue("@id", id);//WHERE
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@foto", img());
                }
                else if (alterouImagem == "não")
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@foto", img());
                }

                //verificar se CPF ja existe
                if (txtCPF.Text != cpfAntigo)
                {
                    using (SqlCommand cmdVerificar = new SqlCommand("SELECT * FROM funcionarios WHERE cpf = @cpf", con.conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@cpf", txtCPF.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmdVerificar);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("CPF já registrado", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtCPF.Text = "";
                            txtCPF.Focus();
                            return;
                        }
                    }
                }

                //verificar se Nome ja existe
                if (txtNome.Text != nomeAntigo)
                {
                    using (SqlCommand cmdVerificar = new SqlCommand("SELECT * FROM funcionarios WHERE nome = @nome", con.conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@nome", txtNome.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmdVerificar);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("NOME já registrado", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtNome.Text = "";
                            txtNome.Focus();
                            return;
                        }
                    }
                }

                //verificar se Celular ja existe
                if (txtCelular.Text != celularAntigo)
                {
                    using (SqlCommand cmdVerificar = new SqlCommand("SELECT * FROM funcionarios WHERE celular = @celular", con.conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@celular", txtCelular.Text);

                        SqlDataAdapter da = new SqlDataAdapter(cmdVerificar);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("CELULAR já registrado", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtCelular.Text = "";
                            txtCelular.Focus();
                            return;
                        }
                    }
                }

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Editado com sucesso!", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                DesabilitarCampos();
                LimparCampos();
                LimparFoto();
                alterouImagem = "não";

            }
        }

        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            using(SqlCommand cmd = new SqlCommand("DELETE FROM funcionarios WHERE id = @id", con.conn))
            {
                var res = MessageBox.Show("Deseja realmente excluir o registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    Listar();
                    MessageBox.Show("Registro Excluido com Sucesso!", " Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                LimparCampos();  
                DesabilitarCampos();
                
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
