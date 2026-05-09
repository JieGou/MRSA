using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MRSA
{
    public class Generation
    {
        public static Random rand = new Random();

        /// <summary>
        /// Information about the distance between points
        /// </summary>
        public class Distant
        {
            public Point a;
            public Point b;
            public int i1, i2;
            public double len;
            public Distant(Point A, Point B, int i, int j)
            {
                a = A;
                b = B;
                len = Tree.dist(a, b);
                i1 = i;
                i2 = j;
            }
        }

        /// <summary>
        /// Generates points
        /// </summary>
        /// <param name="P"></param>
        public static void GeneratePoints(ref Point[] P)
        {
            int i;
            if (P != null)
            {
                P[0].X = 10;
                P[0].Y = 560;
                for (i = 1; i < P.Length; i++)
                {
                    P[i].X = rand.Next(10, 590) * 1;
                    P[i].Y = rand.Next(10, 560) * 1;
                }
                Array.Sort(P, (Point a, Point b) =>
                            {
                                if (a.X > b.X) return 1;
                                if (a.X == b.X) return 0;
                                return -1;
                            });
            }
        }

        /// <summary>
        /// Generates chromosomes
        /// </summary>
        /// <param name="Chr"></param>
        /// <param name="k"></param>
        public static void GenerateChromosome(ref string[] Chr, int k)
        {
            int i, j, r1, r2;
            string s1, s2;
            List<string> L = new List<string>();
            for (i = 0; i < Chr.Length; i ++)
            {
                char imp = 'a';
                Chr[i] = "";
                L.Clear();
                for (j = 0; j < k; j++)
                {
                    L.Add(imp.ToString());
                    imp++;
                }
                while (L.Count != 1)
                {
                    r1 = rand.Next(0, L.Count);
                    s1 = L[r1];
                    L.RemoveAt(r1);
                    r2 = rand.Next(0, L.Count);
                    s2 = L[r2];
                    L.RemoveAt(r2);
                    L.Add(s1 + s2 + "+");
                }
                Chr[i] = L[0];
            }
        }

        /// <summary>
        /// Gets the size of the minimum spanning tree
        /// </summary>
        /// <param name="P"></param>
        /// <returns></returns>
        public static double GenetateKrusckal(Point[] P)
        {
            int i, j;
            List<Distant> Mas = new List<Distant>();
            double cost = 0;
            for (i = 0; i < P.Length; i++)
                for (j = 0; j < P.Length; j++)
                    Mas.Add(new Distant(P[i], P[j], i, j));
            Distant[] Dl = Mas.ToArray();
            int[] T = new int[P.Length];
            Array.Sort(Dl, (Distant D1, Distant D2) => { if (D1.len > D2.len) return 1; if (D1.len == D2.len) return 0; return -1; });
            for (i = 0; i < P.Length; i++)
                T[i] = i;
            for (i = 0; i < Dl.Length; i++)
            {
                int i1 = Dl[i].i1;
                int i2 = Dl[i].i2;
                double l = Dl[i].len;
                if (T[i1] != T[i2])
                {
                    cost += l;
                    int old = T[i2];
                    int yan = T[i1];
                    for (j = 0; j < P.Length; j++)
                        if (T[j] == old)
                            T[j] = yan;
                }
            }
            return cost / 10.0;
        }
    }
}
