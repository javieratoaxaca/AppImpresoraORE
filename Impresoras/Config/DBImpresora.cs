using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Impresoras.Config
{
    class DBImpresora
    {
        string cnx; // variable que contendra la ruta para conectvidad con las BD
        MySqlConnection mySqlcnn;

        //Constructor
        public DBImpresora()
        {
            cnx= "Database=impresora; Data Source=localhost;User id=root;password=oportunidades;"; //-->Usuario Local
           // cnx = "SERVER=192.168.0.85; PORT=3306;DATABASE=impresora;UID=user_ext;PASSWORD=oportunidades;"; // -->Usuario Externo
        }

        //Metodo para abrir la conexion 

        public MySqlConnection getConnection()
        {
            try
            {
                mySqlcnn = new MySqlConnection(cnx);
                mySqlcnn.Open();
               
                
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al conectarse a la Base de datos." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Al realizar la conexion la Base de datos." + ex.Message);
            }

            return mySqlcnn;
        }

        //metodo para Ejecucion de Querys
        public int ExecuteQuery(string querySql)
        {
            int res = 0;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(querySql,getConnection());

                res = mySqlCommand.ExecuteNonQuery();
                
                getConnection().Close();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al ejecutar las sentencias SQL." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return res;
        }

        // METODO PARA OBTENER LA LECTURA DE DATOS
        public MySqlDataReader GetDataReader(string querySql)
        {
            MySqlDataReader MySqlDr = null;
            try
            {
                MySqlCommand MySqlCommand = new MySqlCommand(querySql, getConnection());
                MySqlDataAdapter MySqlDap = new MySqlDataAdapter(MySqlCommand);
                MySqlDr = MySqlCommand.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error: Al ejecutar las sentencias SQL." + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MySqlDr;
        }

        //metodo para la cuestion de datos
        public DataTable GetDataTabla(string querySql)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlCommand MySqlCommand = new MySqlCommand(querySql, getConnection());
            MySqlDataAdapter MySqlDap = new MySqlDataAdapter(MySqlCommand);
            MySqlDap.SelectCommand = MySqlCommand;
            MySqlDap.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

    }
}
