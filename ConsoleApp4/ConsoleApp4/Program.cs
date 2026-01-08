
Console.WriteLine("Welcome to Quiz battle");

Console.WriteLine("Quiz battle regler");

Console.WriteLine("Svara på frågor korrekt för att tjäna poäng");

while (!QuizUtils.IsCompleted())
{
    QuizUtils.DisplayQuestion();
    int answer = QuizUtils.GetAnswer();
    QuizUtils.CheckAnswer(answer);

    QuizUtils.WriteStatus();
}
Console.WriteLine("Tack för att du spelade");