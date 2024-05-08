namespace EMSPackage.Sdk.Dto.Reservation;

public record EmsCreateReservationDto(DateTime ReservationDate, decimal Price, bool hasCupon, List<Guid> EventIds, string UserId );