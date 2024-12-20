﻿using LoansLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansLib.BL.Interfaces
{
    public interface ILoanStrategy
    {
        CalcLoanResponse CalcLoan(CalcLoanRequest calcLoanRequest);
    }
}