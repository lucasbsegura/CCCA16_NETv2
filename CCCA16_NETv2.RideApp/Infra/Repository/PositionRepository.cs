using CCCA16_NETv2.RideApp.Domain.Contracts;
using CCCA16_NETv2.RideApp.Domain.Entity;
using CCCA16_NETv2.RideApp.Infra.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCCA16_NETv2.RideApp.Infra.Repository
{
    public class PositionRepository(IDbService connection) : IPositionRepository
    {
        private readonly IDbService _connection = connection;

        public async void SavePosition(Position position)
        {
            var positionDb = new PositionDb(position.PositionId, position.RideId, position.Coord.GetLatitude(), position.Coord.GetLongitude(), position.Date);
            var result = await _connection.EditData(
            "INSERT INTO cccat16.position (position_id, ride_id, lat, long, date) " +
            "VALUES (@PositionId, @RideId, @Latitude, @Longitude, @Date)",
            positionDb);
        }
    }

    public class PositionDb(Guid positionId, Guid rideId, decimal latitude, decimal longitude, DateTime date)
    {
        [Column("position_id")]
        public Guid PositionId { get; } = positionId;
        [Column("ride_id")]
        public Guid RideId { get; } = rideId;
        [Column("lat")]
        public decimal Latitude { get; } = latitude;
        [Column("long")]
        public decimal Longitude { get; } = longitude;
        public DateTime Date { get; } = date;
    }
}
