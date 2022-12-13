namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void Showstatistics()
        {
            var result = 0.0;
            var hightGrade =  double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                hightGrade = Math.Max(number, hightGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;   
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {hightGrade}");
        }

        private List<double> grades; 
        private string name;
    }
}