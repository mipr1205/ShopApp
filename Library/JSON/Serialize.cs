using System.Collections.Generic;
using Newtonsoft.Json;


namespace Library
{
    public static class Serialize
    {
        public static string ToJson(this List<Customer> self) => JsonConvert.SerializeObject(self, Library.JSON.Converter.Settings);
    }
}
