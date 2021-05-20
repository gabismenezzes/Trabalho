using System;
using System.Collections.Generic;
using BuffetWeb.Dados;
using BuffetWeb.Models.Buffet.Cliente;

namespace Buffet.Models.Buffet.Cliente
    {
        public class ClienteService
        {

            private readonly DatabaseContext _databaseContext;

            public ClienteService(DatabaseContext databaseContext)
            {
                _databaseContext = databaseContext;
            }

            public List<ClienteEntity> ObterClientes()
            {
                var listaDeClientes = new List<ClienteEntity>();
            
                listaDeClientes.Add(new ClienteEntity
                {
                    
                });
            
                listaDeClientes.Add(new ClienteEntity
                {
                    
                });

                return listaDeClientes;
            }
        }
    }