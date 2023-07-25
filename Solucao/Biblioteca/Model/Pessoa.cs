﻿using System;

namespace Biblioteca.Model
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set;}
        public string Telefone { get; set;}
        public string CPF { get; set;}
        public string RG { get; set;}

        public int CEP { get; set;}
        public string Estado { get; set;}
        public string Cidade { get; set;}
        public string Endereço { get; set;}




    }
}