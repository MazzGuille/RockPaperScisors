
Random random = new Random();
bool playAgain = true;
string player;
string computer;
string answer;

while(playAgain)
{
    player = "";
    computer = "";
    answer = "";

    while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
    Console.WriteLine("Rock, Paper, Scissors?");
    player = Console.ReadLine();
    player = player.ToUpper();
    }

    
    switch(random.Next(1,4))
    {
        case 1:
        computer = "ROCK";
        break; 
        case 2:
        computer = "PAPER";
        break; 
        case 3:
        computer = "SCISSORS";
        break; 
    }
    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    switch(player)
    {
        case "ROCK":
            if(computer == "ROCK")
            {
                Console.WriteLine("It's a draw!");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("You loose! :c");
            }
            else
            {
                Console.WriteLine("You win! :D");
            }
            break;
        case "PAPER":
           if(computer == "ROCK")
            {
                Console.WriteLine("You win! :D");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("You loose! :c");
            }
            break;
        case "SCISSORS":
        if(computer == "ROCK")
            {
                Console.WriteLine("You loose! :c");
            }
            else if(computer == "PAPER")
            {
                Console.WriteLine("You win! :D");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            break;
    }
    Console.WriteLine("Would you like to play again? (Y/N)");
    answer = Console.ReadLine();
    answer = answer.ToUpper();

    if(answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Thanks for playing! Hope you had a nice time! Please, come again!");
