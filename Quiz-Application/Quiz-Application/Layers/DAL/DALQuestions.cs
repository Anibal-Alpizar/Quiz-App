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
    public class DALQuestions : IDALQuestions
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public bool DeleteQuestion(string pId)
        {

            double rows = 0;
            string sql = @" delete  from  [Questions] where QId = @IdElectronico ";
            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@IdElectronico", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
                return rows > 0;
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

        public List<Question> GetAllQuestion()
        {
            DataSet ds = null;
            List<Question> lista = new List<Question>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT QId, QDesc, Q01, Q02, Q03,Q04 ,QA FROM Questions";
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
                        Question oElectronicoBodegaDTO = new Question()
                        {
                            Id = (dr["QId"].ToString()),
                            Description = dr["QDesc"].ToString(),
                            Question1 = dr["Q01"].ToString(),
                            Question2 = dr["Q02"].ToString(),
                            Question3 = dr["Q03"].ToString(),
                            Question4 = dr["Q04"].ToString(),
                            CorrectQuestion = dr["QA"].ToString(),

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

        public Question GetQuestionById(string pId)
        {
            DataSet ds = null;
            Question oCliente = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Questions Where QId = @IdCliente ";
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
                        oCliente = new Question();
                        oCliente.Id = dr["QId"].ToString();
                        oCliente.Description = dr["QDesc"].ToString();
                        oCliente.Question1 = dr["Q01"].ToString();
                        oCliente.Question2 = dr["Q02"].ToString();
                        oCliente.Question3 = dr["Q03"].ToString();
                        oCliente.Question4 = dr["Q04"].ToString();
                        oCliente.CorrectQuestion = dr["QA"].ToString();

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

        public Question SaveQuestion(Question pQuestion)
        {
            Question oQuiestion = null;
            SqlCommand command = new SqlCommand();

            string sql = @"Insert into Questions(QDesc,Q01,Q02,Q03,Q04,QA)
                            values (@QDes,@Q01,@Q02,@Q03,@Q04, @QA)";
            try
            {
                command.Parameters.AddWithValue("@QDes", pQuestion.Description);
                command.Parameters.AddWithValue("@Q01", pQuestion.Question1);
                command.Parameters.AddWithValue("@Q02", pQuestion.Question2);
                command.Parameters.AddWithValue("@Q03", pQuestion.Question3);
                command.Parameters.AddWithValue("@Q04", pQuestion.Question4);
                command.Parameters.AddWithValue("@QA", pQuestion.CorrectQuestion);
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

        public Question UpdateQuestion(Question pQuestion)
        {
            Question oQuestion = null;
            string sql = @" 
                            UPDATE [dbo].[Questions]
                               SET 
                                  [QDesc] = @QDesc
                                  ,[Q01] = @Q01
                                  ,[Q02] = @Q02
                                  ,[Q03] = @Q03
                                  ,[Q04] = @Q04 
                                  ,[QA] = @QA                                 
                             WHERE [QId] = @QId  ";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                command.Parameters.AddWithValue("@QId", pQuestion.Id);
                command.Parameters.AddWithValue("@QDesc", pQuestion.Description);
                command.Parameters.AddWithValue("@Q01", pQuestion.Question1);
                command.Parameters.AddWithValue("@Q02", pQuestion.Question2);
                command.Parameters.AddWithValue("@Q03", pQuestion.Question3);
                command.Parameters.AddWithValue("@Q04", pQuestion.Question4);
                command.Parameters.AddWithValue("@QA", pQuestion.CorrectQuestion);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
                if (rows > 0)
                    oQuestion = GetQuestionById(pQuestion.Id);

                return oQuestion;
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
