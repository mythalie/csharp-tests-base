namespace Tests.Intro
{
    public static class Criptografia
    {
        public static string Criptografar(string entrada)
        {
            if (string.IsNullOrWhiteSpace(entrada) || entrada.Length < 4)
            {
                throw new ArgumentException("entrada é nula, vazia ou muito pequena.");
            }
                
            var primeira = "";
            
            foreach (char letra in entrada)
            {
                var codigo = 0;
               
                if (char.IsLetter(letra))
                    codigo = (int)letra + 3;
                else
                    codigo = (int)letra;
                primeira += (char)codigo;
            }

            var primeiraCharArray = primeira.ToCharArray();
            Array.Reverse(primeiraCharArray);

            var segunda = new string(primeiraCharArray);
            var metade = segunda.Length / 2;
            var terceira = segunda.Substring(0, metade);
            
            foreach (char letra in segunda.Skip(metade))
            {
                var codigo = (int)letra - 1;
                terceira += (char)codigo;
            }
            return terceira;
        }
    }
}
