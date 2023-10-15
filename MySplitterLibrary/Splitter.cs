using System;

namespace MySplitterLibrary
{
    public class Splitter
    {
        public decimal SplitAmount(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("Number of people must be greater than 0.");
            }

            if (amount < 0)
            {
                return 0; // Handle negative amounts by returning 0 per person.
            }

            return amount / numberOfPeople;
        }
    }
}
