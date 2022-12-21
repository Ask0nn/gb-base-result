namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string[] arr = new string[] { "asd", "12345", "fffda", "++1", "x-", "ffff", "ds" }; //result = [asd, ++1, x-, ds]
            Console.WriteLine("Исходный массив:\n[ {0} ]", string.Join(", ", arr));

            arr = Array.FindAll(arr, e => e.Length <= 3).ToArray();
            Console.WriteLine("Измененный массив:\n[ {0} ]", string.Join(", ", arr));
        }
    }
}