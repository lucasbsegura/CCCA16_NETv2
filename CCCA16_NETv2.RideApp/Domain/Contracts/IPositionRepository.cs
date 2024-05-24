using CCCA16_NETv2.RideApp.Domain.Entity;

namespace CCCA16_NETv2.RideApp.Domain.Contracts
{
    public interface IPositionRepository
    {
        void SavePosition(Position position);
    }
}
