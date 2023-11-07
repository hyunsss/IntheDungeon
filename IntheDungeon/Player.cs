using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheDungeon
{
    public class Player
    {
        public void IsOpen(InteractiveObject interactiveObject)
        {
            //상호작용 오브젝트 오픈
            interactiveObject.IsOpen();
        }

        public void GoNext(Dungeon dungeon)
        {

        }
    }
}
