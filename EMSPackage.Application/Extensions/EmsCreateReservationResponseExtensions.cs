using EMSPackage.Application.Models;
using EMSPackage.Sdk.Dto.Category;

namespace EMSPackage.Application.Extensions;

public static class EmsCreateReservationResponseExtensions
{
    public static EmsReservationResponseModel ToModel(this EmsCreateReservationResponseDto dto)
    {
        return new EmsReservationResponseModel(dto.ReservationDate, dto.Price, dto.HasCupon);
    }
}