using log4net;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Properties;
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
    public class DALCandidates : IDALCandidates
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public Candidate Login(string pLogin, string pPassword)
        {
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Candidate oUsuario = null;
            try
            {
                command.CommandText = @"select * from Student where SName = @pLogin AND SPass = @pPassword";
                command.Parameters.AddWithValue("@pLogin", pLogin);
                command.Parameters.AddWithValue("@pPassword", pPassword);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oUsuario = new Candidate();
                        oUsuario.Name = reader["SName"].ToString();
                        // oUsuario.IdRol = int.Parse(reader["IdRol"].ToString());
                        oUsuario.Password = reader["SPass"].ToString();
                        // oUsuario.Phone = reader["SPhone"].ToString();
                    }
                }

                return oUsuario;
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
        public List<Candidate> GetAllElectronico()
        {
            DataSet ds = null;
            List<Candidate> lista = new List<Candidate>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT SId, SName, SAge, SPass, SAdd, SPhone FROM Student";
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Candidate oElectronicoBodegaDTO = new Candidate()
                        {
                            Id = (dr["SId"].ToString()),
                            Name = dr["SName"].ToString(),
                            Age = int.Parse(dr["SAge"].ToString()),
                            Password = dr["SPass"].ToString(),
                            Add = dr["SAdd"].ToString(),
                            Phone = dr["SPhone"].ToString()
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

        public bool DeleteElectronico(string pId)
        {
            double rows = 0;
            // Crear el SQL
            string sql = @" delete   from  [Student] where SId = @IdElectronico ";
            SqlCommand command = new SqlCommand();

            try
            {
                // Pasar parámetros
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

        public Candidate GetCandidateById(string pId)
        {
            DataSet ds = null;
            Candidate oCliente = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Student Where SId = @IdCliente ";
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
                        oCliente = new Candidate();
                        oCliente.Id = (dr["SId"].ToString());
                        oCliente.Name = dr["SName"].ToString();
                        oCliente.Age = int.Parse(dr["SAge"].ToString());
                        oCliente.Password = dr["SPass"].ToString();
                       // oCliente.Score = int.Parse(dr["SScore"].ToString());
                        oCliente.Add = dr["SAdd"].ToString();
                        oCliente.Phone = dr["SPhone"].ToString();
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
        public Candidate SaveScore(Candidate pScore)
        {

            Candidate pQuestion = null;
            SqlCommand command = new SqlCommand();

            string sql = @"Insert into Student(SScore) values (@SScore)";
            try
            {
                command.Parameters.AddWithValue("@SScore", pScore.Score);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                return pQuestion;
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

        public Candidate SaveCandidate(Candidate pQuestion)
        {
            Candidate oQuiestion = null;
            SqlCommand command = new SqlCommand();

            string sql = @"Insert into Student(SName,SAge,SPass,SScore,SAdd,SPhone)
                            values (@SName,@SAge,@SPass,@SScore,@SAdd,@SPhone)";
            try
            {
                command.Parameters.AddWithValue("@SName", pQuestion.Name);
                command.Parameters.AddWithValue("@SAge", pQuestion.Age);
                command.Parameters.AddWithValue("@SPass", pQuestion.Password);
                command.Parameters.AddWithValue("@SScore", pQuestion.Score);
                command.Parameters.AddWithValue("@SAdd", pQuestion.Add);
                command.Parameters.AddWithValue("@SPhone", pQuestion.Phone);
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

        public Candidate UpdateCandidte(Candidate pCandidate)
        {
            Candidate oCandidate = null;
            string sql = @" 
                            UPDATE [dbo].[Student]
                               SET 
                                  [SName] = @QDesc
                                  ,[SAge] = @Q01
                                  ,[SPass] = @Q02
                                  ,[SScore] = @Q03
                                  ,[SAdd] = @Q04 
                                  ,[SPhone] = @QA                                 
                             WHERE [SId] = @QId  ";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                command.Parameters.AddWithValue("@QId", pCandidate.Id);
                command.Parameters.AddWithValue("@QDesc", pCandidate.Name);
                command.Parameters.AddWithValue("@Q01", pCandidate.Age);
                command.Parameters.AddWithValue("@Q02", pCandidate.Password);
                command.Parameters.AddWithValue("@Q03", pCandidate.Score);
                command.Parameters.AddWithValue("@Q04", pCandidate.Add);
                command.Parameters.AddWithValue("@QA", pCandidate.Phone);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
                if (rows > 0)
                    oCandidate = GetCandidateById(pCandidate.Id);

                return oCandidate;
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

