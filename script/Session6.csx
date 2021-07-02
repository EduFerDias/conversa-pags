using System;
using System.Collections.Generic;

public class retangulo
{
    public double basee { get; set; }
    public double altura { get; set; } 
}
public class notas
{
    public double nota1 { get; set; }
    public double nota2 { get; set; }
    public double nota3 { get; set; }
}
public class TreinoFocadoA
{
    public List<int> gerar_sequencia(int fim)
    {
        List<int> sequencia  = new List<int>();
        for(int i = 0; i <= fim; i++)
        {
            sequencia.Add(i);
        }
        return sequencia;
    }
    public  List<int> gerar_sequencia2(int inicio, int fim)
    {
        List<int> seq1 = new List<int>();
         for(int i = inicio; i <= fim; i++)
        {
            seq1.Add(i);
        }
        return seq1;
    }
    public List<int> gerar_sequencia_pares(int inicio, int fim)
    {
        List<int> seq2 = new List<int>();
        for(int i = inicio; i <= fim; i++)
        {
            if(i % 2 == 0)
            seq2.Add(i);
        }
        return seq2;
    }

    public int somar_ate(int fim)
    {
        int soma_f = 0;
        for(int i = 0; i <= fim; i++)
        {
            soma_f += i;
        }
        return soma_f;
    }
    public double calc_media(List<double> notas)
    {
        double somas = 0;
        for(int i = 0; i < notas.Count; i++)
        {
            somas += notas[i];
        }
        double n_final = somas/notas.Count;
        return n_final;
    }
    public List<double> calc_mediaV2 (List<notas> notas)
    {
        List<double> resposta = new List<double>();
        for(int i = 0; i < notas.Count; i++)
        {
            notas in_process = notas[i];
            double result = (in_process.nota1 + in_process.nota2 + in_process.nota3)/3;
            resposta.Add(result);
        }
        return resposta;
    }

    public List<double> calcular_quadrado(List<double> ret)
    {
        List<double> resposta = new List<double>();
        for(int i = 0; i < ret.Count; i++)
        {
            resposta.Add(Math.Pow(ret[i],2));
        }
        return resposta;
    }

    private double calc_retangulo(retangulo sub)
    {
        return sub.basee * sub.altura;
    }
    public List<double> AreaRetangulos(List<retangulo> rets)
    {
        List<double> areas = new List<double>();
        for(int i = 0; i < rets.Count; i++)
        {
            areas.Add(calc_retangulo(rets[i]));
        }
        return areas;
    }
}

// testes TA
List<double> TesteA = new List<double>();
TesteA.Add(7);
TesteA.Add(8);
TesteA.Add(6);

TreinoFocadoA tA = new TreinoFocadoA();

notas a1 = new notas();
a1.nota1 = 7;
a1.nota2 = 6;
a1.nota3 = 8;

notas a2 = new notas();
a2.nota1 = 4;
a2.nota2 = 6;
a2.nota3 = 8;

notas a3 = new notas();
a3.nota1 = 8;
a3.nota2 = 9;
a3.nota3 = 7;

List<notas> Alunos = new List<notas> ();
Alunos.Add(a1);
Alunos.Add(a2);
Alunos.Add(a3);

retangulo hb = new retangulo();
	hb.basee = (8);
	hb.altura = (6);

retangulo h2 = new retangulo();
	h2.basee = (9);
	h2.altura = (3);

retangulo h3 = new retangulo();
	h3.basee = (4);
	h3.altura = (10);

List<retangulo> Lista_ret = new List<retangulo>();
Lista_ret.Add(hb);
Lista_ret.Add(h2);
Lista_ret.Add(h3);

Console.WriteLine("Treino A x1: "+ string.Join("-", tA.gerar_sequencia(6)));
Console.WriteLine("Treino A x2: "+ string.Join("-", tA.gerar_sequencia2(2,7)));
Console.WriteLine("Treino A x3: "+ string.Join("-", tA.gerar_sequencia_pares(2,7)));
Console.WriteLine("Treino A x4: "+ tA.somar_ate(3));
Console.WriteLine("Treino A x5: "+ tA.calc_media(TesteA));
Console.WriteLine("Treino A x6: " + string.Join("-",tA.calc_mediaV2(Alunos)));
Console.WriteLine("Treino A x7: "+ string.Join("-",tA.calcular_quadrado(TesteA)));
Console.WriteLine("Treino A x9/x8: " + string.Join("-",tA.AreaRetangulos(Lista_ret)));

//

