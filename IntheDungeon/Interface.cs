using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
플레이어 : 물체를 여는 기능, 들어가는 기능
상자, 문, 던전
문, 던전 : 들어갈 수 있어야 함
문 들어갔을 때 : 건물안으로 들어간다.
던전 들어갔을 때 : 던전 맵을 진입한다.
상자, 문 : 열수 있어야 함
상자를 열면 : 아이템 나오게
문을 열면 : 건물안으로 진입할 수 있도록 설명한다.

*/
namespace IntheDungeon
{
    // 드랍아이템
    public interface IDropItem
    {
        public void DropItem();
    }
    
    public interface IsLockInOut
    {
        public void IsLockIn();
        public void IsLockOut();
    }
}
