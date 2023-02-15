using Newtonsoft.Json;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.JsonTraining.Models
{
    internal class Shop
    {
        [JsonProperty("client")]
        public string? Client { get; set; }
        public string? collectionName { get; set; }
        public string? dateExported { get; set; }
        public string? version { get; set; }
        public List<object>? folders { get; set; } = new();
        public List<Request>? requests { get; set; }=new List<Request>();

    }

    class Folder
    {
        public string? containerId { get; set; } = "Folder";
        public int sortNum { get; set; }=12;
        public string? name { get; set; }="Folder";
        public string? _id { get; set; }="Folder";
        public string? created { get; set; }="Folder";
    }
    class Request
    {
        public string? containerId { get; set; }
        public int sortNum { get; set; }
        public List<Header>? headers { get; set; }= new List<Header>(); 
        public string? colId { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
        public string? method { get; set; }
        public string? modified { get; set; }
        public string? created { get; set; }
        public string? _id { get; set; }

        [JsonProperty("params")]
        public List<object>? parametres { get; set; } = new();
        public List<object>? tests { get; set; }= new();
    }
    class Header
    {
        public string name { get; set; } = "HeaderName";
        public string value { get; set; } = "HeaderValue";
    }
}