public class pessoa
{
    public string nome { get; set; }
    public DateTime nascimento { get; set; }

    public override string ToString()
    {
        return "(" + nome + ", " + nascimento.ToString("dd/MM/yy") + ")";
    }
}

public class TreinoFocadoB 
{
    public List<DateTime> GerarSequenciaDias (int fim)
    {
        List<DateTime> sequencia = new List<DateTime>();
        for(int i = 0; i < fim; i++)
        {
            sequencia.Add(DateTime.Now.AddDays(i));
        }
        return sequencia;
    }
    public List<DateTime> GerarSequenciaDias2 (int fim, DateTime Data)
    {
        List<DateTime> sequencia = new List<DateTime>();
        for(int i = 0; i < fim; i++)
        {
            sequencia.Add(Data.AddDays(i));
        }
        return sequencia;
    }
    public List<DateTime> GerarSequenciaDiasPares (int fim, DateTime Data)
    {
        List<DateTime> sequencia = new List<DateTime>();
        for(int i = 0; i < fim; i++)
        {	
			if(Data.AddDays(i).Day % 2 == 0)
            sequencia.Add(Data.AddDays(i));

        }
        return sequencia;
    }

    private string signo(DateTime nascimento)
    {
        string output = string.Empty;

        DateTime inicio_aries = new DateTime(nascimento.Year, 03, 21);
		DateTime final_aries = new DateTime(nascimento.Year, 04, 20);
		
		DateTime inicio_touro = new DateTime(nascimento.Year, 04, 21);
		DateTime final_touro = new DateTime(nascimento.Year, 05, 20);
		
		DateTime inicio_gemeos = new DateTime(nascimento.Year, 05, 21);
		DateTime final_gemeos = new DateTime(nascimento.Year, 06, 20);
		
		DateTime inicio_cancer = new DateTime(nascimento.Year, 06, 21);
		DateTime final_cancer = new DateTime(nascimento.Year, 07, 21);
		
		DateTime inicio_leao = new DateTime(nascimento.Year, 07, 22);
		DateTime final_leao = new DateTime(nascimento.Year, 08, 22);
		
		DateTime inicio_virgem = new DateTime(nascimento.Year, 08, 23);
		DateTime final_virgem = new DateTime(nascimento.Year, 09, 22);
		
		DateTime inicio_libra = new DateTime(nascimento.Year, 09, 23);
		DateTime final_libra = new DateTime(nascimento.Year, 10, 22);
		
		DateTime inicio_escorp = new DateTime(nascimento.Year, 10, 23);
		DateTime final_escorp = new DateTime(nascimento.Year, 11, 21);
		
		DateTime inicio_sargi = new DateTime(nascimento.Year, 11, 22);
		DateTime final_sargi = new DateTime(nascimento.Year, 12, 21);
		
		DateTime inicio_capricornio = new DateTime(nascimento.Year, 12, 22);
		DateTime final_capricornio = new DateTime(nascimento.Year, 01, 20);
		
		DateTime inicio_aquario = new DateTime(nascimento.Year, 01, 21);
		DateTime final_aquario = new DateTime(nascimento.Year, 02, 19);
		
        DateTime inicio_peixes = new DateTime(nascimento.Year, 02, 20);
		DateTime final_peixes = new DateTime(nascimento.Year, 03, 20);

        if(nascimento >= inicio_aries && nascimento < final_aries)
        {
            output = "Aries";
        }
        else if(nascimento >= inicio_touro && nascimento <= final_touro)
        {
            output = "Touro";
        }
        else if(nascimento >= inicio_gemeos && nascimento <= final_gemeos)
        {
            output = "Gemeos";
        }
        else if(nascimento >= inicio_cancer && nascimento <= final_cancer)
        {
            output = "Câncer";
        }
        else if(nascimento >= inicio_leao && nascimento <= final_leao)
        {
            output = "Leão";
        }
        else if(nascimento >= inicio_virgem && nascimento <= final_virgem)
        {
            output = "Virgem";
        }
        else if(nascimento >= inicio_libra && nascimento <= final_libra )
        {
            output = "Libra";
        }
        else if(nascimento >= inicio_escorp && nascimento <= final_escorp )
        {
            output = "Escorpiao";
        }
        else if(nascimento >= inicio_sargi && nascimento <= final_sargi )
        {
            output = "Sargitário";
        }
        else if(nascimento >= inicio_capricornio && nascimento <= final_capricornio )
        {
            output = "Capricornio";
        }
        else if(nascimento >= inicio_aquario && nascimento <= final_aquario )
        {
            output = "Aquário";
        }
        else if(nascimento >= inicio_peixes && nascimento <= final_peixes )
        {
            output = "Peixes";
        }

        return output;
    }
    public List<string> signos(List<DateTime> nascimentos)
    {
        List<string> output = new List<string>();
        for(int i = 0; i < nascimentos.Count; i++)
        {
            string signo_p = signo(nascimentos[i]);
            output.Add(signo_p);
        }
        return output;
    }

