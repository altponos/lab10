using Newtonsoft.Json.Linq;

JArray array = new JArray();
array.Add("text");
array.Add(new DateTime(2005, 1, 11));

JObject o = new JObject();
o["MyArray"] = array;

string json = o.ToString();
Console.WriteLine(json);