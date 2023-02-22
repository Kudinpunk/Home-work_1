/* Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int dist_ab_x = xa - xb;
    int dist_ab_y = ya - yb;
    int dist_ab_z = za - zb;
    double distance_ab = Math.Sqrt(dist_ab_x * dist_ab_x + 
    dist_ab_y * dist_ab_y + dist_ab_z * dist_ab_z);
    return distance_ab;
}

Console.WriteLine("Input x for a: ");
int x_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y for a: ");
int y_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input z for a: ");
int z_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x for b: ");
int x_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y for b: ");
int y_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input z for b: ");
int z_b = Convert.ToInt32(Console.ReadLine());

double distance_AB_3d = Math.Round(DistanceAB(x_a, y_a, z_a, x_b, y_b, z_b), 2);
Console.Write($"Distance between A and B in 3d spaced = {distance_AB_3d}");