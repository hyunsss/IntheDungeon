namespace IntheDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ItemBox box = new ItemBox();
            Dungeon dungeon = new Dungeon();
            Door door = new Door();
 

            player.IsOpen(box);
            player.IsOpen(door);



        }
    }
}