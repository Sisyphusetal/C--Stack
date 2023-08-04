public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;


    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random rand = new Random();
        Console.WriteLine($"{Name} uses {AttackList[rand.Next(0, AttackList.Count)].Name}");
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!");
    }
}
