using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DepartmentDAL : ConexaoDAL, IDAL<Departments>
    {
        public void Insert(Departments item){
            conn = new MySqlConnection(getConString());
            try{
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO departments(dept_no, dept_name) VALUES(@dept_no, @dept_name)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@dept_no", item.Dept_no);
                cmd.Parameters.AddWithValue("@dept_name", item.Dept_name);
                cmd.ExecuteNonQuery();

            } catch (MySqlException ex) {
                Console.WriteLine("Error: {0}", ex.ToString());
            } finally {
                if (conn != null){
                    conn.Close();
                }
            }
        }
        public void Update(Departments item){
            conn = new MySqlConnection(getConString());
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public List<Departments> Select(){
            conn = new MySqlConnection(getConString());
            List<Departments> lsRes = new List<Departments>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                lsRes = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return lsRes;
        }
        public void Delete(Departments item){
            conn = new MySqlConnection(getConString());
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
