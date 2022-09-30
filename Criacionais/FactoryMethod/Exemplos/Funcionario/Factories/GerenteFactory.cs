﻿using FactoryMethod.Exemplos.Funcionario.Model;

namespace FactoryMethod.Exemplos.Funcionario.Factories
{
    public class GerenteFactory : FuncionarioFactory
    {
        public GerenteFactory(string nome, int idade, double salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override Model.Funcionario CriarFuncionario()
        {
            return new Gerente(_nome, _idade, _salario, _descricao);
        }
    }
}