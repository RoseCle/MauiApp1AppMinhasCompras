using SQLite;

namespace MauiApp1AppMinhasCompras.Models
{
    public class Produto
    {
        string _Descricao;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if(value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }
        }
        public double quantidade { get; set; }
        public double preco { get; set; }
        public double Total { get => Quantidade * Preco; }
    }

}