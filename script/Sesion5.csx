using System;

public class calculo 
{
    public double valor1 { get; set; }
    public double valor2 { get; set; }
    public string operação { get; set; }
}

public class triangulo
{
    public double lado1 { get; set; }
    public double lado2 { get; set; }
    public double lado3 { get; set; }
}

public class pessoa
{
    public string nome { get; set; }
    public double altura { get; set; }
    public double peso { get; set;}
}

public class notas
{
    public double nota1 { get; set; }
    public double nota2 { get; set; }
    public double nota3 { get; set; }
}

public class treino_focadoA 
{
    public double calculadora( calculo vlrs)

    {
        string operação = vlrs.operação;
        double resultado = 0;
        if(operação.Contains("+") || operação.Contains("soma"))
        {
            resultado = vlrs.valor1 + vlrs.valor2;
        } 
        else if(operação.Contains("-") || operação.Contains("subtração"))
        {
            resultado = vlrs.valor1 - vlrs.valor2;
        }
        else if(operação.Contains("*") || operação.Contains("x") || operação.Contains("multiplicação"))
        {
            resultado = vlrs.valor1 * vlrs.valor2;
        }
        else if (operação.Contains("/") || operação.Contains("divisão"))
        {
            resultado = vlrs.valor1 / vlrs.valor2;
        }
        else if (operação.Contains("Math.pow") || operação.Contains("potenciacao") || operação.Contains("^"))
        {
            resultado = Math.Pow(vlrs.valor1, vlrs.valor2);
        }
        else
        {
            resultado = 404;
        }
        return resultado;
    }

    public string termometro( double temperatura)
    {
        string estado_pessoa = string.Empty;
        if( temperatura <= 35)
        {
            estado_pessoa = "Procure ajuda você esta com Hipotermia";
        }
        else if ( temperatura > 35 && temperatura < 37.5)
        {
            estado_pessoa = "Você esta normal, não há problemas com a sua temperatura";
        }
        else if( temperatura > 37.6 && temperatura < 39.5)
        {
            estado_pessoa = "melhor se cuidar, você esta com febre!";
        }
        else if ( temperatura > 39.6 && temperatura < 41)
        {
            estado_pessoa = "Voce tem que se cuidar rápido, sua febre esta bem alta!";
        }
        else if (temperatura > 41)
        {
            estado_pessoa = "Procure ajuda, você esta com Hipertermia";
        }

        return estado_pessoa;
    }
    
    public string lucro_ou_prejuizo( double gastos, double lucros)
    {
        double indice = lucros - gastos;
        string retorno = string.Empty;
        if(indice > 0)
        {
            retorno = $"Muito bem, você está R$ {Math.Abs(indice)} positivo";
        }
        else if (indice < 0)
        {
            retorno = $"Cuidado você fechou em prejuizo e ele foi de: {Math.Abs(indice)}";
        } 
        else
        {
            retorno = "perdão o bot não entendeu ou o você não fechou o mes nem em lucro nem em prejuizo";
        }
        return retorno;
    }
    
    public double arredondar_d_meio__meio(double nota)
    {
        double nota_decimal = nota - Math.Truncate(nota);
        if(nota_decimal > 0.00 && nota_decimal < 0.25) 
        {
           nota = Math.Floor(nota);
        }
        else if (nota_decimal > 0.25 && nota_decimal < 0.75)
        {
           nota = Math.Floor(nota) + 0.5;
        }
        else
        {
            nota = Math.Ceiling(nota);
        }
        return nota;
    }

    public string passou1 (double nota)
    {
        string resposta = string.Empty;
        if(nota > 5)
        {
            resposta = "Parabéns você passou!";
        }
        else if(nota < 5)
        {
            resposta = "Que pena você não passou";
        }
        return resposta;
    }

