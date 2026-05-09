using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MRSA
{
    public class Mutate
    {
        static Random rand = new Random();

        /// <summary>
        /// Performs chromosome mutation
        /// </summary>
        /// <param name="m"></param>
        public static void MutateChr(ref string m)
        {
            bool prov;
            int i;
            string d1;
            string d2;
            string newm = "";
            int kol = 0;
            do
            {
                prov = true;
                d1 = Mut(m);
                d2 = Mut(m);
                if (d1.Length > d2.Length)
                {
                    for (i = 0; i < d1.Length; i++)
                        if (d1[i] == d2[0])
                            prov = false;
                }
                else
                {
                    for (i = 0; i < d2.Length; i++)
                        if (d2[i] == d1[0])
                            prov = false;
                }
                kol++;
                if (kol > 20)
                    prov = true;
            }
            while (!prov);
            if (!(kol > 20))
            {
                int id1 = 0;
                int id2 = 0;
                for (i = 0; i < m.Length; i++)
                {
                    if (m[i] == d1[0]) id1 = i;
                    if (m[i] == d2[0]) id2 = i;
                }
                if (id1 < id2)
                {
                    for (i = 0; i < id1; i++)
                        newm += m[i];
                    newm += d2;
                    for (i = id1 + d1.Length; i < id2; i++)
                        newm += m[i];
                    newm += d1;
                    for (i = id2 + d2.Length; i < m.Length; i++)
                        newm += m[i];
                }
                else
                {
                    for (i = 0; i < id2; i++)
                        newm += m[i];
                    newm += d1;
                    for (i = id2 + d2.Length; i < id1; i++)
                        newm += m[i];
                    newm += d2;
                    for (i = id1 + d1.Length; i < m.Length; i++)
                        newm += m[i];
                }
                m = newm;
            }
        }

        /// <summary>
        /// Extracts a substring for chromosome mutation
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static string Mut(string m)
        {
            int k = 0;
            int i;
            int x = rand.Next(1, ((m.Length + 1) / 2) - 1);
            for (i = 0; i < m.Length; i++)
            {
                if (m[i] == '+')
                    x--;
                if (x == 0)
                {
                    k = i;
                    x--;
                }
            }
            int kp = 2;
            string sm = m[k].ToString();
            k--;
            while (kp != 0)
            {
                if (m[k] == '+') kp += 2;
                if (m[k - 1] == '+') kp += 2;
                kp -= 2;
                sm = m[k - 1].ToString() + m[k].ToString() + sm;
                k -= 2;
            }
            return sm;            
        }
    }
}
