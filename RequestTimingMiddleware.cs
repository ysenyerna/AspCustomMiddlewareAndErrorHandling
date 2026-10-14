using System.Diagnostics;

// Middleware class
public class RequestTimingMiddleware
{
	private readonly RequestDelegate _next;

	public readonly static List<string> recentRequests = [];

	public RequestTimingMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext context)
	{
		// Start a stopwatch
		var stopwatch = Stopwatch.StartNew();

		// Call next()
		await _next(context);

		// Log the elasped time
		stopwatch.Stop();
		var log = $"Request: {context.Request.Method} {context.Request.Path}, Time Elapsed: {stopwatch.ElapsedMilliseconds}ms";
		Console.WriteLine(log);
		if (recentRequests.Count >= 20)
			recentRequests.RemoveAt(0);
		recentRequests.Add(log);

	}
}
