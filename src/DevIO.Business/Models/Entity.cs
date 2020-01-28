using System;

namespace DevIO.Business.Models
{
    public abstract class Entity
    {
        //Implementação base de cada entidade do banco
        //Toda entidade tem um ID portanto definimos numa classe base para minimizar a duplicação da implementação
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}