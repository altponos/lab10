using Newtonsoft.Json.Linq;

JArray array = new JArray();
array.Add(new DateTime(2005, 1, 11));
array.Add(new DateTime(2007, 12, 14));

JObject o = new JObject();
o["NeArray"] = array;

string json = o.ToString();
Console.WriteLine(json);

Console.WriteLine(0 / int.Parse("0"));