    public string passou2  (double nota, int faltas)
    {
        string resposta = string.Empty;
        if(nota > 5 && faltas < 25)
        { 
            resposta = "Parabéns você passou!";
        }
        else if( nota > 5 && faltas > 25)
        {
            resposta = "uma pena você ficou de recoperação por notas";
        }
        else if (nota < 5 && faltas > 25)
        {
            resposta = "uma pena você não tirou a nota minima, por isso ficou de recuperação, mas sua presença foi boa";
        }
        else
        {
            resposta = "voce ficou de recuperação por suas notas e sua preseça";
        }
        return resposta;
    }
    public string tipo_triangulo (triangulo obj_v)
    {
        string resp = string.Empty;
        if(obj_v.lado1 == obj_v.lado2 && obj_v.lado1 != obj_v.lado3 || obj_v.lado1 != obj_v.lado2 && obj_v.lado1 == obj_v.lado3)
        {
            resp = "O triangulo é  isóceles";
        }
        else if (obj_v.lado1 == obj_v.lado2 && obj_v.lado1 == obj_v.lado3)
        {
            resp = "O triangulo é equilatero";
        }
        else if(obj_v.lado1 != obj_v.lado2 && obj_v.lado1 != obj_v.lado3)
        {
            resp = "O triangulo é escaleno";
        }
        return resp;
    }

    public string IMC (pessoa paciente)
    {
        double calc_altura = Math.Pow(paciente.altura, 2);
        double imc = calc_altura / paciente.peso;
        string condicao = string.Empty;
        if(imc > 18.6 && imc < 24.9)
        {
            condicao = " Peso normal";
        }
        else if (imc > 25 && imc < 29.9)
        {
            condicao = "Sobrepeso";
        }
        else if (imc < 18.5)
        {
            condicao = "Abaixo do peso";
        }
        return paciente.nome + "Voce esta com" + condicao;
    }
}

public class peca_dominio
{
    public double  ladoA { get; set; }
    public double  ladoB { get; set; } 
}

public class semaforo
{
    public bool Luz_vermelha_acesa { get; set; }
    public bool Luz_amarela_acesa  { get; set; }
    public bool Luz_verde_acesa    { get; set; }
}

public class recuperação_b 
{
    public string Email { get; set; }
    public string Telefone { get; set; }
}

public class Treino_focadoB
{
    public bool Cor_primaria(string cor)
    {
        bool e_cor_primaria = false;
        switch (cor)
        {
            case "Amarelo":
            e_cor_primaria = true;

            break;

            case "Azul":
            e_cor_primaria = true;

            break;

            case "Vermelho":
            e_cor_primaria = true;

            break;
        }

        return e_cor_primaria;
    }

    string combinação_cor_primaria ( string cor1, string cor2)
    {
        bool v_cores = Cor_primaria(cor1) && Cor_primaria(cor2);
        string output = string.Empty;
        if(v_cores == false)
        {
            output = "Uma das cores não é valida, tente novamente com uma cor PRIMARIA";
        }
        else if(cor1.Contains("Amarelo") && cor2.Contains("Azul") || cor1.Contains("amarelo") && cor2.Contains("azul") || cor1.Contains("Azul") && cor2.Contains("Amarelo") || cor1.Contains("azul") && cor2.Contains("amarelo"))
        {
            output = " A cor resultante é verde";
        }
        else if(cor1.Contains("Amarelo") && cor1.Contains("Vermelho") || cor1.Contains("amarelo") && cor2.Contains("vermelho") || cor1.Contains("Vermelho") && cor1.Contains("Amarelo") || cor1.Contains("vermelho") && cor2.Contains("amarelo"))
        {
            output = "A cor resultante é verde";
        }
        else if(cor1.Contains("Vermelho") && cor2.Contains("Azul") || cor1.Contains("vermelho") && cor2.Contains("azul") || cor1.Contains("Azul") && cor2.Contains("Vermelho") || cor1.Contains("azul") && cor2.Contains("vermelho"))
        {
            output = "A cor resultante é Roxo/púrpura";
        }
        else if(cor1.Contains("Vermelho") && cor2.Contains("Vermelho") || cor1.Contains("vermelho") && cor2.Contains("vermelho") )
        {
            output = "A cor resultante é Vermelho";
        }
        else if(cor1.Contains("Azul") && cor2.Contains("Azul") || cor1.Contains("azul") && cor2.Contains("azul") )
        {
            output = "A cor resultante é Azul";
        }
        else if(cor1.Contains("Amarelo") && cor2.Contains("Amarelo") || cor1.Contains("amarelo") && cor2.Contains("amarelo") )
        {
            output = "A cor resultante é Amarelo";
        }
        else
        {
            output = "Uma das cores não é valida, tente novamente com uma cor PRIMARIA";
        }
        return output;
    }
    string primeiro_nome(string nome_completo)
    {
        int Comprimento_PN = nome_completo.IndexOf(" ");
        string primeiro_nome = nome_completo.Substring(0, Comprimento_PN);

        if(Comprimento_PN == 0)
        {
            primeiro_nome = nome_completo;
        }
        return primeiro_nome;
    } 

