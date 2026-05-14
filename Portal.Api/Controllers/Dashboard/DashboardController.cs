// using MediatR;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Portal.Application.Dtos.Customer;
// using Portal.Application;
// using Portal.Application.Customers.Commands.CreateCustomer;
// using Portal.Application.Dtos.Address;
// using Portal.Application.Address.Commands;
// using Portal.Application.Customers.Query.GetAllCustomer;
// using Portal.Application.Customers.Query.GetAddress;
// using Microsoft.AspNetCore.Authorization;
// // using static Portal.Application.Common.Enums;
// using Portal.Domain.Models.Address;
// using Portal.Application.Dashboard.Query;
// using Portal.Application.Dtos.Quote;
// using Portal.Application.Dtos.Order;
// using Portal.Application.Dashboard.Query.Order;
// using Portal.Application.Dtos.Dashboard.Order;
// using Portal.Application.Dtos.Dashboard.Quote;
// using Portal.Application.Dashboard.Query.Quote;
// using Portal.Application.Dtos.Dashboard.Announcement;
// using Portal.Application.Dashboard.Query.Announcement;
// using Portal.Application.Dtos.Dashboard.Performance;
// using Portal.Application.Dashboard.Query.Performance;
// using Portal.Application.Inventory.Query;
// using Portal.Application.Dtos.Dashboard.Appointment;
// using Portal.Application.Dashboard.Query.Appointment;

// namespace Portal.Api.Controllers.Dashboard
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class DashboardController : BaseAPIController
//     {
//         private readonly IMediator _mediator;
//         public DashboardController(IMediator mediator)
//         {
//             _mediator = mediator;
//         }
        
//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardQuotesList")]

//         public async Task<ActionResult<APIResponse<List<DashboardQuotesListDto>>>> GetDashboardQuotesList(
//             CancellationToken cancellationToken,
//             QuoteSearchOption SearchBy = QuoteSearchOption.All,
//             string ?SearchValue ="",
//             string ?StoreNo = ""
//             )
//         {
//             APIResponse<List<DashboardQuotesListDto>> responce = new APIResponse<List<DashboardQuotesListDto>>();
//             var query = new GetDashboardQuotesListQuery( SearchBy, SearchValue , StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }
//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardOrderList")]

//         public async Task<ActionResult<APIResponse<List<DashboardOrderListDto>>>> GetDashboardOrderList(
//             CancellationToken cancellationToken,
//             OrderSearchOption SearchBy = OrderSearchOption.All,
//             string? SearchValue = "",
//             string? StoreNo = ""
//             )
//         {
//             APIResponse<List<DashboardOrderListDto>> responce = new APIResponse<List<DashboardOrderListDto>>();
//             var query = new GetDashboardOrderListQuery(SearchBy, SearchValue, StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }
//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardQuotesStatus")]

//         public async Task<ActionResult<APIResponse<List<DashboardQuotesStatusDto>>>> GetDashboardQuotesStatus(
//             CancellationToken cancellationToken,
//             QuoteSearchOption SearchBy = QuoteSearchOption.All,
//             string? SearchValue = "",
//             string? StoreNo =""
//             )
//         {
//             APIResponse<List<DashboardQuotesStatusDto>> responce = new APIResponse<List<DashboardQuotesStatusDto>>();
//             var query = new GetDashboardQuotesStatusQuery(SearchBy, SearchValue, StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }
//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardOrderStatus")]

//         public async Task<ActionResult<APIResponse<List<DashboardOrderStatusDto>>>> GetDashboardOrderStatus(
//             CancellationToken cancellationToken,
//             OrderSearchOption SearchBy = OrderSearchOption.All,
//             string? SearchValue = "",
//             string? StoreNo = ""
//             )
//         {
//             APIResponse<List<DashboardOrderStatusDto>> responce = new APIResponse<List<DashboardOrderStatusDto>>();
//             var query = new GetDashboardOrderStatusQuery(SearchBy, SearchValue, StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }
//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getYearDashboardOrderStatus")]

//         public async Task<ActionResult<APIResponse<List<DashboardYearOrderStatusDto>>>> GetYearDashboardOrderStatus(
//             CancellationToken cancellationToken,
//             OrderSearchOption SearchBy = OrderSearchOption.All,
//             string? SearchValue = "",
//             string? StoreNo =""
//             )
//         {
//             APIResponse<List<DashboardYearOrderStatusDto>> responce = new APIResponse<List<DashboardYearOrderStatusDto>>();
//             var query = new GetYearDashboardOrderStatusQuery(SearchBy, SearchValue, StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }



//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardAnnouncementBanner")]

//         public async Task<ActionResult<APIResponse<List<AnnouncementBannerDto>>>> GetDashboardAnnouncementBanner(
//             CancellationToken cancellationToken,
//             AnnouncementSearchOption SearchBy = AnnouncementSearchOption.All,
//             string? SearchValue = "",
//             string? StoreNo =""
//             )
//         {
//             APIResponse<List<AnnouncementBannerDto>> responce = new APIResponse<List<AnnouncementBannerDto>>();
//             var query = new GetDashboardAnnouncementBannerQuery(SearchBy, SearchValue, StoreNo);
//             responce = await _mediator.Send(query, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }

//         [HttpGet]
//         [Microsoft.AspNetCore.Mvc.Route("getDashboardPerformance")]

//         public async Task<ActionResult<APIResponse<PerformanceDto>>> GetDashboardPerformance(
//             CancellationToken cancellationToken,
//             PerformanceSearchOption SearchBy = PerformanceSearchOption.All,
//             string StoreNo  = "",
//             string? SearchValue = ""
//             )
//         {
//             APIResponse<PerformanceDto> responce = new APIResponse<PerformanceDto>();
//             try
//             {
//                 var query = new GetDashboardPerformanceQuery(SearchBy, StoreNo, SearchValue);
//                 responce = await _mediator.Send(query, cancellationToken);
//                 if (responce.IsSuccess)
//                 {
//                     return Ok(responce);
//                 }
//                 else
//                 {
//                     return StatusCode(responce.StatusCode, responce);
//                 }
//             }
//             catch (Exception ex) 
//             {
//                 return BadRequest(ex.Message);
//             }
//         }

//         [HttpPost]
//         [Route("appointments")]
//         public async Task<ActionResult<APIResponse<object>>> Appointments(GetAppointmentDto getAppointmentsDto, CancellationToken cancellationToken)
//         {
//             APIResponse<object> responce = new APIResponse<object>();
//             var command = new AppointmentQuery(getAppointmentsDto);
//             responce = await _mediator.Send(command, cancellationToken);
//             if (responce.IsSuccess)
//             {
//                 return Ok(responce);
//             }
//             else
//             {
//                 return StatusCode(responce.StatusCode, responce);
//             }
//         }
//     }
// }
