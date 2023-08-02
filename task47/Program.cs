int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetDoubleMass(int rows, int columns) {
    double[,] arr = new double[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i,j] = rnd.Next(-10,10) + Math.Round(rnd.NextDouble(),1);
            
        
        }
    }
    return arr;
}


void PrintArr(double[,] arr) {
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
double[,] Mass = GetDoubleMass(ROWS,COLUMNS);
PrintArr(Mass);



