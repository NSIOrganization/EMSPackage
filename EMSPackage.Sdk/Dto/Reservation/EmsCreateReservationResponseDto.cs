namespace EMSPackage.Sdk.Dto.Category;

public record EmsCreateReservationResponseDto(DateTime ReservationDate, decimal Price, bool HasCupon);