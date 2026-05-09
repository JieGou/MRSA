using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MRSA
{
    /// <summary>
    /// Tree
    /// </summary>
    public class Tree
    {
        static public Random rand = new Random();
        public List<Node> Nodes = new List<Node>();
        static public string Name = "";
        static public string Com1 = "";
        static public string Com2 = "";
        static public string Com3 = "";

        /// <summary>
        /// Edge
        /// </summary>
        public class Node
        {
            public string Style;
            public double len = 0;
            public Point A;
            public Point B;
            //A - Best, B - Worst
            public Node() { }
            public Node(Point A, Point B, string Style)
            {
                this.A = A;
                this.B = B;
                if (Style == "H")
                {
                    if (A.X < B.X)
                    {
                        this.A = B;
                        this.B = A;
                    }
                }
                else
                {
                    if (A.Y > B.Y)
                    {
                        this.A = B;
                        this.B = A;
                    }
                }
                this.Style = Style;
                len = dist(A, B) / 10.0;
            }
        }
        Point BestP;
        Point WorstP;

        /// <summary>
        /// Constructor for creating a tree from two points
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public Tree(Point A, Point B)
        {
            BestP = B;
            WorstP = A;
            if (A.Y < B.Y || (A.Y == B.Y && A.X > B.X))
            {
                BestP = A;
                WorstP = B;
            }
            Nodes.Add(new Node(new Point(WorstP.X, WorstP.Y), new Point(BestP.X, WorstP.Y), "H"));
            Nodes.Add(new Node(new Point(BestP.X, WorstP.Y), new Point(BestP.X, BestP.Y), "V"));
        }

        /// <summary>
        /// Constructor for creating a tree from a tree and a point
        /// </summary>
        /// <param name="A"></param>
        /// <param name="T"></param>
        public Tree(Point A, Tree T)
        {
            int i;
            double MinNode = 10000000;
            int NumNode = 0;
            Node ProbaNode, DopProbaNode;
            for (i = 0; i < T.Nodes.Count; i++)
            {
                if (T.Nodes[i].Style == "H")
                {
                    if (A.Y == T.Nodes[i].A.Y)
                    {
                        if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                        {
                            ProbaNode = (new Node(A, T.Nodes[i].A, "H"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                        else
                        {
                            ProbaNode = (new Node(A, T.Nodes[i].B, "H"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                    }
                    else
                    {
                        if (A.X >= T.Nodes[i].B.X && A.X <= T.Nodes[i].A.X)
                        {
                            ProbaNode = (new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                        else
                        {
                            if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                            {
                                ProbaNode = (new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                                DopProbaNode = (new Node(new Point(A.X, T.Nodes[i].A.Y), T.Nodes[i].A, "H"));
                                if (MinNode > ProbaNode.len + DopProbaNode.len)
                                {
                                    MinNode = ProbaNode.len + DopProbaNode.len;
                                    NumNode = i;
                                }
                            }
                            else
                            {
                                ProbaNode = (new Node(A, new Point(A.X, T.Nodes[i].B.Y), "V"));
                                DopProbaNode = (new Node(new Point(A.X, T.Nodes[i].B.Y), T.Nodes[i].B, "H"));
                                if (MinNode > ProbaNode.len + DopProbaNode.len)
                                {
                                    MinNode = ProbaNode.len + DopProbaNode.len;
                                    NumNode = i;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (A.X == T.Nodes[i].A.X)
                    {
                        if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                        {
                            ProbaNode = (new Node(A, T.Nodes[i].A, "V"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                        else
                        {
                            ProbaNode = (new Node(A, T.Nodes[i].B, "V"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                    }
                    else
                    {
                        if (A.Y <= T.Nodes[i].B.Y && A.Y >= T.Nodes[i].A.Y)
                        {
                            ProbaNode = (new Node(A, new Point(T.Nodes[i].A.X, A.Y), "H"));
                            if (MinNode > ProbaNode.len)
                            {
                                MinNode = ProbaNode.len;
                                NumNode = i;
                            }
                        }
                        else
                        {
                            if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                            {
                                ProbaNode = (new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                                DopProbaNode = (new Node(new Point(A.X, T.Nodes[i].A.Y), T.Nodes[i].A, "H"));
                                if (MinNode > ProbaNode.len + DopProbaNode.len)
                                {
                                    MinNode = ProbaNode.len + DopProbaNode.len;
                                    NumNode = i;
                                }
                            }
                            else
                            {
                                ProbaNode = (new Node(A, new Point(A.X, T.Nodes[i].B.Y), "V"));
                                DopProbaNode = (new Node(new Point(A.X, T.Nodes[i].B.Y), T.Nodes[i].B, "H"));
                                if (MinNode > ProbaNode.len + DopProbaNode.len)
                                {
                                    MinNode = ProbaNode.len + DopProbaNode.len;
                                    NumNode = i;
                                }
                            }
                        }
                    }
                }
            }
                i = NumNode;
                if (T.Nodes[i].Style == "H")
                {
                    if (A.Y == T.Nodes[i].A.Y)
                    {
                        if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                        {
                            T.Nodes.Add(new Node(A, T.Nodes[i].A, "H"));
                        }
                        else
                        {
                            T.Nodes.Add(new Node(A, T.Nodes[i].B, "H"));
                        }
                    }
                    else
                    {
                        if (A.X >= T.Nodes[i].B.X && A.X <= T.Nodes[i].A.X)
                        {
                            T.Nodes.Add(new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                        }
                        else
                        {
                            if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                            {
                                T.Nodes.Add(new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                                T.Nodes.Add(new Node(new Point(A.X, T.Nodes[i].A.Y), T.Nodes[i].A, "H"));
                            }
                            else
                            {
                                T.Nodes.Add(new Node(A, new Point(A.X, T.Nodes[i].B.Y), "V"));
                                T.Nodes.Add(new Node(new Point(A.X, T.Nodes[i].B.Y), T.Nodes[i].B, "H"));
                            }
                        }
                    }
                }
                else
                {
                    if (A.X == T.Nodes[i].A.X)
                    {
                        if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                        {
                            T.Nodes.Add(new Node(A, T.Nodes[i].A, "V"));
                        }
                        else
                        {
                            T.Nodes.Add(new Node(A, T.Nodes[i].B, "V"));
                        }
                    }
                    else
                    {
                        if (A.Y <= T.Nodes[i].B.Y && A.Y >= T.Nodes[i].A.Y)
                        {
                            T.Nodes.Add(new Node(A, new Point(T.Nodes[i].A.X, A.Y), "H"));
                        }
                        else
                        {
                            if (dist(A, T.Nodes[i].A) < dist(A, T.Nodes[i].B))
                            {
                                T.Nodes.Add(new Node(A, new Point(A.X, T.Nodes[i].A.Y), "V"));
                                T.Nodes.Add(new Node(new Point(A.X, T.Nodes[i].A.Y), T.Nodes[i].A, "H"));
                            }
                            else
                            {
                                T.Nodes.Add(new Node(A, new Point(A.X, T.Nodes[i].B.Y), "V"));
                                T.Nodes.Add(new Node(new Point(A.X, T.Nodes[i].B.Y), T.Nodes[i].B, "H"));
                            }
                        }
                    }
            }
            Nodes = T.Nodes;
        }

        /// <summary>
        /// Constructor for creating a tree from two subtrees
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public Tree(Tree A, Tree B)
        {
            Node MinNode1 = new Node();
            Node MinNode2 = new Node();
            List<Node> MinNodes1 = new List<Node>();
            List<Node> MinNodes2 = new List<Node>();
            double MinR = 10000000;
            int i, j;
            for (i = 0; i < A.Nodes.Count; i++)
            {
                for (j = 0; j < B.Nodes.Count; j++)
                {
                    if (dist(A.Nodes[i].A, B.Nodes[j].A) < MinR || dist(A.Nodes[i].A, B.Nodes[j].B) < MinR || dist(A.Nodes[i].B, B.Nodes[j].A) < MinR || dist(A.Nodes[i].B, B.Nodes[j].B) < MinR)
                    {
                        MinNode1 = A.Nodes[i];
                        MinNode2 = B.Nodes[j];
                        MinR = Math.Min(Math.Min(Math.Min(dist(A.Nodes[i].A, B.Nodes[j].A), dist(A.Nodes[i].B, B.Nodes[j].B)), dist(A.Nodes[i].A, B.Nodes[j].B)), dist(A.Nodes[i].B, B.Nodes[j].A));
                    }
                }
            }
            for (i = 0; i < A.Nodes.Count; i++)
            {
                if (A.Nodes[i].A == MinNode1.A || A.Nodes[i].B == MinNode1.B || A.Nodes[i].A == MinNode1.B || A.Nodes[i].B == MinNode1.A)
                    MinNodes1.Add(A.Nodes[i]);
            }
            for (i = 0; i < B.Nodes.Count; i++)
            {
                if (B.Nodes[i].A == MinNode2.A || B.Nodes[i].B == MinNode2.B || B.Nodes[i].A == MinNode2.B || B.Nodes[i].B == MinNode2.A)
                    MinNodes2.Add(MinNode2);
            }
            Point P1 = MinNode1.A;
            Point P2 = MinNode2.A;
            for (i = 0; i < MinNodes1.Count; i++)
            {
                for (j = 0; j < MinNodes2.Count; j++)
                {
                    Help(MinNodes1[i], MinNodes2[j], MinR, ref P1, ref P2);
                }
            }
            
            Tree T = new Tree(P1, P2);
            Nodes = A.Nodes;
            for (i = 0; i < B.Nodes.Count; i++)
                Nodes.Add(B.Nodes[i]);
            for (i = 0; i < T.Nodes.Count; i++)
                Nodes.Add(T.Nodes[i]);
        }

        /// <summary>
        /// Finds the two points with minimum distance between them
        /// </summary>
        /// <param name="MinNode1"></param>
        /// <param name="MinNode2"></param>
        /// <param name="MinR"></param>
        /// <param name="P1"></param>
        /// <param name="P2"></param>
        public static void Help(Node MinNode1, Node MinNode2, double MinR, ref Point P1, ref Point P2)
        {
            int i, j;
            int sh = 10;
            if (MinNode1.Style == "H")
            {
                if (MinNode2.Style == "H")
                {
                    for (i = MinNode1.B.X; i <= MinNode1.A.X; i += sh)
                    {
                        for (j = MinNode2.B.X; j <= MinNode2.A.X; j += sh)
                        {
                            if (dist(new Point(i, MinNode1.A.Y), new Point(j, MinNode2.A.Y)) < MinR)
                            {
                                MinR = dist(new Point(i, MinNode1.A.Y), new Point(j, MinNode2.A.Y));
                                P1 = new Point(i, MinNode1.A.Y);
                                P2 = new Point(j, MinNode2.A.Y);
                            }
                        }
                    }
                }
                else
                {
                    for (i = MinNode1.B.X; i <= MinNode1.A.X; i += sh)
                    {
                        for (j = MinNode2.A.Y; j <= MinNode2.B.Y; j += sh)
                        {
                            if (dist(new Point(i, MinNode1.A.Y), new Point(MinNode2.A.X, j)) < MinR)
                            {
                                MinR = dist(new Point(i, MinNode1.A.Y), new Point(MinNode2.A.X, j));
                                P1 = new Point(i, MinNode1.A.Y);
                                P2 = new Point(MinNode2.A.X, j);
                            }
                        }
                    }
                }
            }
            else
            {
                if (MinNode2.Style == "H")
                {
                    for (i = MinNode1.A.Y; i <= MinNode1.B.Y; i += sh)
                    {
                        for (j = MinNode2.B.X; j <= MinNode2.A.X; j += sh)
                        {
                            if (dist(new Point(MinNode1.A.X, i), new Point(j, MinNode2.A.Y)) < MinR)
                            {
                                MinR = dist(new Point(MinNode1.A.X, i), new Point(j, MinNode2.A.Y));
                                P1 = new Point(MinNode1.A.X, i);
                                P2 = new Point(j, MinNode2.A.Y);
                            }
                        }
                    }
                }
                else
                {
                    for (i = MinNode1.A.Y; i <= MinNode1.B.Y; i += sh)
                    {
                        for (j = MinNode2.A.Y; j <= MinNode2.B.Y; j += sh)
                        {
                            if (dist(new Point(MinNode1.A.X, i), new Point(MinNode2.A.X, j)) < MinR)
                            {
                                MinR = dist(new Point(MinNode1.A.X, i), new Point(MinNode2.A.X, j));
                                P1 = new Point(MinNode1.A.X, i);
                                P2 = new Point(MinNode2.A.X, j);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static double dist(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }

        /// <summary>
        /// Performs selection
        /// </summary>
        /// <param name="Chrom"></param>
        /// <param name="Chr"></param>
        public static void Select(ref string[] Chrom, List<string> Chr)
        {
            int i, j;
            string tempstr;
            double tempd;
            int x = rand.Next(0, Chr.Count);
            Chrom[Chrom.Length - 1] = Chr[x];
            for (i = 0; i < Chrom.Length; i++)
                Chr.Add(Chrom[i]);
            double[] L = new double[Chr.Count];
            for (i = 0; i < L.Length; i++)
                L[i] = Len(Chr[i], Form1.P);
            for (i = 0; i < L.Length; i++)
            {
                for (j = 0; j < L.Length - 1; j ++)
                {
                    if (L[j] > L[j + 1])
                    {
                        tempd = L[j];
                        L[j] = L[j + 1];
                        L[j + 1] = tempd;
                        tempstr = Chr[j];
                        Chr[j] = Chr[j + 1];
                        Chr[j + 1] = tempstr;
                    }
                }
            }
            for (i = 0; i < Chrom.Length - 1; i++)
                Chrom[i] = Chr[i];
        }

        /// <summary>
        /// Gets the chromosome length
        /// </summary>
        /// <param name="s"></param>
        /// <param name="P"></param>
        /// <returns></returns>
        public static double Len(string s, Point[] P)
        {
            double dlina = 0;
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
            for (i = 0; i < T[T.Count - 1].Nodes.Count; i ++)
            {
                dlina += T[T.Count - 1].Nodes[i].len;
            }
            return dlina;
        }

        /// <summary>
        /// Provides information about a chromosome
        /// </summary>
        /// <param name="s"></param>
        /// <param name="P"></param>
        public static void Inf(string s, Point[] P)
        {
            string InfAboutChr = s;
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
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string WritePath1 = $@"TSP{P.Length}.tsp";
                string WritePath2 = $@"TOUR{P.Length}.tsp";
                using (StreamWriter sw = new StreamWriter(WritePath1, false, System.Text.Encoding.Default))
                {
                    if (Name == "")
                        sw.WriteLine($"NAME : TSP{P.Length}");
                    else
                        sw.WriteLine($"NAME : {Name}");
                    if (Com1 != "")
                        sw.WriteLine($"COMMENT : {Com1}");
                    if (Com2 != "")
                        sw.WriteLine($"COMMENT : {Com2}");
                    if (Com3 != "")
                        sw.WriteLine($"COMMENT : {Com3}");
                    sw.WriteLine("TYPE : TSP");
                    sw.WriteLine($"DIMENSION : {P.Length}");
                    sw.WriteLine("EDGE_WEIGHT_TYPE : EUC_2D");
                    sw.WriteLine("NODE_COORD_SECTION");
                    for (i = 0; i < P.Length; i++)
                    {
                        sw.WriteLine($"{i + 1} {P[i].X} {P[i].Y}");
                    }
                    sw.WriteLine("EOF");
                }
                using (StreamWriter sw = new StreamWriter(WritePath2, false, System.Text.Encoding.Default))
                {
                    if (Name == "")
                        sw.WriteLine($"NAME : TOUR{P.Length}");
                    else
                        sw.WriteLine($"NAME : {Name}");
                    if (Com1 != "")
                        sw.WriteLine($"COMMENT : {Com1}");
                    sw.WriteLine("TYPE : TOUR");
                    sw.WriteLine($"DIMENSION : {P.Length}");
                    sw.WriteLine("TOUR_SECTION");
                    for (i = 0; i < InfAboutChr.Length; i++)
                        if (InfAboutChr[i] != '+')
                            sw.WriteLine(InfAboutChr[i] - 96);
                        else
                            sw.WriteLine(InfAboutChr[i]);
                 //   sw.WriteLine(InfAboutChr[0]);
                    sw.WriteLine("-1");
                    sw.WriteLine("EOF");
                }
                MessageBox.Show(
                 "Data saved",
                 "Information",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);
            }
        }
    }
}