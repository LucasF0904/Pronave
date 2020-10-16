using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Pronave.Classes;

namespace Pronave.DAO
{
    public class DaoHelper
    {
        private static SQLiteConnection sqliteConnection;
        public DaoHelper() { }
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=.\\sdk.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public void createDataBase()
        {

            try
            {
                DbConnection();                
                SQLiteConnection.CreateFile("C:/Program Files (x86)/Pronave/sdk.sqlite");

                createTableCliente();
                createTableContasReceber();
                createTableEnderecoCliente();
                createTableEstoqueMatriz();
                createTableEstoqueVendedor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void createTableCliente()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Cliente(id int primary key not null, nome Varchar(80), created_at datetime default current_timestamp, cpf int, posicao_financeiro VarChar(150), id_endereco_cliente int, lista_negra int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void createTableContasReceber()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contas_Receber(id int primary key not null, data_inicio datetime default current_timestamp, data_fim datetime default current_timestamp)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void createTableEnderecoCliente()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Endereco_Cliente(id int primary key not null, cep int, rua VarChar(100), bairro VarChar(100), numero VarChar(50), complemento VarChar(100))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void createTableEstoqueMatriz()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS EstoqueMatriz(codigo int primary key not null, descricao Varchar(150), estoque_atual int, estoque_anterior int, custo real, formas_pagto int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void createTableEstoqueVendedor()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Estoque_Vendedor(codigo int primary key not null, estoque_atual int, estoque_anterior int)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAll(string tabela)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM " + tabela;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetClienteById(long id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Cliente Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetContasReceberById(long id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contas_Receber Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEnderecoClienteById(long id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Endereco_Cliente Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEstoqueMatrizById(long id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Matriz Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEstoqueVendedorById(long id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Vendedor Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Cliente> GetAllInfoCliente()
        {
            List<Cliente> listCliente = new List<Cliente>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Person";
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0,
                                nome = dbReader["nome"] != null ? Convert.ToString(dbReader["nome"]) : "",
                                created_at = Convert.ToDateTime(dbReader["created_at"]),
                                cpf = dbReader["cpf"] != null ? Convert.ToInt32(dbReader["cpf"]) : 0,
                                posicao_financeiro = dbReader["posicao_financeiro"] != null ? Convert.ToString(dbReader["posicao_financeiro"]) : "",
                                id_endereco_cliente = dbReader["id_endereco_cliente"] != null ? Convert.ToInt32(dbReader["id_endereco_cliente"]) : 0,
                                lista_negra = dbReader["lista_negra"] != null ? Convert.ToInt32(dbReader["lista_negra"]) : 0
                            };
                            listCliente.Add(cliente);
                        }
                    }
                    return listCliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Contas_Receber> GetAllInfoContasReceber()
        {
            List<Contas_Receber> listContasReceber = new List<Contas_Receber>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contas_Receber";
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Contas_Receber contas_receber = new Contas_Receber
                            {
                                id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0,
                                data_inicio = Convert.ToDateTime(dbReader["data_inicio"]),
                            };
                            listContasReceber.Add(contas_receber);
                        }
                    }
                    return listContasReceber;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Endereco_Cliente> GetAllInfoEnderecoCliente()
        {
            List<Endereco_Cliente> listEnderecoCliente = new List<Endereco_Cliente>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Endereco_Cliente";
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Endereco_Cliente endereco_Cliente = new Endereco_Cliente
                            {
                                id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0,
                                cep = dbReader["cep"] != null ? Convert.ToInt32(dbReader["cep"]) : 0,
                                rua = dbReader["rua"] != null ? Convert.ToString(dbReader["rua"]) : "",
                                bairro = dbReader["bairro"] != null ? Convert.ToString(dbReader["bairro"]) : "",
                                numero = dbReader["numero"] != null ? Convert.ToString(dbReader["numero"]) : "",
                                complemento = dbReader["complemento"] != null ? Convert.ToString(dbReader["complemento"]) : "",
                            };
                            listEnderecoCliente.Add(endereco_Cliente);
                        }
                    }
                    return listEnderecoCliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Estoque_Matriz> GetAllInfoEstoqueMatriz()
        {
            List<Estoque_Matriz> listEstoqueMatriz = new List<Estoque_Matriz>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Matriz";
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Estoque_Matriz estoque_Matriz = new Estoque_Matriz
                            {
                                codigo = dbReader["codigo"] != null ? Convert.ToInt32(dbReader["codigo"]) : 0,
                                descricao = dbReader["descricao"] != null ? Convert.ToString(dbReader["descricao"]) : "",
                                estoque_atual = dbReader["estoque_atual"] != null ? Convert.ToInt32(dbReader["estoque_atual"]) : 0,
                                estoque_anterior = dbReader["estoque_anterior"] != null ? Convert.ToInt32(dbReader["estoque_anterior"]) : 0,
                                custo = dbReader["custo"] != null ? Convert.ToDouble(dbReader["custo"]) : 0.0,
                                formas_pagto = dbReader["formas_pagto"] != null ? Convert.ToInt32(dbReader["formas_pagto"]) : 0,
                            };
                            listEstoqueMatriz.Add(estoque_Matriz);
                        }
                    }
                    return listEstoqueMatriz;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Estoque_Vendedor> GetAllInfoEstoqueVendedor()
        {
            List<Estoque_Vendedor> listEstoqueVendedor = new List<Estoque_Vendedor>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Vendedor";
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            Estoque_Vendedor estoque_Vendedor = new Estoque_Vendedor
                            {
                                codigo = dbReader["codigo"] != null ? Convert.ToInt32(dbReader["codigo"]) : 0,
                                estoque_atual = dbReader["estoque_atual"] != null ? Convert.ToInt32(dbReader["estoque_atual"]) : 0,
                                estoque_anterior = dbReader["estoque_anterior"] != null ? Convert.ToInt32(dbReader["estoque_anterior"]) : 0,
                            };
                            listEstoqueVendedor.Add(estoque_Vendedor);
                        }
                    }
                    return listEstoqueVendedor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cliente GetClienteObject(long id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Cliente Where Id=" + id;
                    Cliente cliente = new Cliente();
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            cliente.id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0;
                            cliente.nome = dbReader["nome"] != null ? Convert.ToString(dbReader["nome"]) : "";
                            cliente.created_at = Convert.ToDateTime(dbReader["created_at"]);
                            cliente.cpf = dbReader["cpf"] != null ? Convert.ToInt32(dbReader["cpf"]) : 0;
                            cliente.posicao_financeiro = dbReader["posicao_financeiro"] != null ? Convert.ToString(dbReader["posicao_financeiro"]) : "";
                            cliente.id_endereco_cliente = dbReader["id_endereco_cliente"] != null ? Convert.ToInt32(dbReader["id_endereco_cliente"]) : 0;
                            cliente.lista_negra = dbReader["lista_negra"] != null ? Convert.ToInt32(dbReader["lista_negra"]) : 0;
                        }
                    }
                    return cliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contas_Receber GetContasReceberObject(long id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contas_Receber Where Id=" + id;
                    Contas_Receber contas_Receber = new Contas_Receber();

                    using (var dbReader = cmd.ExecuteReader())
                    {

                        while (dbReader.Read())
                        {
                            contas_Receber.id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0;
                            contas_Receber.data_inicio = Convert.ToDateTime(dbReader["data_inicio"]);
                            contas_Receber.data_fim = Convert.ToDateTime(dbReader["data_fim"]);
                        }
                    }
                    return contas_Receber;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Endereco_Cliente GetEnderecoClienteObject(long id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Endereco_Cliente Where Id=" + id;
                    Endereco_Cliente endereco_Cliente = new Endereco_Cliente();

                    using (var dbReader = cmd.ExecuteReader())
                    {

                        while (dbReader.Read())
                        {
                            endereco_Cliente.id = dbReader["id"] != null ? Convert.ToInt32(dbReader["id"]) : 0;
                            endereco_Cliente.cep = dbReader["cep"] != null ? Convert.ToInt32(dbReader["cep"]) : 0;
                            endereco_Cliente.rua = dbReader["rua"] != null ? Convert.ToString(dbReader["rua"]) : "";
                            endereco_Cliente.bairro = dbReader["bairro"] != null ? Convert.ToString(dbReader["bairro"]) : "";
                            endereco_Cliente.numero = dbReader["numero"] != null ? Convert.ToString(dbReader["numero"]) : "";
                            endereco_Cliente.complemento = dbReader["complemento"] != null ? Convert.ToString(dbReader["complemento"]) : "";
                        }
                    }
                    return endereco_Cliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Estoque_Matriz GetEstoqueMatrizObject(long codigo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Matriz Where codigo =" + codigo;
                    Estoque_Matriz estoque_Matriz = new Estoque_Matriz();

                    using (var dbReader = cmd.ExecuteReader())
                    {

                        while (dbReader.Read())
                        {
                            estoque_Matriz.codigo = dbReader["codigo"] != null ? Convert.ToInt32(dbReader["codigo"]) : 0;
                            estoque_Matriz.descricao = dbReader["descricao"] != null ? Convert.ToString(dbReader["descricao"]) : "";
                            estoque_Matriz.estoque_atual = dbReader["estoque_atual"] != null ? Convert.ToInt32(dbReader["estoque_atual"]) : 0;
                            estoque_Matriz.estoque_anterior = dbReader["estoque_anterior"] != null ? Convert.ToInt32(dbReader["estoque_anterior"]) : 0;
                            estoque_Matriz.custo = dbReader["custo"] != null ? Convert.ToDouble(dbReader["custo"]) : 0.0;
                            estoque_Matriz.formas_pagto = dbReader["formas_pagto"] != null ? Convert.ToInt32(dbReader["formas_pagto"]) : 0;
                        }
                    }
                    return estoque_Matriz;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Estoque_Vendedor GetEstoqueVendedorObject(long codigo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque_Vendedor Where codigo=" + codigo;
                    Estoque_Vendedor estoque_Vendedor = new Estoque_Vendedor();
                    using (var dbReader = cmd.ExecuteReader())
                    {
                        while (dbReader.Read())
                        {
                            estoque_Vendedor.codigo = dbReader["codigo"] != null ? Convert.ToInt32(dbReader["codigo"]) : 0;
                            estoque_Vendedor.estoque_atual = dbReader["estoque_atual"] != null ? Convert.ToInt32(dbReader["estoque_atual"]) : 0;
                            estoque_Vendedor.estoque_anterior = dbReader["estoque_anterior"] != null ? Convert.ToInt32(dbReader["estoque_anterior"]) : 0;
                        }
                    }
                    return estoque_Vendedor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddCliente(Cliente cliente)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Cliente(id, nome, created_at, cpf, posicao_financeiro, id_endereco_cliente, lista_negra ) values (@id, @nome, @created_at, @cpf, @posicao_financeiro, @id_endereco_cliente, @lista_negra)";
                    cmd.Parameters.AddWithValue("@id", cliente.id);
                    cmd.Parameters.AddWithValue("@nome", cliente.nome);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                    cmd.Parameters.AddWithValue("@posicao_financeiro", cliente.posicao_financeiro);
                    cmd.Parameters.AddWithValue("@id_endereco_cliente", cliente.id_endereco_cliente);
                    cmd.Parameters.AddWithValue("@lista_negra", cliente.lista_negra);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddContasReceber(Contas_Receber contas_Receber)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contas_Receber(id, data_inicio, data_fim) values (@id, @data_inicio, @data_fim)";
                    cmd.Parameters.AddWithValue("@id", contas_Receber.id);
                    cmd.Parameters.AddWithValue("@data_inicio", contas_Receber.data_inicio);
                    cmd.Parameters.AddWithValue("@data_fim", contas_Receber.data_fim);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddEnderecoCliente(Endereco_Cliente endereco_Cliente)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Endereco_Cliente(id, nome, cep, rua, bairro, numero, complemento ) values (@id, @cep, @rua, @bairro @numero, @complemento)";
                    cmd.Parameters.AddWithValue("@id", endereco_Cliente.id);
                    cmd.Parameters.AddWithValue("@cep", endereco_Cliente.cep);
                    cmd.Parameters.AddWithValue("@rua", endereco_Cliente.rua);
                    cmd.Parameters.AddWithValue("@bairro", endereco_Cliente.bairro);
                    cmd.Parameters.AddWithValue("@numero", endereco_Cliente.numero);
                    cmd.Parameters.AddWithValue("@complemento", endereco_Cliente.complemento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddEstoqueMatriz(Estoque_Matriz estoque_Matriz)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Estoque_Matriz(codigo, descricao, estoque_atual, estoque_anterior, custo, formas_pagto) values (@codigo, @descricao, @estoque_atual, @estoque_anterior, @custo, @formas_pagto)";
                    cmd.Parameters.AddWithValue("@codigo", estoque_Matriz.codigo);
                    cmd.Parameters.AddWithValue("@descricao", estoque_Matriz.descricao);
                    cmd.Parameters.AddWithValue("@estoque_atual", estoque_Matriz.estoque_atual);
                    cmd.Parameters.AddWithValue("@estoque_anterior", estoque_Matriz.estoque_anterior);
                    cmd.Parameters.AddWithValue("@custo", estoque_Matriz.custo);
                    cmd.Parameters.AddWithValue("@formas_pagto", estoque_Matriz.formas_pagto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddEstoqueVendedor(Estoque_Vendedor estoque_Vendedor)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Estoque_Vendedor(codigo, estoque_atual, estoque_anterior) values (@codigo, @estoque_atual, @estoque_anterior)";
                    cmd.Parameters.AddWithValue("@codigo", estoque_Vendedor.codigo);
                    cmd.Parameters.AddWithValue("@estoque_atual", estoque_Vendedor.estoque_atual);
                    cmd.Parameters.AddWithValue("@estoque_anterior", estoque_Vendedor.estoque_anterior);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateCliente(Cliente cliente)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (cliente != null)
                    {
                        cmd.CommandText = "UPDATE Cliente SET nome=@nome, cpf=@cpf, posicao_financeiro=@posicao_financeiro, lista_negra=@lista_negra WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", cliente.id);
                        cmd.Parameters.AddWithValue("@nome", cliente.nome);
                        cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                        cmd.Parameters.AddWithValue("@posicao_financeiro", cliente.posicao_financeiro);
                        cmd.Parameters.AddWithValue("@lista_negra", cliente.lista_negra);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateContasReceber(Contas_Receber contas_Receber)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (contas_Receber != null)
                    {
                        cmd.CommandText = "UPDATE Contas_Receber SET data_inicio=@data_inicio, data_fim=@data_fim WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", contas_Receber.id);
                        cmd.Parameters.AddWithValue("@data_inicio", contas_Receber.data_inicio);
                        cmd.Parameters.AddWithValue("@data_fim", contas_Receber.data_fim);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateEnderecoCliente(Endereco_Cliente endereco_Cliente)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (endereco_Cliente != null)
                    {
                        cmd.CommandText = "UPDATE Endereco_Cliente SET cep=@cep, rua=@rua, bairro=@bairro, numero=@numero, complemento=@complemento WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", endereco_Cliente.id);
                        cmd.Parameters.AddWithValue("@cep", endereco_Cliente.cep);
                        cmd.Parameters.AddWithValue("@rua", endereco_Cliente.rua);
                        cmd.Parameters.AddWithValue("@bairro", endereco_Cliente.bairro);
                        cmd.Parameters.AddWithValue("@numero", endereco_Cliente.numero);
                        cmd.Parameters.AddWithValue("@complemento", endereco_Cliente.complemento);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateEstoqueMatriz(Estoque_Matriz estoque_Matriz)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (estoque_Matriz != null)
                    {
                        cmd.CommandText = "UPDATE Estoque_Matriz SET descricao=@descricao, estoque_atual=@estoque_atual, estoque_anterior=@estoque_anterior, custo=@custo, formas_pagto=@formas_pagto WHERE codigo=@codigo";
                        cmd.Parameters.AddWithValue("@codigo", estoque_Matriz.codigo);
                        cmd.Parameters.AddWithValue("@descricao", estoque_Matriz.descricao);
                        cmd.Parameters.AddWithValue("@estoque_atual", estoque_Matriz.estoque_atual);
                        cmd.Parameters.AddWithValue("@estoque_anterior", estoque_Matriz.estoque_anterior);
                        cmd.Parameters.AddWithValue("@custo", estoque_Matriz.custo);
                        cmd.Parameters.AddWithValue("@formas_pagto", estoque_Matriz.formas_pagto);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateEstoqueVendedor(Estoque_Vendedor estoque_Vendedor)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (estoque_Vendedor != null)
                    {
                        cmd.CommandText = "UPDATE Estoque_Vendedor SET estoque_atual=@estoque_atual, estoque_anterior=@estoque_anterior WHERE codigo=@codigo";
                        cmd.Parameters.AddWithValue("@codigo", estoque_Vendedor.codigo);
                        cmd.Parameters.AddWithValue("@estoque_atual", estoque_Vendedor.estoque_atual);
                        cmd.Parameters.AddWithValue("@estoque_anterior", estoque_Vendedor.estoque_anterior);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteCliente(int id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Cliente Where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteContasReceber(int id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Contas_Receber Where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteEnderecoCliente(int id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Endereco_Cliente Where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteEstoqueMatriz(int codigo)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Estoque_Matriz Where codigo=@codigo";
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteEstoqueVendedor(int codigo)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Estoque_Vendedor Where codigo=@codigo";
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteAll(string Table)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM " + Table;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}