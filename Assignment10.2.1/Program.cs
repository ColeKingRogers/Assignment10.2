namespace Assignment10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProblemOne(new List<int> { 2, -1, 3, -3, 10, -200 });

            Employee emp = new Employee();
            List<Employee> employees = emp.CreateData();
            ProblemTwo(employees);

            ProblemThree(new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" });

            ProblemFour(new List<int> { 55, 200, 740, 76, 230, 482, 95 });
        }

        static void ProblemOne(List<int> numb1)
        {
            var result = (from n in numb1
                          where n > -1
                          orderby n ascending
                          select n).ToList();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void ProblemTwo(List<Employee> employees)
        {
            var result = (from emp in employees
                          where emp.Age < 30 && emp.Salary > 5000
                          orderby emp.Salary ascending
                          select new { emp.Age, emp.Salary });
            foreach (var item in result)
            {
                Console.WriteLine($"Salary: {item.Salary}, Age: {item.Age}");
            }
        }
        static void ProblemThree(List<string> citys)
        {
            var result = (from city in citys
                          where city.StartsWith("A") && city.EndsWith("M")
                          select city);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void ProblemFour(List<int> numb2)
        {
            var result = (from n in numb2
                          where n > 80
                          select n);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
