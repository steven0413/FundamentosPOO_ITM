namespace FundamentosPOO_ITM.Domain.Services

{
    public class MathService
    {
        public string PositivePower(int num)

        {
            if (num > 0)
                return (num*num).ToString(); // .Tostring Convert Num a Text

            if (num == 0)
                return "0";

            return "Número negativo";
        }


        public int DoubleOrTriple(int a, int b) // Método
        {
            if (a >= b)
                return a * 2;

            return b * 3;
        }

        public double RootOrSquare(int num) //double números decimales
        {
            if (num > 0)
                return Math.Sqrt(num); //Math.Sqrt raíz cuadrada retorna números decimales.
           
            return num * num;
        }

        public double CirclePerimeter(double radius)
        {
            double perimeter = 2 * Math.PI * radius;

            return Math.Round(perimeter, 2); // dos decimales
        }

        public string MidweekDay(int day) // Recibe un número entero y retorna un texto (string)
        {
            switch (day)
            {
                case 1:
                    return "Lunes";

                case 2:
                    return "Martes";

                case 3:
                    return "Miércoles";

                case 4:
                    return "Jueves";

                case 5:
                    return "Viernes";

                default:
                    return "Número fuera del rango laboral";
            }
        }

        public string TaxCalculator(double salary)
        {
            if (salary > 12000) // condicion 
            {
                double excess = salary - 12000;

                double tax = excess * 0.15;

                return Math.Round(tax, 2).ToString();
            }

            return "No debe impuestos";
        }

        public int RemainderFinder(int a, int b) 
        {
            return a % b;
        }

        public int SumOfEvens()
        {
            int sum = 0; // acumulador

            for (int i = 1; i <= 50; i++) // Bucle for
            {
                if (i % 2 == 0) // validacion par
                {
                    sum += i; // acumulacion
                }
            }

            return sum;
        }

        public string FractionDifference(int a, int b, int c, int d)
        {
            int numerator = (a * d) - (c * b);

            int denominator = b * d;

            if (numerator == 0)
                return "0";

            return $"{numerator}/{denominator}";
        }

        public int StringLength(string word)
        {
            return word.Length;
        }

        public double AverageOfFour(double a, double b, double c, double d)
        {
            double average = (a + b + c + d) / 4;

            return average;
        }

    }

}
