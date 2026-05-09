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

    }

}
