int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetDoubleMass(int rows, int columns) {
    int[,] arr = new int[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i,j] = rnd.Next(1,10);
            
        
        }
    }
    return arr;
}

void SearchElementInMass(int[,] arr, int numRow, int numColumn) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1);)
        {
            if (numRow  > arr.GetLength(0) || numColumn  > arr.GetLength(1)) {
                Console.WriteLine("Элемента с такой позицией нет в массиве");
                return;
            } else {
                Console.WriteLine(arr[numRow - 1,numColumn - 1]);
                return;
            }
        }
}

}

void PrintArr(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}




int ROWS = Zapros("введите количество строк");
int COLUMNS = Zapros("введите количество столбцов");
int RowNumber = Zapros("Введите номер строки");
int ColumnNumber = Zapros("Введите номер столбца");
int[,] Mass = GetDoubleMass(ROWS,COLUMNS);
PrintArr(Mass);
Console.WriteLine();
SearchElementInMass(Mass,RowNumber,ColumnNumber);


