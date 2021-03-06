﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventures.Model.DAL
{
    class ClienteDataStore
    {
        AdventuresContext context = new AdventuresContext();


        public List<Cliente> ListarClientes()
        {
            return context.Clientes.ToList();
        }

        public void AddCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void RemoverCliente(int id)
        {
            Cliente cliente = context.Clientes.FirstOrDefault(c => c.Id == id);
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }

        public void EditarCliente(Cliente cliente)
        {
            Cliente editCliente = context.Clientes.FirstOrDefault(c => c.Id == cliente.Id);

            editCliente.Nome = cliente.Nome;
            editCliente.Cpf = cliente.Cpf;
            editCliente.DataCadastro = cliente.DataCadastro;
            editCliente.Email = cliente.Email;

            context.Clientes.Update(editCliente);
            context.SaveChanges();
        }

        
    }
}
