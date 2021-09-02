namespace practice.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class SortService : ISort
    {
        public IEnumerable<int> SortAscending(IEnumerable<int> numbers)
        {
            return numbers.OrderBy(x => x);
        }

        public IEnumerable<int> SortDescending(IEnumerable<int> numbers)
        {
            return numbers.OrderByDescending(x => x);
        }
    }
}


