using Microsoft.Extensions.Options;

namespace TesteWebMotors.Util
{
    public class Constantes
    {
        public AppConfig Config { get { return this._Config; } }
        private readonly AppConfig _Config;

        public Constantes(IOptionsSnapshot<AppConfig> config)
        {
            this._Config = config.Value;
        }
    }
}
