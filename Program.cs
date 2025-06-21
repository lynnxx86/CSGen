using PassgenConsole;



Console.WriteLine(">>=========================================<<\n||    ____                  ______         ||\n||   / __ \\____ ___________/ ____/__  ____ ||\n||  / /_/ / __ `/ ___/ ___/ / __/ _ \\/ __ \\||\n|| / ____/ /_/ (__  |__  ) /_/ /  __/ / / /||\n||/_/    \\__,_/____/____/\\____/\\___/_/ /_/ ||\n>>=========================================<<");
Console.WriteLine("Welcome to PassGen!");
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
  



Random rand = new Random(DateTime.Now.Millisecond);
Random randomAdder = new Random(DateTime.Now.Millisecond);
string numString = "";

Random divide = new Random(DateTime.Now.Second);
int divisor = divide.Next(1,7);
//int divisor = 8;
/* I need to add support for higher letter counts and cap them eventually. This is the flaw of my design;
this produces much more sensible passwords than my previous design at the cost of limiting size. But how large of a password is
    the average person going to use anyways?
    
    */
int index = letterCount /  divisor;
string[] alpha = File.ReadAllLines("alpha.txt");
string[] twoLetter = File.ReadAllLines("2letter.txt");
string[] threeLetter = File.ReadAllLines("3letter.txt");
string[] fourLetter = File.ReadAllLines("4letter.txt");
string[] fiveLetter = File.ReadAllLines("5letter.txt");
string[] sixLetter = File.ReadAllLines("6letter.txt");
string[] sevenLetter = File.ReadAllLines("7letter.txt");
string[] specials = new string[] { "!", "@", "#","$","%","^","&","*","(",")","?","/",">","<" };
int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
string[][] letterArrays = new string[][]
{
    alpha,
    twoLetter,
    threeLetter,
    fourLetter,
    fiveLetter,
    sixLetter,
    sevenLetter,
};
    
/*Do (ii + ii) + (iiii) to build to howMany. The amount of ii's in (ii+ii) should equal the divisor, for example, i/3 should be (iii + iii + iii) */
//divisor = 1;
Console.WriteLine("Divisor: " + divisor);
Console.WriteLine("letterCount: " + letterCount);
double ii = (double)letterCount / divisor;
if (ii < 1)
{
    Console.WriteLine("Inorganic loopA");
    ii = letterCount / divisor + 1;
}
double iiB = letterCount % divisor;
//if (iiB < 1)
//{
  //  Console.WriteLine("Inorganic loopB");
    //iiB = letterCount % divisor + 1;
//}
int fileGrab1 = (int)Math.Floor(ii);
int fileGrab2 = (int)Math.Floor(iiB);
int adder = randomAdder.Next(1,6);
int adder2 = randomAdder.Next(1,5);
if (fileGrab1 == 0)
{
    fileGrab1 += 2 + adder;
}

if (fileGrab2 == 0)
{
    fileGrab2 += 2 + adder2;
}
Console.WriteLine("filegrab: " + fileGrab1);
		
Console.WriteLine("filegrab2: " + fileGrab2);
double foo = 0;
for (int i = 0; i < divisor; i++)
{
    foo += fileGrab1;
}
foo += fileGrab2;
string empty = "";
string empty2 = "";
if (foo > letterCount)
{
    double diff = foo - letterCount;
    foo += foo - diff;
}

 

Console.WriteLine("foo: " + foo);
string[] selectedArray = alpha;
string[] selectedArray2 = twoLetter;
//fileGrab1 = 3;
//fileGrab is ii after Math.Floor, ii is letterCount / divisor
Console.WriteLine("LINE 149 fileGrab1: " + fileGrab1);
//double that = divisor * fileGrab1;
//double caseNum = 0;
if (fileGrab1 * divisor == letterCount)
{
    switch (letterCount)
    {
        case 1:

            selectedArray = alpha;
            break;
        case 2:
            selectedArray = twoLetter;
            break;
        case 3:
            selectedArray = threeLetter;
            break;
        case 4:
            selectedArray = fourLetter;
            break;
        case 5:
            selectedArray = fiveLetter;
            break;
        case 6:
            /*casenum = that/fileGrab
             selectedArray = casenum

             */
            selectedArray = sixLetter;
            break;
        case 7:
            selectedArray = sevenLetter;
            break;
        case 8:
            selectedArray = fourLetter;
            break;

            
        default:
            Environment.Exit(4);
            break;
    }

    fileGrab2 = 0;
}
if (fileGrab1 * divisor != letterCount)
{
    Console.WriteLine("index: " + index);
    switch (letterCount /  divisor)
    {
        case 1:
            index = fileGrab1 * divisor;

           selectedArray = letterArrays[index -1]; 
            break;
        case 2:
            selectedArray = letterArrays[index - 1];
            break;
        case 3:
            selectedArray = letterArrays[index - 1];
            break;
        case 4:
            selectedArray = letterArrays[index - 1];
            break;
        case 5:
            selectedArray = letterArrays[index - 1];
            break;
        case 6:
            
            selectedArray = letterArrays[index - 1];
            break;
        case 7:
            selectedArray = letterArrays[index - 1];
            break;
        default:
            Environment.Exit(4);
            break;
    }




    switch (fileGrab2)
    {
        case 1:
            
            
                
            
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 2:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 3:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 4:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 5:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 6:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 7:
            selectedArray2 = letterArrays[fileGrab2 -1];
            break;
        case 0:
            break;
        default:
            Environment.Exit(4);
            break;

    }
}
Console.WriteLine("Updated filegrab2: " + fileGrab2);


int arrayLen = selectedArray.Length;
Console.WriteLine("Array Length: " + arrayLen);


string final = "";
//Console.WriteLine("fileGrab1: " + fileGrab1);
//Console.WriteLine("fileGrab2: " + fileGrab2);

//We need to replace the fileGrabs in the loops with a better calculated value

//I gotta straighten this shit out
Console.WriteLine("fileGrab1 going into loops:  " + fileGrab1);
Console.WriteLine("fileGrab2 going into loops:  " + fileGrab2);
int ix = fileGrab1 - fileGrab2;
int ixx = fileGrab1 - ix + 1;
Console.WriteLine("ix: " + ix);
Console.WriteLine("ixx: " + ixx);
for (int i = 0; i < ixx; i++)
{
    string word = selectedArray[rand.Next(selectedArray.Length)];
    final += word;
    Console.WriteLine(word);
}

for (int i = 0; i < fileGrab2; i++)
{
    string word2 = selectedArray2[rand.Next(selectedArray2.Length)];
    final += word2;
    Console.WriteLine(word2);
}
Console.WriteLine("final: " + final);







//lynnxx