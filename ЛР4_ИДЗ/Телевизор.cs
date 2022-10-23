using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Телевизор : БытТехника
    {
        protected int hercz;
        protected bool DDD;
        public Телевизор(string pName, int pPrice, bool pDDD, int pHercz) : base(pName, pPrice)
        {
            hercz = pHercz;
            DDD = pDDD;
        }
        override public string GetInfo()
        {
            return $"Название: {name}, Кол-во герц = {hercz}";
        }
    }
}
