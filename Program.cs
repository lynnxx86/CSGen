using PassgenConsole;

Console.WriteLine("Welcome to lynnxx's password generator!");
Console.WriteLine("How many total characters should your password be? This includes letters, numbers and special characters.");
int howMany = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many letters should be in your password?");
int letterCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many numbers should be in your password?");
int numberCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many special characters should be in your password?");
int specialCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Standard or Random format? type either standard or random.");
string unformat = Console.ReadLine();
string format = unformat.ToLower();


bool again = true;
int charMin = 8;
int letterMin = 3;
int numberMin = 1;
int specialMin = 1;
int filecountAlpha = File.ReadLines("alpha.txt").Count();
int filecount2 = File.ReadLines("2letter.txt").Count();
int filecount3 = File.ReadLines("3letter.txt").Count();
int filecount4 = File.ReadLines("4letter.txt").Count();
int filecount5 = File.ReadLines("5letter.txt").Count();
int filecount6 = File.ReadLines("6letter.txt").Count();
int filecount7 = File.ReadLines("7letter.txt").Count();
int filecountSpecial = File.ReadLines("specials.txt").Count();

if (howMany < charMin)
{
    Environment.Exit(2);

}

if (letterCount < letterMin)
{
    Environment.Exit(3);
}

if (numberCount < numberMin)
{
    Environment.Exit(4);
}

if (specialCount < specialMin)
{
    Environment.Exit(5);
}
if (howMany != letterCount + numberCount + specialCount)
{
    Console.WriteLine("Hmm, something doesn't add up..");
    Environment.Exit(1);
}
  



Random numCount = new Random();
string numString = "";
Random num = new Random(DateTime.Now.Microsecond);
Random num2 = new Random(DateTime.Now.Second);
Random random = new Random();



