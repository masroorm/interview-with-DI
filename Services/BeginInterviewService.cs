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
            this.HasDuplicateNumbers();
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


