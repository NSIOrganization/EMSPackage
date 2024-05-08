using EMSPackage.Sdk.Dto.Category;
using Refit;

namespace EMSPackage.Sdk.Dto;

public interface IEmsApi
{
    [Post("/webhook/ReservationWebhook/CreateReservation")]
    public Task<EmsCreateReservationResponseDto> CreateReservationAsync([Body] EmsCreateReservationRequestDto request, [HeaderCollection] IDictionary<string, string> headers);
}