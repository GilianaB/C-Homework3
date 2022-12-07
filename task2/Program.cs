double abc=0;
double [] points = new double [6];
for (int i=0; i < points.Length; i++)
points[i] = Convert.ToDouble(Console.ReadLine());
abc=Math.Sqrt((points[3]-points[0])*(points[3]-points[0])+(points[4]-points[1])*(points[4]-points[1])+(points[5]-points[2])*(points[5]-points[2]));
Console.WriteLine(abc);