using Enums_Collections_task.Helpers.Enums;
using Enums_Collections_task.Models;

Weapon huntingWeapon = new Weapon(4, BulletType.Hunting);

while (true)
{
    Console.WriteLine("1 - Fill");
    Console.WriteLine("2 - Fire");
    Console.WriteLine("3 - Show next bullet ");
    Console.WriteLine("4 - Terminate app");

    int command = int.Parse(Console.ReadLine());

    switch (command)
    {
        case 1:
            huntingWeapon.Fill();
            break;
        case 2:
            huntingWeapon.Fire();
            break;
        case 3:
            huntingWeapon.PullTrigger();
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Commant not found");
            break;
    }

}