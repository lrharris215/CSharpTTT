using System;
namespace TicTacToe
{
    public class Player
    {
        public virtual string Name { get; }
        public virtual char Mark { get; }

        public Player(string name, char mark)
        {
            Name = name;
            Mark = mark;
        }

        public Player() { }
    }
}
