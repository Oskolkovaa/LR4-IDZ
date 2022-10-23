using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Пылесос : БытТехника
    {
        protected int weight;
        protected string type;
        public Пылесос(string pName, int pPrice, int pWeight, string pType) : base(pName, pPrice)
        {
            type=pType;
            weight=pWeight;
        }
        override public string GetInfo()
        {
            return $"Название: {name}, Вес = {weight}";
        }
    }
}
