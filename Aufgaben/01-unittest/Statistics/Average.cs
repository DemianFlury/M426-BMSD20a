using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count == 0) throw new ArgumentException();
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return ((double)sum / numbers.Count);
        }

        public double Median(List<int> numbers)
        {
            numbers.Sort();
            int index;
            if (numbers.Count == 0)
                throw new ArgumentException();

            else if(numbers.Count % 2 == 1)
            {
                index = numbers.Count / 2;
                return numbers[index];
            }

            else
            {
                index = numbers.Count / 2;
                double median = numbers[index] + numbers[index -1];
                median /= 2;
                return median;
            }
        }
    }
}
