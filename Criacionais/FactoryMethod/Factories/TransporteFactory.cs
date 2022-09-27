﻿using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public abstract class TransporteFactory
    {
        protected string _descricao;
        protected int _anoFabricacao;

        public TransporteFactory(string descricao, int anoFabricacao)
        {
            _descricao=descricao;
            _anoFabricacao=anoFabricacao;
        }

        public abstract Transporte CriarTransporte();
    }
}
