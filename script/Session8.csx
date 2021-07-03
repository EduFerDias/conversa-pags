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

TreinoFocadoA tA =  new TreinoFocadoA();
Retangulo r1 = new Retangulo();
r1.altura = 6;
r1.basee = 8;

Retangulo r2 = new Retangulo();
r2.altura = 7;
r2.basee = 14;

Retangulo r3 = new Retangulo();
r3.altura = 5;
r3.basee = 20;

Notas a1 = new Notas();
a1.nota1 = 8;
a1.nota2 = 7;
a1.nota3 = 6;

Notas a2 = new Notas();
a2.nota1 = 9;
a2.nota2 = 4;
a2.nota3 = 5;

Notas a3 = new Notas();
a3.nota1 = 5;
a3.nota2 = 9;
a3.nota3 = 7;

List<Notas> tA_notas = new List<Notas>() {a1, a2, a3};
List<Retangulo> tA_Retangulos = new List<Retangulo>() {r1, r2, r3};

List<int> tA_int = new List<int>(){2, 4, 5, 9, 3, 10};
List<double> tA_double = new List<double>(){9, 25, 64, 100};

try
{
    Console.WriteLine("TreinoA x1: " + tA.somar_impares(tA_int));
    Console.WriteLine("TreinoA x2: " + string.Join(", ", tA.CalcularCubo(tA_int)));
    Console.WriteLine("TreinoA x3: " + string.Join(", ",tA.Calcular_Raiz(tA_double)));
    Console.WriteLine("TreinoA x4: " + tA.MaiorNumero(tA_int));
    Console.WriteLine("TreinoA x5: " + tA.Media(tA_double));
    Console.WriteLine("TreinoA x6: " + string.Join(", ",tA.Media_Notas(tA_notas)));
    Console.WriteLine("TreinoA x7/x8: " + string.Join(", ",tA.AreaRetangulos(tA_Retangulos)));
}
catch(Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
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

    public List<int> CodigoAscii(string frase)
    {
        List<int> ascii = new List<int>();
        foreach (char item in frase)
        {
            ascii.Add(Convert.ToInt32(item));
        }
        return ascii;
    }

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

    public string Alternado(Pessoa_c fulano)
    {
        string Alternado =  string.Empty;
        int alt = 0;
        foreach (char letra in fulano.Nome)
        {
            string Frase = string.Empty;
            alt++;

            if(alt % 2 != 0)
            Alternado += Convert.ToString(letra).ToUpper();
            else
            Alternado += Convert.ToString(letra).ToLower();
        }

        return Alternado;
    }

    public string Invertido(string frase)
    {
        string Invertido = string.Empty;

        foreach (char item in frase)
        {
            Invertido = item + Invertido;
        }
        return Invertido;
    }

    public bool Palindromo(string frase)
    {
        string invertido = string.Empty;
        foreach (char item in frase)
        {
            invertido = item + invertido;
        }
        bool e_palidromo = false;
        if(frase == invertido)
        {
            e_palidromo = true;
        }
        return e_palidromo;
    }
}