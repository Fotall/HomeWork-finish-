

string[] Array = { "Hello", "2", "Hello", ":-)" };
 
 int Limit = 3;
 for (int i = 0; i < Array.Length;i++)
     if(Array[i].Length <= Limit)
         Console.WriteLine(Array[i]);




