using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    /*P: год написания пьесы 
     * Qp = Q · (Т-Р+1), где Т - текущий год*/
    class Play : Perfomace 
    {
        public Play(string name, int n1, int n2, int P) : base(name,n1,n2)
        {
            this.P = P;
        }
        public int P { get; set; }
        private int T = Convert.ToInt32(DateTime.Now.Year);
        public override double countQ()
        {
            return base.countQ() * (T - P + 1.0);
        }

        public override string toString()
        {
            return "Класс: < "+ this +" > \nНазвание: " + name + "\nЗрителей в начале: " + n1 + "\nЗрителей в конце: " + n2 + 
                "\nГод написания пьесы:" + P + "\nQ = " + countQ();
        }

    }
}
