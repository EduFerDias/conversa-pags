using System;
using System.Collections.Generic;

public class Retangulo{
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
            if(item % 2 != 0)
            soma += item;
        }
        return soma;
    }
    
    public List<int> CalcularCubo(List<int> numeros)
    {
        List<int> resposta = new List<int>();
        foreach(int item in numeros)
        {
            int cubo = item * item * item;
            resposta.Add(cubo);
        }
        return resposta;
    
    }
    public List<double> Calcular_Raiz(List<double> numeros)
    {
        List<double> raizes = new List<double>();
        foreach(int item in numeros)
        {
            if(Math.Pow(Math.Sqrt(item), 2) != item)
            throw new Exception("Um dos numeros inseridos não possui raiz");


            raizes.Add(Math.Sqrt(item));
        }
        return raizes;
    }
    
    public int MaiorNumero (List<int> numeros)
    {
        int maior = 0;

        foreach(int item in numeros)
        {
            if(item >= maior)
                maior = item;
     
        }
        return maior;
    }

    public double Media(List<double> numeros)
    {
        List<double> medias = new List<double>();
        double somas = 0;
        foreach(double item in numeros)
        {
            somas += item;
        }
        return somas / numeros.Count;
    }

    public List<double> Media_Notas (List<Notas> alunos)
    {
        List<double> medias = new List<double>();
        foreach (Notas item in alunos)
        {
            Notas nota = item;
            double somas = nota.nota1 + nota.nota2 + nota.nota3;
            medias.Add(somas / 3);   
        }
        return medias;
    }

    private double AreaRetangulo(Retangulo ret)
    {
        return ret.basee * ret.altura;
    }

    public List<double> AreaRetangulos(List<Retangulo> retangulos)
    {
        List<double> areas=  new List<double>();
        foreach (Retangulo item in retangulos)
        {
            Retangulo ret = item;
            areas.Add(AreaRetangulo(ret));
        }
        return areas;
    }
}

public class Pessoa{
    public string nome { get; set; }
    public DateTime nascimento { get; set; }

    public override string ToString()
    {
        return "(" + nome + ", " + nascimento.ToString("dd/MM/yy") + ")";
    }
}

public class TreinoFocadoB{
    

    public List<DateTime> UltimoDia (List<DateTime> datas)
    {
        List<DateTime> ultimoDia = new List<DateTime>();
        foreach (DateTime item in datas)
            {
                ultimoDia.Add(item.AddMonths(1).AddDays(item.Day));
            }
        return ultimoDia;
    }

    public DateTime MaiorData(List<DateTime> datas)
    {
        DateTime maior = new DateTime();
        foreach (DateTime item in datas)
        {
            if(maior <= item)
            maior = item;
        }
        return maior;
    }

    public List<Pessoa> FiltrarMaiores(List<Pessoa> pessoas)
    {
        List<Pessoa> Maiores = new List<Pessoa>();
        foreach (Pessoa item in pessoas)
        {
            if(DateTime.Now.AddYears(-18) > item.nascimento)
            {
                Maiores.Add(item);
            }
        }
        return Maiores;
    }
    
    public bool TodosMaiores ( List<Pessoa> grupo)
    {
        bool tdsMaiores = true;
        foreach (Pessoa item in grupo)
        {
            if(item.nascimento > DateTime.Now.AddYears(-18))
            {
                tdsMaiores = false;

                break;
            }
        }
        return tdsMaiores;
    }
}


public class Pessoa_c{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public DateTime Nascimento { get; set; }

    public override string ToString()
    {
        return "(" + Nome + ", " + Nascimento.ToString("dd/MM/yy") + ")";
    }
}

public class TreinoFocadoC{
    public string SepararLetras(string frase)
    {
        List<char> letras = new List<char>();
        foreach(char item in frase)
        {
            letras.Add(item);
        }
        return string.Join("-", letras);
    }

    //public List<int> CodigoAscii(string frase)

    public bool TodasVogais(string frase)
    {
        bool todasvg = true;
        foreach(char item in frase)
        {
            bool e_vogal = item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' || item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U';
            if(!e_vogal == true)
            {
                todasvg = false;

                break;
            }
        }
        
        return todasvg;
    }
}