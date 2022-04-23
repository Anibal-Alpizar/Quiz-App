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

namespace Quiz_Application.Interfaces
{
    public interface IBLLQuestions
    {
        Question SaveQuestion(Question pElectronico);
        List<Question> GetAllQuestions();
        bool DeleteQuestion(string pId);
    }
}
