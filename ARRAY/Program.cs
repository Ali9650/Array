
#region task 1
//int [] numbers = { 123, 456, 565, 789 };
//for (int i=0; i < numbers.Length; i++)
//{
//    Console.WriteLine (numbers [i]);
//}
#endregion



#region task 2
//int[] numbers = { 123, 456, 565, 789 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum+= numbers[i];
//}
//Console.WriteLine(sum);
#endregion

#region task 3
//int[] numbers = { 123, 456, 565, 789 };
//for (int i = numbers.Length -1;i>= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion

#region task 4
//int temp = 0;
//int[] numbers = { 123, 456, 565, 789 };
//for (int i = 0; i < numbers.Length/2; i++)
//{
// temp = numbers[i];
// numbers[i] = numbers[numbers.Length-i-1];
// numbers[numbers.Length-i-1] = temp;
//}
//for (int i = 0;i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion


#region task 5
//int max = 0;
//int[] numbers = { 123, 456, 565, 789 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//        max = numbers[i];
//}
//Console.WriteLine(max);
#endregion

#region task 6
//int count = 0;
//int[] numbers = { 123, 456, 565, 789 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    count++;
//}

//Console.WriteLine(count);
#endregion

#region   Task7
//int[] arr = { 2,7,44,78,23};
//int n = arr.Length;
//Console.WriteLine("Selection sort");
//Console.Write("Initial array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//int temp, smallest;
//for (int i = 0; i < n - 1; i++)
//{
//    smallest = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (arr[j] < arr[smallest])
//        {
//            smallest = j;
//        }
//    }
//    temp = arr[smallest];
//    arr[smallest] = arr[i];
//    arr[i] = temp;
//}
//Console.WriteLine();
//Console.Write("Sorted array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
#endregion

#region Task 8
//int count = 0;
//int[] numbers = { 103, 476, 505, 900, 0 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion

#region task 9
//int count  = 0;
//int[] numbers = { -103, 476, -505, 900, -90 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion

#region task10
//int count = 0;
//int[] numbers = { -103, 476, -505, 900, -90 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion


#region task 11
//int[] numbers = { 103, 476, 505, 900, 90 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * numbers[i];
//    Console.WriteLine(numbers[i]);
//}
#endregion

#region task 12
//int[] array = { 6, 3, 2, 5 };
//for (int i = 1; i<array.Length; i++)
//{
//    int key = array[i];
//    int flag = 0;
//    for (int j = i - 1; j >= 0 && flag != 1;)
//    {
//        if (key >= array[j])
//        {
//            array[j + 1] = array[j];
//            j--;
//            array[j + 1] = key;
//        }
//        else flag = 1;
//    }
//}
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}
#endregion