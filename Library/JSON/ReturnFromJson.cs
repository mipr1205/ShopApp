using Library.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.JSON
{
    public class ReturnFromJson<T> where T:IEntity
    {
        public static List<T> FromJson(string json) => JsonConvert.DeserializeObject<List<T>>(json, Library.JSON.Converter.Settings);
    }
}
