using System;

public string calc_retangle(double a1, double a2, double b1, double b2)
{
    double area1 = a1 * a2;
    double area2 = b1 * b2;

    string resposta = "";
    
    if(area1 == area2)
    {
        resposta = "Os retangulos são iguais!";
    }
    else
    {
        resposta = "Os retangulos são diferentes!";
    }
    return resposta;
}

string i = calc_retangle(6,8,12,4);
Console.WriteLine("Exercicio 1: " + i);

//--------------------------------------------------------------------------------

public double area_retangulo (double altura, double largura)
{
    double calc = altura * largura;
    return calc;
}

public string retangulo_maior (double a1 ,double a2, double b1, double b2)
{
    double area1 = area_retangulo(a1, a2);
    double area2 = area_retangulo(b1, b2);
    string resposta = " ";
    if( area1 == area2){
        resposta = "Os retangulos são iguais";
    }
    else if(area1 > area2){
        resposta = "O primeiro retangulo é maior";
    }
    else{
        resposta = "O segundo retangulo é maior";
    }

    return resposta;
}

string ig = retangulo_maior(6,8,12,4);

Console.WriteLine("Exercio 2: " + ig);

// ----------------------------------------------

public class retangulo
{
    public double altura { get; set; }
    public double basse  { get; set; } 
}

public double calc_a_retangulos2 (retangulo a1)
{
    double calc = a1.altura * a1.basse;
    return calc;
}

public string retangulos_maiores2 (retangulo ret1, retangulo ret2, retangulo ret3)
{
    double area1 = calc_a_retangulos2(ret1);
    double area2 = calc_a_retangulos2(ret2);
    double area3 = calc_a_retangulos2(ret3);
    string resposta = " ";

    if(area1 > area2 && area1 > area3)
    {
        resposta = "O primeiro retangulo é maior";
    }
    else if (area2 > area3 && area2 > area1)
    {
        resposta = "o segundo retangulo é maior";
    }
    else if ( area3 > area1 && area3 > area2)
    {
        resposta = "o terceiro retangulo é maior";
    }
    else
    {
        resposta = "existem dois maiores triangulos";
    }

    return resposta;
}

retangulo test1 = new retangulo();
test1.altura = 8;
test1.basse = 10;

retangulo test2 = new retangulo();
test2.altura = 9;
test2.basse = 2;

retangulo test3 = new retangulo();
test3.altura = 5;
test3.basse = 3;

string awser = retangulos_maiores2(test1, test2, test3);
Console.WriteLine("Exercicio 3: " + awser );

// ---------------------------------------------

public class ingresso {
    public bool   meia  { get; set; }
    public double preco { get; set; }
    public string filme { get; set; }
}
public class cinemark 
{
    public double calcular_ingresso1(ingresso comp)
    {
        double ct = comp.preco * 1;
        if(comp.meia == true)
        {
            ct = comp.preco * 0.5;
        }
        return ct;
    }

    public string calcular_ingresso2(ingresso comp)
    {
        double ct = comp.preco * 1;
        if(comp.meia == true)
        {
            ct = comp.preco * 0.5;
        }
        return $"Compra concluida! O ingresso para o filme {comp.filme} é de {ct}R$";  
    }
    public double calcular_ingresso3 (ingresso ing1, ingresso ing2)
    {
        double vl1= ing1.preco * 1;
        if(ing1.meia == true)
        {
            vl1 = ing1.preco * 0.5;
        };
        double vl2 = ing2.preco * 1;
        if(ing2.meia == true)
        {
            vl2 = ing2.preco * 0.5;
        };
        double ct = vl2 + vl1;
        return ct; 
    }

}
ingresso ingresso1 = new ingresso ();
    ingresso1.preco = 12.00;
    ingresso1.meia = false;
    ingresso1.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

ingresso ingresso2 = new ingresso ();
    ingresso2.preco = 12.00;
    ingresso2.meia = true;
    ingresso2.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

cinemark a = new cinemark();
double ci1 = a.calcular_ingresso1(ingresso1);
string ci2 = a.calcular_ingresso2(ingresso2);
double ci3 = a.calcular_ingresso3(ingresso1, ingresso2);
Console.WriteLine($"Exercicio4: Calc_ingresso1: {ci1} Calc_ingresso2: {ci2} e Calc_ingresso3: {ci3}");

