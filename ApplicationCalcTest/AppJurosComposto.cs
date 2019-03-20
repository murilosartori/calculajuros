using System;

namespace ApplicationCalcTest
{
    public class AppJurosComposto
    {
        public double CalculoJurosComposto(double valorinicial, int mes)
        {
            try
            {
                double juros = 0.01;
                double valorfinal = valorinicial * Math.Pow((1 + juros), mes);
                valorfinal = Math.Truncate(100 * valorfinal) / 100;
                return valorfinal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
