﻿using System;

using MySql.Data.MySqlClient;

using System.Data;
using System.Windows.Forms;

using Impresoras.Data;

namespace Impresoras.Models
{
    class mdImpresora:Config.DBImpresora
    {
        
        public mdImpresora() { }

        //Metodo para insertar los datos a la base de datos 

        public dtImpresora GetProducto(int idInventarioPrint)
        {

            dtImpresora dtPrint = new dtImpresora();
            try
            {
                string Query = string.Format("SELECT * FROM inventarioequipo  where idInventarioEquipo like '{0}'", idInventarioPrint);
                // MySqlDataReader dr = GetDataTabla(Query);
                MySqlDataReader dr = GetDataReader(Query);

                while (dr.Read())
                {
                    dtPrint.IdInventarioEquipo = Convert.ToInt32(dr["idInventarioEquipo"].ToString());
                    dtPrint.NumeroEquipo = dr["numEquipo"].ToString();
                    dtPrint.NombreEquipo = dr["nombreEquipo"].ToString();
                    dtPrint.SerieEquipo = dr["serieEquipo"].ToString();
                    dtPrint.MarcaEquipo = dr["marcaEquipo"].ToString();
                    dtPrint.ModeloEquipo = dr["modeloEquipo"].ToString();
                    dtPrint.ObsEquipo = dr["obsEquipo"].ToString();
                    dtPrint.EstadoEquipo = Convert.ToInt32(dr["statusEquipo"].ToString());
                    dtPrint.FechaAlta = dr["fechaRegistro"].ToString();
                    dtPrint.ImgQr = dr["imgQr"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return dtPrint;
        }

        public bool insertImpresora(dtImpresora dtPrint) {

            string Query = string.Format("INSERT INTO inventarioequipo (numEquipo,nombreEquipo,serieEquipo,marcaEquipo," +
                                         "modeloEquipo,obsEquipo,statusEquipo,fechaRegistro,imgQr) " +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}')",
                                         dtPrint.NumeroEquipo,dtPrint.NombreEquipo,dtPrint.SerieEquipo,dtPrint.MarcaEquipo, 
                                         dtPrint.ModeloEquipo, dtPrint.ObsEquipo,dtPrint.EstadoEquipo,dtPrint.FechaAlta,dtPrint.ImgQr);

            //MySqlCommand
            try
            {
                Console.Write(Query);

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


        //Metodo para saber si existe una impresora
        public bool ExistePrint(string serie)
        {

            dtImpresora dtPrint = new dtImpresora();
            dtPrint.SerieEquipo = serie;
            try
            {
                string Query = string.Format("SELECT serieEquipo FROM inventarioequipo WHERE serieEquipo LIKE '{0}'", dtPrint.SerieEquipo);
                MySqlDataReader dr = GetDataReader(Query);
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Metodo para Actualizar el Registro Completo y se muestre en el Datagrid
        public bool UpdatePrint(dtImpresora dtPrint)
        {
            string Query = string.Format("UPDATE inventarioequipo SET numEquipo='{0}',nombreEquipo='{1}',serieEquipo='{2}',marcaEquipo='{3}',modeloEquipo='{4}',obsEquipo='{5}',statusEquipo={6}, fechaRegistro='{7}',imgQr='{8}' WHERE idInventarioEquipo like '{9}'",
                dtPrint.NumeroEquipo,
                dtPrint.NombreEquipo,
                dtPrint.SerieEquipo,
                dtPrint.MarcaEquipo,
                dtPrint.ModeloEquipo,
                dtPrint.ObsEquipo,
                dtPrint.EstadoEquipo,
                dtPrint.FechaAlta,
                dtPrint.ImgQr,
                dtPrint.IdInventarioEquipo);
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
        //Metodo para Actualizar el Registro de Status de la Impresora 0=Baja, 1=Activo ,2 = Asignado se muestre en el Datagrid
        public bool UpdatePrintStatus(dtImpresora dtPrint,dtDetallesAsignacion dtAssignPrint)
        {
            string Query = string.Format("UPDATE inventarioequipo SET statusEquipo={0} Where idInventarioEquipo={1}", dtPrint.EstadoEquipo,dtAssignPrint.IdInventarioEquipo);
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

        //Metodo para Buscar un dato en la Base 
        public void cargaGridBuscador(DataGridView grid, string txtBuscar)
        {
            try
            {
                string query = string.Format("Select numEquipo,nombreEquipo,serieEquipo,marcaEquipo,modeloEquipo,obsEquipo,fechaRegistro,imgQr From inventarioequipo Where serieEquipo LIKE '%{0}%' OR modeloEquipo LIKE '%{0}%' OR numEquipo LIKE '%{0}%'",txtBuscar);
                MySqlCommand cmd = new MySqlCommand(query, getConnection());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid.DataSource = dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        //Metodo para llenar el DataGridView
        public void llenargrid(DataGridView grid)
        {
            try
            {
                string Query = string.Format("select idInventarioEquipo as Id,numEquipo as Num_Equipo, nombreEquipo as Nombre_Equipo,serieEquipo as Serie_Equipo,marcaEquipo as Marca_Equipo,modeloEquipo as Modelo_Equipo,obsEquipo as Observaciones,fechaRegistro as Fecha_Alta,imgQr as Qr from inventarioequipo where statusEquipo=1");
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

        //Metodo para llenar el ComboBox
        public void llenarCmbxPrint(ComboBox cmb)

        {
            cmb.Items.Clear();
            try
            {
                //string Query = string.Format("SELECT CONCAT(idSare,'---', sare)AS Region FROM region; ");
                string Query = string.Format("SELECT * FROM inventarioequipo");
                //string Query2 = string.Format("SELECT sare  FROM region; ");
                MySqlDataReader dr = GetDataReader(Query);
                //MySqlDataReader dr2 = GetDataReader(Query2);

                while (dr.Read())
                {
                    //cmb.Items.Add(dr[3].ToString() + " -- " + dr[4].ToString() + " -- " + dr[5].ToString());
                    cmb.Items.Add(dr[3].ToString());
                    //cmb.Items.Add(dr[2].ToString())

                }
                cmb.Items.Insert(0, "--- Selecciona una Impresora ---");
                cmb.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
