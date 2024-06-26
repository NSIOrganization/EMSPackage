using EMSPackage.Sdk.Dto.Category;
using EMSPackage.Sdk.Dto.Reservation;

namespace EMSPackage.Application.Models;

public record EmsReservationRequestModel(
    DateTime ReservationDate,
    decimal Price,
    bool HasCoupon,
    List<string> EventIds,
    string UserId,
    string BaseUrl,
    IDictionary<string, string> Headers)
{
    
    
    
    public EmsCreateReservationRequestDto ToDto()
    {
        decimal adjustedPrice = HasCoupon ? Price * 0.5m : Price;

        return new EmsCreateReservationRequestDto(new EmsCreateReservationDto(ReservationDate, adjustedPrice, HasCoupon, EventIds,
            UserId));
    }
}