using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Entidades;
using TesteWebMotors.HTTP;
using TesteWebMotors.Util;

namespace TesteWebMotors.Service
{
    public class APIService
    {
        private readonly BindService BindService;

        #region :: Construtores ::

        public APIService(BindService bind)
        {
            this.BindService = bind;
        }

        #endregion

        #region :: Serviços ::

        public async Task<List<ResponseMake>> GetMakers()
        {
            string url = this.BindService.GetURL(BindService.Servicos.make);

            var response = await HttpRequestFactory.Get(url);

            return response.ContentAsType<List<ResponseMake>>();
        }

        public async Task<List<ResponseModel>> GetModels(int makeId)
        {
            string url = this.BindService.GetURL(BindService.Servicos.model);

            var response = await HttpRequestFactory.Get(string.Format(url, makeId));

            return response.ContentAsType<List<ResponseModel>>();
        }

        public async Task<List<ResponseVersion>> GetVersions(int modelId)
        {
            string url = this.BindService.GetURL(BindService.Servicos.version);

            var response = await HttpRequestFactory.Get(string.Format(url, modelId));

            return response.ContentAsType<List<ResponseVersion>>();
        }

        public async Task<List<ResponseVehicle>> GetVehicles(int page)
        {
            string url = this.BindService.GetURL(BindService.Servicos.model);

            var response = await HttpRequestFactory.Get(string.Format(url, page));

            return response.ContentAsType<List<ResponseVehicle>>();
        }

        #endregion
    }
}
