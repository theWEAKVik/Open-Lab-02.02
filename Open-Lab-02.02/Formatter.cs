using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
          string vratit = null;
          for (int i = 0; i < 5; i++)
          {
                numbers[i] = Math.Round(numbers[i], 2,MidpointRounding.AwayFromZero);
                vratit = vratit + numbers[i].ToString() + "";
          }
            Console.Write(vratit.Replace(",", "."));
        }
    }
}
