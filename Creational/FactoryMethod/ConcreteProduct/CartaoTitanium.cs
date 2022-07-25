using Factory_Method.Product;

namespace Factory_Method.ConcreteProduct
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;
        public CartaoTitanium(int LimiteCredito, int CobrancaAnual)
        {
            _tipoCartao = "Titanium";
            _limiteCredito = LimiteCredito;
            _cobrancaAnual = CobrancaAnual;
        }

        public override string TipoCartao
         { 
            get { return _tipoCartao; }
         }
        public override int LimiteCredito 
        { 
            get {return _limiteCredito;} 
            set {_limiteCredito = value;} 
            }
        public override int CobrancaAnual
        { 
            get {return _cobrancaAnual;} 
            set {_cobrancaAnual = value;}
        }
        
    }
}