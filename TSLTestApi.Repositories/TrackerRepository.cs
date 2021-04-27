using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TSLTestApi.Interfaces;
using TSLTestApi.ViewModels;
//using Microsoft.AspNet.WebApi.Client

namespace TSLTestApi.Repositories
{
    public class TrackerRepository : ITracker
    {
        private const string Api_Key = "569d44cbeaf04b2da798548564c40ec1";

        public TrackingDataViewModel GetTrackingData(string trackingId)
        {
            string uri = $@"https://cco-telematics-apis.azure-api.net/dev/tele/status/{trackingId}?api_key={Api_Key}";
            var response = Task.Run(async () => await (new HttpClient()).GetAsync(uri)).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var result = Task.Run(async () => await response.Content.ReadAsAsync<List<TrackingDataViewModel>>()).GetAwaiter().GetResult();
                var data = result.FirstOrDefault();
                if (result.Count > 0)
                {
                    data.start_position_lat = double.Parse(data.start_position_coord.Split(',')?.First());
                    data.start_position_lon = double.Parse(data.start_position_coord.Split(',')?.Last());
                    data.destination_lat = double.Parse(data.destination_coord.Split(',')?.First());
                    data.destination_lon = double.Parse(data.destination_coord.Split(',')?.Last());
                    data.current_asset_position_lat = double.Parse(data.current_asset_position_coord.Split(',')?.First());
                    data.current_asset_position_lon = double.Parse(data.current_asset_position_coord.Split(',')?.Last());
                    data.eta = (int)(data.duration_to_destination / 60);
                }
                return data;
            }
            else
            {
                throw new Exception("The Api call was not successful");
            }
        }
    }
}
