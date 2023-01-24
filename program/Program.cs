int CountNewElement(string[] array)
      {
      int count = 0;
      foreach(string element in array)
       {
      if (element.Length < 4)
       count++;}
        return count;
      }
      
         string[] s =Console.ReadLine().Split(" ");
      Console.WriteLine($"[{string.Join(", ", s)}]");
      
      string[] mas = new string[CountNewElement(s)];
      int index=0;
      for (int i=0; i< s.Length; i++)
      if (s[i].Length < 4)
      {
        mas[index]=s[i];
        index++;
      }
      Console.WriteLine($"[{string.Join(", ", mas)}]");
