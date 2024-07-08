using System.Text;

namespace HungryPizza.Domain
{
    public static class Utils
    {
        private static Random random = new Random();

        public static string GerarCodigoAleatorio(int tamanhoCodigo)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder(tamanhoCodigo);

            for (int i = 0; i < tamanhoCodigo; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
