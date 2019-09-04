using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL{
    public class CidadeDAL : ConexaoDAL, IDAL<Cidade>{
        public void Insert(Cidade item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"INSERT INTO cidade (CID_NOME, CID_UF)
                            values(@CID_NOME, @CID_UF)";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CID_NOME", item.CID_NOME);
                cmd.Parameters.AddWithValue("CID_UF", item.CID_UF.ToArray());
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

        public void Update(Cidade item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"UPDATE cidade SET CID_NOME = @CID_NOME, CID_UF = @CID_UF
                            WHERE CID_ID = @CID_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CID_NOME", item.CID_NOME);
                cmd.Parameters.AddWithValue("CID_UF", item.CID_UF);
                cmd.Parameters.AddWithValue("CID_ID", item.CID_ID);
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
    
        public void Delete(Cidade item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"DELETE FROM cidade WHERE CID_ID = @CID_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CID_ID", item.CID_ID);
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
    
        public List<Cidade> Select(){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"SELECT CID_ID, CID_NOME, CID_UF FROM cidade";
                // WHERE CID_ID = @CID_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                //cmd.Parameters.AddWithValue("CID_ID", item.CID_ID);
                //Abre a conexão com o banco
                conn.Open();
                //Cria o objeto de leitura dos Dados e lista de Resultados
                MySqlDataReader dados = cmd.ExecuteReader();
                List<Cidade> resultados = new List<Cidade>();
                while(dados.Read()){
                    Cidade cid = new Cidade();
                    cid.CID_ID = Convert.ToInt32(dados[0].ToString());
                    cid.CID_NOME = dados[1].ToString();
                    cid.CID_UF = dados[2].ToString();
                    resultados.Add(cid);
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