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
    public class Quiz
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Q01 { get; set; }
        public string Q02 { get; set; }
        public string Q03 { get; set; }
        public string Q04 { get; set; }
        public string CorrectResponse { get; set; }
    }
}
