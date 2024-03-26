using EMSPackage.Application.Extensions;
using EMSPackage.Application.Models;
using EMSPackage.Sdk.Dto;

namespace EMSPackage.Application.Client;

public class EmsSdkClient(IEmsApi api) : IEmsSdkClient
{
    public async Task<EmsReservationResponseModel> CreateReservationAsync(EmsReservationRequestModel requestModel)
    {
        var result = await api.CreateReservationAsync(requestModel.ToDto(), requestModel.Headers);
        return result.ToModel();
    }
}