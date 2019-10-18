using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Наследование;

namespace Контейнеры
{
    class ProductException : ArgumentException
    {
        public int Value { get; }
        public ProductException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
}
