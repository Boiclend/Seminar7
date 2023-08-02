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

void GetArithmeticMeanColumns(int[,] arr) {
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1);)
        {
            double summColumnsNum = 0;
            double result = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                summColumnsNum = summColumnsNum + arr[i,k];
                result = summColumnsNum / arr.GetLength(1);
            }
            count++;
            Console.WriteLine($"среднее арифметическое {count} строки = {result}");
            break;  
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
int[,] Mass = GetDoubleMass(ROWS,COLUMNS);
PrintArr(Mass);
Console.WriteLine();
GetArithmeticMeanColumns(Mass);
