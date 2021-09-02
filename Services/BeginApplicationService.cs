namespace practice.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class BeginApplicationService : IBeginApplication
    {
        private readonly ISort sortService;
        private readonly IDuplicates duplicatesService;
        private readonly INumberService numberService;

        public BeginApplicationService(
            ISort sortService,
            IDuplicates duplicatesService,
            INumberService numberService)
        {
            this.sortService = sortService;
            this.duplicatesService = duplicatesService;
            this.numberService = numberService;
        }

        public void StartApplication()
        {
            Console.WriteLine("Begin application here");

            // Call the methods here that you need to call
            // this.PlusOne();
            // this.ShowDuplicateNumbers();
            // this.WriteDistinctSortedValues();
        }

        private void PlusOne()
        {
            // You are given a large integer represented as an integer array digits, 
            // where each digits[i] is the ith digit of the integer. 
            // The digits are ordered from most significant to least significant in left-to-right order. 
            // The large integer does not contain any leading 0's.

            // Increment the large integer by one and return the resulting array of digits.
            var numbers = new List<int> { 6, 9, 9 };

            var result = this.numberService.AppendArrayOfNumbers(numbers);

            foreach (var value in result)
            {
                Console.Write(value + " ");
            }
        }

        private void ShowDuplicateNumbers()
        {
            // Given an array of numbers, print out the number that has duplicates in the given array 
            var numbers = new List<int> { 1, 2, 3, 1 };
            if (this.duplicatesService.HasDuplicates(numbers))
            {
                var duplicatesFound = this.duplicatesService.GetDuplicates(numbers);

                foreach (var found in duplicatesFound)
                {
                    Console.WriteLine($"Found Duplicate: {found}");
                }
            }

        }

        private void WriteDistinctSortedValues()
        {
            // Given an integer array nums sorted in non descending order, remove the duplicates in place such that each unique elements appears only once.
            // The relative order of elements should be kept the same

            var numbers = new List<int> { 6, 6, 1, 3, 0, 4, 4, 8, 2, 6, 7 };

            var sorted = this.sortService.SortAscending(numbers);

            var distinct = this.duplicatesService.RemoveDuplicates(sorted);

            foreach (var value in distinct)
            {
                Console.WriteLine(value);
            }
        }
    }
}