    public List<pessoa> FiltrarMaiores (List<pessoa> dados)
    {
        List<pessoa> maiores = new List<pessoa>();
        for(int i = 0; i < dados.Count; i++)
        {
            pessoa verif = dados[i];
            if(verif.nascimento <= DateTime.Now.AddYears(-18))
            {
                maiores.Add(verif);
            }
        }
        return maiores;
    }
    public bool todosMaiores(List<pessoa> turma)
    {
        for(int i = 0; i < turma.Count; i++)
        {
            pessoa verificacao = turma[i];
            if(verificacao.nascimento > DateTime.Now.AddYears(-18))
			{
            	return false;
			}
        }
        return true;
    }
}
//Teste TreinoB
pessoa h4 = new pessoa();
	h4.nome = "Fulano";
	h4.nascimento = new DateTime (1990, 05, 06);

pessoa h5 = new pessoa();
	h5.nome = "Ciclano";
	h5.nascimento = new DateTime (2000, 08, 11);

pessoa h6 = new pessoa();
	h6.nome = "Beltrano";
	h6.nascimento = new DateTime (1980, 03, 01);

pessoa h7 = new pessoa();
	h7.nome = "Luiz";
	h7.nascimento = new DateTime (1970, 09, 14);


DateTime b1 = new DateTime(2003,12,16);
DateTime b2 = new DateTime(2009,05,20);
DateTime b3 = new DateTime(1990,07,21);

List<DateTime> TesteB = new List<DateTime>();
TesteB.Add(b1);
TesteB.Add(b2);
TesteB.Add(b3);


List<pessoa> b = new List<pessoa>();
b.Add(h4);
b.Add(h5);
b.Add(h6);
b.Add(h7);

TreinoFocadoB tB = new TreinoFocadoB();

Console.WriteLine("Treino B x1: "+ string.Join("-", tB.GerarSequenciaDias(7)));
Console.WriteLine("Treino B x2: "+ string.Join("-", tB.GerarSequenciaDias2(7, b2)));
Console.WriteLine("Treino B x3: "+ string.Join("-", tB.GerarSequenciaDiasPares(7,b2)));
Console.WriteLine("Treino B x6/x5: " + string.Join("-",tB.signos(TesteB)));
Console.WriteLine("Treino B x7: "+ string.Join("-",tB.FiltrarMaiores(b)));
Console.WriteLine("Treino B x8: " + string.Join("-",tB.todosMaiores(b)));




//-----------
public class pessoa_c
{
    public string nome { get; set; }
    public DateTime nascimento { get; set; }
    public string cidade { get; set; }
}

public class TreinoFocadoC
{
	public string SepararLetras (string frase)
    {
        List<string> LetrasSeparadas = new List<string>();
        for(int i = 0; i < frase.Length; i++)
        {
            LetrasSeparadas.Add(frase.Substring(i,1));
        }
        string FraseSeparada = string.Join("-",LetrasSeparadas);
        return FraseSeparada;
    }
    public string Iverter (string frase)
    {
        List<string> FraseInvertida = new List<string>();
        int ferramenta = frase.Length - 1;
        for(int i = ferramenta; i >= 0; i--)
        {
            FraseInvertida.Add(frase.Substring(i,1));
        }
        string FraseEspelhada = string.Join("",FraseInvertida);
        return FraseEspelhada;
    }

    public bool TodasVogais(string frase)
    {
        bool resposta = false;
        for(int i = 0; i < frase.Length; i++)
        {
            string letras = frase.Substring(i,1);
            if(letras.Contains("a") || letras.Contains("e") || letras.Contains("i") || letras.Contains("o") || letras.Contains("u"))
            resposta = true;
			else
			return false;
        }
        return resposta;
    }

    private string UltimoNome(string NomeCompleto)
    {
        int corte = NomeCompleto.LastIndexOf(" ");
        string UltimoNome = NomeCompleto.Substring(corte + 1);
        return UltimoNome;
    }
    public List<string> UltimosNomes(List<string> Nomes)
    {
        List<string> Ultimos = new List<string>();
        for(int i = 0; i < Nomes.Count; i++)
        {
            string nome = Nomes[i];
            Ultimos.Add(UltimoNome(nome));
        }
        return Ultimos;
    }

