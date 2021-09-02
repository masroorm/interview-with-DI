namespace practice.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class DuplicatesService : IDuplicates
    {
        public bool HasDuplicates(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Any(x => x.Count() > 1);
        }

        public IEnumerable<int> RemoveDuplicates(IEnumerable<int> numbers)
        {
            return numbers.Distinct();
        }

        public IEnumerable<int> GetDuplicates(IEnumerable<int> numbers)
        {
            var result = default(IEnumerable<int>);

            var grouped = numbers.GroupBy(x => x);

            if (grouped.Any(x => x.Count() > 1))
            {
                result = grouped.Where(x => x.Count() > 1).Select(x => x.Key);
            }

            return result;
        }
    }
}


