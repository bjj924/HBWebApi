using HBWebApi.Entities.Models;
using System;
using System.Threading.Tasks;

namespace HBWebApi.Domain.ArrayLogic
{
    public class CalculateArray : ICalculateArray
    {
        public Task<CharArrayResponse> Calculate(CharArray numbers)
        {
            CharArrayResponse result = new CharArrayResponse();

            try
            {
                int maxLength = numbers.FirstNumber?.Length > numbers.SecondNumber?.Length
                ? numbers.FirstNumber.Length
                : numbers.SecondNumber.Length;

                numbers.FirstNumber = numbers.FirstNumber.PadLeft(maxLength, '0');
                numbers.SecondNumber = numbers.SecondNumber.PadRight(maxLength, '0');

                var arrNum1 = numbers.FirstNumber.ToCharArray();
                var arrNum2 = numbers.SecondNumber.ToCharArray();
                Array.Reverse(arrNum2);

                string resultNumber = "";
                var carry = 0;
                for (int i = maxLength - 1; i >= 0; i--)
                {
                    if (!int.TryParse(arrNum1[i].ToString(), out int charNum1))
                    {
                        result.ErrorMessage = "The first number contains a non decimal value";
                        result.StatusCode = 400;
                        throw new Exception();
                    }
            
                    if (!int.TryParse(arrNum2[i].ToString(), out int charNum2))
                    {
                        result.ErrorMessage = "The second number contains a non decimal value";
                        result.StatusCode = 400;
                        throw new Exception();
                    }
                            
                    var tmpSum = charNum1 + charNum2 + carry;
                    var currentChar = tmpSum % 10;
                    resultNumber = currentChar.ToString() + resultNumber;

                    carry = tmpSum / 10;
                }

                result.Result = resultNumber;
                result.StatusCode = 200;
                return Task.FromResult(result);
            }
            catch (Exception)
            {
                return Task.FromResult(result);
            }
        }
    }
}
