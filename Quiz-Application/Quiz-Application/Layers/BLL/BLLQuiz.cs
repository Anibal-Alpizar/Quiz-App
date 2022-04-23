using Quiz_Application.Interfaces;
using Quiz_Application.Layers.DAL;
using Quiz_Application.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.Layers.BLL
{
    public class BLLQuiz : IBLLQuiz
    {
        public List<Quiz> GetAllQuices()
        {
            DALQuiz _IDALQuestions = new DALQuiz();
            return _IDALQuestions.FillQuiz();
        }
    }
}
