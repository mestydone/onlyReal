﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramTree;

namespace SimpleLang.Visitors
{
    class PlusZero : ChangeVisitor
    {
        public override void VisitBinOpNode(BinOpNode binop)
        {
            if (binop.Left is IntNumNode && (binop.Left as IntNumNode).Num == 0 &&
            binop.Op == '+')
            {
                binop.Right.Visit(this); 
                ReplaceExpr(binop, binop.Right); 
            }
            else 
            {
                base.VisitBinOpNode(binop); 
            }
        }
    }
}