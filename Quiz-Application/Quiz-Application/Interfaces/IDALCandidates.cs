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
    public interface IDALCandidates
    {
        Candidate GetCandidateById(string pId);
        Candidate SaveCandidate(Candidate pQuestion);
        Candidate UpdateCandidte(Candidate pElectronico);
        Candidate Login(string pLogin, string pPassword);
        List<Candidate> GetAllElectronico();
        bool DeleteElectronico(string pId);

    }
}
