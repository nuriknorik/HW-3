/*Задание 1
Создайте интерфейс ICalc. В нём должно быть два
метода:
    ■ int Less(int valueToCompare) — возвращает количество
значений меньших, чем valueToCompare;
    ■ int Greater(int valueToCompare) — возвращает коли-
    чество значений больших, чем valueToCompare.
    Класс, созданный ранее в практическом задании Array,
    должен имплементировать интерфейс ICalc.
    Метод Less — возвращает количество элементов мас-
    сива меньших, чем valueToCompare.
    Метод Greater — возвращает количество элементов
массива больших, чем valueToCompare.
    Напишите код для тестирования полученной функ-
    циональности.);*/
/*Задание 2
Создайте интерфейс IOutput2. В нём должно быть
два метода:
    ■ void ShowEven() — отображает четные значения из
контейнера с данными;ДОМАШНЕЕ ЗАДАНИЕ
1
    ■ void ShowOdd() — отображает нечетные значения из
контейнера с данными .
    Класс, созданный ранее в практическом задании Array,
    должен имплементировать интерфейс IOutput2.
    Метод ShowEven — отображает четные значения из
массива.
    Метод ShowOdd — отображает нечетные значения
    из массива.
    Напишите код для тестирования полученной функ-
    циональности.
        Задание 3
Создайте интерфейс ICalc2. В нём должно быть два
метода:
    ■ int CountDistinct() — возвращает количество уникаль-
    ных значений в контейнере данных;
    ■ int EqualToValue(int valueToCompare) — возвращает
    количество значений равных valueToCompare .
    Класс, созданный ранее в практическом задании Array,
    должен имплементировать интерфейс ICalc2.
    Метод CountDistinct — возвращает количество уни-
    кальных значений в массиве.
    Метод EqualToValue — возвращает количество эле-
    ментов массива равных valueToCompare.
    Напишите код для тестирования полученной функ-
    циональности.*/
using ConsoleApp3;
namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
            Array j = new Array(1, 2, 3, 4, 5, 6);
            for (int i = 0; i < j.Length; i++)
            {
                Console.Write(i);
            }
        }
    }
    internal interface ICalc
    {
    }
    internal interface ICalc2
    {
    }
    {
    class Array: ICalc ,ICalc2
    {
        public Array(Int32[] numbers) {
            this.Array = new Int32[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
                this[i] = numbers[i];
        }
        

        public int Length { get; set; }

        public int MinElem(int ToCompare) //minimalный элемент
        {
            Int32 count = new();
            for (int i = 0; i < this.Array.Length; i++)
                if (ToCompare > this.Array[i]) count++;
            return count;
        }

        public int MaxElem(int ToCompare)  //максимальный элемент
        {
            Int32 count = new();
            for (int i = 0; i < this.Array.Length; i++)
                if (ToCompare < this.Array[i]) count++;
            return count;
        }

        public void ShowEven() //четные значения
        {
            for (int i = 0; i < this.Array.Length; i++)
                if (this.Array[i] % 2 == 0) 
                    Console.Write($"{Array[i]} ");
            Console.WriteLine();
        }

        public void ShowOdd() //нечетные значения
        {
            for (int i = 0; i < this.Array.Length; i++)
                if (this.Array[i] % 2 != 0) 
                    Console.Write($"{Array[i]} ");
            Console.WriteLine();
        }

        public int CountDistinct()  //уникальные элементы
        {
            Int32 count = new();
            Int32 unical = new();

            for (int i = 0; i < this.Array.Length; i++)
            {
                for (int j = 0; j < this.Array.Length; j++)
                {
                    if (this.Array[i] == this.Array[j])
                    {
                        unical++;
                        if (unical == 2) ;
                    }
                }
                if (unical == 1) count++;
                unical = 0;
            }
            return count;
        }

        private Int32[] Array;

        public Array(int numbers, int i, int i1, int i2, int i3, int i4)
        {
            throw new NotImplementedException();
        }
    }
    }
}
