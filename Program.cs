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
Random rand2 = new Random(DateTime.Now.Millisecond);
Random randomAdder = new Random(DateTime.Now.Millisecond);
string numString = "";

Random divide = new Random(DateTime.Now.Second);
int divisor = divide.Next(1,7);
//int divisor = 4;
/* I need to add support for higher letter counts and cap them eventually. This is the flaw of my design;
this produces much more sensible passwords than my previous design at the cost of limiting size. But how large of a password is
    the average person going to use anyways?
    
    */
double idx = letterCount / divisor;
int index = (int)Math.Floor(idx);
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
    double diff2 = foo - letterCount;
    foo += foo - diff2;
}

int augment = 0;

Console.WriteLine("foo: " + foo);
string[] selectedArray = alpha;
string[] selectedArray2 = twoLetter;
string[] selectedArray3 = alpha;
string[] subSelectedArray1 = fourLetter;
//fileGrab1 = 3;
//fileGrab is ii after Math.Floor, ii is letterCount / divisor
Console.WriteLine("LINE 149 fileGrab1: " + fileGrab1);
//double that = divisor * fileGrab1;
//double caseNum = 0;
bool defaultSplit = false;
int diff = 0;
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

        default:
            defaultSplit = true;
            Console.WriteLine("Defaulted");
            int aug1 = letterCount - 6;
            int aug2 = letterCount - aug1;
            Console.WriteLine("aug1: " + aug1);
           
           
            selectedArray = letterArrays[aug2];
            
            if (aug2 < letterCount)
            {
                diff = letterCount - aug2 -1;
                if (diff % letterCount == 1)
                {
                    diff = 0;
                }
                subSelectedArray1 = letterArrays[diff];
            }
           // subSelectedArray1 = letterArrays[aug2];
            break;
    } fileGrab2 = 0;
}
if (fileGrab1 * divisor != letterCount)
{
    Console.WriteLine("index: " + index);
    switch (letterCount /  divisor)
    {
        case 1:
            index = fileGrab1 * divisor -1;

            selectedArray = letterArrays[index];
            if (index > letterArrays.Length)
            {
                int indexDif = index - letterArrays.Length;
                index -= indexDif;
            }
            
            Console.WriteLine("Negative Index :" + index);
            if (index - 1 < 0)
            {
                index += 2;
            }
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

Console.WriteLine("selectedArray: "  + selectedArray);


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
Console.WriteLine("selectedArray2: " + selectedArray2);
/*I don't remember why I did the fileGrab2--; but  I'll leave it...for now*/
fileGrab2--;
Console.WriteLine("Updated filegrab2: " + fileGrab2);
/*I'm sure I had a reason*/

int arrayLen = selectedArray.Length;
Console.WriteLine(selectedArray);
Console.WriteLine("Array Length: " + arrayLen);


string final = "";



//I gotta straighten this shit out
Console.WriteLine("fileGrab1 going into loops:  " + fileGrab1);
Console.WriteLine("fileGrab2 going into loops:  " + fileGrab2);

/*
 *  filegrab is the quantity, divisor is the index,
 * unless divisor is 1?
 *  
 * 
 */
if (divisor == 1)
{
    for (int i = 0; i < divisor; i++)
    {
        Console.WriteLine("divisor == 1");
        string word = selectedArray[rand.Next(selectedArray.Length)];
        final += word;
        Console.WriteLine("Divisor1" + word);
    }
}

if (divisor == 2)
{
    for (int i = 0; i < divisor; i++)
    {
        Console.WriteLine("divisor == 2");
        string word = selectedArray[rand.Next(selectedArray.Length)];
        final += word;
        Console.WriteLine("Divisor2: " + word);
    }
}

if (letterCount < 10)
{
    if (letterCount == 8 | letterCount == 9)
    {
        Console.WriteLine("defaultSplit");
        for (int i = 0; i < 1; i++)
        {
            string word  = selectedArray[rand.Next(selectedArray.Length)];
            string word2 = subSelectedArray1[rand.Next(diff)];
            string words = word + word2;
            final += words;
            Console.WriteLine("DefaultSplit: " + words);
        }
    }
    else
    {


        Console.WriteLine("Under 10");
        for (int i = 0; i < fileGrab1; i++)
        {
            string word = selectedArray[rand.Next(selectedArray.Length)];
            // string word2 = selectedArray[rand2.Next(selectedArray.Length)];
            //string words = word + word2;
            final += word;
            Console.WriteLine(word);
        }

/*This is printing too many words on occasion*/
        for (int i = 0; i < fileGrab2; i++)
        {
            string word2 = selectedArray2[rand.Next(selectedArray2.Length)];
            final += word2;
            Console.WriteLine(word2);
        }
    }
}

if (letterCount >= 10)
{
    Console.WriteLine("Over 10");
    string aug = selectedArray3[rand.Next(selectedArray3.Length)];
    for (int i = 0; i < fileGrab1; i++)
    {
        string word = selectedArray[rand.Next(selectedArray.Length)] + subSelectedArray1[rand.Next(subSelectedArray1.Length)];
        final += word;
        Console.WriteLine(word);
    }

    for (int i = 0; i < fileGrab2; i++)
    {
        string word2 = selectedArray2[rand.Next(selectedArray2.Length)];
        final += word2;
        Console.WriteLine(word2);
    }

    final += aug;
}

bool loggy = false;
Console.WriteLine("final: " + final);
Console.WriteLine("Would you like to leave a log?");
string log = Console.ReadLine();
string logLow = log.ToLower();
if (log == "y")
{
    loggy = true;
}

if (loggy == true)
{
    Logger entry = new Logger
    {
        LogHowMany = howMany,
        LogDivisor = divisor,
        LogletterCount = letterCount.ToString(),
        LogNumCount = numberCount,
        LogSpecialsCount = specialCount,
        LogfileGrab1 = fileGrab1,
        LogfileGrab2 = fileGrab2,
        Logfinal = final
    };

    entry.SaveToFile();
}
//in the future you'll be able to generate multiple passwords




//lynnxx