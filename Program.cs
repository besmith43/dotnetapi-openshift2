using System.Net.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
	using HttpResponseMessage response = new HttpClient().GetAsync("http://dotnetapi-openshift-git.demo:5000/").Result;

	return $"Hello World from C# on { System.Net.Dns.GetHostEntry(string.Empty).HostName }\napi version 1.0\n{ response.content }";
	});

app.Run();
