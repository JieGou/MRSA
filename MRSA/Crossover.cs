using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MRSA
{
    public class Crossover
    {
        static Random rand = new Random();

        /// <summary>
        /// Extracts a chromosome segment for crossover
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        public static string Cross(string s1)
        {
            int x = rand.Next(1, (s1.Length + 1) / 2 - 1), plus = 0;
            int i;
            for (i = 0; i < s1.Length; i++)
            {
                if (s1[i] == '+')
                    x--;
                if (x == 0)
                {
                    plus = i;
                    x--;
                }
            }

            int cp = 2;
            string sm = s1[plus].ToString();
            plus--;
            while (cp != 0)
            {
                if (s1[plus] == '+') cp += 2;
                if (s1[plus - 1] == '+') cp += 2;
                cp -= 2;
                sm = s1[plus - 1].ToString() + s1[plus].ToString() + sm;
                plus -= 2;
            }
            return sm;
        }

        /// <summary>
        /// Performs crossover
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="news1"></param>
        /// <param name="news2"></param>
        public static void Crossovering(string s1, string s2, ref string news1, ref string news2)
        {
            string c1 = Cross(s1);
            string c2 = Cross(s2);
            news1 = Zam(c1, c2, s1);
            news2 = Zam(c2, c1, s2);
        }

        /// <summary>
        /// Performs gene exchange
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="s1"></param>
        /// <returns></returns>
        public static string Zam(string c1, string c2, string s1)
        {
            List<string> Need = new List<string>();
            List<string> Del = new List<string>();
            int i, j;
            int st = 0;
            for (i = 0; i < s1.Length; i++)
                if (c1[0] == s1[i])
                    st = i;
            string strzam = "";

            for (i = 0; i < c1.Length; i++)
                if (c1[i] != '+')
                    Need.Add(c1[i].ToString());

            for (i = 0; i < c2.Length; i++)
                Need.Remove(c2[i].ToString());

            for (i = 0; i < c2.Length; i++)
                if (c2[i] != '+')
                    Del.Add(c2[i].ToString());

            for (i = 0; i < c1.Length; i++)
                Del.Remove(c1[i].ToString());

            string k1 = "";
            string k2 = "";
            for (i = 0; i < Del.Count; i++)
                k2 += Del[i];
            for (i = 0; i < Need.Count; i++)
                k1 += Need[i];
            for (i = 0; i < st; i++)
                strzam += s1[i];
            for (i = st + c1.Length; i < s1.Length; i++)
                strzam += s1[i];
            c1 = strzam;
            strzam = "";
            for (i = 0; i < c1.Length; i++)
            {
                int zamFrom = Del.IndexOf(c1[i].ToString());
                int zamTo = rand.Next(Need.Count);
                if (zamFrom > -1 && Need.Count > 0)
                {
                    strzam += Need[zamTo];
                    Del.Remove(Del[zamFrom].ToString());
                    Need.Remove(Need[zamTo].ToString());
                }
                else
                {
                    strzam += c1[i];
                }
            }
            if (strzam != "") c1 = strzam;
            
            while (Del.Count > 0)
            {
                strzam = "";
                int zam = 0;
                int delplus = 0;
                for (i = 0; i < c1.Length; i++)
                {
                    if (Del.IndexOf(c1[i].ToString()) > -1)
                    {
                        zam = i;
                        delplus = Del.IndexOf(c1[i].ToString());
                    }
                }
                int jump = 0;
                int z = 0;
                Del.Remove(Del[delplus].ToString());
                for (i = 0; i < c1.Length; i++)
                {
                    if (i > zam && c1[i] != '+')
                        jump++;
                    if (i > zam && c1[i] == '+' && jump < 2)
                    {
                        delplus = i;
                        z = zam;
                        zam = c1.Length + 1;
                    }
                    if (i > zam && c1[i] == '+' && jump > 1)
                        jump--;
                }
                for (i = 0; i < c1.Length; i++)
                {
                    if (i != z && i != delplus)
                    {
                        strzam += c1[i];
                    }
                }
                if (strzam != "") c1 = strzam;
            }

                while (Need.Count > 0)
                {
                    strzam = "";
                    int zam = rand.Next(Need.Count);

                    int x = rand.Next(1, c1.Length);
                for (i = 0; i < c1.Length; i++)
                    if (x == i)
                    {
                        strzam += c1[i];
                        strzam += (Need[zam].ToString() + "+");
                    }
                    else
                        strzam += c1[i];
                    Need.Remove(Need[zam]);
                    if (strzam != "") c1 = strzam;
                }
            strzam = c2;
            for (i = 0; i < c1.Length; i++)
                strzam += c1[i];

            return strzam;
        }
    }
}
