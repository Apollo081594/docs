            // TryParse returns true if the conversion succeeded
            // and stores the result in j.
        
            if (Int32.TryParse("-105", out int j))
                Console.WriteLine(j);
            else
                Console.WriteLine("String could not be parsed.");
            // Output: -105
