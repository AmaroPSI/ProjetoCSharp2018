using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Casa
    {
        private string id;
        private string localidade;
        private string rua;

        public Casa(string id, string localidade, string rua)
        {
            this.id = id;
            this.localidade = localidade;
            this.rua = rua;
        }
        public Casa(string id)
        {
            this.id = id;
            this.localidade = Localidade;
            this.rua = Rua;
        }
     
        public string Id { get => id; set => id = value; }
        public string Localidade { get => localidade; set => localidade = value; }
        public string Rua { get => rua; set => rua = value; }

        public override string ToString()
        {
            return id;
        }
    }
}
