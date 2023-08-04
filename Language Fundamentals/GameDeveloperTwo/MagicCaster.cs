public class MagicCaster : Enemy
{


    public MagicCaster (string name) : base(name)
    {
        Health = 80;
        AttackList = new List<Attack>()
        {
            new Attack("Fireball", 25),
            new Attack("Lightning Bolt", 20),
            new Attack("Staff Strike", 10),
        };
    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"{Name} heals {Target.Name}! Their health is now {Target.Health}!");
    }
}