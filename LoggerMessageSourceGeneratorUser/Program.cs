// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Logging;

Console.WriteLine("Hello, World!");

internal static partial class LoggerExtensions
{
    [LoggerMessage(
        EventId = 10,
        Level = LogLevel.Error,
        Message = "The handler with id [{requestId:D}] failed processing request")]
    public static partial void HandlerError(this ILogger logger, Guid requestId);
}   