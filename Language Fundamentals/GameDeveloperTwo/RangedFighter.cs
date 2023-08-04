public class RangedFighter : Enemy
{
    public int Distance;


    public RangedFighter (string name) : base(name)
    {   
        List<Attack> AttackList = new List<Attack> {new Attack("Shoot an arrow", 20),new Attack("Throw a knife", 15)};
        Distance = 5;
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine($"Oh no, the enemy is too close! {Name} cannot attack!");
        }
        else{
        base.PerformAttack();
        }
    }

    public void Dash()
    {
        Distance += 20;
    }

}