    public bool ApenasCoresPrimaeias(List<string> cores)
    {
        bool resposta = false;
        for(int i = 0; i < cores.Count; i++)
        {
            string cor = cores[i];
            if(cor.Contains("Amarelo") || cor.Contains("Vermelho") || cor.Contains("Azul") || cor.Contains("amarelo") || cor.Contains("vermelho") || cor.Contains("azul"))
            resposta = true;
			else
			return false;
        }
        return resposta;
    }

    public bool SenhaForte(string senha)
        {
            int localizacao = 0;
            int localizacao_n = 0;

                if( senha.Contains("!"))
                    localizacao = senha.IndexOf("!");
                else if(senha.Contains("@"))
                    localizacao = senha.IndexOf("@");
                else if( senha.Contains("#"))
                    localizacao = senha.IndexOf("#");
                else if(senha.Contains("$"))
                    localizacao = senha.IndexOf("$");
                else if(senha.Contains("%"))
                    localizacao = senha.IndexOf("%");

            bool tem_mais_de_um = senha.Substring(localizacao + 1).Contains("!") || senha.Substring(localizacao + 1).Contains("@") || senha.Substring(localizacao + 1).Contains("#") || senha.Substring(localizacao + 1).Contains("$") || senha.Substring(localizacao + 1).Contains("%");
            
                if(senha.Contains("1"))
                    localizacao_n = senha.IndexOf("1");
                else if(senha.Contains("2"))
                    localizacao_n = senha.IndexOf("2");
                else if(senha.Contains("3"))
                    localizacao_n = senha.IndexOf("3");
                else if(senha.Contains("4"))
                    localizacao_n = senha.IndexOf("4");
                else if(senha.Contains("5"))
                    localizacao_n = senha.IndexOf("5");
                else if(senha.Contains("6"))
                    localizacao_n = senha.IndexOf("6");
                else if( senha.Contains("7"))
                    localizacao_n = senha.IndexOf("7");
                else if(senha.Contains("8"))
                    localizacao_n = senha.IndexOf("8");
                else if(senha.Contains("9"))
                    localizacao_n = senha.IndexOf("9");
                else if(senha.Contains("0"))
                    localizacao_n = senha.IndexOf("0");
            
            bool tem_mais_de_um_numero = senha.Substring(localizacao_n + 1).Contains("0") || senha.Substring(localizacao_n + 1).Contains("1") || senha.Substring(localizacao_n + 1).Contains("2") || senha.Substring(localizacao_n + 1).Contains("3") || senha.Substring(localizacao_n + 1).Contains("4") || senha.Substring(localizacao_n + 1).Contains("5") || senha.Substring(localizacao_n + 1).Contains("6") || senha.Substring(localizacao_n + 1).Contains("7") || senha.Substring(localizacao_n + 1).Contains("8") || senha.Substring(localizacao_n + 1).Contains("9");
            bool tem_oito = senha.Length >= 8;
            return tem_mais_de_um && tem_oito && tem_mais_de_um_numero;
        }
}

TreinoFocadoC tC = new TreinoFocadoC();

List<string> TesteC = new List<string>();
string c1 = "aeee";
string c2 = "Sou bonitao";
string c3 = "Amarelo";

List<string> TesteC2 = new List<string>();
string c21 = "Eduardo Ferreira Dias";
string c22 = "Edmundo Dias";
string c23 = "Eronildes Ferreira";

List<string> TesteC0 = new List<string>();
string c0 = "Azul";
string c01 = "Vermelho";
string c001 = "Amarelo";

TesteC2.Add(c21);
TesteC2.Add(c22);
TesteC2.Add(c23);


TesteC.Add(c1);
TesteC.Add(c2);
TesteC.Add(c3);

TesteC0.Add(c0);
TesteC0.Add(c01);
TesteC0.Add(c001);

Console.WriteLine("Treino C x1: "+ tC.SepararLetras(c2));
Console.WriteLine("Treino C x2: "+ tC.Iverter(c2));
Console.WriteLine("Treino C x3: "+ tC.TodasVogais(c1));
Console.WriteLine("Treino C x4/x5: "+ string.Join("-", tC.UltimosNomes(TesteC2)));
Console.WriteLine("Treino C x6: "+ tC.ApenasCoresPrimaeias(TesteC0));
Console.WriteLine("Treino C x7: "+ tC.SenhaForte("Seas00##");;