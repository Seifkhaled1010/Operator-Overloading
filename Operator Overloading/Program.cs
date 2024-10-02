namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);

            Money m3 = m1 + m2;
            Money m4 = m1 - m2;

            Console.WriteLine($"Money m1: ${m1.Amount}, Money m2: {m2.Amount}");
            Console.WriteLine($"Money m3: ${m3.Amount}");
            Console.WriteLine($"Money m4: ${m4.Amount}");
            Console.WriteLine(m4 < m3);


            Console.ReadKey();
        }
    }

    class Money
    {
        public decimal amount;
        public decimal Amount => amount;

        public Money(decimal value)
        {
            this.amount = Math.Round(value, 2);
        }

        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.amount + money2.amount;
            return new Money(value);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.amount - money2.amount;
            return new Money(value);
        }

        public static Money operator *(Money money1, Money money2)
        {
            var value = money1.amount * money2.amount;
            return new Money(value);
        }

        public static Money operator /(Money money1, Money money2)
        {
            var value = money1.amount / money2.amount;
            return new Money(value);
        }

        public static bool operator >(Money money1, Money money2)
        {
            return money1.amount > money2.amount;
        }

        public static bool operator <(Money money1, Money money2)
        {
            return money1.amount < money2.amount;
        }

        public static bool operator >=(Money money1, Money money2)
        {
            return money1.amount >= money2.amount;
        }

        public static bool operator <=(Money money1, Money money2)
        {
            return money1.amount <= money2.amount;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.amount == money2.amount;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return money1.amount != money2.amount;
        }

        public static Money operator ++(Money money)
        {
            var value = money.amount;
            return new Money(++value);
        }

        public static Money operator --(Money money)
        {
            var value = money.amount;
            return new Money(--value);
        }
    }

}
