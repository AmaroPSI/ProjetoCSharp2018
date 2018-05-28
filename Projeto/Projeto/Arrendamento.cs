using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_csharp
{
    class Arrendamento
    {
        private string arrendatário;
        private string iniciocontrato;
        private string tempo;
        private string renovavel;

        public string Arrendatário { get => arrendatário; set => arrendatário = value; }
        public string Iniciocontrato { get => iniciocontrato; set => iniciocontrato = value; }
        public string Tempo { get => tempo; set => tempo = value; }
        public string Renovavel { get => renovavel; set => renovavel = value; }

        public Arrendamento(string arrendatário, string iniciocontrato, string tempo,string renovavel)
        {
            this.Arrendatário = arrendatário;
            this.Iniciocontrato = iniciocontrato;
            this.Tempo = tempo;
            this.renovavel = renovavel;
        }

        public override string ToString()
        {
            return "Inicio: " + iniciocontrato + " " + tempo +  " " + " meses " + " Renovável: " + renovavel + "a " + arrendatário ;
        }
    }
}
