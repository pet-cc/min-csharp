using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL{
    public class CategoriaDAL : ConexaoDAL, IDAL<Categoria>{
        public void Insert(Categoria item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"INSERT INTO categoria (CAT_NOME)
                            values(@CAR_NOME)";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CAT_NOME", item.CAT_NOME);
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

        public void Update(Categoria item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"UPDATE categoria SET CAT_NOME = @CID_NOME
                            WHERE CAT_ID = @CAT_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CAT_NOME", item.CAT_NOME);
                cmd.Parameters.AddWithValue("CAT_ID", item.CAT_ID);
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
    
        public void Delete(Categoria item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"DELETE FROM categoria WHERE CAT_ID = @CAT_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("CAT_ID", item.CAT_ID);
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
    
        public List<Categoria> Select(){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"SELECT CAT_ID, CAT_NOMEFROM categoria";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Abre a conexão com o banco
                conn.Open();
                //Cria o objeto de leitura dos Dados e lista de Resultados
                MySqlDataReader dados = cmd.ExecuteReader();
                List<Categoria> resultados = new List<Categoria>();
                while(dados.Read()){
                    Categoria cat = new Categoria();
                    cat.CAT_ID = Convert.ToInt32(dados[0].ToString());
                    cat.CAT_NOME = dados[1].ToString();
                    resultados.Add(cat);
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