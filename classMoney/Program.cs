using System;

namespace classMoney
{
    class Program
    {
        class Money {
            int Rub { get; set; } = 0;
            int Coins { get; set; } = 0;

            public Money()
            {
                Rub = 0;
                Coins = 0;
            }
            //checking for negative numbers
            public Money(int r, int c){
                try { 
                    if (r < 0 || c < 0){
                        throw new Exception("bancrupt");
                    }
                    Rub = r;
                    Coins = c;
                }
                catch (Exception e){
                    Console.WriteLine($"Error: {e.Message}");
                }
            } 

            public static Money operator + (Money m1, Money m2) {
                return new Money (m1.Rub + m2.Rub, m1.Coins + m2.Coins );
            }
            public static Money operator -(Money m1, Money m2)
            {
                return new Money(m1.Rub - m2.Rub, m1.Coins - m2.Coins);
            }
            public static Money operator /(Money m1, int a)
            {
                return new Money(m1.Rub/a, m1.Coins/a);
            }
            public static Money operator ++(Money m1)
            {
                return new Money(m1.Rub, m1.Coins+1);
            }
            public static Money operator --(Money m1)
            {
                return new Money(m1.Rub, m1.Coins - 1);
            }
            public static bool operator <(Money m1, Money m2)
            {   if (m1.Rub == m2.Rub) { return m1.Coins < m2.Coins; }
                else { return m1.Rub < m2.Rub;}
            }
            public static bool operator > (Money m1, Money m2){
               return m1.Rub == m2.Rub?  m1.Coins > m2.Coins : m1.Rub > m2.Rub;   //то же что и выше но с помощью тернарного оператора
            }
            public static bool operator ==(Money m1, Money m2)
            {
                return m1.Rub == m2.Rub && m1.Coins == m2.Coins? true : false;
            }
            public static bool operator !=(Money m1, Money m2)
            {
                return m1.Rub == m2.Rub && m1.Coins == m2.Coins ? false : true;
            }

            public void print() { Console.WriteLine($"rubles: {Rub} coins: {Coins}\n"); }
        }


        static void Main(string[] args)
        {

            Money money1 = new(3,7); //money with 3 rubles 7 coins
            Console.WriteLine("money1(or 2?): "); money1.print();

            Money money2 = new(2, 5); //money with 2 rubles 5 coins  
            Console.WriteLine("money2: "); money2.print();

            money2--;
            Console.WriteLine("moey2--: "); money2.print();

            money2++;
            Console.WriteLine("money2++: "); money2.print();

            Money money3 = money1 + money2;
            Console.WriteLine("mone3 = money1 + money2: "); money3.print();

            Money money4 = money1 - money2;
            Console.WriteLine("money4 = money1 - money2: "); money4.print();

            Money money5 = money2 - money1;
            Console.WriteLine("money5 = money2 - money1:(!!!exeption!!!) "); money5.print();
            Console.WriteLine("comparing money 1 and money2:\n");
            Console.WriteLine($"money2 > money1?: {money2 > money1}");
            Console.WriteLine($"money2 < money1?: {money2< money1}");
            Console.WriteLine($"money2 == money1?: {money2 == money1}");
            Console.WriteLine($"money2 != money1?: {money2 != money1}");




            Console.ReadKey();
        }
    }
}
