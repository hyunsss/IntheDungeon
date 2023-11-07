using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheDungeon
{
    public class Vehicle : InteractiveObject, IsLockInOut
    {
        public virtual void IsLockIn() { }
        public virtual void IsLockOut() { }
       
    }

    public class Car : Vehicle
    {
        private bool IsLock;
        public Car() { 
            IsLock = true;
        }
        public void IsRide(){
            //차에 탑승
        }
        public override void IsLockIn() {
            if (IsLock) { Console.WriteLine("이미 잠겨있습니다."); }
            else
            {
                Console.WriteLine("차를 잠굽니다.");
                IsLock = true;
            }
        }
        public override void IsLockOut() {
            if (IsLock)
            {
                Console.WriteLine("차가 잠겨있습니다. 잠금을 해제 하시겠습니까?");
                string Answer = Console.ReadLine();
                switch (Answer)
                {
                    case "yes":
                        IsLock = false;
                        IsRide();
                        break;
                    case "no":
                        Console.WriteLine("차를 그냥 둡니다.");
                        break;
                }
            }
        }
    }
}
