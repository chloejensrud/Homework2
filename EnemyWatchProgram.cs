//Written By Chloe Jensrud
//2/5/25

namespace WatchTower
{
     public class Program
    {
        static void Main(string[] args)
        {
            EnemyWatch aEnemyWatch = new EnemyWatch(2, 3);
            string location = aEnemyWatch.CalcDirection();
            Console.WriteLine(location);
        }
    }
}
