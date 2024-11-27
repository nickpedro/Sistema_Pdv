using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Pdv.cadastro
{
    public partial class frmCargo : Form
    {
        Conexao con = new Conexao();

        string id;
        string nomeAntigo;
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void FormatarGD()//Formatando os dados dentro da grid visivel.
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargo";   
            grid.Columns[0].Visible = false;
        }

        private void Listar()//Listar e Atualizar os dados do banco na grid
        {
            con.AbrirConexao();
            string sql = "SELECT * FROM cargos ORDER BY cargo asc";
            using (SqlCommand cmd = new SqlCommand(sql, con.conn))
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();
                FormatarGD();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM cargos WHERE id = @id", con.conn))
            {
                var res = MessageBox.Show("Deseja realmente excluir o cargo " + nomeAntigo , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    Listar();
                    MessageBox.Show("Registro Excluido com Sucesso!", " Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Cargo", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            // botão editar
            con.AbrirConexao();
            string sql = "UPDATE cargos SET cargo = @cargo WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(sql, con.conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cargo", txtNome.Text);

                // Verificar se o cargo já existe, exceto para o ID atual
                if (txtNome.Text != nomeAntigo)
                {
                    string verificarSql = "SELECT * FROM cargos WHERE cargo = @cargo AND id != @id";
                    using (SqlCommand cmdVerificar = new SqlCommand(verificarSql, con.conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@cargo", txtNome.Text);
                        cmdVerificar.Parameters.AddWithValue("@id", id); // Exclui o registro atual da verificação

                        SqlDataAdapter da = new SqlDataAdapter(cmdVerificar);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Cargo " + txtNome.Text + " já registrado", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtNome.Text = "";
                            txtNome.Focus();
                            return;
                        }
                    }
                }

                // Se não houver duplicidade, faz a atualização
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro do Cargo " + txtNome.Text + " Editado com sucesso!", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            string sql = "INSERT INTO cargos(cargo) VALUES(@cargo)";

            using (SqlCommand cmd = new SqlCommand(sql, con.conn))//Validando os campos para não ser permitido deixar em branco
            {
                if (txtNome.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtNome.Focus();
                    return;
                }

                // Adicionando os parâmentros à consulta
                cmd.Parameters.AddWithValue("@cargo", txtNome.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                Listar();

                MessageBox.Show("Registro Salvo com Sucesso!", " Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

             
                //Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btnSalvar.Enabled=true;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)//tratamento para não pegar dados inexistentes
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
                txtNome.Enabled = true;

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                nomeAntigo = grid.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
