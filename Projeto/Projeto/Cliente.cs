using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoC
{
    class Cliente
    {
        private string nome;
        private Double nif;
        private Double contacto;

        public Cliente()
        {
            nome = "";
            nif = 0;
            contacto = 0;
        }

        public Cliente(String nome, Double nif, Double contacto)
        {
            this.nome = nome;
            this.nif = nif;
            this.contacto = contacto;
        }
       

        public String Nome { get => nome; set => nome = value; }
        public Double Contacto { get => contacto; set => contacto = value; }
        public Double Nif { get => nif; set => nif = value; }

        public override string ToString()
        {
            return nome ;
        }
    }
        
   
}
