﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Impresoras.Data;
using Impresoras.Config;

namespace Impresoras.Models
{
    class mdRegion:DBImpresora
    {
        public mdRegion() { }
        //Metodo para lectura de los datos de la tabla de Region
        public dtRegion GetRegion(string sareregion)
        {

            dtRegion dtRegion = new dtRegion();
            try
            {
                string Query = string.Format("SELECT * FROM region  where idSare like '{0}'", sareregion);
                // MySqlDataReader dr = GetDataTabla(Query);
                MySqlDataReader dr = GetDataReader(Query);

                while (dr.Read())
                {
                    dtRegion.IdRegion = Convert.ToInt32(dr["idRegion"].ToString());
                    dtRegion.IdEdo= Convert.ToInt32(dr["idEdo"].ToString());
                    dtRegion.Estado = dr["estado"].ToString();
                    dtRegion.IdSare= dr["idSare"].ToString();
                    dtRegion.Sare = dr["sare"].ToString();
                    dtRegion.CveOfiLocalidad = dr["cveOfiLocalidad"].ToString();
                    dtRegion.CveMun = dr["cveMun"].ToString();
                    dtRegion.Municipio= dr["municipio"].ToString();
                    dtRegion.CveLocalidad = dr["cveLocalidad"].ToString();
                    dtRegion.Localidad = dr["localidad"].ToString();
                    dtRegion.Cupo = Convert.ToInt32(dr["cupo"].ToString());
                    dtRegion.JefeSare = dr["jefeSare"].ToString();
                    dtRegion.Email = dr["email"].ToString();
                    dtRegion.Domicilio = dr["domicilio"].ToString();
                    dtRegion.Horario = dr["horario"].ToString();
                    dtRegion.Telefono = dr["telefono"].ToString();
                    dtRegion.Latitud = dr["latitud"].ToString();
                    dtRegion.Longitud = dr["longitud"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return dtRegion;
        }
        //Metodo para insertar Datos 
        public bool insertRegiones(dtRegion dtRegiones) {
            string query = string.Format("INSERT INTO region (idEdo,estado,idSare,sare,cveOfiLocalidad,cveMun,municipio,cveLocalidad,localidad,cupo,jefeSare,email,domicilio,horario,telefono,latitud,longitud) VALUES ({0},'{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9},'{10}','{11}','{12}','{13}','{14}','{15}','{16}')",
                dtRegiones.IdEdo,
                dtRegiones.Estado,
                dtRegiones.IdSare,
                dtRegiones.Sare,
                dtRegiones.CveOfiLocalidad,
                dtRegiones.CveMun,
                dtRegiones.Municipio,
                dtRegiones.CveLocalidad,
                dtRegiones.Localidad,
                dtRegiones.Cupo,
                dtRegiones.JefeSare,
                dtRegiones.Email,
                dtRegiones.Domicilio,
                dtRegiones.Horario,
                dtRegiones.Telefono,
                dtRegiones.Latitud,
                dtRegiones.Longitud );

            try
            {
                Console.Write(query);

                int result = ExecuteQuery(query);
                if (result > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
        //Metodo para Actualizar la Region
        public bool UpdateRegion(dtRegion dtRegiones)
        {
            string Query = string.Format("UPDATE region SET sare='{0}',cveOfiLocalidad='{1}',cveMun='{2}',municipio='{3}',cveLocalidad='{4}',localidad='{5}',cupo={6},jefeSare='{7}' , email='{8}',domicilio='{9}', horario='{10}',telefono='{11}', latitud ='{12}', longitud='{13}' WHERE idSare like {14}",
            dtRegiones.Sare,
            dtRegiones.CveOfiLocalidad,
            dtRegiones.CveMun,
            dtRegiones.Municipio,
            dtRegiones.CveLocalidad,
            dtRegiones.Localidad,
            dtRegiones.Cupo,
            dtRegiones.JefeSare,
            dtRegiones.Email,
            dtRegiones.Domicilio,
            dtRegiones.Horario,
            dtRegiones.Telefono,
            dtRegiones.Latitud,
            dtRegiones.Longitud,
            dtRegiones.IdSare);
            try
            {
                int result = ExecuteQuery(Query);
                if (result > 0)

                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }
        //Metodo para Eliminar la Region
        public bool deleteRegion(string sareregion)
        {
            string Query = string.Format("DELETE from region  WHERE idSare like '{0}' ", sareregion);
            try
            {
                int result = ExecuteQuery(Query);
                if (result > 0)

                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }
        //Metodo para saber si existe una Region Duplicada
        public bool existeRegion(string sare)
        {

            dtRegion dtRegiones = new dtRegion ();
            dtRegiones.IdSare = sare;
            try
            {
                string Query = string.Format("SELECT idSare FROM region WHERE idSare LIKE '{0}'", dtRegiones.IdSare);
                MySqlDataReader dr = GetDataReader(Query);
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Metodo para llenar el DataGridView
        public void llenarGrid(DataGridView grid)
        {
            try
            {
                string Query = string.Format("select idEdo,estado,idSare,sare,cveOfiLocalidad,cveMun,municipio,cveLocalidad,localidad,cupo,jefeSare,email,domicilio,horario,telefono,latitud,longitud  from region");
                MySqlCommand Query2 = new MySqlCommand(Query, getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(Query2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //Metodos para Llenar el Combobox de Region 
        public void llenarCmbxRegion(ComboBox cmb)

        {
            cmb.Items.Clear();
            try
            {
                //string Query = string.Format("SELECT CONCAT(idSare,'---', sare)AS Region FROM region; ");
                string Query = string.Format("SELECT * FROM region ");
                //string Query2 = string.Format("SELECT sare  FROM region; ");
                MySqlDataReader dr = GetDataReader(Query);
                //MySqlDataReader dr2 = GetDataReader(Query2);

                while (dr.Read())
                {
                    cmb.Items.Add(dr[4].ToString());
                    //cmb.Items.Add(dr[3].ToString() +" -- " +  dr[4].ToString());
                    //cmb.Items.Add(dr[2].ToString())

                }
                cmb.Items.Insert(0, "--- Selecciona una SARE ---");
                cmb.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
}
}
