using Microsoft.Extensions.Options;

namespace TesteWebMotors.Util
{
    public class BindService
    {
        private readonly Constantes CONSTANTES;

        public BindService(Constantes constantes)
        {
            this.CONSTANTES = constantes;

        }
        public string GetURL(Servicos servico)
        {

            var url = this.CONSTANTES.Config.BaseURL;

            switch (servico)
            {
                case Servicos.make:
                    {
                        url += "/make";
                        break;
                    }
                case Servicos.model:
                    {
                        url += "/model?MakeID={0}";
                        break;
                    }
                case Servicos.version:
                    {
                        url += "/version?ModelID={0}";
                        break;
                    }
                case Servicos.vehicles:
                    {
                        url += "/vehicles?Page={0}";
                        break;
                    }

            }
            return url;
        }


        public enum Servicos
        {
            make,
            model,
            version,
            vehicles
        }
    }
}
