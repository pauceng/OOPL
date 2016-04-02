private int GreatestCommonDivisor()
{
    int temp, greater = numerator,smaller = denominator;
    if (numerator > denominator)
    {
        greater = numerator; smaller = denominator;
    }
    else
    {
        greater = denominator; smaller = numerator;
    }
    while (smaller != 0)
    {
        temp = greater;
        greater = smaller;
        smaller = temp % smaller;  
    }
    return greater;
}