namespace Rumini.Entities
{
    internal class PlayerStrategy
    {
        public int DelayInvestingCards { get; set; } = 0;

        public int InvestingCardsLimit { get; set; } = 1;

        public bool ThrowAwayCheapCards { get; set; } = false;

        public bool ThrowAwayCheapSceneCards { get; set; } = false;

        public bool ThrowAwayDuplicates { get; set; } = false;

        public bool ThrowAwayExpensiveCards { get; set; } = false;

        public bool ThrowAwayExpensiveSceneCards { get; set; } = false;
    }
}