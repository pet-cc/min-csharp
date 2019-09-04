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
        protected MySqlConnection conn;

        protected String getConString(){
            string server = ConfigurationManager.AppSettings["server"];
            string userid = ConfigurationManager.AppSettings["userid"];
            string pass = ConfigurationManager.AppSettings["password"];
            string db = ConfigurationManager.AppSettings["database"];
            
            return String.Format("server={0};userid={1};password={2};database={3}", server, userid, pass, db);
        }
    }
}
