namespace EMSPackage.Application.Models;

public record EmsReservationResponseModel(DateTime ReservationDate, decimal Price, bool HasCupon);
