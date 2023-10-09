using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_2
{
    internal class FootballTeam : IEnumerable<Player>
    {
        private List<Player> _players;
        public FootballTeam() 
        {
            _players = new List<Player>();
        }
        public void AddPlayer(string name, int age, int numer) 
        {
            Player player=new Player(name,age,numer);
            _players.Add(player);
        }
        public IEnumerator<Player> GetEnumerator()
        {
            return _players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
