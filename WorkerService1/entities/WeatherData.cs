using System.Text.Json.Serialization;

namespace WorkerService1.entities
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("region")]
        public string Region;

        [JsonPropertyName("country")]
        public string Country;

        [JsonPropertyName("lat")]
        public double Lat;

        [JsonPropertyName("lon")]
        public double Lon;

        [JsonPropertyName("tz_id")]
        public string TzId;

        [JsonPropertyName("localtime_epoch")]
        public int LocaltimeEpoch;

        [JsonPropertyName("localtime")]
        public string Localtime;
    }

    public class Condition
    {
        [JsonPropertyName("text")]
        public string Text;

        [JsonPropertyName("icon")]
        public string Icon;

        [JsonPropertyName("code")]
        public int Code;
    }

    public class Current
    {
        [JsonPropertyName("last_updated_epoch")]
        public int LastUpdatedEpoch;

        [JsonPropertyName("last_updated")]
        public string LastUpdated;

        [JsonPropertyName("temp_c")]
        public double TempC;

        [JsonPropertyName("temp_f")]
        public double TempF;

        [JsonPropertyName("is_day")]
        public int IsDay;

        [JsonPropertyName("condition")]
        public Condition Condition;

        [JsonPropertyName("wind_mph")]
        public double WindMph;

        [JsonPropertyName("wind_kph")]
        public double WindKph;

        [JsonPropertyName("wind_degree")]
        public int WindDegree;

        [JsonPropertyName("wind_dir")]
        public string WindDir;

        [JsonPropertyName("pressure_mb")]
        public double PressureMb;

        [JsonPropertyName("pressure_in")]
        public double PressureIn;

        [JsonPropertyName("precip_mm")]
        public double PrecipMm;

        [JsonPropertyName("precip_in")]
        public double PrecipIn;

        [JsonPropertyName("humidity")]
        public int Humidity;

        [JsonPropertyName("cloud")]
        public int Cloud;

        [JsonPropertyName("feelslike_c")]
        public double FeelslikeC;

        [JsonPropertyName("feelslike_f")]
        public double FeelslikeF;

        [JsonPropertyName("vis_km")]
        public double VisKm;

        [JsonPropertyName("vis_miles")]
        public double VisMiles;

        [JsonPropertyName("uv")]
        public double Uv;

        [JsonPropertyName("gust_mph")]
        public double GustMph;

        [JsonPropertyName("gust_kph")]
        public double GustKph;
    }

    public class WeatherData
    {
        [JsonPropertyName("location")]
        public Location Location;

        [JsonPropertyName("current")]
        public Current Current;
    }


}