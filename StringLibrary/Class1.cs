using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringLibrary
{

    public static class StringLibrary
    {
        
        #region EuclideanAlgorithm

        public static int EuclidAlgorithm(int firstNumber, int secondNumber)
        {
            int temp;
            while (secondNumber != 0)
            {
                temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }
            return Math.Abs(firstNumber);
        }


         


        #region BinaryEuclideanAlgorithm

        public static int BinaryEuclidAlgorithm(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return secondNumber;
            }
            if (secondNumber == 0)
            {
                return firstNumber;
            }
            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }
            if (firstNumber == 1 || secondNumber == 1)
            {
                return 1;
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                return 2 * BinaryEuclidAlgorithm(firstNumber >> 1, secondNumber >> 1);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return BinaryEuclidAlgorithm(firstNumber >> 1, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return BinaryEuclidAlgorithm(firstNumber, secondNumber >> 1);
            }
            if (firstNumber % 2 != 0 && secondNumber % 2 != 0 && firstNumber > secondNumber)
            {
                return BinaryEuclidAlgorithm((firstNumber - secondNumber) >> 1, secondNumber);
            }
            if (firstNumber % 2 != 0 && secondNumber % 2 != 0 && firstNumber < secondNumber)
            {
                return BinaryEuclidAlgorithm((secondNumber - firstNumber) >> 1, firstNumber);
            }
            return 0;
        }






        #endregion

        #region Newton method        

        public static double Radical(double number, int power, double accuracy)
        {
            if (number < 0 && power % 2 == 0 || power == 0) throw new ArgumentException();
            if (number == 0) return 0;
            double x = 0, result = 1;
            do
            {
                x = result;
                result = ((power - 1) * x + number / Math.Pow(x, power - 1)) / power;

            } while (Math.Abs(x - result) > accuracy);
            return result;
        }
        #endregion




    } }
#endregion}