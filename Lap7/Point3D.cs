using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap7
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private Point3D() : this(0, 0, 0) { }

        private Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Point3D CreatePoint(int x, int y, int z)
        {
            return new Point3D(x, y, z);
        }
        public override string ToString()
        {
            return $"Point({X}, {Y}, {Z})";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point3D p = (Point3D)obj;
            return (X == p.X && Y == p.Y && Z == p.Z);
        }
        public override int GetHashCode()
        {
            return (X, Y, Z).GetHashCode();
        }
        public static void LogError(string message)
        {
            using (StreamWriter writer = new StreamWriter("errors.log", true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }

    }
