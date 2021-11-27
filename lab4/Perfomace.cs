using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    /*Спектакль: - название; 
     * n1 – число зрителей в начале; 
     * n2 – число зрителей в конце. 
     * Q = (n2 – n1)/ n1 */
    class Perfomace
    {
        public Perfomace(string name, int n1, int n2)
        {
            this.name = name;
            this.n1 = n1;
            this.n2 = n2;
        }
        public string name { get; set; }
        public int n1 { get; set; }
        public int n2 { get; set; }

        public virtual double countQ()
        {
            return ((double)n1 - (double)n2) / (double)n1;
        }

        public virtual string toString()
        {
            double q = countQ();
            return "Класс: < " + this+ " >\nНазвание: " + name + "\nЗрителей в начале: " + n1 + "\nЗрителей в конце: " + n2 +"\nQ = " + q; 
        }

    }
}
