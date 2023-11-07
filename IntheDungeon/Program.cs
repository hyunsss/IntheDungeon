namespace IntheDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ItemBox box = new ItemBox();
            Dungeon dungeon = new Dungeon();

            player.IsOpen(box);
            player.GoNext(dungeon);



        }
    }
}