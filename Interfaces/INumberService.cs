namespace practice.Interfaces
{
    using System.Collections.Generic;
    public interface INumberService
    {
        abstract IEnumerable<int> AppendArrayOfNumbers(IEnumerable<int> numbers);
    }
}