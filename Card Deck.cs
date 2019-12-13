using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWW
{
    class Card_Deck
    {
        int m_count = 0;

        bool[] m_cards = new bool[52];

        public void shuffle()
        {
            m_count = 0;

            for (int i = 0; i < m_cards.Length; i++)
            {
                m_cards[i] = false;
            }
        }

        public int deal()
        {
            int n = 0;
            Random r = new Random();
            n = r.Next(0, 52);

            if (m_count == 52)
            {
                return -1;
            }

            while (m_cards[n] == true)
            {
                n = r.Next(0, 52);
            }

            m_cards[n] = true;
            m_count++;
            return n;
        }
    }
}
