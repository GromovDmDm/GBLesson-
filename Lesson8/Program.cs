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

void Show3DArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            if(j / array.GetLength(2) == 0) Console.WriteLine();
        }
    } 
}

void CreateRandomUniqueElementArray(int[] array) {
    int element = new Random().Next(10, 100);
    array[0] = element;
    for (int i = 1; i < array.Length; i++) {
        while(Array.IndexOf(array, element) != -1) {
            element = new Random().Next(10, 100);
        }
        array[i] = element;       
    }
}

void Fill3dArray(int[,,] array3d, int[] array) {
    int arrayIndex = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = array[arrayIndex];
                arrayIndex++;
            }
        }
    }
}

bool ValidationCountElementArray(int num) {
    int MaxCountElementArray = 89;
    if(num > MaxCountElementArray) return false;
    return true;
}

int x = NumberRequest("Введите число x: ");
int y = NumberRequest("Введите число y: ");
int z = NumberRequest("Введите число z: ");

if(ValidationCountElementArray( x * y * z)) {
    int[,,] array3d = new int [x, y, z];
    int[] array = new int [array3d.Length];
    CreateRandomUniqueElementArray(array);
    Fill3dArray(array3d, array);
    Show3DArray(array3d);
} else Console.WriteLine("Вы ввели длину многомерного массива больше допустимой!" +
                         " Т.к. мы заполняем массив из неповторяющихся двузначных чисел максимальная длина массива 89");