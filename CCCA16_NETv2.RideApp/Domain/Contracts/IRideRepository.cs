using CCCA16_NETv2.RideApp.Domain.Entity;

namespace CCCA16_NETv2.RideApp.Domain.Contracts
{
    public interface IRideRepository
    {
        void SaveRide(Ride ride);
        Task<bool> HasActiveRideByPassengerId(Guid passenderId);
        Task<Ride> GetRideById(Guid id);
        void UpdateRide(Ride ride);
    }
}
