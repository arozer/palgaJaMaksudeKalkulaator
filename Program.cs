using System;

namespace palgaJaMaksudeKalkulaator
{
 
    class Program
    {

        static void Main(string[] args)
        {
            double tax = 0.2;
            double employmentfond = 0.016;
            double pension2 = 0.02;
            double RemainderOfTheYear = 25200;
            double freeTaxesSum = 0;
            double brutto_salary =0;

            while (RemainderOfTheYear <= 0)
            {
                freeTaxesSum = 0;
            }

            try
            {
                Console.WriteLine("enter your salary: ");
                brutto_salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter your freetaxes sum: ");
                freeTaxesSum = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("wrong type of information");
            }
              KuuPalkVähemKui1200eurot(freeTaxesSum, brutto_salary,tax,employmentfond,pension2);
        }


             static void KuuPalkVähemKui1200eurot(double freeTaxes,double salary,double tax,double employmentfond, double pension2)
            {

                double netto_salary = 0;
            netto_salary = salary - ((((salary -((salary * employmentfond) + (salary * pension2))) - freeTaxes) * tax) + ((salary * employmentfond) + (salary * pension2)));
                Console.WriteLine($"your salary is:{netto_salary}");

            }

            public void KuuPalkVahel1201Kuni2100Eurot(double freeTaxesSum, double salary, double tax, double employmentfond, double pension2)
            {

                double netto_salary = 0;
                netto_salary = ((((salary - freeTaxesSum) * tax) * employmentfond) * pension2);
            }

            public void KuuPalkRohkemKui2101eurot(double freeTaxessum, double salary, double tax, double employmentfond, double pension2)
            {
                double netto_salary = 0;
                netto_salary = ((((salary - freeTaxessum) * tax) * employmentfond) * pension2);

            }
    }
}

