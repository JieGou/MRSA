using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MRSA
{
    public class Draw
    {
        public const int r = 2;

        /// <summary>
        /// Draws points
        /// </summary>
        /// <param name="P"></param>
        public static void DrawPoint(Point[] P)
        {
            int i;
            Form1.k.Clear(Color.White);
            Pen pen = new Pen(Color.Green, 2);
            for (i = 0; i < P.Length; i++)
                Form1.k.DrawEllipse(pen, P[i].X, P[i].Y, r * 2, r * 2);
        }

        /// <summary>
        /// Connects two points
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void DrawPoint(Point A, Point B)
        {
            Pen pen = new Pen(Color.Red, 2);
            Form1.k.DrawLine(pen, A.X + r, A.Y + r, A.X + r, B.Y + r);
            Form1.k.DrawLine(pen, A.X + r, B.Y + r, B.X + r, B.Y + r);
        }

        /// <summary>
        /// Draws a tree by points
        /// </summary>
        /// <param name="T"></param>
        /// <param name="P"></param>
        public static void DrawTree(Tree T, Point[] P)
        {
            DrawPoint(P);
            int i;
            for (i = 0; i < T.Nodes.Count; i ++)
            {
                DrawPoint(T.Nodes[i].A, T.Nodes[i].B);
            }
        }

        /// <summary>
        /// Draws a tree from a chromosome
        /// </summary>
        /// <param name="s"></param>
        /// <param name="P"></param>
        public static void ReadChr(string s, Point[] P)
        {
            char nom = (char)(400);
            List<Tree> T = new List<Tree>();
            int i;
            while (s.Length != 1)
            {
                string sn;
                sn = "";
                i = -1;
                while (++i < s.Length - 2)
                {
                    if (s[i] != '+' && s[i + 1] != '+' && s[i + 2] == '+')
                    {
                        if (s[i + 1] < (char)(400) && s[i] < (char)(400))
                        {
                            T.Add(new Tree(P[int.Parse((s[i + 1] - 97).ToString())], P[int.Parse((s[i] - 97).ToString())]));
                            sn += nom.ToString();
                            nom = (char)(nom + 1);
                            i += 2;
                        }
                        else
                        {
                            if (s[i + 1] >= (char)(400) && s[i] >= (char)(400))
                            {
                                T.Add(new Tree(T[s[i + 1] - 400], T[s[i] - 400]));
                                sn += nom.ToString();
                                nom = (char)(nom + 1);
                                i += 2;
                            }
                            else
                            {
                                if (s[i + 1] >= (char)(400))
                                {
                                    T.Add(new Tree(P[int.Parse((s[i] - 97).ToString())], T[s[i + 1] - 400]));
                                    sn += nom.ToString();
                                    nom = (char)(nom + 1);
                                    i += 2;
                                }
                                else
                                {
                                    T.Add(new Tree(P[int.Parse((s[i + 1] - 97).ToString())], T[s[i] - 400]));
                                    sn += nom.ToString();
                                    nom = (char)(nom + 1);
                                    i += 2;
                                }
                            }

                        }
                    }
                    else
                    {
                        sn += s[i];
                    }
                }

                if (i == s.Length - 2)
                {
                    sn += s[s.Length - 2];
                    sn += s[s.Length - 1];
                }
                if (i == s.Length - 1)
                    sn += s[s.Length - 1];
                s = sn;
            };
            DrawTree(T[T.Count - 1], P);
        }
    }
}
