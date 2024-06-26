﻿using System.Linq;
using ConversaoMonetaria.Data.Context;
using ConversaoMonetaria.Data.Repositorio.Base;
using ConversaoMonetaria.Dominio.Core.Data;
using ConversaoMonetaria.Dominio.Entidades.Moedas;
using ConversaoMonetaria.Dominio.Enums;
using ConversaoMonetaria.Dominio.Interfaces.Repositorio;

namespace ConversaoMonetaria.Data.Repositorio;

public class MoedaRepositorio : BaseRepositorio<Moeda>, IMoedaRepositorio
{
    private readonly ConversaoMonetariaContext _conversaoMonetariaContext;

    public MoedaRepositorio(ConversaoMonetariaContext ConversaoMonetariaContext) : base(ConversaoMonetariaContext)
    {
        _conversaoMonetariaContext = ConversaoMonetariaContext;
    }

    public new IUnitOfWork UnitOfWork => _conversaoMonetariaContext;


    public IQueryable<Moeda> Listar()
    {
        return _conversaoMonetariaContext.Moedas;
    }

    public IQueryable<Moeda> Obter(long id)
    {
        return _conversaoMonetariaContext.Moedas.Where(p => p.Id == id);
    }

    public bool ExisteMoedaComCodigo(string codigo)
    {
        return _conversaoMonetariaContext.Moedas.Any(p => p.Codigo == codigo && p.Status == EStatusMoeda.Ativa);
    }
}