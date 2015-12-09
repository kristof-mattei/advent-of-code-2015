namespace AOC
{
    public abstract class BaseDay<TIn, TOut>
    {
        public BaseDay(TIn input)
        {
            this.Input = input;
        }

        protected TIn Input { get; set; }

        public abstract TOut Execute();
    }
}
