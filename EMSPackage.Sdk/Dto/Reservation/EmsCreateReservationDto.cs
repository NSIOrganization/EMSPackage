namespace EMSPackage.Sdk.Dto.Reservation;

public record EmsCreateReservationDto(DateTime ReservationDate, decimal Price, bool HasCoupon, List<string> EventIds, string UserId );