while (again == true)
{
    switch (letterCount)
{
    case 8:
       
       
       
       
        int treeNum = num2.Next(3); /*This decides which branch in the case we take. branchNum would probably
        make more sense but I'm a lazy bitch. The tree/branch decides how the letter count will be met- for an 8 letter count it could be a
        7 + 1, 4 + 4, or 5 + 3 and this decides which*/
        
        if (treeNum == 0)
        {
            Console.WriteLine("rolled 0"); //This is just for me
            StreamReader reader8 = new StreamReader("7letter.txt");
            string line = "";
            /*This int and loop grab a word from the .txt file and save it into line */
            int lineIndex = num.Next(filecount7);
            for (int i = 0; i <= lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

           /*This does the same thing as the last few lines but from the second .txt file*/
            StreamReader reader82 = new StreamReader("alpha.txt");
            string line82 = "";
            int lineIndex82 = num2.Next(filecountAlpha);
            for (int i = 0; i <= lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            
            /*Here through the for loop grabs however many specials are specified and saves them into specialLine*/
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }


            string finalLine80 = "";
            string subFinalLine = "";

           /*Generating the specified amount of nums*/
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            /* Next is formatting- standard is the common words/number/special, random is those three pieces in a randomly decided order */

            if (format == "standard")
            {
                /* Putting everyting except the specials*/
                subFinalLine = line + line82 + numString;
                /*Adding the specials and we're done!*/
                finalLine80 = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                /* This is the random formatting. The order is decided by which randomly generated number is the lowest -
                 if lineNum is lowest, do this order, and so forth. */
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                /* I felt like being a little extra and made a suuuuper simple bubble sort for this */
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line82 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line82;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line82 + line + specialLine;
                }
                
                finalLine80 = subFinalLine + numString;
            }
            /* Printing the finised results and closing out */

            Console.WriteLine(finalLine80);
            reader8.Close();
            reader82.Close();
        }
        
        
        /* This program from here out simply repeats, changing which .txt files it reads from depending on what's appropriate
         from the user input. It's very modular! */
        else if (treeNum == 1)
        {
            Console.WriteLine("rolled 1");
            StreamReader reader8 = new StreamReader("4letter.txt");
            
            string line = "";
            
            int lineIndex = num.Next(filecount4);
            for (int i = 0; i <= lineIndex; i++)
            {
                line = reader8.ReadLine();
            }
            Console.WriteLine("First 4 letter");

          
            StreamReader reader82 = new StreamReader("4letter.txt");
            string line82 = "";
            
            
            int lineIndex82 = num2.Next(filecount4);
            for (int i = 0; i <= lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }
            Console.WriteLine("Second 4 letter");

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

           
            string finalLine80 = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line82 + numString;
                finalLine80 = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line82 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line82;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line82 + line + specialLine;
                }
                
                finalLine80 = subFinalLine + numString;
            }

            Console.WriteLine(finalLine80);
            
            reader8.Close();
            reader82.Close();
        }
        else if (treeNum == 2)
        {
            Console.WriteLine("rolled 2");
            StreamReader reader8 = new StreamReader("5letter.txt");
            string line = "";
           
            

            int lineIndex = num.Next(filecount5);
            for (int i = 0; i <= lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            
            StreamReader reader82 = new StreamReader("3letter.txt");
            string line82 = "";
            
            int lineIndex82 = num2.Next(filecount3);
            for (int i = 0; i <= lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

           
            
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            
            string finalLine80 = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line82 + numString;
                finalLine80 = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line82 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line82;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line82 + line + specialLine;
                }
                
                finalLine80 = subFinalLine + numString;
            }

            Console.WriteLine(finalLine80);
            reader8.Close();
            reader82.Close();
            
        }
        else if (treeNum == 3)
        { 
            Console.WriteLine("rolled 3");
            StreamReader reader8 = new StreamReader("6letter.txt");
            string line = "";
           
           

            int lineIndex = num.Next(filecount6);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

           
            StreamReader reader82 = new StreamReader("2letter.txt");
            string line82 = "";
            int lineIndex82 = num2.Next(filecount2);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }


            string finalLine80 = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line82 + numString;
                finalLine80 = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line82 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line82;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line82 + line + specialLine;
                }
                
                finalLine80 = subFinalLine + numString;
            }

            Console.WriteLine(finalLine80);
            
            
            reader8.Close();
            reader82.Close();
            
        }

        break;
    case 7:
        
        Random num722 = new Random(DateTime.Now.Millisecond);
        int treeNum7 = num722.Next(2);

        if (treeNum7 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader7 = new StreamReader("6letter.txt");
            string line = "";
            
            int lineIndex7 = num.Next(filecount6);
            for (int i = 0; i <= lineIndex7; i++)
            {
                line = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("alpha.txt");
            string line72 = "";
            int lineIndex72 = num2.Next("alpha.txt".Length);
            for (int i = 0; i <= lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            
            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line72 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line72 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line72;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line72 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
            

            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 1)
        {
            Console.WriteLine("Rolled 1");
            StreamReader reader7 = new StreamReader("5letter.txt");
            string line = "";
           
            int lineIndex7 = num.Next(filecount5);
            for (int i = 0; i <= lineIndex7; i++)
            {
                line = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("2letter.txt");
            string line72 = "";
            int lineIndex72 = num2.Next(filecount2);
            for (int i = 0; i <= lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line72 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line72 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line72;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line72 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
            

            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 2)
        {
            Console.WriteLine("Rolled 2");
            StreamReader reader7 = new StreamReader("4letter.txt");
            string line = "";
           
            int lineIndex7 = num.Next(filecount4);
            for (int i = 0; i <= lineIndex7; i++)
            {
                line = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("3letter.txt");
            string line72 = "";
          
            int lineIndex72 = num2.Next(filecount3);
            for (int i = 0; i <= lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line72 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line72 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line72;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line72 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            


            reader7.Close();
            reader72.Close();  
        }

        break;
    case 6:
        Random num622 = new Random(DateTime.Now.Millisecond);
        int treeNum6 = num622.Next(2);
        if (treeNum6 == 0)
        {
           
            Console.WriteLine("Rolled 0");
            StreamReader reader6 = new StreamReader("5letter.txt");
            string line = "";

           
            int lineIndex6 = num.Next(filecount5);
            for (int i = 0; i <= lineIndex6; i++)
            {
                line = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("alpha.txt");
            string line62 = "";
            
            int lineIndex62 = num2.Next(filecountAlpha);
            for (int i = 0; i <= lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line62 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line62 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line62;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line62 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 1)
        {
            Console.WriteLine("Rolled 1");
            
            StreamReader reader6 = new StreamReader("4letter.txt");
            string line = "";
            int lineIndex6 = num.Next(filecount4);
            for (int i = 0; i <= lineIndex6; i++)
            {
                line = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("2letter.txt");
            string line62 = "";
            int lineIndex62 = num2.Next(filecount2);
            for (int i = 0; i <= lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }
            

            
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line62 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line62 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line62;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line62 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 2)
        {
            
            
            Console.WriteLine("Rolled 2");
            StreamReader reader6 = new StreamReader("3letter.txt");
            string line = "";

           
            int lineIndex6 = num.Next(filecount3);
            for (int i = 0; i <= lineIndex6; i++)
            {
                line = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("3letter.txt");
            string line62 = "";
           
            int lineIndex62 = num2.Next(filecount3);
            for (int i = 0; i <= lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            
            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line62 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line62 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line62;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line62 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
          

            reader6.Close();
            reader62.Close();
        }
        

        break;
        
    case 5:
        Console.WriteLine("Case 5");
        Random num522 = new Random(DateTime.Now.Millisecond);
        int treeNum5 = num522.Next(2);
        if (treeNum5 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader5 = new StreamReader("4letter.txt");
            string line = "";

           
            int lineIndex5 = num.Next(filecount4);
            for (int i = 0; i <= lineIndex5; i++)
            {
                line = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("alpha.txt");
            string line52 = "";
            
            int lineIndex52 = num2.Next(filecountAlpha);
            for (int i = 0; i <= lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line52 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line52 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line52;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line52 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
            reader5.Close();
            reader52.Close();
        }
        else if (treeNum5 == 1)
        {
           Console.WriteLine("rolled 1"); 
            StreamReader reader5 = new StreamReader("3letter.txt");
            string line = "";

            
            int lineIndex5 = num.Next(filecount3);
            for (int i = 0; i <= lineIndex5; i++)
            {
                line = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("2letter.txt");
            string line52 = "";
            
            int lineIndex52 = num2.Next(filecount2);
            for (int i = 0; i <= lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line52 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line52 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line52;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line52 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            reader5.Close();
            reader52.Close();
        }

        break;
        
    case 4:
        Random num422 = new Random(DateTime.Now.Millisecond);
        int treeNum4 = num422.Next(1);
        if (treeNum4 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader4 = new StreamReader("2letter.txt");
            string line = "";

            
            int lineIndex4 = num.Next(filecount2);
            for (int i = 0; i <= lineIndex4; i++)
            {
                line = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("2letter.txt");
            string line42 = "";
           
            int lineIndex42 = num2.Next(filecount2);
            for (int i = 0; i <= lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line42 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line42 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line42;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line42 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            reader4.Close();
            reader42.Close();
        }
        else if (treeNum4 == 1)
        {
            Console.WriteLine("Rolled 1");
            StreamReader reader4 = new StreamReader("3letter.txt");
            string line = "";

           
            int lineIndex4 = num.Next(filecount3);
            for (int i = 0; i < lineIndex4; i++)
            {
                line = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("alpha.txt");
            string line42 = "";
            
            int lineIndex42 = num2.Next(filecountAlpha);
            for (int i = 0; i < lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }

            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line42 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line42 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line42;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line42 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            reader4.Close();
            reader42.Close();
        }

        break;
       
    case 3:
        Random num322 = new Random(DateTime.Now.Millisecond);
        int treeNum3 = num322.Next(1);
        if (treeNum3 == 0)
        {
            Console.WriteLine("rolled 0");
            StreamReader reader3 = new StreamReader("alpha.txt");
            string line = "";

          
            int lineIndex3 = num.Next(filecountAlpha);
            for (int i = 0; i <= lineIndex3; i++)
            {
                line = reader3.ReadLine();
            }

            StreamReader reader32 = new StreamReader("2letter.txt");
            string line32 = "";
           
            int lineIndex32 = num2.Next(filecount2);
            for (int i = 0; i <= lineIndex32; i++)
            {
                line32 = reader32.ReadLine();

            }

            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + line32 + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine + line32 + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine + line32;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line32 + line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);

            reader3.Close();
            reader32.Close();
        }
        else if (treeNum3 == 1)
        {
            Console.WriteLine("rolled 1");
            StreamReader reader3 = new StreamReader("3letter.txt");
            string line = "";

           
            int lineIndex3 = num.Next(filecountAlpha);
            for (int i = 0; i < lineIndex3; i++)
            {
                line = reader3.ReadLine();
            }
            string[] specialChars = File.ReadAllLines("specials.txt");

            Random rand = new Random();
            string specialLine = "";

            for (int i = 0; i < specialCount; i++)
            {
                int index = rand.Next(specialChars.Length);
                specialLine += specialChars[index];
            }
            

            
            

            string finalLine = "";
            string subFinalLine = "";

           
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }

            if (format == "standard")
            {
                subFinalLine = line + numString;
                finalLine = subFinalLine + specialLine;
            }
            else if (format == "random")
            {
                int lineNum = random.Next(3);
                int lineNum2 = random.Next(3);
                int specialLineNum = random.Next(3);
                int[] randoms =  new int[] {lineNum, lineNum2, specialLineNum};
                Sorter.Sort(randoms);
                if (randoms[0] == lineNum)
                { 
                    subFinalLine = specialLine  + line;
                    
                }
                else if (randoms[0] == lineNum2)
                {
                    subFinalLine = line + specialLine;
                }
                else if (randoms[0] == specialLineNum)
                {
                    subFinalLine = line + specialLine;
                }
                
                finalLine = subFinalLine + numString;
            }

            Console.WriteLine(finalLine);
            reader3.Close();
        }

        break;
    default:
        break;
}
    Console.WriteLine("Would you like to generate another password?");
    string second =  Console.ReadLine();
    string secondLow = second.ToLower();
    if (secondLow == "yes")
    {
        Console.WriteLine("Would you like to use the previous parameters or set new ones? Use --p for previous or --n for new.");
        string parameters = Console.ReadLine();
        switch (parameters)
        {
            case "--p":
                Console.WriteLine("Using previous parameters.");
                break;
            case "--n":
                howMany = 0;
                letterCount = 0;
                numberCount = 0;
                specialCount = 0;
                format = "";
                Console.WriteLine("How many total characters should your password be? This includes letters, numbers and special characters.");
                howMany = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many letters should be in your password?");
                letterCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many numbers should be in your password?");
                numberCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many special characters should be in your password?");
                specialCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Standard or Random format? type either standard or random.");
                unformat = Console.ReadLine();
                format = unformat.ToLower();
                break;
            default:
                Console.WriteLine("Unrecognized Input.");
                break;
                
                
            
        }
       
        Console.WriteLine();
    }
    if (secondLow == "no")
    {
        again = false;
    }
}