
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

if (howMany != letterCount + numberCount + specialCount)
{
    Console.WriteLine("Hmm, something doesn't add up..");
    Environment.Exit(1);
}
else
{
    
}

//string[] specials = new string[] {"!","@", "#", "$", "%", "?"};
Random numCount = new Random();
string numString = "";
Random num = new Random();
switch (letterCount)
{
    case 8:
       
       
        Random spec8 = new Random(DateTime.Now.Hour);
        Random num2 = new Random(DateTime.Now.Millisecond);
        int treeNum = num2.Next(3);
        //int treeNum = 2;
        if (treeNum == 0)
        {
            Console.WriteLine("rolled 0");
            StreamReader reader8 = new StreamReader("7letter.txt");
            string line = "";
            //line = reader.ReadLine();
            num = new Random();

            int lineIndex = num.Next(filecount7);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("alpha.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next(filecountAlpha);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            
            
            StreamReader special80 = new StreamReader("specials.txt");
            string specialLine80 = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine80 = special80.ReadLine();
            }
            

            
            

            string subFinalLine = line + line82 + specialLine80;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine80 = subFinalLine + numString;
            
            Console.WriteLine(finalLine80);
            special80.Close();
            reader82.Close();
        }
        else if (treeNum == 1)
        {
            Console.WriteLine("rolled 1");
            StreamReader reader8 = new StreamReader("4letter.txt");
            string line = "";
           
            

            int lineIndex = num.Next(filecount4);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("4letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next(filecount4);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line + line82 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine81 = subFinalLine + numString;
            
            Console.WriteLine(finalLine81);
            Console.WriteLine(finalLine81);
            reader8.Close();
            reader82.Close();
        }
        else if (treeNum == 2)
        {
            Console.WriteLine("rolled 2");
            StreamReader reader8 = new StreamReader("5letter.txt");
            string line = "";
           
            

            int lineIndex = num.Next(filecount5);
            for (int i = 0; i < lineIndex; i++)
            {
                line = reader8.ReadLine();
            }

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("3letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next(filecount3);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

           
            
            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line + line82 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine82 = subFinalLine + numString;
            
            Console.WriteLine(finalLine82);
            Console.WriteLine(finalLine82);
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

            //Console.WriteLine(line);
            StreamReader reader82 = new StreamReader("2letter.txt");
            string line82 = "";
            Random num82 = new Random();
            int lineIndex82 = num82.Next(filecount2);
            for (int i = 0; i < lineIndex82; i++)
            {
                line82 = reader82.ReadLine();
            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line + line82 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine83 = subFinalLine + numString;
            
            Console.WriteLine(finalLine83);
            
            
            reader8.Close();
            reader82.Close();
            
        }

        return;
    case 7:
        
        Random num722 = new Random(DateTime.Now.Millisecond);
        int treeNum7 = num722.Next(2);

        if (treeNum7 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader7 = new StreamReader("6letter.txt");
            string line7 = "";
            
            int lineIndex7 = num.Next(filecount6);
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

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line7 + line72 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine70 = subFinalLine + numString;
            
            Console.WriteLine(finalLine70);
            

            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 1)
        {
            Console.WriteLine("Rolled 1");
            StreamReader reader7 = new StreamReader("5letter.txt");
            string line7 = "";
            Random num7 = new Random();
            int lineIndex7 = num7.Next(filecount5);
            for (int i = 0; i < lineIndex7; i++)
            {
                line7 = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("2letter.txt");
            string line72 = "";
            Random num72 = new Random();
            int lineIndex72 = num72.Next(filecount2);
            for (int i = 0; i < lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line7 + line72 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine70 = subFinalLine + numString;
            
            Console.WriteLine(finalLine70);
            

            reader7.Close();
            reader72.Close();
        }
        else if (treeNum7 == 2)
        {
            Console.WriteLine("Rolled 2");
            StreamReader reader7 = new StreamReader("4letter.txt");
            string line7 = "";
            Random num7 = new Random();
            int lineIndex7 = num7.Next(filecount4);
            for (int i = 0; i < lineIndex7; i++)
            {
                line7 = reader7.ReadLine();
            }

            StreamReader reader72 = new StreamReader("3letter.txt");
            string line72 = "";
            Random num72 = new Random();
            int lineIndex72 = num72.Next(filecount3);
            for (int i = 0; i < lineIndex72; i++)
            {
                line72 = reader72.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line7 + line72 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine70 = subFinalLine + numString;
            
            Console.WriteLine(finalLine70);


            


            reader7.Close();
            reader72.Close();  
        }

        return;
    case 6:
        Random num622 = new Random(DateTime.Now.Millisecond);
        int treeNum6 = num622.Next(2);
        if (treeNum6 == 0)
        {
           
            Console.WriteLine("Rolled 0");
            StreamReader reader6 = new StreamReader("5letter.txt");
            string line6 = "";

            Random num6 = new Random(DateTime.Now.Millisecond);
            int lineIndex6 = num6.Next(filecount5);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("alpha.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next(filecountAlpha);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line6 + line62 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 1)
        {
            Console.WriteLine("Rolled 1");
            
            StreamReader reader6 = new StreamReader("4letter.txt");
            string line6 = "";

            Random num6 = new Random();
            int lineIndex6 = num6.Next(filecount4);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("2letter.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next(filecount2);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }
            

            
            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line6 + line62 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader6.Close();
            reader62.Close();
        }
        else if (treeNum6 == 2)
        {
            
            
            Console.WriteLine("Rolled 2");
            StreamReader reader6 = new StreamReader("3letter.txt");
            string line6 = "";

            Random num6 = new Random();
            int lineIndex6 = num6.Next(filecount3);
            for (int i = 0; i < lineIndex6; i++)
            {
                line6 = reader6.ReadLine();
            }

            StreamReader reader62 = new StreamReader("3letter.txt");
            string line62 = "";
            Random num62 = new Random();
            int lineIndex62 = num62.Next(filecount3);
            for (int i = 0; i < lineIndex62; i++)
            {
                line62 = reader62.ReadLine();

            }

            
            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line6 + line62 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader6.Close();
            reader62.Close();
        }
        

        return;
        
    case 5:
        Console.WriteLine("Case 5");
        Random num522 = new Random(DateTime.Now.Millisecond);
        int treeNum5 = num522.Next(2);
        if (treeNum5 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader5 = new StreamReader("4letter.txt");
            string line5 = "";

            Random num5 = new Random();
            int lineIndex5 = num5.Next(filecount4);
            for (int i = 0; i < lineIndex5; i++)
            {
                line5 = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("alpha.txt");
            string line52 = "";
            Random num52 = new Random();
            int lineIndex52 = num52.Next(filecountAlpha);
            for (int i = 0; i < lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            
            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line5 + line52 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader5.Close();
            reader52.Close();
        }
        else if (treeNum5 == 1)
        {
           Console.WriteLine("rolled 1"); 
            StreamReader reader5 = new StreamReader("3letter.txt");
            string line5 = "";

            Random num5 = new Random();
            int lineIndex5 = num5.Next(filecount3);
            for (int i = 0; i < lineIndex5; i++)
            {
                line5 = reader5.ReadLine();
            }

            StreamReader reader52 = new StreamReader("2letter.txt");
            string line52 = "";
            Random num52 = new Random();
            int lineIndex52 = num52.Next(filecount2);
            for (int i = 0; i < lineIndex52; i++)
            {
                line52 = reader52.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line5 + line52 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader5.Close();
            reader52.Close();
        }

        return;
        
    case 4:
        Random num422 = new Random(DateTime.Now.Millisecond);
        int treeNum4 = num422.Next(1);
        if (treeNum4 == 0)
        {
            Console.WriteLine("Rolled 0");
            StreamReader reader4 = new StreamReader("2letter.txt");
            string line4 = "";

            Random num4 = new Random();
            int lineIndex4 = num4.Next(filecount2);
            for (int i = 0; i < lineIndex4; i++)
            {
                line4 = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("2letter.txt");
            string line42 = "";
            Random num42 = new Random();
            int lineIndex42 = num42.Next(filecount2);
            for (int i = 0; i < lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line4 + line42 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader4.Close();
            reader42.Close();
        }
        else if (treeNum4 == 1)
        {
            Console.WriteLine("Rolled 1");
            StreamReader reader4 = new StreamReader("3letter.txt");
            string line4 = "";

            Random num4 = new Random();
            int lineIndex4 = num4.Next(filecount3);
            for (int i = 0; i < lineIndex4; i++)
            {
                line4 = reader4.ReadLine();
            }

            StreamReader reader42 = new StreamReader("alpha.txt");
            string line42 = "";
            Random num42 = new Random();
            int lineIndex42 = num42.Next(filecountAlpha);
            for (int i = 0; i < lineIndex42; i++)
            {
                line42 = reader42.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line4 + line42 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader4.Close();
            reader42.Close();
        }

        return;
       
    case 3:
        Random num322 = new Random(DateTime.Now.Millisecond);
        int treeNum3 = num322.Next(1);
        if (treeNum3 == 0)
        {
            Console.WriteLine("rolled 0");
            StreamReader reader3 = new StreamReader("alpha.txt");
            string line3 = "";

            Random num3 = new Random();
            int lineIndex3 = num3.Next(filecountAlpha);
            for (int i = 0; i < lineIndex3; i++)
            {
                line3 = reader3.ReadLine();
            }

            StreamReader reader32 = new StreamReader("2letter.txt");
            string line32 = "";
            Random num32 = new Random();
            int lineIndex32 = num32.Next(filecount2);
            for (int i = 0; i < lineIndex32; i++)
            {
                line32 = reader32.ReadLine();

            }

            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line3 + line32 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);

            reader3.Close();
            reader32.Close();
        }
        else if (treeNum3 == 1)
        {
            Console.WriteLine("rolled 1");
            StreamReader reader3 = new StreamReader("3letter.txt");
            string line3 = "";

            Random num3 = new Random();
            int lineIndex3 = num3.Next(filecountAlpha);
            for (int i = 0; i < lineIndex3; i++)
            {
                line3 = reader3.ReadLine();
            }
            StreamReader special = new StreamReader("specials.txt");
            string specialLine = "";
           

            int specialLineIndex = num.Next(filecountSpecial);
            for (int i = 0; i < specialLineIndex; i++)
            {
                specialLine = special.ReadLine();
            }
            

            
            

            string subFinalLine = line3 + specialLine;
            for (int i = 0; i < numberCount; i++)
            {
                int numcounted = numCount.Next(0,10);
                numString += numcounted.ToString();
            }
            string finalLine = subFinalLine + numString;
            
            Console.WriteLine(finalLine);
            reader3.Close();
        }

        return;
    default:
        return;
    
    
    
    
    
    
    
    
}




