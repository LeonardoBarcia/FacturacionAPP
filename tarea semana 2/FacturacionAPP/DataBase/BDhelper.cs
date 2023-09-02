using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FacturacionAPP.DataBase
{
    class BDhelper
    {
        private SqlConnection coneccion;
        public BDhelper()
        {
            coneccion = new SqlConnection(@"Data Source=LEONARDODJ-PC\SQLEXPRESS;Initial Catalog=Kiosco_24;Integrated Security=True");
            
        }
            
         
        internal int ProximaFactura()
        {
            SqlCommand comando = new SqlCommand();
            coneccion.Open();

            comando.Connection = coneccion;
            comando.CommandText = "SP_PROXIMO_ID";
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = System.Data.SqlDbType.Int;
            parametro.Direction = System.Data.ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            coneccion.Close();
            
            return (int)parametro.Value;
        }

        internal DataTable consultarFacturas(string v, List<parametro> lista)
        {
            DataTable tabla = new DataTable();
            coneccion.Open();
            SqlCommand comando = new SqlCommand(v,coneccion);
            comando.CommandType = CommandType.StoredProcedure;
            foreach (parametro parametro in lista)
            {
                comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);

            }
            tabla.Load(comando.ExecuteReader());
            coneccion.Close();
            return tabla;
        }

        
        internal DataTable ConsultarFormaPago(string strsql)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            coneccion.Open();
            comando.Connection = coneccion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = strsql;
            tabla.Load(comando.ExecuteReader());
            coneccion.Close();
            return tabla;

        }

        internal bool ConfirmarFactura(Factura nueva)
        {
            bool ok = true;
            SqlCommand comando = new SqlCommand();
            coneccion.Open();
            comando.Connection = coneccion;
            comando.CommandText = "SP_INSERT_MAESTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cliente",nueva.Cliente);
            comando.Parameters.AddWithValue("@total", nueva.CalcularTotal());

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@id_factura";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction=ParameterDirection.Output;
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            int facturaNRO = (int)parametro.Value;
            SqlCommand cmdDetalle;
            int detalleNRO = 1;
            foreach (DetalleFactura item in nueva.detalles)
            {
                cmdDetalle = new SqlCommand();

                cmdDetalle.Connection= coneccion;
                cmdDetalle.CommandText = "SP_INSERT_MAESTO";
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_factura", facturaNRO);
                cmdDetalle.Parameters.AddWithValue("@detalle", detalleNRO);
                cmdDetalle.Parameters.AddWithValue("id_acticulo", item.articulo);
                cmdDetalle.Parameters.AddWithValue("@cantiada", item.Cantidad);
                comando.ExecuteNonQuery();

                detalleNRO++;

            }
            coneccion.Close();
            return ok;
        }
    }
}
