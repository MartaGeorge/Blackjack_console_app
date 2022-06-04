using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Cards
    {
        private List<string> t= new List<string>();
        private List<int> integer = new List<int>();
        public List<string> T
        {
            get { return t; }
        }
        public List<int> Integer
        {
            get { return integer; }
        }
        public enum Rank
        {
            Deuce=2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack=10,
            Queen=10,
            King=10,
            Ace=11
        }
        public enum Suit
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }
        private void Fisher_Yates(List<string>E,List<int>val)
        {
            Random r = new Random();
            for(int i=E.Count-1;i>0;i--)
            {
                int j = r.Next(0, i + 1);
                string temp = E[i];
                E[i] = E[j];
                E[j] = temp;
                int aux = val[i];
                val[i] = val[j];
                val[j] = aux;
            }
        }
        public void Shuffle()
        {
            string[] values = Enum.GetNames(typeof(Rank));
            int[] v = (int[])Enum.GetValues(typeof(Rank));
            string[] s = Enum.GetNames(typeof(Suit));
            foreach(var a in values)
            {
                
                string rank = a;
                foreach(var b in s)
                {
                    string suit = b;
                    t.Add($"{a} of {b}");
                }
            }
            foreach(var c in v)
            {
                for(int i=1;i<=4;i++)
                {
                    integer.Add(c);
                }
            }
            Fisher_Yates(t,integer);
        }
        public Cards()
        {
            Shuffle();
        }
    }
}
