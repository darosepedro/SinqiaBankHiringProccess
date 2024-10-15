namespace SinqiaBankHiringProccess.Infrasturucture
{
    //Acrescentei o prefixo Sinqia para evitar conflito com a classe ConfigurationManager nativa
    public class SinqiaConfigurationManager 
    {
        private static SinqiaConfigurationManager _instance;
        private static readonly object _lock = new object();

        public string AppConfig { get; private set; } = "Configuração Padrão";

        private SinqiaConfigurationManager() { }

        public static SinqiaConfigurationManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SinqiaConfigurationManager();
                    }
                    return _instance;
                }
            }
        }
    }
}
