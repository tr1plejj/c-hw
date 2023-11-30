int[] CreateArray()
{
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(1, 100);
    }
    return array;
}

int Find(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 20 && array[i] < 90) count++;
    }
    return count;
}

int Find1(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Числа, в промежутке от 20 до 90: " + Find(CreateArray()));
Console.WriteLine("Кол-во четных чисел: " + Find1(CreateArray()));

double[] CreateArrayAndFind()
{
    double[] array = new double[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 9999) * 0.01;
    }
    return array;
}

double Diff(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++){
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.WriteLine("Разница между макс и мин значениями: " + Diff(CreateArrayAndFind()));
