using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro.Exceptions
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
