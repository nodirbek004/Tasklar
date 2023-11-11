using System.Linq;

namespace Tasklar._22Vazifa;

public class Linq
{
    public class Homework_22_10_2023
    {
        public static void task1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            var result = numbers.Where(x => x % 2 == 0);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task2()
        {
            var numbers = new List<int>() { 3, -3, 5, 6, 7, 8, -7, 9, 10, -10, 11, 12, -11, 13, 14, };
            var result = numbers.Where(x => x > 0).Where(x => x < 10);
            PrintValues(result);
        }
        public static void task3()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var result = numbers.Select(x => new { number = x, square = x * x });
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task4()
        {
            var numbers = new List<int>() { 1, 2, 3, 3, 4, 3, 2, 1, 2, 1, 1, 1, 1, };
            var result = numbers.GroupBy(x => x);
            foreach (var x in result)
            {
                Console.WriteLine("Number {0} appears {1} times", x.Key, x.Count());
            }
        }
        public static void task5()
        {
            var inputstr = "an apple a day, very useful vitamins";
            var result = inputstr.GroupBy(x => x);
            foreach (var x in result)
            {
                Console.WriteLine("Character {0}: {1} times", x.Key, x.Count());
            }
        }
        public static void task6()
        {
            var daysofweek = new string[] { "monday", "tuesday", "wednesday", "thursday", "firday", "saturday", "sunday" };
            var text = "Monday morning arrived with a sense of urgency as people rushed to start their week. The office buzzed with activity as colleagues greeted each other and discussed their weekend adventures. By Tuesday, the initial burst of energy had settled into a steady rhythm, and meetings filled the calendar. Wednesday arrived, bringing a midweek slump that was quickly remedied by the promise of Friday just around the corner. Thursday was a day of anticipation, as plans for the upcoming weekend began to take shape. Finally, Friday arrived with a surge of excitement. The workday seemed to fly by, fueled by the anticipation of the weekend ahead. And just like that, Saturday and Sunday appeared, offering a much-needed break from the daily grind. People reveled in the freedom of the weekend, whether it was spent exploring new places, catching up on hobbies, or simply relaxing. But as Sunday evening approached, a tinge of melancholy settled in—a reminder that the weekend was coming to an end and Monday was waiting just beyond the horizon, ready to start the cycle anew.";
            var strarr = text.Split(' ', ',');
            var result = strarr.Where(x => daysofweek.Any(y => y == x.ToLower()));
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task7()
        {
            var numbers = new List<int>() { 1, 2, 3, 3, 4, 3, 2, 1, 2, 1, 1, 1, 1, };
            var result = numbers.GroupBy(x => x);
            foreach (var x in result)
            {
                Console.WriteLine("{0}  {1}  {2}", x.Key, x.Key * x.Count(), x.Count());
            }
        }
        public static void task8()
        {
            string text = "The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'";
            var strarr = text.Split(',', ' ', '\'');
            var result = strarr.Where(x => x.StartsWith('A') && x.EndsWith('M'));
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task9()
        {
            Random random = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                numbers.Add(random.Next(1, 100));
            }
            var result = numbers.Where(x => x > 80);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task10()
        {
            var numbers = new List<int>();
            Console.Write("Input the number of members on the List: ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
            repeat:
                Console.Write("Member {0} : ", i);
                bool check = int.TryParse(Console.ReadLine(), out int num);
                if (!check)
                {
                    Console.WriteLine("Please repeat last input");
                    goto repeat;
                }
                numbers.Add(num);
            }
        control:
            Console.Write("Input the value above you want to display the members of the List : ");
            bool checknew = int.TryParse(Console.ReadLine(), out int cont);
            if (!checknew)
            {
                Console.WriteLine("Please repeat");
                goto control;
            }
            var result = numbers.Where(x => x > cont);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task11()
        {
            var numbers = new List<int>() { 3, 4, 46, 64, 23, 76, 2353, 13, 3, 4, 4, 35, 4, 2, 32, 3, };
        task11:
            Console.Write("How many records you want to display ? :");
            bool check = int.TryParse(Console.ReadLine(), out int top);
            if (!check)
            {
                Console.WriteLine("Please repeat input");
                goto task11;
            }
            var result = numbers.OrderByDescending().Take(top);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        public static void task12()
        {
            // : belgisi qolib ketdi
            string text = "Input the string : this IS a STRING";
            var texts = text.Split(' ');
            var result = texts.Where(x => String.Equals(x, x.ToUpper()));
            PrintValues(result);
        }
        public static void task13()
        {
            Console.Write("Input number of strings to store in the array : ");
            var n = GetNumber();
            Console.WriteLine("Input {0} strings for the array : ", n);
            var words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element[{0}]: ", i);
                words[i] = Console.ReadLine();
            }
            PrintValues(words);
        }
        public static void task14()
        {
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : ");
            var n = GetNumber();
            var employees = Student.GetAllStudents;
            var result = employees.OrderBy(x => x.Contract).Take(n);
            PrintValues(result);
        }
        public static void task15()
        {
            string files = "aaa.frx, bbb.TXT, xyz.dbf,abc.pdf, aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt";
            var extensions = files.Split(',').ToList();

            var result = extensions.GroupBy(x => x.Trim()
                                                    .Split('.')[1]
                                                    .ToLower());
            foreach (var x in result)
            {
                Console.WriteLine("{0} File(s) with .{1} extension ", x.Count(), x.Key);
            }
        }
        public static void task16()
        {
            Console.Write("Papka yo'lini kiriting: ");
            string path = Console.ReadLine();
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles();
            var avg = files.Average(x => x.Length);
            Console.WriteLine($"O'rtacha {avg / Math.Pow(2, 20)} MB");
        }
        public static void task17()
        {
            Console.Write("Enter word to input: ");
            var items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
            var removeitem = Console.ReadLine().Trim();
            items.Remove(removeitem);
            PrintValues(items);
        }
        public static void task18()
        {
            Console.Write("Enter word to input: ");
            var items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
            var removeitem = Console.ReadLine().Trim();
            items.Remove(items.Find(x => string.Equals(x, removeitem)));
            PrintValues(items);
        }
        public static void task19()
        {
            //Console.Write("Enter word to input: ");
            //var items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
            //var removeitem = Console.ReadLine().Trim();
            //items.RemoveAll(x => x == removeitem);
            //PrintValues(items);
            var nums = new int[] { 3, 3, 4, 5, };
            var res = nums.FirstOrDefault(x => x == 9);
            Console.WriteLine(res);
        }
        public static void task20()
        {
            Console.Write("Enter index to input: ");
            var items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
            var index = GetNumber();
            items.RemoveAt(index - 1);
            PrintValues(items);
        }
        public static void task21()
        {
            var items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
            Console.Write("Enter starting index to input: ");
            var index = GetNumber();
            Console.Write("Enter count of elements to delete: ");
            var count = GetNumber();
            var maxcount = items.Count - index;
            items.RemoveRange(index - 1, count > maxcount ? maxcount + 1 : count);
            PrintValues(items);
        }
        public static void task22()
        {
            Console.Write("Input number of strings to store in the array : ");
            var n = GetNumber();
            Console.WriteLine("Input {0} strings for the array : ", n);
            var words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element[{0}]: ", i);
                words[i] = Console.ReadLine();
            }
            Console.Write("Input the minimum length of the item you want to find : ");
            var min = GetNumber();
            var result = words.Where(x => x.Length > min);
            PrintValues(result);
        }
        public static void task23()
        {
            var result = items.Select(item => new { item, items });
            //PrintValues(result);
            foreach (var item in result)
            {
                Console.WriteLine();
                foreach (var x in item.items)
                {
                    Console.WriteLine(item.item + "     " + x);
                }
            }
        }
        public static void task24()
        {
            var employees = Employee.GetEmployees();
            var res1 = employees.SelectMany(emp => items.Select(x => new { name = emp.FirstName, first = x }));
            var result = res1.SelectMany(x => items.Select(y => new { x.name, x.first, y }));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void task25()
        {
            var employees = Employee.GetEmployees();
            var students = Student.GetAllStudents;
            var result = employees.Join(students,
                teacher => teacher.FirstName,
                student => student.Course,
                (teacher, student) => new
                {
                    teacher = teacher,
                    student = student,
                });
            //PrintValues(result);
            foreach (var gr in result)
            {
                Console.WriteLine($"Course: {gr.teacher.TechCourse};    Teacher: {gr.teacher.FirstName};     Student: {gr.student.FirstName} Course: {gr.student.Course} ");
            }
        }
        public static void task26()
        {
            var employees = Employee.GetEmployees();
            var students = Student.GetAllStudents;
            var result = students.GroupJoin(employees,
                std => std.Course,
                teacher => teacher.FirstName,
                (std, teacher) => new
                {
                    Course = std.Course,
                    stdname = std.FirstName + " " + std.LastName,
                    teachers = teacher.DefaultIfEmpty()
                }).SelectMany(x => x.teachers.Select(t => new { x.Course, x.stdname, teacher = t }));
            Console.WriteLine();
            PrintValues(result);
        }
        public static void task27()
        {
            var employees = Employee.GetEmployees();
            var students = Student.GetAllStudents;
            var result = employees.GroupJoin(students,
                employees => employees.FirstName,
                std => std.Course,
                (teacher, std) => new
                {
                    teacher = teacher,
                    students = std.DefaultIfEmpty(),
                }).SelectMany(x => x.students.Select(std => new { name = x.teacher.FirstName, students = std }));
            PrintValues(result);
        }
        public static void task28()
        {
            var students = Student.GetAllStudents.Select(x => x.FirstName);
            var result = students.OrderBy(x => x.Length);
            PrintValues(result);
        }
        public static void task29()
        {
            var students = Student.GetAllStudents.Select(x => x.FirstName).ToList();
            var result = Enumerable.Range(0, students.Count()).GroupBy(i => i / 3, i => students[i]);
            foreach (var item in result)
            {
                PrintValues(item);
                Console.WriteLine();
            }
        }
        public static void task30()
        {
            var students = Student.GetAllStudents;
            var result = students.Select(x => x.FirstName).Distinct().Order();
            PrintValues(result);
        }
        public static List<string> items = new List<string>() { "item1", "item2", "item3", "item4", "item5", "item6" };
        public static int GetNumber()
        {
        GetNumber:
            bool check = int.TryParse(Console.ReadLine(), out int number);
            if (!check)
            {
                Console.WriteLine("Please repeat last input: ");
                goto GetNumber;
            }
            return number;

        }
        public static void PrintValues<T>(IEnumerable<T> collection)
        {
            foreach (var x in collection)
            {
                Console.WriteLine(x);
            }
        }

    }
}
