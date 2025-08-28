namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        List<string> conjuntoU = new List<string>();

        List<string> conjuntoV = new List<string>();

        int contador = 0;
        int peso = 0;



        foreach (string elemento in s.Split())
        {
            Console.WriteLine(elemento);

            string elementoActual = elemento;
            if (elemento == elementoActual)
            {
                contador++;
            }

        }

        return new List<string>();
    }
}