//-----------------------------
public class ingressos
{
    public int qtdIngressos { get; set; }
    public bool meia        { get; set; }
    public double preco     { get; set; }
    public string filme     { get; set; }
}

public class cinemark2
{
    public double calc_total1(ingressos ing1)
    {
        double calc = ing1.qtdIngressos * ing1.preco;
        if(ing1.meia == true)
        {
            calc = (ing1.qtdIngressos * ing1.preco)/2;
        }
        return calc;
    }
    public string calcular_total2(ingressos ing1)
    {
        double calc = ing1.qtdIngressos * ing1.preco;
        if(ing1.meia == true)
        {
            calc = (ing1.qtdIngressos * ing1.preco)/2;
        }
        string resposta = $"Compra concluida! A compra de {ing1.qtdIngressos} ingressos Inteira para o filme {ing1.filme} é de R${ing1.preco}";
        if (ing1.meia == true)
        {
            resposta = $"Compra concluida! A compra de {ing1.qtdIngressos} ingressos meia para o filme {ing1.filme} é de R${ing1.preco}";
        }
        return resposta;
    }
}
cinemark2 c = new cinemark2();

ingressos tested1 = new ingressos ();
    tested1.qtdIngressos = 2;
    tested1.meia = true;
    tested1.preco = 12.00;
    tested1.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

double tester1 = c.calc_total1(tested1);
string tester2 = c.calcular_total2(tested1);

Console.WriteLine($"Exercicio5: calcular total1: {tester1} calcular_total2: {tester2}");

//------------------------------------------------
public class ingressos2
{
    public int qtdIngressos { get; set; }
    public bool meia        { get; set; }
    public double preco     { get; set; }
    public string filme     { get; set; }
}

public  class cinemark3 
{
    private double aplicar_cupom(double total, double cupom)
    {
        double pf = total;
        if(cupom > 0)
        {
             double pp = (total/100)*cupom;
             pf = total - pp;
        }
        return pf;
    }

    public double calcular_total3( ingressos2 ingressos, double cupom)
    {
        double calculo = ingressos.qtdIngressos * ingressos.preco;
        if(ingressos.meia == true)
        {
            calculo = (ingressos.qtdIngressos * ingressos.preco)/2;
        };
        double preco_final = aplicar_cupom (calculo, cupom);
        return preco_final;
    }
}

ingressos2 abc = new ingressos2();
abc.meia = false;
abc.qtdIngressos = 3;
abc.preco = 12.00;
abc.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

cinemark3 t = new cinemark3();
double jj = t.calcular_total3(abc, 10);
Console.WriteLine("Exercicio 6: " + jj);

// ex7

public class ingressos3
{
    public int qtdIngressos { get; set; }
    public bool meia        { get; set; }
    public double preco     { get; set; }
    public string filme     { get; set; }
}

public  class cinemark4 
{
    private double aplicar_cupom(double total, double cupom)
    {
        double pf = total;
        if(cupom > 0)
        {
             double pp = (total/100)*cupom;
             pf = total - pp;
        }
        return pf;
    }

    public double calcular_total4( ingressos3 ingressos, double cupom)
    {
        double calculo = ingressos.qtdIngressos * ingressos.preco;
        if(ingressos.meia == true)
        {
            calculo = (ingressos.qtdIngressos * ingressos.preco)/2;
        };
        double preco_final = aplicar_cupom (calculo, cupom);
        double deconto_extra = 0;

        if(preco_final > 100)
        {
            deconto_extra = preco_final * 0.10;
        }
        return preco_final - deconto_extra;
    }
}

ingressos3 abcd = new ingressos3();
abcd.meia = false;
abcd.qtdIngressos = 10;
abcd.preco = 12.00;
abcd.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

cinemark4 l3 = new cinemark4();
double hj = l3.calcular_total4(abcd, 10);
Console.WriteLine("Exercicio 7: " + hj);
//-----
public class ingressos4
{
    public int qtdIngressos { get; set; }
    public bool meia        { get; set; }
    public double preco     { get; set; }
    public string filme     { get; set; }
}

public  class cinemark5 
{
    private double aplicar_cupom(double total, double cupom)
    {
        double pf = total;
        if(cupom > 0)
        {
             double pp = (total/100)*cupom;
             pf = total - pp;
        }
        return pf;
    }

