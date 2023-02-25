Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Week(int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("Ошибка");
  }
  else Console.WriteLine("нет");
}

Week(day);