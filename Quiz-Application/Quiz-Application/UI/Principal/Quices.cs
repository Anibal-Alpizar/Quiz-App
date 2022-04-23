using log4net;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.BLL;
using Quiz_Application.Layers.DAL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Properties;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/


namespace Quiz_Application.UI.Principal
{
    public partial class Quices : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        private List<Question> QuestionsList = new List<Question>();
        private int NoQuestion = -1;
        private int TotalScore = 0;
        private int TimeLimit = 50;    

        public Quices()
        {
            InitializeComponent();
        }
        private void ShowNextQuestion()
        {
            NoQuestion++;
            Question question = QuestionsList[NoQuestion];

            this.rtbPregunta.Text = question.Description;
            this.rtb1.Text = question.Question1;
            this.rtb2.Text = question.Question2;
            this.rtb3.Text = question.Question3;
            this.rtb4.Text = question.Question4;
            this.rdb3.Checked = true;
        }
        private void SaveScore()
        {
            DALCandidates _IBLLElectronico = new DALCandidates();

            try
            {
                Candidate oElectronico = new Candidate();
                oElectronico.Score = this.TotalScore;
                oElectronico = _IBLLElectronico.SaveScore(oElectronico);
                MessageBox.Show("Candidate added with satisfaction.");
            }

            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadQuestions()
        {
            

            /*
             Para facilitar la hora todas son la 1
             Cambiar luego
            */


            BLLQuiz oBllQuiz = new BLLQuiz();
            this.dvgQuestionONLYADMIN.DataSource = oBllQuiz.GetAllQuices();
            Question q1 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[0].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[0].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[0].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[0].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[0].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[0].Cells[5].Value.ToString(),
                CorrectResponse = 1 
            };
            Question q2 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[1].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[1].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[1].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[1].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[1].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[1].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q3 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[2].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[2].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[2].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[2].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[2].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[2].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q4 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[3].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[3].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[3].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[3].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[3].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[3].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q5 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[4].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[4].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[4].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[4].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[4].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[4].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q6 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[5].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[5].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[5].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[5].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[5].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[5].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q7 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[6].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[6].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[6].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[6].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[6].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[6].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q8 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[7].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[7].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[7].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[7].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[7].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[7].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q9 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[8].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[8].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[8].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[8].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[8].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[8].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };
            Question q10 = new Question()
            {
                Id = dvgQuestionONLYADMIN.Rows[9].Cells[0].Value.ToString(),
                Description = dvgQuestionONLYADMIN.Rows[9].Cells[1].Value.ToString(),
                Question1 = dvgQuestionONLYADMIN.Rows[9].Cells[2].Value.ToString(),
                Question2 = dvgQuestionONLYADMIN.Rows[9].Cells[3].Value.ToString(),
                Question3 = dvgQuestionONLYADMIN.Rows[9].Cells[4].Value.ToString(),
                Question4 = dvgQuestionONLYADMIN.Rows[9].Cells[5].Value.ToString(),
                CorrectResponse = 1
            };

            QuestionsList.Add(q1);
            QuestionsList.Add(q2);
            QuestionsList.Add(q3);
            QuestionsList.Add(q4);
            QuestionsList.Add(q5);
            QuestionsList.Add(q6);
            QuestionsList.Add(q7);
            QuestionsList.Add(q8);
            QuestionsList.Add(q9);
            QuestionsList.Add(q10);

        }
        private void Score()
        {
            Question question = QuestionsList[NoQuestion];

            if (rdb1.Checked && question.CorrectResponse == 1)//1
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//2
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//3
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//4
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//5
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//6
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//7
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//8
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//9
                TotalScore++;

            if (rdb1.Checked && question.CorrectResponse == 1)//10
                TotalScore++;

        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            int value = int.Parse(this.lblTiempoTranscurrido.Text);

            if (value >= TimeLimit)
            {
                tmr.Stop();
                btnSiguiente.Enabled = false;
                MessageBox.Show($"La prueba a terminado del total de {QuestionsList.Count} preguntas!");
                return;
            }
            value++;
            this.lblTiempoTranscurrido.Text = value.ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Score();

            if (NoQuestion == QuestionsList.Count - 1)
            {
                if (TotalScore >= 80)
                {
                    tmr.Stop();
                    btnSiguiente.Enabled = false;
                    MessageBox.Show($"Felicidades lo lograste. Tu calificacion fue un: {this.TotalScore}");


                    IBLLResults _IBLLElectronico = new BLLResults();

                    try
                    {
                        Result oResult = new Result();
                        oResult.Cantidate = Settings.Default.Login;
                        oResult.Score = this.TotalScore;
                        oResult = _IBLLElectronico.SaveResult(oResult);
                        MessageBox.Show("Score saved");

                        Pay pay = new Pay();
                        pay.Visible = true; 
                        this.Hide();

                    }

                    catch (Exception er)
                    {
                        StringBuilder msg = new StringBuilder();
                        msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                        _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                        MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (TotalScore < 80)
                {
                    tmr.Stop();
                    btnSiguiente.Enabled = false;
                    MessageBox.Show($"Lamentablemente no lo lograste.Tu calificacion fue un: {this.TotalScore}");

                    IBLLResults _IBLLElectronico = new BLLResults();

                    try
                    {
                        Result oResult = new Result();
                        oResult.Cantidate = Settings.Default.Login;
                        oResult.Score = this.TotalScore;
                        oResult = _IBLLElectronico.SaveResult(oResult);
                        MessageBox.Show("Score saved.");

                    }
                    catch (Exception er)
                    {
                        StringBuilder msg = new StringBuilder();
                        msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                        _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                        MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ShowNextQuestion();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.rtbPregunta.Visible = true;
            this.rtb1.Visible = true;
            this.rtb2.Visible = true;
            this.rtb3.Visible = true;
            this.rtb4.Visible = true;
            this.rdb1.Visible = true;
            this.rdb2.Visible = true;
            this.rdb3.Visible = true;
            this.rdb4.Visible = true;
            this.btnSiguiente.Visible = true;
            this.lblTiempoTranscurrido.Visible = true;
            this.btnStart.Visible = false;
            this.lblTiempoTranscurrido.Visible = true;
            this.btnSiguiente.Visible = true;

            tmr.Start();
            LoadQuestions();
            ShowNextQuestion();

        }
    }
}
