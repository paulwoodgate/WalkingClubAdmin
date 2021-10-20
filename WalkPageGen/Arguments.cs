using System;

namespace WalkPageGen
{
    public class Arguments
    {
        public int Year { get; set; }
        public string Filename { get; set; }

        public Arguments()
        {

        }

        public static Arguments Format(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("You must pass 2 arguments to the generator, the year and the name of the file to be created");
            }

            var arguments = new Arguments
            {
                Year = FormatYear(args[0]),
                Filename = args[1]
            };

            return arguments;
        }

        private static int FormatYear(string yearValue)
        {
            int minYear = 2017;

            if (!int.TryParse(yearValue, out int year))
            {
                throw new ArgumentException("The first argument must be numeric");
            }

            if (year < minYear)
            {
                throw new ArgumentException($"The year must not be before {minYear}");
            }
            if (year > DateTime.Now.Year + 1)
            {
                throw new ArgumentException("The year must not be after next year");
            }

            return year;
        }
    }
}