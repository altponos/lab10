using Newtonsoft.Json.Linq;

JArray array = new JArray();
array.Add(new DateTime(2005, 1, 11));

JObject o = new JObject();
o["NeArray"] = array;

string json = o.ToString();
Console.WriteLine(json);
