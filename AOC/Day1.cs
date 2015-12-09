namespace AOC
{
    using System.Linq;

    public class Day1 : BaseDay<string, int>
    {
        public override int Execute()
        {
            var up = this.Input.Count(e => e == '(');
            var down = this.Input.Count(e => e == ')');

            return up - down;
        }

        public Day1(string input)
            : base(input)
        {
        }
    }
}
