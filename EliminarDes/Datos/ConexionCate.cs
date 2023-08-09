using System.Data.SqlClient;

namespace Proyeto.Datos
{
    public class ConexionCate
    {
        private string cadenaSql = string.Empty;

        public ConexionCate()
        {
            //PARA OBTENER LA CADENA DE CONEXION QUE ESTA EN EL ARCHIVO APPSETTINGS.JSON

            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            //PARA OBTENER EL VALOR DE LA CADENA DE CONEXION
            cadenaSql = builder.GetSection("ConnectionStrings: cadenaSql").Value;
        }

        //CREAR METODO PARA DEVOLVER LA CADENA
        public string getCadenaSql()
        {
            return cadenaSql;
        }
    }
}
