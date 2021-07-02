using System;
using System.Collections.Generic;

public class Retangulos{
    public double basee { get; set; }
    public double altura { get; set; }
}

public class Notas{
    public double nota1 { get; set; }
    public double nota2 { get; set; }
    public double nota3 { get; set; }
}

public class TreinoFocadoA{
    public int somar_impares (List<int> numeros)
    {
        int soma = 0;
        foreach (int item in numeros)
        {
            if(numeros[item] % 2 != 0)
            soma += numeros[item];
        }
        return soma;
    }
    
    public List<int> CalcularCubo(List<int> numeros)
    {
        List<int> resposta = new List<int>();
        foreach(int item in numeros)
        {
            int cubo = numeros[item] * numeros[item] * numeros[item];
            resposta.Add(cubo);
        }
        return resposta;
    
    }
    public List<double> Calcular_Raiz(List<double> numeros)
    {
        List<double> raizes = new List<double>();
        foreach(int item in numeros)
        {
            if(Math.Pow(Math.Sqrt(numeros[item]), 2) != numeros[item])
            throw new Exception("Um dos numeros inseridos não possui raiz");


            raizes.Add(Math.Sqrt(numeros[item]));
        }
        return raizes;
    }
    
    public int MaiorNumero (List<int> numeros)
    {
        int maior = 0;

        foreach(int item in numeros)
        {
            int ante = 0;
            if(item > 0)
            ante = item - 1;

            if(numeros[item] >= numeros[ante])
            {
                maior = numeros[item];
            }            
        }
        return maior;
    }

    //public double Media (List<double> media)
    //{
        
   // }
}