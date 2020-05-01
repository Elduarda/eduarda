namespace MobileCamoes.Infra
{
    public class AppSettings
    {
        public const string ApiUrl = "https://api.themoviedb.org/3";
        public const string ApiKey = "5e24c8d754be7a8e2ed368324ca41272";
        public const string ApiImageBaseUrl = "https://image.tmdb.org/t/p/w500/";

        public static string OfflineDataBaseLiteDBPath { get; set; }
        public static string OfflineDataBaseSQLitePath { get; set; }
        public static string OfflineFileSystemPath { get; set; }
    }
}
