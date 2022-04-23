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
    public class BLLQuestions : IBLLQuestions
    {
        public bool DeleteQuestion(string pId)
        {
            IDALQuestions _IDALQuestions = new DALQuestions();
            return _IDALQuestions.DeleteQuestion(pId);
        }

        public List<Question> GetAllQuestions()
        {
            IDALQuestions _IDALQuestions = new DALQuestions();
            return _IDALQuestions.GetAllQuestion();
        }

        public Question SaveQuestion(Question pCuestions)
        {
            IDALQuestions _IDALQuestion = new DALQuestions();
            Question oElectronico = null;
            if (_IDALQuestion.GetQuestionById(pCuestions.Id) == null)
                oElectronico = _IDALQuestion.SaveQuestion(pCuestions);
            else
                oElectronico = _IDALQuestion.UpdateQuestion(pCuestions);

            return oElectronico;
        }
    }
}
