using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Reservoom.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine($"Result of Equals => {obj is RoomID roomID1 && FloorNumber == roomID1.FloorNumber && RoomNumber == roomID1.RoomNumber}");
            return obj is RoomID roomID &&
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public static bool operator ==(RoomID left, RoomID right)
        {
            Console.WriteLine($"First Result of left is null && right is null => {left is null && right is null}");
            if (left is null && right is null) return true;

            Console.WriteLine($"Second Result of left is null && right is null => {!(left is null) && left.Equals(right)}");
            return !(left is null) && left.Equals(right);
        }

        public static bool operator !=(RoomID left, RoomID right)
        {
            Console.WriteLine($"Result of != => {!(left == right)}");
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
    }
}