    public double calcular_total5( ingressos4 ingressos, double cupom)
    {
        double calculo = ingressos.qtdIngressos * ingressos.preco;
        if(ingressos.meia == true)
        {
            calculo = (ingressos.qtdIngressos * ingressos.preco)/2;
        };
        DateTime dt_compra = DateTime.Now;
        double valor_bruto = calculo;
        if(dt_compra.DayOfWeek == DayOfWeek.Wednesday)
        {
            valor_bruto = calculo/2;
        };
        double preco_final = aplicar_cupom (valor_bruto, cupom);
        double deconto_extra = 0;

        if(preco_final > 100)
        {
            deconto_extra = preco_final * 0.10;
        }
        return preco_final - deconto_extra;
    }
}

ingressos4 abcde = new ingressos4();
abcde.meia = false;
abcde.qtdIngressos = 7;
abcde.preco = 12.00;
abcde.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";

cinemark5 c1 = new cinemark5();
double tst = c1.calcular_total5(abcde, 10);
Console.WriteLine("Exercicio 8: " + tst);
//------------------------------------------------------------------------
public class ingressos5
{
    public int qtdIngressos { get; set; }
    public bool meia        { get; set; }
    public double preco     { get; set; }
    public string filme     { get; set; }
    public string genero    { get; set; }
}
public  class cinemark6 
{
    private double aplicar_cupom2(double total, double cupom)
    {
        double pf = total;
        if(cupom > 0)
        {
             double pp = (total/100)*cupom;
             pf = total - pp;
        }
        return pf;
    }

    public double calcular_total5( ingressos5 ingressos, double cupom)
    {
        double calculo = ingressos.qtdIngressos * ingressos.preco;
        if(ingressos.meia == true)
        {
            calculo = (ingressos.qtdIngressos * ingressos.preco)/2;
        };
        DateTime dt_compra = DateTime.Now;
        double valor_bruto = calculo;
        if(dt_compra.DayOfWeek == DayOfWeek.Wednesday)
        {
            valor_bruto = calculo/2;
        };
        double preco_final = aplicar_cupom2 (valor_bruto, cupom);
        double desconto_extra = 0;

        if(preco_final > 100)
        {
            desconto_extra = preco_final * 0.10;
        };
        if( ingressos.genero == "Nacional")
        {
            preco_final = 5 * ingressos.qtdIngressos;
            desconto_extra = 0;
        };
        return preco_final - desconto_extra;
    }
}

ingressos5 c25 = new ingressos5();
c25.meia = false;
c25.qtdIngressos = 7;
c25.preco = 12.00;
c25.filme = "Demon Slayer: Kimetsu no Yaiba the Movie: Infinity Train.";
c25.genero = "Nacional";

cinemark6 la = new cinemark6();
double lg = la.calcular_total5(c25,10);
Console.WriteLine("Exercicio 9: " + lg);
//--------------------------------------
public class jogadas
{
    public string jogador1 { get; set; }
    public string jogador2 { get; set; }

}
public string Jokempo (jogadas jogo)
{
    bool partida = jogo.jogador1.Contains("Tessoura") && jogo.jogador2.Contains("Papel")
                    ||
                    jogo.jogador1.Contains("Papel") && jogo.jogador2.Contains("Pedra")
                    ||
                    jogo.jogador1.Contains("Pedra") && jogo.jogador2.Contains("Tessoura");
    string resposta = " ";
    if( partida == true)
    {
        resposta = "Jogador 1 venceu";
    }
    else if (jogo.jogador1 == jogo.jogador2)
    {
        resposta = "Empate!";
    }
    else
    {
         resposta = "Jogador 2 venceu";
    }

    return resposta;
}
jogadas l4 = new jogadas ();
l4.jogador1 = "Tessoura";
l4.jogador2 = "Papel"   ;

string v = Jokempo(l4);
Console.WriteLine("Exercicio 10: " + v);

//---------------------------------------
public string impar_par(string escolha_p1, int n_jogador1, string escolha_p2, int n_jogador2)
{
    int result_jogada = 2 % (n_jogador1 + n_jogador2) ;
    string resultado =  " ";
    if(result_jogada == 0)
    {
        resultado = "Par";
    }
    else
    {
        resultado = "Impar";
    }
    string final = " ";
    if(escolha_p1 == resultado)
    {
        final = "Jogador 1 venceu";
    }
    else if(escolha_p2 == resultado)
    {
        final = "Jogador 2 venceu";
    }
    return final;
}

string ll = impar_par("Par",3,"Impar",2);
Console.WriteLine("Exercicio 11: " + ll);