using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheDungeon
{
    public abstract class InteractiveObject
    {
        public virtual void IsOpen() { }
    }

    public class ItemBox : InteractiveObject, IDropItem
    {
        public void DropItem()
        {
            
        }

        public override void IsOpen()
        {
            //열었을 때 드랍 아이템
            DropItem();
            Console.WriteLine("아이템을 드랍합니다");
        }
    }


    public class Door : InteractiveObject
    {
        private bool Dooropen;
        private bool IsLock;
        public Map map;
        public Door()
        {
            map = new Map();
            IsLock = false;
            Dooropen = false;
        }
        public override void IsOpen() { 
            //열었을 때
            if(!IsLock)
            {
                Dooropen = true;
                Console.WriteLine("문이 열렸습니다. 들어가시겠습니까?");
                string Answer = Console.ReadLine();
                switch(Answer)
                {
                    case "yes":
                        map.GoNext();
                        break;
                    case "no":
                        break;

                }

            } else if(IsLock)
            {
                Console.WriteLine("문이 잠겨있습니다. 열 수 없습니다.");
            }
            
        }

    }
    internal class Object
    {
    }
}
