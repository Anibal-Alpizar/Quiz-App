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
    public class BLLResults : IBLLResults
    {
        public Result SaveResult(Result pResult)
        {
            IDALResults _IDALElectronico = new DALResultds();
            Result oElectronico = null;
            if (_IDALElectronico.GetQuestionById(pResult.Cantidate) == null)
                oElectronico = _IDALElectronico.SaveQuestion(pResult);
            return oElectronico;
        }
    }
}
