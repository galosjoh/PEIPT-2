using MongoDB.Bson;
using Galos_PEIPT2.Models;

namespace Galos_PEIPT2.Services
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAllReservations();
        Reservation? GetReservationById(ObjectId id);
        void AddReservation(Reservation newReservation);
        void EditReservation(Reservation updatedReservation);
        void DeleteReservation(Reservation reservationToDelete);
    }
}