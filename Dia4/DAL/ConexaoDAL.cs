using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DAL{
    interface IDAL<T>{
        void Insert(T item);
        void Update(T item);
        List<T> Select();
        void Delete(T item);
    }

    public class ConexaoDAL{
        protected static MySqlConnection conn;

        protected static String getConString(){
            string server = ConfigurationManager.AppSettings["server"];
            string userid = ConfigurationManager.AppSettings["userid"];
            string pass = ConfigurationManager.AppSettings["password"];
            string db = ConfigurationManager.AppSettings["database"];
            
            return String.Format("server={0};userid={1};password={2};database={3}", server, userid, pass, db);
        }

        public static bool TestConnection(){
            bool connection = false;
            conn = new MySqlConnection(getConString());
            try{
                conn.Open();
                connection = true;
            } catch (MySqlException ex) {
                throw new Exception("Erro na SQL: " + ex.Message);
            } catch(Exception ex){
                throw new Exception("Erro no método: " + ex.Message);
            } finally{
                if (conn != null){
                    conn.Close();
                }
            }
            return connection;
        }
    }
}
