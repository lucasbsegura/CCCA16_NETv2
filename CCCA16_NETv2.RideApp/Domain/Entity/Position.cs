using CCCA16_NETv2.RideApp.Domain.Vo;

namespace CCCA16_NETv2.RideApp.Domain.Entity
{
    public class Position(Guid positionId, Guid rideId, Coord coord, DateTime date)
    {
        public Guid PositionId { get; } = positionId;
        public Guid RideId { get; } = rideId;
        public Coord Coord { get; } = coord;
        public DateTime Date { get; } = date;

        public static Position Create(Guid rideId, decimal latitude, decimal longitude)
        {
            var positionId = Guid.NewGuid();
            var date = DateTime.Now;
            return new Position(positionId, rideId, new Coord(latitude, longitude), date);
        }

        public static Position Restore(Guid positionId, Guid rideId, decimal latitude, decimal longitude, DateTime date)
        {
            return new Position(positionId, rideId, new Coord(latitude, longitude), date);
        }
    }
}
