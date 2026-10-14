## ASP Custom Middleware and Error Handling
ASP program to demonstrate global exception handling and a custom middleware that logs request metrics.

### Middleware
The program has a middleware named `RequestTimingMiddleware` that starts a stopwatch and logs the amount of time
requests take to be processed. The output is logged to the console and the history can be viewed by accessing the
`/metrics` endpoint, which returns `JSON` of the most recent 20 requests.  
#### Request History:
<img width="509" height="207" alt="request-history" src="https://github.com/user-attachments/assets/35902c3a-0ac7-4f5c-b9ac-5691c2674d96" />

### Error Handling
The program uses a global error handler which catches any errors that occur while processing middleware and
displays an error message.
#### Error Response   
<img width="497" height="179" alt="error-response" src="https://github.com/user-attachments/assets/2a250fa9-339f-4afa-8a96-ca60d596a6a9" />
