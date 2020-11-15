using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            // #6. Replace the method code to throw an "ArgumentNullException" exception if the "obj" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            // #7. Replace the method code to throw an "ArgumentNullException" exception if the "obj1" or "obj2" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj1 == null)
            {
                throw new ArgumentNullException(nameof(obj1));
            }
            else if (obj2 == null)
            {
                throw new ArgumentNullException(nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            // #8. Replace the method code to throw an "ArgumentNullException" exception if the "str" parameter is null or equals to ""; otherwise return "str" value. Use string.IsNullOrEmpty method. Use "nameof" expression to get a parameter name for an exception constructor.
            return string.IsNullOrEmpty(str) ? throw new ArgumentNullException(nameof(str)) : str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            // #9. Replace the method code to throw an "ArgumentNullException" exception if the "str1" or "str2" parameter is null or equals to ""; otherwise return a concatenation of "str1" and "str2" strings. Use string.Concat method to concatenate "str1" and "str2" strings. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1));
            }
            else if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2));
            }
            else
            {
                return string.Concat(str1, str2);
            }
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            // #10. Replace the method code to throw an "ArgumentException" exception if a value of the "evenNumber" parameter is not even; otherwise return a "evenNumber" value. Use "nameof" expression to get a parameter name for an exception constructor.
            return evenNumber % 2 == 0 ? evenNumber : throw new ArgumentException(string.Empty, nameof(evenNumber));
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            // #11. Replace the method code to throw an "ArgumentOutOfRange" exception if a value of the "candidateAge" parameter is less than 16 or greater then 63 (for a male candidate) or 58 (for a female candidate); otherwise return "candidateAge" value. Use "nameof" expression to get a parameter name for an exception constructor.
            return candidateAge switch
            {
                int _ when isCandidateWoman && (candidateAge < 16 || candidateAge > 58) => throw new ArgumentOutOfRangeException(nameof(candidateAge)),
                int _ when candidateAge < 16 || candidateAge > 63 => throw new ArgumentOutOfRangeException(nameof(candidateAge)),
                _ => candidateAge,
            };
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            // #12. Add new code to the method to validate method parameters and throw exceptions in case of validation errors:
            // * Throw "ArgumentOutOfRangeException" exception if "day" parameter is less then 1 or greater then 31.
            // * Throw "ArgumentOutOfRangeException" exception if "month" parameter is less then 1 or greater then 12.
            // * Throw "ArgumentNullException" exception if "username" parameter is null or equals to "".
            // Use "nameof" expression to get a parameter name for an exception constructor.
            return $"{username}-{day}{month}" switch
            {
                string _ when day < 1 || day > 31 => throw new ArgumentOutOfRangeException(nameof(day)),
                string _ when month < 1 || month > 12 => throw new ArgumentOutOfRangeException(nameof(month)),
                string _ when string.IsNullOrEmpty(username) => throw new ArgumentNullException(nameof(username)),
                _ => $"{username}-{day}{month}",
            };
        }
    }
}
