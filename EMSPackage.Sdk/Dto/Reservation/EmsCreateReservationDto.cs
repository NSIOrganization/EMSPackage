namespace EMSPackage.Sdk.Dto.Reservation;

public record EmsCreateReservationDto(DateTime ReservationDate, decimal Price, bool hasCupon, Guid EventId, string UserId );