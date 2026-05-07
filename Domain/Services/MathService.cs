namespace FundamentosPOO_ITM.Domain.Services

{
    public class MathService
    {
        public string PositivePower(int num)
        {
            if (num > 0)
                return (num*num).ToString();

            if (num == 0)
                return "0";

            return "Número negativo";
        }
    }
}
