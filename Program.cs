// turn off copilot mode
// turn off copilot mode

 /*int heroHealth = 10 ;
int monsterHealth = 10 ;

Random diceAttacl = new Random();


do
{
  int  diceRoll = diceAttack.Next(1, 11);
  monsterHealth -= diceRoll;
  if (monsterHealth >0){
    Console.WriteLine($"Monster was damaged and lost {diceRoll} health and now has {monsterHealth} health.") ;
    int rollAgain = diceAttack.Next(1, 11);
    heroHealth -= rollAgain;
    if (heroHealth >0){
      Console.WriteLine($"Hero was damaged and lost {rollAgain} health and now has {heroHealth} health.") ;
    }
    else{
      Console.WriteLine($"Hero has been defeated and lost and lost {rollAgain} remaining. Monster Wins!") ;
      break ;
    }
  }else{
      Console.WriteLine($"Hero wins. Monsters has been defeated. he lost {monsterHealth} remaining");
    }

} while (monsterHealth >0); */

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");