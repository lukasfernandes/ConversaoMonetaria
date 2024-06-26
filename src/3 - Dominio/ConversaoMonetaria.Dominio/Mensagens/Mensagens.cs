﻿namespace ConversaoMonetaria.Dominio.Mensagens;

public class Mensagens
{
    public int CodigoMensagem { get; set; }
    public string Mensagem { get; set; }

    public static Mensagens Obrigatorio()
    {
        return new Mensagens { CodigoMensagem = 101, Mensagem = "O campo {0} é obrigatório" };
    }

    public static Mensagens TamanhoMaximo()
    {
        return new Mensagens
        {
            CodigoMensagem = 102,
            Mensagem = "O valor do campo {0} está com tamanho inválido, o máximo é {1} caracteres"
        };
    }

    public static Mensagens CampoInvalido()
    {
        return new Mensagens { CodigoMensagem = 103, Mensagem = "O valor do campo {0} não é válido" };
    }

    public static Mensagens DataInvalida()
    {
        return new Mensagens
            { CodigoMensagem = 104, Mensagem = "O valor do campo {0} não corresponde a uma data válida" };
    }

    public static Mensagens TamanhoDecimal()
    {
        return new Mensagens
            { CodigoMensagem = 105, Mensagem = "O valor do campo {0} está com tamanho inválido, máximo é {1}" };
    }

    public static Mensagens MaiorQue()
    {
        return new Mensagens { CodigoMensagem = 106, Mensagem = "O valor do campo {0} deve ser maior que {1}" };
    }

    public static Mensagens DiferenteDe()
    {
        return new Mensagens
            { CodigoMensagem = 107, Mensagem = "O valor do campo {0} não pode ser diferente de {1}" };
    }

    public static Mensagens ValorMinimo()
    {
        return new Mensagens { CodigoMensagem = 108, Mensagem = "O valor do campo {0} deve ser no mínimo {1}" };
    }

    public static Mensagens ValorNulo()
    {
        return new Mensagens { CodigoMensagem = 109, Mensagem = "O valor do campo {0} não pode ser nulo" };
    }

    public static Mensagens NaoEncontrado()
    {
        return new Mensagens
            { CodigoMensagem = 110, Mensagem = "Não foram encontrados registros com os parâmetros informados" };
    }

    public static Mensagens CaixaAlta()
    {
        return new Mensagens
            { CodigoMensagem = 111, Mensagem = "O valor do campo {0} deve sem em caixa alta" };
    }

    public static Mensagens AutenticacaoNaoPermitida()
    {
        return new Mensagens { CodigoMensagem = 112, Mensagem = "Não permitido. Você já está autenticado" };
    }

    public static Mensagens AutenticacaoNaoAutorizada()
    {
        return new Mensagens { CodigoMensagem = 113, Mensagem = "Não autorizado, verifique os dados Informados" };
    }

    public static Mensagens OpcaoInvalida()
    {
        return new Mensagens { CodigoMensagem = 114, Mensagem = "A opção escolhida no campo {0} é inválida" };
    }

    public static Mensagens NaoDevExistir()
    {
        return new Mensagens
            { CodigoMensagem = 115, Mensagem = "O valor do campo {0} já foi cadastrado." };
    }

    public static Mensagens TamanhoMinimo()
    {
        return new Mensagens
        {
            CodigoMensagem = 116,
            Mensagem = "O valor do campo {0} está com tamanho inválido, o mínimo é {1} caracteres"
        };
    }
}