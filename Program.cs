
Console.WriteLine("Welcome to lynnxx's password generator!");
Console.WriteLine("How many total characters should your password be? This includes letters, numbers and special characters.");
int howMany = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many letters should be in your password?");
int letterCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many numbers should be in your password?");
int numberCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many special characters should be in your password?");
int specialCount = Convert.ToInt32(Console.ReadLine());
int charMin = 8;
int letterMin = 6;
int numberMin = 1;
int specialMin = 1;
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

if (howMany != letterCount + numberCount + specialCount)
{
    Console.WriteLine("Hmm, something doesn't add up..");
    Environment.Exit(1);
}
else
{
    
}

string[] specials = new string[] {"!","@", "#", "$", "%", "?"};

switch (letterCount)
{
    case 8:
        string numString = "";
        Random numcount8 = new Random();
        Random spec8 = new Random(DateTime.Now.Hour);
        Random num2 = new Random(DateTime.Now.Millisecond);
        int treeNum = num2.Next(3);
        //int treeNum = 2;
        if (treeNum == 0)
        {
            StreamReader reader8 = new StreamReader("7letter.txt");
            string line = "";
            //line = reader.ReadLine();
            Random num = new Random();

            int lineIndex = num.Next("7letter.txt".Length);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("alpha.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            int specIndex = spec8.Next(specials.Length);
            string special = specials[specIndex];
            
            

            string subFinalLine = line + line82 + special;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numcount8.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);
            reader8.Close();
            reader82.Close();
        }
        else if (treeNum == 1)
        {
            StreamReader reader8 = new StreamReader("4letter.txt");
            string line = "";
           
            Random num = new Random();

            int lineIndex = num.Next("4letter.txt".Length);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("4letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next("4letter.txt".Length);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            string finalLine = line + line82;
            Console.WriteLine(finalLine);
            reader8.Close();
            reader82.Close();
        }
        else if (treeNum == 2)
        {  StreamReader reader8 = new StreamReader("5letter.txt");
            string line = "";
           
            Random num = new Random();

            int lineIndex = num.Next("5letter.txt".Length);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("3letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            string finalLine = line + line82;
            Console.WriteLine(finalLine);
            reader8.Close();
            reader82.Close();
            
        }
        else if (treeNum == 3)
        { StreamReader reader8 = new StreamReader("6letter.txt");
            string line = "";
           
            Random num = new Random();

            int lineIndex = num.Next("6letter.txt".Length);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("2letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            string finalLine = line + line82;
            Console.WriteLine(finalLine);
            reader8.Close();
            reader82.Close();
            
        }

        return;
    case 7:
        Random num722 = new Random(DateTime.Now.Millisecond);
        int treeNum7 = num722.Next(2);

        if (treeNum7 == 0)
        {
            StreamReader reader7 = new StreamReader("6letter.txt");
            string line7 = "";
            Random num7 = new Random();
            int lineIndex7 = num7.Next("6letter.txt".Length);
            for (int i = 0; i < lineIndex7; i++)
            {
                line7 = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("alpha.txt");
            string line72 = "";
            Random num72 = new Random();
            int lineIndex72 = num72.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string finalLine7 = line7 + line72;
            Console.WriteLine(finalLine7);


            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 1)
        {
            StreamReader reader7 = new StreamReader("5letter.txt");
            string line7 = "";
            Random num7 = new Random();
            int lineIndex7 = num7.Next("5letter.txt".Length);
            for (int i = 0; i < lineIndex7; i++)
            {
                line7 = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("2letter.txt");
            string line72 = "";
            Random num72 = new Random();
            int lineIndex72 = num72.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string finalLine7 = line7 + line72;
            Console.WriteLine(finalLine7);


            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 2)
        {
            StreamReader reader7 = new StreamReader("4letter.txt");
            string line7 = "";
            Random num7 = new Random();
            int lineIndex7 = num7.Next("4letter.txt".Length);
            for (int i = 0; i < lineIndex7; i++)
            {
                line7 = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("3letter.txt");
            string line72 = "";
            Random num72 = new Random();
            int lineIndex72 = num72.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            string finalLine7 = line7 + line72;
            Console.WriteLine(finalLine7);


            reader7.Close();
            reader72.Close();  
        }

        return;
    case 6:
        Random num622 = new Random(DateTime.Now.Millisecond);
        int treeNum6 = num622.Next(2);
        if (treeNum6 == 0)
        {
            StreamReader reader6 = new StreamReader("5letter.txt");
            string line6 = "";

            Random num6 = new Random();
            int lineIndex6 = num6.Next("5letter.txt".Length);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("alpha.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            string finalLine6 = line6 + line62;
            Console.WriteLine(finalLine6);

            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 1)
        {
            StreamReader reader6 = new StreamReader("4letter.txt");
            string line6 = "";

            Random num6 = new Random();
            int lineIndex6 = num6.Next("4letter.txt".Length);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("2letter.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            string finalLine6 = line6 + line62;
            Console.WriteLine(finalLine6);

            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 2)
        {
            StreamReader reader6 = new StreamReader("3letter.txt");
            string line6 = "";

            Random num6 = new Random();
            int lineIndex6 = num6.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("3letter.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            string finalLine6 = line6 + line62;
            Console.WriteLine(finalLine6);

            reader6.Close();
            reader62.Close();
        }
        

        return;
        
    case 5:
        Random num522 = new Random(DateTime.Now.Millisecond);
        int treeNum5 = num522.Next(1);
        if (treeNum5 == 0)
        {
            StreamReader reader5 = new StreamReader("4letter.txt");
            string line5 = "";

            Random num5 = new Random();
            int lineIndex5 = num5.Next("4letter.txt".Length);
            for (int i = 0; i < lineIndex5; i++)
            {
                line5 = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("alpha.txt");
            string line52 = "";
            Random num52 = new Random();
            int lineIndex52 = num52.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            string finalLine5 = line5 + line52;
            Console.WriteLine(finalLine5);

            reader5.Close();
            reader52.Close();
        }
        else if (treeNum5 == 1)
        {
            
            StreamReader reader5 = new StreamReader("3letter.txt");
            string line5 = "";

            Random num5 = new Random();
            int lineIndex5 = num5.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex5; i++)
            {
                line5 = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("2letter.txt");
            string line52 = "";
            Random num52 = new Random();
            int lineIndex52 = num52.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            string finalLine5 = line5 + line52;
            Console.WriteLine(finalLine5);

            reader5.Close();
            reader52.Close();
        }

        return;
        
    case 4:
        Random num422 = new Random(DateTime.Now.Millisecond);
        int treeNum4 = num422.Next(1);
        if (treeNum4 == 0)
        {
            StreamReader reader4 = new StreamReader("2letter.txt");
            string line4 = "";

            Random num4 = new Random();
            int lineIndex4 = num4.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex4; i++)
            {
                line4 = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("2letter.txt");
            string line42 = "";
            Random num42 = new Random();
            int lineIndex42 = num42.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            string finalLine4 = line4 + line42;
            Console.WriteLine(finalLine4);

            reader4.Close();
            reader42.Close();
        }
        else if (treeNum4 == 1)
        {
            StreamReader reader4 = new StreamReader("3letter.txt");
            string line4 = "";

            Random num4 = new Random();
            int lineIndex4 = num4.Next("3letter.txt".Length);
            for (int i = 0; i < lineIndex4; i++)
            {
                line4 = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("alpha.txt");
            string line42 = "";
            Random num42 = new Random();
            int lineIndex42 = num42.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            string finalLine4 = line4 + line42;
            Console.WriteLine(finalLine4);

            reader4.Close();
            reader42.Close();
        }

        return;
       
    case 3:
        Random num322 = new Random(DateTime.Now.Millisecond);
        int treeNum3 = num322.Next(1);
        if (treeNum3 == 0)
        {
            StreamReader reader3 = new StreamReader("alpha.txt");
            string line3 = "";

            Random num3 = new Random();
            int lineIndex3 = num3.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex3; i++)
            {
                line3 = reader3.ReadLine();
            }

            StreamReader reader32 = new StreamReader("2letter.txt");
            string line32 = "";
            Random num32 = new Random();
            int lineIndex32 = num32.Next("2letter.txt".Length);
            for (int i = 0; i < lineIndex32; i++)
            {
                line32 = reader32.ReadLine();

            }

            string finalLine3 = line3 + line32;
            Console.WriteLine(finalLine3);

            reader3.Close();
            reader32.Close();
        }
        else if (treeNum3 == 1)
        {
            StreamReader reader3 = new StreamReader("alpha.txt");
            string line3 = "";

            Random num3 = new Random();
            int lineIndex3 = num3.Next("alpha.txt".Length);
            for (int i = 0; i < lineIndex3; i++)
            {
                line3 = reader3.ReadLine();
            }
            Console.WriteLine(line3);
            reader3.Close();
        }

        return;
    default:
        return;
    
    
    
    
    
    
    
    
}




