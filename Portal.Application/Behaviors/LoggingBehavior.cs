// using MediatR;
// using Portal.Common.Logging;

// namespace Portal.Application.Behaviors;

// public class LoggingBehavior<TReq, TRes> : IPipelineBehavior<TReq, TRes>
// {
//     private readonly ILogger _logger;

//     public LoggingBehavior(ILogger logger)
//     {
//         _logger = logger;
//     }

//     public async Task<TRes> Handle(
//         TReq request,
//         RequestHandlerDelegate<TRes> next,
//         CancellationToken cancellationToken)
//     {
//         _logger.Log($"Handling {typeof(TReq).Name}");
//         return await next();
//     }
// }