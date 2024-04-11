using MySql.Data.MySqlClient;
using programacao_sozinho.Connection;
using programacao_sozinho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace programacao_sozinho.Dao
{
    public class ClienteDAO
    {
        private MySql.Data.MySqlClient.MySqlConnection Conexao;

        public ClienteDAO()
        {
            this.Conexao = new Connection.Connection().GetConnection();
        }

        public void inserirCliente(Clientes clientes)
        {
            try
            {
                string sql = @"Insert into tb_clientes(
                    nif, nome, profissao, empresa, email, telemovel, endereco, cidade, pais) values (
                    @nif, @nome, @profissao, @empresa, @email, @telemovel, @endereco, @cidade, @pais)";

                MySqlCommand executecmd = new MySqlCommand(sql, Conexao);

                executecmd.Parameters.AddWithValue("@nif", clientes.nif);
                executecmd.Parameters.AddWithValue("@nome", clientes.nome);
                executecmd.Parameters.AddWithValue("@profissao", clientes.profissao);
                executecmd.Parameters.AddWithValue("@empresa", clientes.empresa);
                executecmd.Parameters.AddWithValue("@email", clientes.email);
                executecmd.Parameters.AddWithValue("@telemovel", clientes.telemovel);
                executecmd.Parameters.AddWithValue("@endereco", clientes.endereco);
                executecmd.Parameters.AddWithValue("@cidade", clientes.cidade);
                executecmd.Parameters.AddWithValue("@pais", clientes.pais);

                Conexao.Open();
                executecmd.ExecuteNonQuery();
                MessageBox.Show("Cliente criado.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                throw;
            }
        }
    }
}
