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

    }

}
