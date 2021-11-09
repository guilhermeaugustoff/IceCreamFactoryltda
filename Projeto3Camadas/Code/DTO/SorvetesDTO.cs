using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class SorvetesDTO
    {
        private int _id;
        private string _sabores;
        private string _recheios;
        private string _caldas;

        public int Id { get => _id; set => _id = value; }
        public string Sabores { get => _sabores; set => _sabores = value; }
        public string Recheios { get => _recheios; set => _recheios = value; }
        public string Caldas { get => _caldas; set => _caldas = value; }
    }
}
