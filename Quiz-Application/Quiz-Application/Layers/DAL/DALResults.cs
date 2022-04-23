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
    public class DALResultds : IDALResults
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public Result GetQuestionById(string pId)
        {
            DataSet ds = null;
            Result oCliente = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Result Where RCandidate = @IdCliente ";
                command.Parameters.AddWithValue("@IdCliente", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                //if the select returns Row(s)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //map row by row
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oCliente = new Result();
                        //oCliente.Id = dr["QId"].ToString();
                        oCliente.Cantidate = dr["RCandidate"].ToString();
                        oCliente.Score = int.Parse(dr["RScore"].ToString());
                    }
                }
                return oCliente;
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

        public Result SaveQuestion(Result pQuestion)
        {
            Result oQuiestion = null;
            SqlCommand command = new SqlCommand();

            string sql = @"Insert into Result(RCandidate,RScore)
                            values (@RC,@RS)";
            try
            {
                command.Parameters.AddWithValue("@RC", pQuestion.Cantidate);
                command.Parameters.AddWithValue("@RS", pQuestion.Score);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                return oQuiestion;

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

