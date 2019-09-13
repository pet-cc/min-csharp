using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL{
    public class NoticiaDAL : ConexaoDAL, IDAL<Noticia>{
        public void Insert(Noticia item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"INSERT INTO noticia (NOT_TITULO, NOT_TEXTO, NOT_DATA, CAT_ID, AUT_ID)
                            values(@NOT_TITULO, @NOT_TEXTO, @NOT_DATA, @CAT_ID, @AUT_ID)";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("NOT_TITULO", item.NOT_TITULO);
                cmd.Parameters.AddWithValue("NOT_TEXTO", item.NOT_TEXTO);
                cmd.Parameters.AddWithValue("NOT_DATA", item.NOT_DATA);
                if (item.CAT != null)
                    cmd.Parameters.AddWithValue("CAT_ID", item.CAT.CAT_ID);
                else
                    cmd.Parameters.AddWithValue("CAT_ID", DBNull.Value);
                if (item.AUT != null)
                    cmd.Parameters.AddWithValue("AUT_ID", item.AUT.AUT_ID);
                else
                    cmd.Parameters.AddWithValue("AUT_ID", DBNull.Value);
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

        public void Update(Noticia item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado NOT_TITULO, NOT_TEXTO, NOT_DATA, CAT_ID, AUT_ID
                string sql = "UPDATE noticia SET NOT_TITULO = @NOT_TITULO, NOT_TEXTO = @NOT_TEXTO, NOT_DATA = @NOT_DATA"+
                    (item.CAT != null ? ", CAT_ID = @CAT_ID" : "")+
                    (item.AUT != null ? ", AUT_ID = @AUT_ID" : "")+
                    "WHERE NOT_ID = @NOT_ID";
                //Objeto responsável por executar a Query no BD         
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("NOT_TITULO", item.NOT_TITULO);
                cmd.Parameters.AddWithValue("NOT_TEXTO", item.NOT_TEXTO);
                cmd.Parameters.AddWithValue("NOT_DATA", item.NOT_DATA);
                if(item.CAT != null)
                    cmd.Parameters.AddWithValue("CAT_ID", item.CAT.CAT_ID);
                if(item.AUT != null)
                    cmd.Parameters.AddWithValue("AUT_ID", item.AUT.AUT_ID);
                cmd.Parameters.AddWithValue("NOT_ID", item.NOT_ID);
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
    
        public void Delete(Noticia item){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"DELETE FROM noticia WHERE NOT_ID = @NOT_ID";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                cmd.Parameters.AddWithValue("NOT_ID", item.NOT_ID);
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
    
        public List<Noticia> Select(){
            //Objeto de Conexão com o BD
            conn =  new MySqlConnection(getConString());
            try{
                //SQL a ser executado
                string sql = @"SELECT NOT_ID, NOT_TITULO, NOT_TEXTO, NOT_DATA, CAT_ID, AUT_ID FROM noticia";
                //Objeto responsável por executar a Query no BD            
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Parâmetros da Query
                //cmd.Parameters.AddWithValue("CID_ID", item.CID_ID);
                //Abre a conexão com o banco
                conn.Open();
                //Cria o objeto de leitura dos Dados e lista de Resultados
                MySqlDataReader dados = cmd.ExecuteReader();
                List<Noticia> resultados = new List<Noticia>();
                while(dados.Read()){ 
                    Noticia not = new Noticia();
                    not.NOT_ID = Convert.ToInt32(dados[0].ToString());
                    not.NOT_TITULO = dados[1].ToString();
                    not.NOT_TEXTO = dados[2].ToString();
                    not.NOT_DATA = Convert.ToDateTime(dados[3].ToString());
                    if (!dados.IsDBNull(4)){
                        Categoria cat = new Categoria();
                        cat.CAT_ID = Convert.ToInt32(dados[4].ToString());
                        not.CAT = cat;
                    }
                    if (!dados.IsDBNull(5))
                    {
                        Autor aut = new Autor();
                        aut.AUT_ID = Convert.ToInt32(dados[5].ToString());
                        not.AUT = aut;
                    }
                    resultados.Add(not);
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