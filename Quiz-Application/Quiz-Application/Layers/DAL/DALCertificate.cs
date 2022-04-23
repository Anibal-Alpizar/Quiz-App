using log4net;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.Layers.DAL
{
    public class DALCertificate : IDALCertificate
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public List<Certificate> GetFullInformacion()
        {
            DataSet ds = null;
            List<Certificate> lista = new List<Certificate>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT * FROM Certificate";
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Certificate oElectronicoBodegaDTO = new Certificate()
                        {
                            Id = (dr["Id"].ToString()),
                            Message = (dr["Message"].ToString()),
                            Location = (dr["Location"].ToString()),
                            Congratulations = (dr["Congratulation"].ToString()),
                            FinalMessage = (dr["FinalMessage"].ToString()),
                          
                        };

                        lista.Add(oElectronicoBodegaDTO);
                    }
                }

                return lista;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }
    }
}
