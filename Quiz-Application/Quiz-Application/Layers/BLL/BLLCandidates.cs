using Quiz_Application.Interfaces;
using Quiz_Application.Layers.DAL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Util;
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
    public class BLLCandidates : IBLLCandidates
    {
        public bool DeleteCandidate(string pId)
        {
            IDALCandidates _IDALCandidate = new DALCandidates();
            return _IDALCandidate.DeleteElectronico(pId);
        }

        public List<Candidate> GetAllCandidates()
        {
            IDALCandidates _IDALCandidate = new DALCandidates();
            return _IDALCandidate.GetAllElectronico();
        }

        public Candidate Login(string pLogin, string pPassword)
        {
            IDALCandidates _DALUsuario = new DALCandidates();
            // Encriptar el password
            // string crytpPasswd = Cryptography.EncrypthAES(pPassword);

            return _DALUsuario.Login(pLogin, pPassword);
        }

        public Candidate SaveCandidate(Candidate pCandidate)
        {
            IDALCandidates _IDALCandidate = new DALCandidates();
            Candidate oCandidate = null;
            if (_IDALCandidate.GetCandidateById(pCandidate.Id) == null)
                oCandidate = _IDALCandidate.SaveCandidate(pCandidate);
            else
                oCandidate = _IDALCandidate.UpdateCandidte(pCandidate);

            return oCandidate;
        }
    }
}
