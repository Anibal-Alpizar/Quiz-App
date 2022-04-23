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
    public class DALQuiz : IDALQuiz
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public List<Quiz> FillQuiz()
        {
            DataSet ds = null;
            List<Quiz> lista = new List<Quiz>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT * FROM Questions";
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
                        Quiz oElectronicoBodegaDTO = new Quiz()
                        {
                            Id = (dr["QId"].ToString()),
                            Description = (dr["QDesc"].ToString()),
                            Q01 = (dr["Q01"].ToString()),
                            Q02 = (dr["Q02"].ToString()),
                            Q03 = (dr["Q03"].ToString()),
                            Q04 = (dr["Q04"].ToString()),
                            CorrectResponse = (dr["QA"].ToString()),


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
