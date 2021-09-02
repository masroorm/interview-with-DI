namespace practice.Interfaces
{
    using System.Collections.Generic;
    public interface ISort
    {
        abstract IEnumerable<int> SortAscending(IEnumerable<int> numbers);

        abstract IEnumerable<int> SortDescending(IEnumerable<int> numbers);
    }
}


