namespace PdpB27_Darslar.Lesson7.Collections.MyCollection
{
    internal class MyCollectionStart
    {
        public static void Start()
        {
            MyCollection<int> myCollection = new();
            bool repeat = true;
            while (repeat)
            {
                Console.Write($"Menu:\n1.Qo`shish\n" +
                    $"2.O'chirish\n3.Element bor yo'qligini tekshirish\n" +
                    $"4.Barcha elementlarni ko'rish\n" +
                    $"5.Chiqish uchun istalgan belgi yoki 5 raqamini yozing\n" +
                    $"Tanlang:");

                string? input = Console.ReadLine();

                if (byte.TryParse(input, out byte select))
                {
                    switch (select)
                    {
                        case 1: Qoshish(); break;
                        case 2: Ochirish(); break;
                        case 3: Tekshirish(); break;
                        case 4: EkrangaChiqarish(); break;
                        default:
                            repeat = false; break;
                    }
                }
                else
                {
                    repeat = false;
                }
            }

            void EkrangaChiqarish()
            {
                myCollection.ConsoleLog();
            }

            void Tekshirish()
            {
                throw new NotImplementedException();
            }

            void Ochirish()
            {
                bool add = true;
                Console.WriteLine($"O'chirish kerak bo`lgan {int.MinValue} va " +
                    $"{int.MaxValue} oralidagi istalgan sonni kiriting Menu ga qaytish uchun chiqish uchun sonlar oralig'idan boshqa belgi kiriting");
                do
                {
                    if (int.TryParse(Console.ReadLine(), out int select))
                    {
                        if(myCollection.Remove(select))
                        Console.WriteLine("Qiymat o`chirildi yana o'chirish uchun yangi qiymat kiriting:");
                        else Console.WriteLine("Berilgan qiymat topilmadi o'chirish uchun yangi qiymat kiriting");
                    }
                    else
                    {
                        add = false;
                    }
                } while (add);
            }

            void Qoshish()
            {
                bool add = true;
                Console.WriteLine($"Istalgan {int.MinValue} va " +
                    $"{int.MaxValue} oralidagi sonlarni kiriting Menu ga qaytish uchun chiqish uchun sonlar oralig'idan boshqa belgi kiriting");
                do
                {
                    if (int.TryParse(Console.ReadLine(), out int select))
                    {
                        myCollection.Add(select);
                        Console.WriteLine("Qiymat qo`shildi yana yangi qiymat kiriting:");
                    }
                    else
                    {
                        add = false;
                    }
                } while (add);
            }
        }
    }
}
