using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.Layers.Entities
{
    public class Candidate
    {
        public string Id { get; set; }
        public int IdRol { set; get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
        public string Add { get; set; }
        public string Phone { get; set; }
    }
}
