namespace AOC
{
    using System;
    using System.Linq;

    public class Day3 : BaseDay<string, int>
    {
        public override int Execute()
        {
            var splitted = this.Input.Split(new[] { '\n' },
                                            StringSplitOptions.RemoveEmptyEntries);


            return splitted.Aggregate(0, (acc, e) => acc + CalculateSheetRequired(e));
        }

        private static int CalculateSheetRequired(string packageSize)
        {
            var lwh = packageSize.Split('x');

            var l = int.Parse(lwh[0]);
            var w = int.Parse(lwh[1]);
            var h = int.Parse(lwh[2]);

            var sidelw = l * w;
            var sidewh = w * h;
            var sidehl = h * l;

            return 2 * sidelw + 2 * sidewh + 2 * sidehl + new[] { sidelw, sidewh, sidehl }.Min();
        }

        public Day3(string input)
            : base(input)
        {
        }
    }
}
