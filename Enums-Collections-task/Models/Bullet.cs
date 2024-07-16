using Enums_Collections_task.Helpers.Enums;

namespace Enums_Collections_task.Models
{
    internal class Bullet
    {
        private int _id;
        public int Id { get; }
        public BulletType Type { get; set; }

        public Bullet(BulletType type)
        {
            Id = ++_id;
            Type = type;
        }
    }
}
