namespace Chronos.Business.Entities
{
    public class CodigoFuncionalidade
    {
        protected CodigoFuncionalidade() { }
        public CodigoFuncionalidade(
            string prefixoProjeto, 
            string prefixoMenu,
            int sequencialNumerico,
            string identificacaoCompleta)
        {
            PrefixoProjeto = prefixoProjeto;
            PrefixoMenu = prefixoMenu;
            SequencialNumerico = sequencialNumerico;
            IdentificacaoCompleta = identificacaoCompleta;
        }

        public string PrefixoProjeto { get; private set; }
        public string PrefixoMenu { get; private set; }
        public int SequencialNumerico { get; private set; }
        public string IdentificacaoCompleta { get; private set; }
    }
}