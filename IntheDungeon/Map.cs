using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheDungeon
{
    public class Map
    {
        public virtual void GoNext() { }
    }

    public class Dungeon : Map
    {
        public override void GoNext()
        {
            Console.WriteLine("던전으로 들어갑니다");
            //던전 이동
        }

    }

    public class Building : Map
    {
        Door door;
        public Building()
        {
            door = new Door();
        }


    }

}
