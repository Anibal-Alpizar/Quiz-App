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
    public class Question
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public string CorrectQuestion { get; set; }
        public int CorrectResponse { get; set; }

    }
}
