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
            GoblinVillage goblinVillage = new GoblinVillage();


            player.GoNext(goblinVillage);
            player.IsOpen(box);
            player.IsOpen(door);



        }
    }
}