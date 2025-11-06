using System.Diagnostics;

/* Fix me */
List<string> listOfStrings = new List<string> { "13", "Candy", "Mike Myers", true, #FF5F1F, 1978 };


Debug.Assert(NextOnAThursday() == 2031);

int NextOnAThursday()
{
    throw new NotImplementedException();
}

List<int> pileSizes = new List<int> { 4, 9, 11, 17 };
int numHours = 8;



Debug.Assert(EatingSweets(pileSizes, numHours) == 6);

int CuttingChocolate(int cuts) {
	return 0;
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
    return false;
}