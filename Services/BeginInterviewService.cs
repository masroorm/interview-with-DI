namespace practice.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using practice.Interfaces;

    public class BeginInterviewService : IBeginInterview
    {
        private readonly ISort sortService;
        private readonly IDuplicates duplicatesService;

        public BeginInterviewService(
            ISort sortService,
            IDuplicates duplicatesService)
        {
            this.sortService = sortService;
            this.duplicatesService = duplicatesService;
        }

        public void StartInterviewQuestions()
        {
            Console.WriteLine("Begin interview questions");



            // Call the methods here that you need to call
            // this.PlusOne();
            // this.HasDuplicateNumbers();
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

            // Move this to a service that increments the numbers
            var joinedString = string.Join(string.Empty, numbers.Select(x => x.ToString()));
            var number = int.Parse(joinedString) + 1;
            var newSplitNumbers = number.ToString().Select(x => int.Parse(x.ToString()));

            foreach (var value in newSplitNumbers)
            {
                Console.Write(value + " ");
            }
        }

        private void HasDuplicateNumbers()
        {
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


