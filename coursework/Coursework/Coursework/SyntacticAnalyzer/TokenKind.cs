using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.SyntacticAnalyzer
{
    /// <summary>
    /// Types of token in the source language
    /// </summary>
    public enum TokenKind
    {
        // non-terminals
        Identifier, IntLiteral, Operator, CharLiteral,

        // reserved words - terminals
        Begin, Const, Do, Else, End, If, In, Let, Then, Var, While, Skip,

        // punctuation - terminals (Becomes is for assignment (:=) , Is is for constants (~))
        Colon, Semicolon, Becomes, Is, LeftBracket, RightBracket,

        // special tokens
        EndOfText, Error

    }
}
