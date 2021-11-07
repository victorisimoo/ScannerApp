using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserApp.TokenConstruction {
    public enum TokenType
    {
        apostrofe = '\'',
        puntoycoma = ';',
        or = '|',
        Igual = "=>",
        EOF = (char)0,
        Empty = (char)1,
        Null = (char)2,
        Letras = (char)3

    }
}
