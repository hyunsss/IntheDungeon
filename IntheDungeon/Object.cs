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

    public class ItemBox : InteractiveObject, IDropItem, IsLockInOut
    {
        private bool IsLock;
        public ItemBox() { 
            IsLock = true;
        }

        public void DropItem()
        {
            Console.WriteLine("아이템을 드랍합니다");
        }

        public void IsLockIn()
        {
            if (IsLock) { Console.WriteLine("이미 잠겨있습니다."); }
            else {
                Console.WriteLine("상자를 잠굽니다.");
                IsLock = true;
            }
        }

        public void IsLockOut()
        {
            if (IsLock)
            {
                Console.WriteLine("상자가 잠겨있습니다. 잠금을 해제 하시겠습니까?");
                string Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "yes":
                        IsLock = false;
                        IsOpen();
                        break;
                    case "no":
                        Console.WriteLine("상자를 그냥 둡니다.");
                        break;
                }
            }
        }

        public override void IsOpen()
        {
            if(!IsLock)
            {
                Console.WriteLine("상자를 열었습니다!");
                //열었을 때 드랍 아이템
                DropItem();
            } else
            {
                IsLockOut();
            }
            
        }
    }


    public class Door : InteractiveObject, IsLockInOut
    {
        private bool IsLock;
        private bool Dooropen;
        public Dungeon dungeon;
        public Door()
        {
            
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
                        dungeon.GoNext();
                        break;
                    case "no":
                        break;

                }

            } else if(IsLock)
            {
                IsLockOut();
            }
            
        }

        public void IsLockIn()
        {
            if (IsLock) { Console.WriteLine("이미 잠겨있습니다."); }
            else
            {
                Console.WriteLine("문을 잠굽니다.");
                IsLock = true;
            }
        }

        public void IsLockOut()
        {
            if (IsLock)
            {
                Console.WriteLine("문이 잠겨있습니다. 잠금을 해제 하시겠습니까?");
                string Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "yes":
                        IsLock = false;
                        IsOpen();
                        break;
                    case "no":
                        Console.WriteLine("문을 그냥 둡니다.");
                        break;
                }
            }
        }
    }
    internal class Object
    {
    }
}
