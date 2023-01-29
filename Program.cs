string [] Arrey(){
    Console.WriteLine($" Введите размер масива");
    int size = Convert.ToInt32(Console.ReadLine());
    string [] arr = new string [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент масива {i} ");
       arr[i]  = Console.ReadLine();
    }
    return arr;
}