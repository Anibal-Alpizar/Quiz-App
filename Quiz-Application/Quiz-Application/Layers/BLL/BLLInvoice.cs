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
    public class BLLInvoice : IBLLInvoice
    {
        public Invoice SaveInvoice(Invoice pInvoce)
        {
            IDALInvoice _IDALInvoice = new DALInvoice();
            Invoice oInvoice = null;       
                oInvoice = _IDALInvoice.SaveInvoice(pInvoce);
            return oInvoice;
        }
    }
}
