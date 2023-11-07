using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheDungeon
{
    public class Dungeon
    {
        public Door door;
        public virtual void GoNext()
        {
            Console.WriteLine("던전으로 들어갑니다");
            //던전 이동
        }

        public virtual void OpenDoor() { }
    }
    public class GoblinVillage : Dungeon
    {

        public GoblinVillage()
        {
            door = new Door();
        }

        public override void OpenDoor()
        {
            door.IsOpen();
        }

        public override void GoNext()
        {
            Console.WriteLine("고블린 마을로 들어왔습니다!");
        }


    }

}
