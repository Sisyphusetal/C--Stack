public class RangedFighter : Enemy
{
    public int Distance;


    public RangedFighter (string name, int health)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
        Distance = 5;
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine($"Oh no, the enemy is too close! {RangedFighter.Name} cannot attack!")
        }
        else{
        Target.Health - Attack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!");
        }
    }

    public void Dash()
    {
        RangedFighter.Distance = 20;
    }

}