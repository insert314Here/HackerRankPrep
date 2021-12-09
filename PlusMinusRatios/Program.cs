List<int> arr = new List<int>();
arr.Add(1);
arr.Add(1);
arr.Add(0);
arr.Add(-1);
arr.Add(-1);


plusMinus(arr);

static void plusMinus(List<int> arr)
{
    //need to have the length of the list for ratio
            //int listLength = 0;
            //for (int i = 0; i < arr.Count() + 1; i++)
            //{
            //    listLength += i;
            //}

    //iterate through list to find negatives, positives, and zero
    List<int> negative = new List<int>();
    List<int> positive = new List<int>();
    List<int> zero = new List<int>();
    foreach (int numb in arr)
    {
        if (numb < 0)
        {
            negative.Add(numb);
        }
        else if (numb == 0)
        {
            zero.Add(numb);
        }
        else
        {
            positive.Add(numb);
        }
    }

    //positive ratio
    decimal posRatio = 0;
    decimal posCount = positive.Count();
    posRatio = posCount / arr.Count();
    Console.WriteLine(posRatio.ToString("N6"));

    //negative ratio
    decimal negRatio = 0;
    decimal negCount = negative.Count();
    negRatio = negCount / arr.Count();
    Console.WriteLine(negRatio.ToString("N6"));

    //zero ratio
    decimal zeroRatio = 0;
    decimal zeroCount = zero.Count();
    zeroRatio = zeroCount / arr.Count();
    Console.WriteLine(zeroRatio.ToString("N6"));

}