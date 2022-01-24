namespace Rumini.Entities
{
    internal class PlayerStrategy
    {
        /// <summary>
        /// True = better, except for 6 players
        /// </summary>
        public bool AlsoThrowAwayCardInTurnBeforeLast { get; set; } = false;

        public int DelayInvestingCards { get; set; } = 0;

        public bool DoNotThrowAwayCards { get; set; } = false;

        public int InvestingCardsLimit { get; set; } = 1;

        /// <summary>
        /// False = better
        /// </summary>
        public bool ThrowAwayCheapCards { get; set; } = false;

        public bool ThrowAwayCheapSceneCards { get; set; } = false;

        public bool ThrowAwayDuplicates { get; set; } = false;

        /// <summary>
        /// True = better, except for 6 players
        /// </summary>
        public bool ThrowAwayExpensiveCards { get; set; } = false;

        public bool ThrowAwayExpensiveSceneCards { get; set; } = false;
    }
}