using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/
class FactoryDatabase
{
    public static IDataBase CreateDataBase(string pStringConnection)
    {
        IDbConnection conexion = null;
        try
        {
            IDataBase db = new DataBase();

            conexion = new SqlConnection(pStringConnection);

            conexion.Open();

            db._Conexion = conexion;

            if (conexion.State != ConnectionState.Open)
            {
                throw new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");
            }
            return db;
        }
        catch (Exception)
        {
            throw;
        }
    }
}