    public bool dobre_domino (peca_dominio peca)
    {
        bool e_dobre = false;
        if(peca.ladoA == peca.ladoB) 
        {
            e_dobre = true;
        }
        return e_dobre;
    }

    public bool jogada_valida (peca_dominio peca1, peca_dominio peca2)
    {
        bool valido = false;
        if(peca1.ladoA == peca2.ladoA || peca1.ladoB == peca2.ladoA || peca1.ladoA == peca2.ladoB || peca1.ladoB == peca2.ladoB)
        {
            valido = true;
        }
        return valido;
    }

    public string recuperaçao_email(recuperação_b info)
    {
        string fone_cut =  string.Empty;
        if(info.Telefone.Contains("-"))
        {
            int od_cut =  info.Telefone.IndexOf("-");
            fone_cut = "XXXXX" + info.Telefone.Substring(od_cut);
        }
        else
        {
            string also_method = info.Email.Substring(5);
            fone_cut = "XXXXX" + also_method;                
        }
        int i_cut = info.Email.IndexOf("@");
        int f_cut = info.Email.IndexOf(".",i_cut);
        string email_cortado = info.Email;

        return $"Você receberá um e-mail do {email_cortado} para resetar a senha. Um código também foi enviado para o número {fone_cut}.";
    }

   public semaforo inicioSemaforo()
    {
        semaforo iniciado = new semaforo();
        iniciado.Luz_vermelha_acesa = true;
        iniciado.Luz_verde_acesa = false;
        iniciado.Luz_amarela_acesa = false;
        
        return iniciado;
    }


	public string proximo_sinal(semaforo S_in)
	{
		string estado = string.Empty;
		if(S_in.Luz_vermelha_acesa == true)
		{
			estado = "A luz é vermelha!";
			S_in.Luz_vermelha_acesa = false;
			S_in.Luz_verde_acesa = true;
		}
		 else if(S_in.Luz_verde_acesa == true)
		{
			estado = "A luz é Verde";
			S_in.Luz_verde_acesa = false;
			S_in.Luz_amarela_acesa = true;
		}
		else if(S_in.Luz_amarela_acesa == true)
		{
			estado = "A luz é a amarela";
			S_in.Luz_amarela_acesa = false;
			S_in.Luz_vermelha_acesa = true;
		}

        return S_in;
}


public class pessoa_c 
{
    public string nome          { get; set; }
    public DateTime Nascimento  { get; set; }
    public string Cidade        { get; set; }
}

public class Treino_focadoC 
{
    public int Trimestre (DateTime data)
    {
        int resposta = 1;
        if(data.Month > 3 && data.Month <= 6 )
        {
            resposta = 2;
        }
        else if(data.Month > 6 && data.Month <= 9)
        {
            resposta = 3;
        }
        else
        {
            resposta = 4;
        }
        return resposta;
    }

    public string mes ( DateTime data)
    {
        int mes = data.Month;
        string nm_mes = string.Empty;
        if(mes == 1)
        {
            nm_mes = "Janeiro";
        }
        else if(mes==2)
        {
            nm_mes = "Fevereiro";
        }
        else if (mes==3)
        {
            nm_mes = "Março";
        }
        else if(mes == 4)
        {
            nm_mes = "Abril";
        }
        else if(mes==5)
        {
            nm_mes = "Maio";
        }
        else if (mes==6)
        {
            nm_mes = "Junho";
        } 
        else if(mes == 7)
        {
            nm_mes = "Julho";
        }
        else if(mes==8)
        {
            nm_mes = "Agosto";
        }
        else if (mes==9)
        {
            nm_mes = "Setembro";
        }
              if(mes == 10)
        {
            nm_mes = "Outubro";
        }
        else if(mes==11)
        {
            nm_mes = "Novembro";
        }
        else
        {
            nm_mes = "Dezembro";
        }
        return nm_mes;   
    }

    public string periodo_dia(DateTime hj)
    {
        string output = string. Empty;
        if(hj.Hour >= 00 && hj.Hour < 06 )
        {
            output = "Madrugada";
        }
        else if (hj.Hour >= 06 && hj.Hour < 12)
        {
            output = "Manhã";
        }
        else if (hj.Hour >= 12 && hj.Hour < 18)
        {
            output = "Tarde";
        }
        else
        {
            output = "Noite";
        }

        return output;
    }

