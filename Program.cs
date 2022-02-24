using System;

Main();

void Main()
{
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