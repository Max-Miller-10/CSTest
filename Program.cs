using System.Diagnostics;
using System.Runtime.InteropServices;

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", "true", "#FF5F1F", "1978" };

Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    const int THURS = 4;
    int year = 2025;

    while (true)
    {
        if ((int)new DateTime(++year, 11, 6).DayOfWeek == THURS) //Increment before checking
        {
            return year;
        }
    }
}

List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;

int EatingSweets(List<int> pileSizes, int numHours)
{
    float sph = 1;
    while (true)
    {
        int time = 0;
        foreach (int pile in pileSizes)
        {
            time += (int)Math.Ceiling(pile / sph);
        }
        if (time <= numHours)
        {
            return (int)sph;
        }
        else
        {
            sph++;
        }
    }
}

Debug.Assert(EatingSweets(pileSizes, numHours) == 6);

int CuttingChocolate(int cuts)
{
    int midpoint = cuts / 2;
    if (cuts % 2 == 0) //If even number of cuts
    {
        return midpoint * midpoint;
    }
    else //If odd number of cuts
    {
        return midpoint * (midpoint + 1);
    }
}

Debug.Assert(CuttingChocolate(5) == 6);
Debug.Assert(CuttingChocolate(6) == 9);
Debug.Assert(CuttingChocolate(7) == 12);
Debug.Assert(CuttingChocolate(8) == 16);

// Note the exclamation marks showing not, so False 
Debug.Assert(!ValidatePassword("ABCdef")); // too short
Debug.Assert(!ValidatePassword("ABCABC12!")); // duplicates, doesn't divide by 11
Debug.Assert(!ValidatePassword("ABCabcde!")); // no digit 
Debug.Assert(!ValidatePassword("ABCdef12!")); // doesn't divide by 11 
Debug.Assert(ValidatePassword("ABCdef12&")); // should succeed 


bool ValidatePassword(string candidate)
{
    const int MIN_LEN = 8;
    const int MAX_LEN = 32;
    const int SUM_MULT = 11;
    List<char> chars = candidate.ToList();


    if (candidate.Length < MIN_LEN || candidate.Length > MAX_LEN) { return false; }

    if (!chars.Any(char.IsUpper)) { return false; }
    if (!chars.Any(char.IsLower)) { return false; }
    if (!chars.Any(char.IsDigit)) { return false; }

    if (!chars.GroupBy(s => s).All(group => group.Count() == 1)) { return false; } // Ensure no element appears more than once
    if (chars.Sum(c => (int)c) % SUM_MULT != 0) { return false; } //Ensure the sum of the ascii codes is a multiple of 11

    return true;
}