using Enums_Collections_task.Helpers.Enums;

namespace Enums_Collections_task.Models
{
    internal class Weapon
    {
        private int _id;
        public int Id { get; }
        public BulletType BulletType { get; set; }
        public int BulletCapacity { get; set; }
        private Queue<Bullet> bulletQueue;
        public Weapon(int bulletCapacity, BulletType bulletType)
        {
            BulletType = bulletType;
            BulletCapacity = bulletCapacity;
            bulletQueue = new Queue<Bullet>();
        }



        public void Fire()
        {
            if (bulletQueue.Count > 0)
            {
                var bullet = bulletQueue.Dequeue();
                Console.WriteLine($"Fired bullet type {bullet.Type}. Amount of  bullets: {bulletQueue.Count}");
            }
            else
            {
                Console.WriteLine("No bullets");
            }
        }

        public void Fill()
        {
            if (bulletQueue.Count < BulletCapacity)
            {
                Bullet newBullet = new Bullet(BulletType);
                bulletQueue.Enqueue(newBullet);
            }

        }

        public void PullTrigger()
        {
            if (bulletQueue.Count > 0)
            {
                var nextBullet = bulletQueue.Peek();
                Console.WriteLine($"Next bullet: {nextBullet.Type}");
            }
            else
            {
                Console.WriteLine("No bullets");
            }
        }
    }
}
