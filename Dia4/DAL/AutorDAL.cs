using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL{
    public class AutorDAL : ConexaoDAL, IDAL<Autor>{
        public void Insert(Autor item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"INSERT INTO autor (AUT_NOME, AUT_IDADE, CID_ID)
                            values(@AUT_NOME, @AUT_IDADE, @CID_ID)";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("AUT_NOME", item.AUT_NOME);
                cmd.Parameters.AddWithValue("AUT_IDADE", item.AUT_IDADE);
                if (item.CID != null)
                    cmd.Parameters.AddWithValue("CID_ID", item.CID.CID_ID);
                else
                    cmd.Parameters.AddWithValue("CID_ID", DBNull.Value);
                //Abre a conexão com o banco
                conn.Open();
                //Executa a Query
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex) {
                throw new Exception("Erro na SQL: " + ex.Message);
            } catch(Exception ex){
                throw new Exception("Erro no método: " + ex.Message);
            } finally{
                //Fecha a conexão
                if (conn != null){
                    conn.Close();
                }
            }
        }

        public void Update(Autor item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = "UPDATE autor SET AUT_NOME = @AUT_NOME, AUT_IDADE = @AUT_IDADE " +
                    (item.CID != null ? ",CID_ID = @CID_ID " : "")        
                    +"WHERE AUT_ID = @AUT_ID";
                //Objeto responsável por executar a Query no BD         
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("AUT_NOME", item.AUT_NOME);
                cmd.Parameters.AddWithValue("AUT_IDADE", item.AUT_IDADE);
                cmd.Parameters.AddWithValue("AUT_ID", item.AUT_ID);
                if (item.CID != null)
                    cmd.Parameters.AddWithValue("CID_ID", item.CID.CID_ID);
                //Abre a conexão com o banco
                conn.Open();
                //Executa a Query
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex) {
                throw new Exception("Erro na SQL: " + ex.Message);
            } catch(Exception ex){
                throw new Exception("Erro no método: " + ex.Message);
            } finally{
                //Fecha a conexão
                if (conn != null){
                    conn.Close();
                }
            }
        }
    
        public void Delete(Autor item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"DELETE FROM autor WHERE AUT_ID = @AUT_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("AUT_ID", item.AUT_ID);
                //Abre a conexão com o banco
                conn.Open();
                //Executa a Query
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex) {
                throw new Exception("Erro na SQL: " + ex.Message);
            } catch(Exception ex){
                throw new Exception("Erro no método: " + ex.Message);
            } finally{
                //Fecha a conexão
                if (conn != null){
                    conn.Close();
                }
            }
        }
    
        public List<Autor> Select(){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"SELECT AUT_ID, AUT_NOME, AUT_IDADE, CID_ID FROM autor";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                //cmd.Parameters.AddWithValue("CID_ID", item.CID_ID);
                //Abre a conexão com o banco
                conn.Open();
                //Cria o objeto de leitura dos Dados e lista de Resultados
                MySqlDataReader dados = cmd.ExecuteReader();
                List<Autor> resultados = new List<Autor>();
                while(dados.Read()){
                    Autor aut = new Autor();
                    aut.AUT_ID = Convert.ToInt32(dados[0].ToString());
                    aut.AUT_NOME = dados[1].ToString();
                    aut.AUT_IDADE = Convert.ToInt32(dados[2].ToString());
                    if (!dados.IsDBNull(3))
                    {
                        aut.CID = new Cidade();
                        aut.CID.CID_ID = Convert.ToInt32(dados[3].ToString());
                    }
                    resultados.Add(aut);
                }

                return resultados;
            } 
            catch (MySqlException ex) {
                throw new Exception("Erro na SQL: " + ex.Message);
            } catch(Exception ex){
                throw new Exception("Erro no método: " + ex.Message);
            } finally{
                //Fecha a conexão
                if (conn != null){
                    conn.Close();
                }
            }
        }
    }
}