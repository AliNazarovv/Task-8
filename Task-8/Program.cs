using System.Globalization;
using System.Text;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("az");
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = Encoding.Unicode;
            //1. Verilmiş ədədin tək və ya cüt ədəd olduğunu yoxla
            //Yazdim
            int a = 6;
            if (a % 2 == 0)
            {
                Console.WriteLine("Ədəd Çütdür");
            }
            else
            {
                Console.WriteLine("Ədəd Təkdir");
            }
            //2. 2 ədəd verilib. Əgər birinci ədəd ikinci ədədə tam bölünürsə o zaman
            //cavabı çapa vermək.
            //Əks halda "Bölünmür" sözünü çap etmək
            //Yazdim
            int x = 15;
            int y = 5;
            int result = x % y;
            if (result == 0)
            {
                Console.WriteLine($"Cavab : {result}");
            }
            else
            {
                Console.WriteLine("Bölünmür");
            }
            //3.Verilmiş ədədin sonuncu rəqəmi 7 ilə
            //qurtarırmı? Bəli və Xeyr cavabını ekrana çap etmək
            //YAzdim
            int number = 19707;
            int lastDigit = number % 10;
            if (lastDigit == 7)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
            //4.Verilmiş  2 rəqəmli ədədin rəqəmləri eynidirmi?
            //Bəli və Xeyr cavabını ekrana çap etmə
            //Yazdim
            int firstNum = 18;
            int lastNum = 18;
            if (firstNum == lastNum)
            {
                Console.WriteLine("Beli Beraberdir");
            }
            else
            {
                Console.WriteLine("Xeyr beraber deyil");
            }
            //5.Verilmiş 2 rəqəmli ədədin rəqəmləri cəmi cüt ədəddirsə o zaman
            //həmin ikirəqəmli ədədin rəqəmlərinin hasilini ekranda çap etmək.
            //Əks halda "ədəddə tək rəqəm mövcuddur" mətnini ekrana çap etmək.
            //(while dövr operatorundan istifadə edin!
            //Yazdim
            int num1 = 22;
            int num2 = 24;
            int res = 1;
            int sum = num2 + num1;
            if (sum % 2 == 0)
            {
                while (sum > 0)
                {
                    res *= sum % 10;
                    sum /= 10;


                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("ədəddə tək rəqəm mövcuddur");
            }


            //6.Student sinfi yaradın (class)
            //- id,  -name,  -surname,   -birthOfDate
            //  İstifadəçinin Enter Düyməsini sıxdığı müddətcə Yeni bir
            //  tələbə əlavə etmə imkanı olsun
            //  Daxil edilən tələbə məlumatları Student tipli massivə doldurulsun
            //  (Array methodlarını xatırlayın hansı faydalı olar)
            //  Enter düyməsi əvəzinə hər hansı başqa düymə sıxdıqda ekran təmizlənsin və 
            // Massivə doldurulmuş tələbə məlumatları ekranda
            // çap edilsin(ToString metodunu override etməklə)
            //Deqiqlesdirirm

            int len;
        l1:
            Console.WriteLine("Nece student daxil olunacaq");
            string bStr = Console.ReadLine();
            bool check = int.TryParse(bStr, out len);
            if (!check)
            {
                Console.WriteLine("Duzgun eded daxil edin");
                goto l1;
            }
            do
            {

            
            Student[] students = new Student[len];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                Console.WriteLine("Student- in  id - sini daxil et");
                students[i].id = Console.ReadLine();
                Console.WriteLine("Student- in adini daxil et");
                students[i].name = Console.ReadLine();
                Console.WriteLine("Student- in soyadini daxil et");
                students[i].surname = Console.ReadLine();
                Console.WriteLine("Student - in dogumtarixini daxil et");
                students[i].birthOfDate = Console.ReadLine();
                foreach (var item in students)
                {
                    Console.WriteLine(item);

                }

            }
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            //7. Verilmiş tarixi azərbaycan dilinə
            //uyğun formada ekranda göstərmək
            //14.03.2023 - 14 mart 2023-cü il
            //18.09.2009 - 18 sentyabr 2009 - cu il    18.02.2002 - 18 fevral 2002 - ci il
            //18.12.2006 - 18 dekabr 2006 - cı il
            //ctrl + k+ d = kodu nizamlayir
            DateTime time = new DateTime(2023, 3, 14);
            Console.WriteLine($"{time: dd MMMM yyy}");
            DateTime time2 = new DateTime(2009, 9, 18);
            Console.WriteLine($"{time2:dd MMMM yyy}");
            DateTime time3 = new DateTime(2002, 2, 18);
            Console.WriteLine($"{time3:dd MMMM yyy}");
            DateTime newTime = new DateTime(2006, 12, 18);
            Console.WriteLine($"{newTime:dd MMMM yyyy}");



        ////More tasks
        ///
        //6reqemli ədəd verilib 123456 bu ədəddən  456123
        //bu ədədi almaq
        //Yazdim
        l2:
            Console.WriteLine("6 reqemli eded daxil edin");
            string cStr = Console.ReadLine();
            bool Intsrt = int.TryParse(cStr, out int num);
            int final;

            if (num > 100000 && num < 1000000)
            {
                while (num > 0)
                {
                    final = (num % 1000) * 1000 + num / 1000;
                    Console.WriteLine(final);
                    break;

                }

            }
            else
            {
                goto l2;
            }
            //bir cümlə verilib  cümlədəki bütün sözləri çap etmək
            string text = "Salam dostlar necesiz?";
            string[] mass = text.Split(' ');
            foreach (string s in mass)
            {
                Console.WriteLine(s);
            }
            //bir cümlə verilib cümlədəki 4 hərfli sözləri çap etmək
            //Yazdim
            string sentence = "Ay ən yaxşı gecə səfərlərində əsir alır bizi";
            string[] mass2 = sentence.Split(' ');
            foreach (string item in mass2)
            {
                if (item.Length == 4)
                {
                    Console.WriteLine(item);
                }
            }
            //bir cümlə verilib cümlədəki ədədləri çap etmək(regex)

            //bir ədəd verilib ədəddən 0 rəqəmlərini yığışdırıb yeni ədəd almaq
            //Yazdim
            int nums = 12030401;
            string eded = nums.ToString();
            string newnums = "";
            foreach (char item in eded)
            {
                if (item != '0')
                {
                    newnums += item;
                }

            }
            int result23 = int.Parse(newnums);
            Console.WriteLine(result23);

























        }
    }
}
