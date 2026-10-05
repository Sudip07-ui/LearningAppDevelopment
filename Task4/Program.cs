
        int[] favoritenumbers = { 1, 2, 4, 5, 3 };

        
        Array.Sort(favoritenumbers);

        
        Array.Reverse(favoritenumbers);
        
        Console.WriteLine("Array elements after sorting and reversing:");

        for (int i = 0; i < favoritenumbers.Length; i++)
        {
            Console.WriteLine(favoritenumbers[i]);
        }
        
        int searchNumber = 3;
        int position = Array.IndexOf(favoritenumbers, searchNumber);

        Console.WriteLine("\nPosition of " + searchNumber + ": " + position);