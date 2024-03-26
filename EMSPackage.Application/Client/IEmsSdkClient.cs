using EMSPackage.Application.Models;

namespace EMSPackage.Application.Client;

public interface IEmsSdkClient
{
    public Task<EmsReservationResponseModel> CreateReservationAsync(EmsReservationRequestModel requestModel);
}