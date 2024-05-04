// See https://aka.ms/new-console-template for more information
Console.WriteLine("Role Playing Game challenge\n");


/* 
Game Rules

The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.

 */
int heroHP = 20;
int monsterHP = 20;

Random attack = new Random();

do
{
    // Hero's attack
    int heroAtt = attack.Next(1, 11);
    Console.WriteLine($"Hero rolled {heroAtt}!");
    monsterHP -= heroAtt;
    Console.WriteLine($"Monster lost {heroAtt}HP! And now has {monsterHP} HP left.\n");
    if (monsterHP <= 0) continue;

    int monsterAtt = attack.Next(1, 11);
    Console.WriteLine($"Monster rolled {monsterAtt}!");
    heroHP -= monsterAtt;
    Console.WriteLine($"Hero lost {monsterAtt}HP! And now has  {heroHP} HP left.\n");
    if (heroHP <= 0) continue;

}
while (heroHP > 0 && monsterHP > 0);

if (monsterHP <= 0)
{
    Console.WriteLine("Hero wins!");
    monsterHP = 0;
    Console.WriteLine($"Monster has {monsterHP} HP!");
}
//if (heroHP <= 0)
else
{
    Console.WriteLine("Monster wins!");
    heroHP = 0;
    Console.WriteLine($"Hero has {heroHP} HP!");
}
