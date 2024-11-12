using System;

public class Cylinder
{
    private double radius;
    private double height;

    // Властивість для радіусу з перевіркою на від'ємне значення
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0)
                radius = value;
            else
                Console.WriteLine("Некоректне значення для радіусу. Він не може бути від'ємним.");
        }
    }

    // Властивість для висоти з перевіркою на від'ємне значення
    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0)
                height = value;
            else
                Console.WriteLine("Некоректне значення для висоти. Вона не може бути від'ємною.");
        }
    }

    // Метод для обчислення об'єму циліндра
    public double CalculateVolume()
    {
        return Math.PI * radius * radius * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу Cylinder
        Cylinder cylinder = new Cylinder();

        // Введення та перевірка значення радіусу
        double radius;
        Console.Write("Введіть радіус циліндра: ");
        while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть додатнє число для радіусу.");
            Console.Write("Введіть радіус циліндра: ");
        }
        cylinder.Radius = radius;

        // Введення та перевірка значення висоти
        double height;
        Console.Write("Введіть висоту циліндра: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
        {
            Console.WriteLine("Введено некоректне значення. Введіть додатнє число для висоти.");
            Console.Write("Введіть висоту циліндра: ");
        }
        cylinder.Height = height;

        // Обчислення об'єму та виведення результату
        double volume = cylinder.CalculateVolume();
        Console.WriteLine($"Об'єм циліндра з радіусом {cylinder.Radius} і висотою {cylinder.Height} дорівнює {volume:F2}");
    }
}
