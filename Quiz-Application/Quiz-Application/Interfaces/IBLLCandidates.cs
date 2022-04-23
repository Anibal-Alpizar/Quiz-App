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
    public interface IBLLCandidates
    {
        Candidate SaveCandidate(Candidate pCandidate);
        Candidate Login(string pLogin, string pPassword);
        List<Candidate> GetAllCandidates();
        bool DeleteCandidate(string pId);

    }
}
