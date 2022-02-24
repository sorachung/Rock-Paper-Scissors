using System;
using System.Collections.Generic;
using System.Linq;

Main();

void Main()
{
    List<int> scores = new List<int>() { 0, 0 };

    int userChoice;

    while (scores[0] < 3 && scores[1] < 3)
    {
        PrintScores(scores[0], scores[1]);
        PrintIntroUI();
        userChoice = Convert.ToInt32(Console.ReadLine().ToString().Trim());
        scores = PlayGame(userChoice, scores);
    }
    Console.WriteLine("Final Scores: ");
    PrintScores(scores[0], scores[1]);
}

List<int> PlayGame(int userHand, List<int> scores)
{
    chooseHand((userHand));

    Console.WriteLine("VS");

    Random r = new Random();
    int computerHand = r.Next(1, 4);
    chooseHand(computerHand);
    return KeepScore(userHand, computerHand, scores);
}

List<int> KeepScore(int userHand, int computerHand, List<int> scores)
{
    switch (userHand)
    {
        case 1:
            switch (computerHand)
            {
                case 1:
                    break;
                case 2:
                    scores[1] += 1;
                    break;
                case 3:
                    scores[0] += 1;
                    break;
            }
            break;
        case 2:
            switch (computerHand)
            {
                case 1:
                    scores[0] += 1;
                    break;
                case 2:
                    break;
                case 3:
                    scores[1] += 1;
                    break;
            }
            break;
        case 3:
            switch (computerHand)
            {
                case 1:
                    scores[1] += 1;
                    break;
                case 2:
                    scores[0] += 1;
                    break;
                case 3:
                    break;
            }
            break;


    }

    return scores;
}

void chooseHand(int number)
{
    switch (number)
    {
        case 1:
            PrintRock();
            break;

        case 2:
            PrintPaper();
            break;

        case 3:
            PrintScissors();
            break;
        default:
            break;

    }
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

void PrintScores(int playerScore, int computerScore)
{
    Console.WriteLine("----------------------------");
    Console.WriteLine($"| Player : {playerScore} | Computer: {computerScore} |");
    Console.WriteLine("----------------------------");
}

void PrintIntroUI()
{
    Console.WriteLine(@"What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");
}