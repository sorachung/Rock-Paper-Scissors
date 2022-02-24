using System;

Main();

void Main()
{
    int playerScore = 0;
    int computerScore = 0;
    Console.WriteLine("----------------------------");
    Console.WriteLine($"| Player : {playerScore} | Computer: {computerScore} |");
    Console.WriteLine("----------------------------");
    Console.WriteLine(@"What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");

    PrintRock();
    PrintPaper();
    PrintScissors();
}

void PrintRock()
{
    Console.WriteLine(@"
        _______
    ---'   ____)
          (_____)
          (_____)
          (____)
    ---.__(___)
    ");
}

void PrintPaper()
{
    Console.WriteLine(@"
        _______
    ---'    ____)____
                ______)
                _______)
              _______)
    ---.__________)
    ");
}

void PrintScissors()
{
    Console.WriteLine(@"
        _______
    ---'   ____)____
              ______)
          __________)
          (____)
    ---.__(___)
    ");
}