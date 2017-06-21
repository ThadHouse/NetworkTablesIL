public class FunctionDef
    {
        public string name { get; set; }
        public string retType { get; set; }
        [JsonProperty(propertyName: "params")]
        public List<ParamDef> param { get; set; }
    }

    public class ParamDef
    {
        public string name { get; set; }
        public string type { get; set; }
    }
