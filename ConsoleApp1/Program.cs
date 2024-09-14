
using System;
using System.Linq;

public class PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль для проверки:");
            string password = Console.ReadLine();

            PasswordChecker checker = new PasswordChecker();
            int score = checker.CheckPassword(password);

            Console.WriteLine($"Ваш пароль набрал {score} баллов.");
        }
    }

    public int CheckPassword(string password)
    {
        int score = 0;

        // 1. Наличие цифр
        if (password.Any(char.IsDigit))
            score++;

        // 2. Наличие строчных букв
        if (password.Any(char.IsLower))
            score++;

        // 3. Наличие заглавных букв
        if (password.Any(char.IsUpper))
            score++;

        // 4. Наличие спецсимволов
        if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            score++;

        // 5. Длина пароля больше 7 символов
        if (password.Length > 7)
            score++;

        return score;
    }
}
