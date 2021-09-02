namespace practice.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class RemoveDuplicatesService : IRemoveDuplicates
    {
        public IEnumerable<int> RemoveDuplicates(IEnumerable<int> numbers)
        {
            return numbers.Distinct();
        }
    }
}


