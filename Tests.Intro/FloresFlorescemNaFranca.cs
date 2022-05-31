
namespace Tests.Intro
{
    public class FloresFlorescemNaFranca
    {
        public static string Tautograma(string entrada)
        {

            if (string.IsNullOrWhiteSpace(entrada) || string.IsNullOrEmpty(entrada.Trim()) || entrada.Split(" ").Length < 2)
            {
                throw new ArgumentException("Frase inválida.");
            }

            string[] palavras = entrada.Split(" ");

            char letra = palavras[0][0];
            letra = char.ToLower(letra);

            foreach (string palavra in palavras)
            {
                if (char.ToLower(palavra[0]) != letra)
                {
                    return "N";
                }
            }

            return "S";
        }
    }
}
