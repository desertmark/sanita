using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Sanita.Models;
using System.Data.OleDb;
using System.Data;



namespace Sanita.Models
{
    public class ProductoContext
    {

        public List<Producto> Productos()
        {
            List<Producto> productos = new List<Producto>();

            OleDbConnection connection = new OleDbConnection(@"Provider=MICROSOFT.JET.OLEDB.4.0;DATA SOURCE=|DataDirectory|\sanitarios.mdb;Persist Security Info=False");
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT id, descripcion FROM lista";
            command.CommandType = CommandType.Text;
            connection.Open();
            command.Connection = connection;

            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Producto p = new Producto();
                p.Id = Convert.ToInt32(reader["id"].ToString());
                p.Descripcion = reader["descripcion"].ToString();

                productos.Add(p);
            }
            return productos;
        }
    }
}