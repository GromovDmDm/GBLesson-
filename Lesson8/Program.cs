int NumberRequest (string s) {
  Console.Write($"{s}");
  var stringNumber = Console.ReadLine();
  int numericValue;
  bool isNumber = int.TryParse(stringNumber, out numericValue);
  if (!isNumber) {
    Console.WriteLine("Вы ввели не число! Программа будет остановлена");
    System.Environment.Exit(-1);
    }
  return numericValue;
}

void CreateRandom3DArray(String[,,] array) {

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                array[i, j, k] = $"{(new Random().Next(10, 100)).ToString()} ({i},{j},{k})";
            }            
        }
    }

}

void Show3DArray(String[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine(array[i, j, k]);
            }
        }
    } 
}

int x = NumberRequest("Введите число x: ");
int y = NumberRequest("Введите число y: ");
int z = NumberRequest("Введите число z: ");
String[,,] array = new String [x, y, z];
CreateRandom3DArray(array);
Show3DArray(array);