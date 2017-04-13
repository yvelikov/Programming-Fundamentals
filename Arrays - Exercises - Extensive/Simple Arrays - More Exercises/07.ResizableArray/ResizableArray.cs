namespace _07.ResizableArray
{
    using System;
    public class ResizableArray
    {
        public static void Main()
        {
            int?[] array = new int? [4];

            string[] command = Console.ReadLine().Split(' ');
            int? index = 0;

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    array = AddNumber(array, int.Parse(command[1]), index);
                    index++;
                }
                if (command[0] == "removeAt")
                {
                    array = RemoveNumber(array, int.Parse(command[1]));
                    if (index > 0)
                    {
                        index--;
                    }
                    
                }
                if (command[0] == "pop")
                {
                    array = RemoveLastNumber(array);
                    if (index > 0)
                    {
                        index--;
                    }
                }
                if (command[0] == "clear")
                {
                    array = ClearArray(array);
                    index = 0;
                }

                command = Console.ReadLine().Split(' ');
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].HasValue)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", array));
            }
            else Console.WriteLine("empty array");
        }

        private static int?[] RemoveLastNumber(int?[] array)
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].HasValue)
                {
                    index = i;
                }
            }

            int?[] newArray = new int?[array.Length];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        private static int?[] ClearArray(int?[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = null;
            }

            return array;
        }

        private static int?[] RemoveNumber(int?[] array, int index)
        {
            int?[] newArray = new int?[array.Length];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length -1; i++)
            {
                newArray[i] = array[i+1];
            }

            return newArray;
        }

        static int?[] AddNumber(int?[] array, int value, int? index)
        {
            if (index >= array.Length)
            {
                int?[] newArray = new int?[array.Length * 2];
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == index)
                    {
                        newArray[i] = value;
                    }
                    else if (i < array.Length)
                        newArray[i] = array[i];

                }
                
                return newArray;
                
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        array[i] = value;
                    }
                }
            }
            
            return array;
            
        }
    }
}
