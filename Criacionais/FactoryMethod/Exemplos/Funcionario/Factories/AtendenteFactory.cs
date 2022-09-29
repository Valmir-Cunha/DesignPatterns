﻿using FactoryMethod.Exemplos.Funcionario.Model;

namespace FactoryMethod.Exemplos.Funcionario.Factories
{
    public class AtendenteFactory : FuncionarioFactory
    {
        public AtendenteFactory(string nome, int idade, double salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override Model.Funcionario CriarFuncionario()
        {
            return new Atendente(_nome,_idade, _salario, _descricao);
        }
    }
}
