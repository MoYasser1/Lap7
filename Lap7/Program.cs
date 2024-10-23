namespace Lap7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter coordinates for P1 (x, y, z):");
                Point3D P1 = ReadPoint();
                Console.WriteLine("Enter coordinates for P2 (x, y, z):");
                Point3D P2 = ReadPoint();
                if (P1.Equals(P2))
                {
                    Console.WriteLine("P1 and P2 are equal0");
                }
                else
                {
                    Console.WriteLine("P1 and P2 are not equal");
                }
                Console.WriteLine("P1: " + P1.ToString());
                Console.WriteLine("P2: " + P2.ToString());
            }
            catch (Exception ex) {
                Point3D.LogError(ex.Message);
                Console.WriteLine("error log");
            }

        }

        static Point3D ReadPoint()
        {
            int x, y, z;

            try
            {
                Console.Write("X: ");
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("enter X");
                }

                Console.Write("Y: ");
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("enter Y");
                }

                Console.Write("Z: ");
                while (!int.TryParse(Console.ReadLine(), out z))
                {
                    Console.WriteLine("enter Z.");
                }

                return Point3D.CreatePoint(x, y, z);
            }
            catch (Exception ex)
            {
                Point3D.LogError($"Error reading point coordinates: {ex.Message}");
                throw;
            }
        } 
    }
}