    public double dias_vida(DateTime nascimento)
    {
        DateTime hj = DateTime.Now;
        TimeSpan hr_v = hj - nascimento;
        return hr_v.Days;
    }

    public string qual_signo(DateTime nascimento)
    {
        string output = string.Empty;

        DateTime i_aries = new DateTime(nascimento.Year, 03, 21);
		DateTime f_aries = new DateTime(nascimento.Year, 04, 20);
		
		DateTime i_touro = new DateTime(nascimento.Year, 04, 21);
		DateTime f_touro = new DateTime(nascimento.Year, 05, 20);
		
		DateTime i_gemeos = new DateTime(nascimento.Year, 05, 21);
		DateTime f_gemeos = new DateTime(nascimento.Year, 06, 20);
		
		DateTime i_cancer = new DateTime(nascimento.Year, 06, 21);
		DateTime f_cancer = new DateTime(nascimento.Year, 07, 21);
		
		DateTime i_leao = new DateTime(nascimento.Year, 07, 22);
		DateTime f_leao = new DateTime(nascimento.Year, 08, 22);
		
		DateTime i_virgem = new DateTime(nascimento.Year, 08, 23);
		DateTime f_virgem = new DateTime(nascimento.Year, 09, 22);
		
		DateTime i_libra = new DateTime(nascimento.Year, 09, 23);
		DateTime f_libra = new DateTime(nascimento.Year, 10, 22);
		
		DateTime i_escorpiao = new DateTime(nascimento.Year, 10, 23);
		DateTime f_escorpiao = new DateTime(nascimento.Year, 11, 21);
		
		DateTime i_sargitario = new DateTime(nascimento.Year, 11, 22);
		DateTime f_sargitario = new DateTime(nascimento.Year, 12, 21);
		
		DateTime i_capricornio = new DateTime(nascimento.Year, 12, 22);
		DateTime f_capricornio = new DateTime(nascimento.Year, 01, 20);
		
		DateTime i_aquario = new DateTime(nascimento.Year, 01, 21);
		DateTime f_aquario = new DateTime(nascimento.Year, 02, 19);
		
        DateTime i_peixes = new DateTime(nascimento.Year, 02, 20);
		DateTime f_peixes = new DateTime(nascimento.Year, 03, 20);

        if(nascimento > i_aries && nascimento < f_aries)
        {
            output = "Aries";
        }
        else if(nascimento > i_touro && nascimento < f_touro)
        {
            output = "Touro";
        }
        else if(nascimento > i_gemeos && nascimento < f_gemeos)
        {
            output = "Gemeos";
        }
        else if(nascimento > i_cancer && nascimento < f_cancer)
        {
            output = "Câncer";
        }
        else if(nascimento > i_leao && nascimento < f_leao)
        {
            output = "Leão";
        }
        else if(nascimento > i_virgem && nascimento < f_virgem)
        {
            output = "Virgem";
        }
        else if(nascimento > i_libra && nascimento < f_libra )
        {
            output = "Libra";
        }
        else if(nascimento > i_escorpiao && nascimento < f_escorpiao )
        {
            output = "Escorpiao";
        }
        else if(nascimento > i_sargitario && nascimento < f_sargitario )
        {
            output = "Sargitário";
        }
        else if(nascimento > i_capricornio && nascimento < f_capricornio )
        {
            output = "Capricornio";
        }
        else if(nascimento > i_aquario && nascimento < f_aquario )
        {
            output = "Aquário";
        }
        else if(nascimento > i_peixes && nascimento < f_peixes )
        {
            output = "Peixes";
        }
        return output;
    }

    public string data_extenso(pessoa_c dados)
    {
        string nm_mes = mes(dados.Nascimento);
        int n_trimestre = Trimestre(dados.Nascimento);
        double dias_vividos = dias_vida(dados.Nascimento);
        string periodo = periodo_dia(dados.Nascimento);
        string signo = qual_signo(dados.Nascimento);

		return $"{dados.nome} você nasceu ha {dias_vividos} dias, em uma {periodo} do dia {dados.Nascimento.Day} de {nm_mes}({n_trimestre}° trimestre) de {dados.Nascimento.Year}. Seu Signo é de {signo}";

    }
}