using System.Net.Http.Json;

namespace Travel_app_1.TravelApp
{
    public class TravelAppService
    {
        private readonly HttpClient http;

        public TravelAppService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<SelectedArticlesType[]?> GetSelectedArticles()
        {
            return await http.GetFromJsonAsync<SelectedArticlesType[]>("/static-data/travel-app-selected-articles.json");
        }

        public async Task<DestinationsType[]?> GetDestinations()
        {
            return await http.GetFromJsonAsync<DestinationsType[]>("/static-data/travel-app-destinations.json");
        }

        public async Task<ImageSet1Type[]?> GetImageSet1()
        {
            return await http.GetFromJsonAsync<ImageSet1Type[]>("/static-data/travel-app-image-set-1.json");
        }

        public async Task<ImageSet2Type[]?> GetImageSet2()
        {
            return await http.GetFromJsonAsync<ImageSet2Type[]>("/static-data/travel-app-image-set-2.json");
        }

        public async Task<ArticlesSource1Type[]?> GetArticlesSource1()
        {
            return await http.GetFromJsonAsync<ArticlesSource1Type[]>("/static-data/travel-app-articles-source-1.json");
        }

        public async Task<ArticlesSource2Type[]?> GetArticlesSource2()
        {
            return await http.GetFromJsonAsync<ArticlesSource2Type[]>("/static-data/travel-app-articles-source-2.json");
        }

        public async Task<ArticlesSource3Type[]?> GetArticlesSource3()
        {
            return await http.GetFromJsonAsync<ArticlesSource3Type[]>("/static-data/travel-app-articles-source-3.json");
        }

        public async Task<ArticlesSource4Type[]?> GetArticlesSource4()
        {
            return await http.GetFromJsonAsync<ArticlesSource4Type[]>("/static-data/travel-app-articles-source-4.json");
        }
    }
}