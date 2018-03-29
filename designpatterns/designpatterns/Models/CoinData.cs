using Json = Newtonsoft.Json.JsonPropertyAttribute;


namespace designpatterns
{
    public class CoinData
    {
        [Json("id")]
        public string Id { get; set; }
        [Json("name")]
        public string Name { get; set; }
        [Json("symbol")]
        public string Symbol { get; set; }
        [Json("rank")]
        public string Rank { get; set; }
        [Json("price_usd")]
        public string PriceUsd { get; set; }
        [Json("price_btc")]
        public string PriceBtc { get; set; }
        [Json("24h_volume_usd")]
        public string The24HVolumeUsd { get; set; }
        [Json("market_cap_usd")]
        public string MarketCapUsd { get; set; }
        [Json("available_supply")]
        public string AvailableSupply { get; set; }
        [Json("total_supply")]
        public string TotalSupply { get; set; }
        [Json("max_supply")]
        public string MaxSupply { get; set; }
        [Json("percent_change_1h")]
        public string PercentChange1H { get; set; }
        [Json("percent_change_24h")]
        public string PercentChange24H { get; set; }
        [Json("percent_change_7d")]
        public string PercentChange7D { get; set; }
        [Json("last_updated")]
        public string LastUpdated { get; set; }
    }
}
