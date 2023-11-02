namespace AppHW_04_SumNumber
{
    internal class SumNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int target = 15;

            var result = new List<List<int>>();

            foreach (var num1 in array)
            {
                foreach (var num2 in array)
                {
                    foreach (var num3 in array)
                    {
                        if (num1 != num2 && num1 != num3 && num2 != num3 && num1 + num2 + num3 == target)
                        {
                            result.Add(new List<int> { num1, num2, num3 });
                        }
                    }
                }
            }

            foreach (var i in result)
            {
                Console.WriteLine(string.Join(" + ", i));
            }
        }
    }
}