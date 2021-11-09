using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;


namespace Projeto3Camadas.Code.BLL
{
    class SorvetesBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_sorvetes";

        public void Inserir(SorvetesDTO sorDto)
        {
            string inserir = $"insert into {tabela} values(null,'(sorDto.Sorvetes)','(sorDto.Recheios)','(sorDto.Caldas)')";
            conexao.ExecutarComando(inserir);

        }

        public void Editar(SorvetesDTO sorDto)
        {


        }

        public void Excluir(SorvetesDTO sorDto)
        {


        }

        public void Listar(SorvetesDTO sorDto)
        {


        }

    }
}
