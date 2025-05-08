using Microsoft.AspNetCore.Http;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{


    public class HeaderValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Dictionary<string, string> _requiredHeaders;

        public HeaderValidationMiddleware(RequestDelegate next)
        {
            _next = next;

            // Zorunlu header'lar ve beklenen değerler (config'den de alınabilir)
            _requiredHeaders = new Dictionary<string, string>
                                                        {
                                                            { "Ocp-Apim-Subscription-Key", "your-expected-subscription-key-value" },
                                                            { "Content-Type", "application/json" },
                                                            { "Authorization", "Test" }
                                                            // Diğer header'ları buraya ekleyebilirsiniz
                                                        };
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var missingHeaders = new List<string>();
            var invalidHeaders = new List<string>();

            // Tüm zorunlu header'ları kontrol et
            foreach (var header in _requiredHeaders)
            {
                if (!context.Request.Headers.ContainsKey(header.Key))
                {
                    missingHeaders.Add(header.Key);
                    continue;
                }

                var headerValue = context.Request.Headers[header.Key].ToString();
                if (!string.Equals(headerValue, header.Value, StringComparison.OrdinalIgnoreCase))
                {
                    invalidHeaders.Add(header.Key);
                }
            }

            if (missingHeaders.Any() || invalidHeaders.Any())
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(new
                {
                    Success = false,
                    Message = "Invalid or missing headers",
                    MissingHeaders = missingHeaders,
                    InvalidHeaders = invalidHeaders,
                    Timestamp = DateTime.UtcNow
                });
                return;
            }

            // Header'lar doğruysa pipeline'a devam et
            await _next(context);
        }
    }
}