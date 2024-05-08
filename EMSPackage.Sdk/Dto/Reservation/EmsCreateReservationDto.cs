namespace EMSPackage.Sdk.Dto.Reservation;

public record EmsCreateReservationDto(DateTime ReservationDate, decimal Price, bool hasCupon, List<string> EventIds, string UserId );