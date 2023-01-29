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
string[] SecondArray(string[] arr)
{
    string[] array = new string[arr.Length];
    for (int i = 0, j=0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        array[j] = arr[i];
        j++;
        }
    }
    return array;
}
void SwowArrey (string [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ({i})"  + " ");
    }
}