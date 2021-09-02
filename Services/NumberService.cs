namespace practice.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class NumberService : INumberService
    {
        public IEnumerable<int> AppendArrayOfNumbers(IEnumerable<int> numbers)
        {
            var joinedString = string.Join(string.Empty, numbers.Select(x => x.ToString()));
            var number = int.Parse(joinedString) + 1;
            var newSplitNumbers = number.ToString().Select(x => int.Parse(x.ToString()));
            return newSplitNumbers;
        }
    }
}


