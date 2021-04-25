using System;

namespace TSLTestApi.ViewModels
{
    public class TrackingDataViewModel
    {
        public string partitionKey { get; set; }
        public string rowKey { get; set; }
        public DateTime timestamp { get; set; }
        public string asset_fleet_no { get; set; }
        public string asset_reg_no { get; set; }
        public string client_id { get; set; }
        public string client_tracking_id { get; set; }
        public string current_asset_position_coord { get; set; }
        public string current_asset_position_download_status { get; set; }
        public string current_asset_position_name { get; set; }
        public DateTime current_asset_position_timestamp { get; set; }
        public string destination_coord { get; set; }
        public string destination_name { get; set; }
        public string dispatched_by { get; set; }
        public double distance_from_last_position { get; set; }
        public double distance_from_start { get; set; }
        public double distance_to_destination { get; set; }
        public double distance_to_workshop { get; set; }
        public double duration_to_destination { get; set; }
        public string movement_status { get; set; }
        public string return_destination_coord { get; set; }
        public string return_destination_name { get; set; }
        public string service_tracking_id { get; set; }
        public string start_position_coord { get; set; }
        public string start_position_name { get; set; }
        public string this_tracking_job_id { get; set; }
        public string time_hrs_since_last_asset_position { get; set; }
        public string tracking_interval { get; set; }
        public string tracking_type { get; set; }
        public string trip_eta { get; set; }
        public string trip_status { get; set; }
        public double start_position_lat { get; set; }
        public double start_position_lon { get; set; }
        public double destination_lat { get; set; }
        public double destination_lon { get; set; }
        public double current_asset_position_lat { get; set; }
        public double current_asset_position_lon { get; set; }
    }
}
