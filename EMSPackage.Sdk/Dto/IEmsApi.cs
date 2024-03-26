using EMSPackage.Sdk.Dto.Category;
using Refit;

namespace EMSPackage.Sdk.Dto;

public interface IEmsApi
{
    [Post("/webhook/CategoryWebhook/CreateCategory")]
    public Task<EmsCreateReservationResponseDto> CreateProductAsync(EmsCreateReservationRequestDto request, [HeaderCollection] IDictionary<string, string> headers);
}