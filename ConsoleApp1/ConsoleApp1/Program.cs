using Newtonsoft.Json.Linq;

JArray array = new JArray();
array.Add("cool date next entry :)))))))");
array.Add(new DateTime(2001, 9, 11));

JObject o = new JObject();
o["MyArray"] = array;

string json = o.ToString();
Console.WriteLine(json);