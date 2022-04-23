using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.Util
{
    class CustomException : Exception
    {
        public CustomException()
        {

        }
        public CustomException(string pParametro)
            : base(pParametro)
        {

        }
    }
}
