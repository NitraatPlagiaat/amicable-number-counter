// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

List<double> pairMembers = new List<double>();

for (int i = 220; i < 100000; i++)
{
    double total = 0;
    double pivot = i;

    if (!pairMembers.Contains(i))
    {
        for (int j = 0; j < 2; j++)
        {
            if (j == 1)
            {
                pivot = total;
            }
            List<double> numbers = divider(pivot);
            total = countSum(numbers);
        }
        if (total == i && i != pivot)
        {
            Console.WriteLine(i + " | " + pivot);
            pairMembers.Add(pivot);
        }
    }
}

double countSum(List<double> numbers)
{
    double total = 0;

    for (int i = 1; i < numbers.Count; i++)
    {
        total = total + numbers[i];
    }
    return total;
}

List<double> divider(double number)
{
    List<double> wholeNumbers = new List<double>();

    for (int i = 1; i <= number; i++)
    {
        double sum = number / i;

        if (sum % 1 == 0)
        {
            wholeNumbers.Add(sum);
        }
    }
    return wholeNumbers;
}