//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.WriteLine("Введите первое число : ");
  int A = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Введите второе число : ");
  int B = int.Parse(Console.ReadLine()!);

  int exponentiation = Exponentiation(A, B);
  Console.WriteLine(exponentiation);
  */
  // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
/* Console.WriteLine("Введите число : ");
int A = int.Parse(Console.ReadLine()!);

  int SumNumber(int A){
    
    int counter = Convert.ToString(A).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = A - A % 10;
      result = result + (A - advance);
      A = A / 10;
    }
   return result;
  }

int sumNumber = SumNumber(A);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
 */
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array =GetBinaryArray(8);

Console.WriteLine($"[{String.Join(".",array)}]");

int[] GetBinaryArray(int size){

  int[] result = new int[size];
  for(int i =0; i<size; i++){
    result[i] =new Random().Next(100);
  }
  return result;
}
