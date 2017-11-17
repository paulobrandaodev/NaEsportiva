using System;
using System.IO;


namespace Repositorio
{
    public class ProdutoRep
    {
       public void Cadastrar(){
            StreamWriter sv = null;
            try
            {
                sv = new StreamWriter("produtos.csv", true);                
                sv.WriteLine(produto.Codigo + ";" + produto.Nome + ";" + produto.PrecoVenda+ ";" + produto.PrecoCompra+ ";" + produto.Data + ";" + produto.Unidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally{
                sv.Close();
            }
        }
        public string Consultar(string Texto)
        {
            throw new NotImplementedException();
        }

        public string Consultar(DateTime Data)
        {
            throw new NotImplementedException();
        }
    }

}