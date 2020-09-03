using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            try
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    throw new IndexOutOfRangeException();
                    // try
                    // {
                    //     myRoll = myRoll / 0;
                    //     Console.WriteLine($"{other.Name} Wins!");
                    // }
                    // catch (DivideByZeroException e)
                    // {
                    //     Console.WriteLine($"{other.Name} Wins! Not Fair! {e.Message}");
                    // }

                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (IndexOutOfRangeException err)
            {
                Console.WriteLine($"{other.Name} Wins! Not Fair! {err.Message}");
            }

        }
    }

}