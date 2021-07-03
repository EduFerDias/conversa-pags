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
    Console.WriteLine("-----------------------------------");
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
                ultimoDia.Add(item.AddMonths(1).AddDays(-item.Day));
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
            if(item.nascimento > DateTime.Now)
                throw new Exception("Uma das pessoas foi declarada com nascida no futuro, favor verficar as datas");
            if(item.nascimento < DateTime.Now.AddYears(-150))
                throw new Exception("Uma das pessoas é velha demais para estar viva, favor verficar as datas");
            // sim, eu pesquisei e a pessoa mais velha a ter existido morreu com 122 anos, em 1997.
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

            if(item.nascimento > DateTime.Now)
                throw new Exception("Uma das pessoas foi declarada com nascida no futuro, favor verficar as datas");
            if(item.nascimento < DateTime.Now.AddYears(-150))
                throw new Exception("Uma das pessoas é velha demais para estar viva, favor verficar as datas");
        }
        return tdsMaiores;
    }
}



DateTime d1 = new DateTime(2002, 07, 11);
DateTime d2 = new DateTime(2018, 07, 14);
DateTime d3 = new DateTime(2014, 10, 12);

Pessoa p1 = new Pessoa();
p1.nome = "Eusebio";
p1.nascimento = new DateTime(1972, 05, 30);

Pessoa p2 = new Pessoa();
p2.nome = "Maldini";
p2.nascimento = new DateTime(1990, 02, 01);

Pessoa p3 = new Pessoa();
p3.nome = "Cristiano";
p3.nascimento = new DateTime(2002, 09, 12);

List<DateTime> tB_Date = new List<DateTime>(){d1, d2, d3};
List<Pessoa> tB_Pessoa = new List<Pessoa>(){p1, p2, p3};

TreinoFocadoB tB =  new TreinoFocadoB();
try
{
    Console.WriteLine("TreinoB x1: " + string.Join(" - ", tB.UltimoDia(tB_Date)));
    Console.WriteLine("TreinoB x2: " + tB.MaiorData(tB_Date).ToString("dd/MM/yyyy"));
    Console.WriteLine("TreinoB x3: " + string.Join(", ", tB.FiltrarMaiores(tB_Pessoa)));
    Console.WriteLine("TreinoB x4: " + tB.TodosMaiores(tB_Pessoa));
    Console.WriteLine("-----------------------------------");

}
catch (Exception ex)
{
    
    Console.WriteLine(ex.Message);
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

    public string Alternado(Pessoa_c pessoa)
    {
        string Alternado =  string.Empty;
        int alt = 0;
        foreach (char letra in pessoa.Nome)
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

Pessoa_c tC_pessoa = new Pessoa_c();
tC_pessoa.Nome = "Joaquim Elias André Moreira";
tC_pessoa.Nascimento = new DateTime(1946, 03, 22);
tC_pessoa.Cidade = "Palmas, TO";

string frase = "A prece não se resolve no muito falar, e sim no muito sentir.";
TreinoFocadoC tC = new TreinoFocadoC();
 try
 {
     Console.WriteLine("TreinoC x1: " + tC.SepararLetras(frase));
     Console.WriteLine("TreinoC x2: " + tC.TodasVogais("Eae"));
     Console.WriteLine("TreinoC x3: " + string.Join(", ", tC.CodigoAscii("Shrek")));
     Console.WriteLine("TreinoC x4: " + tC.Alternado(tC_pessoa));
     Console.WriteLine("TreinoC x5: " + tC.Invertido("orB"));
     Console.WriteLine("TreinoC x6: " + tC.Palindromo("gollog"));
 }
 catch(Exception ex)
 {
     Console.WriteLine(ex.Message);
 }