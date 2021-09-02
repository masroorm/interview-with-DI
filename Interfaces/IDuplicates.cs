namespace practice.Interfaces
{
    using System.Collections.Generic;
    public interface IDuplicates
    {
        abstract IEnumerable<int> RemoveDuplicates(IEnumerable<int> numbers);

        abstract bool HasDuplicates(IEnumerable<int> numbers);

        abstract IEnumerable<int> GetDuplicates(IEnumerable<int> numbers);
    }
}


