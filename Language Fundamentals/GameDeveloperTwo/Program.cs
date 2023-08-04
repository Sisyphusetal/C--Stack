MeleeFighter Barbaros = new MeleeFighter("Barbaros");
RangedFighter Legolas = new RangedFighter("Legolas");
MagicCaster Elminster = new MagicCaster("Elminster");


Barbaros.PerformAttack(Legolas, Barbaros.AttackList[1]);
Barbaros.Rage(Elminster);
Legolas.PerformAttack(Barbaros, Legolas.AttackList[0]);
Legolas.Dash();
Legolas.PerformAttack(Barbaros, Legolas.AttackList[0]);
Elminster.PerformAttack(Barbaros, Elminster.AttackList[0]);
Elminster.Heal(Legolas);
Elminster.Heal(Elminster);

