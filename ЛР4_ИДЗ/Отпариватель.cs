using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Отпариватель : Утюг
    {
        protected float waterVolume;
        public Отпариватель(string pName, int pPrice, bool pWaterCompartment, float pMaxPower,  float pWaterVolume) : base(pName, pPrice, pWaterCompartment, pMaxPower)
        {
            waterVolume=pWaterVolume;
        }

        override public string GetInfo()
        {
            return $"Название: {name}, Потребление энергии = {maxPower}, Объем бака с водой: {waterVolume}";
        }
    }
}
