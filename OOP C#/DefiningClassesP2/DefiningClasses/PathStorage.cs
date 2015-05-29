using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClasses
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string pathName)
        {
            string fullPath = String.Format("..\\..\\..\\Paths\\SavedPaths\\{0}.txt", pathName);
            StreamWriter writer = new StreamWriter(fullPath);
            using (writer)
            {
                for (int i = 0; i < path.Count; i++)
                {
                    writer.WriteLine(path[i]);
                }
            }
        }

        public static Path LoadPath(string pathName)
        {
            Path path = new Path();
            string fullPath = String.Format("..\\..\\..\\Paths\\SavedPaths\\{0}.txt", pathName);

            StreamReader reader = new StreamReader(fullPath);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    StringBuilder coordinates = new StringBuilder();
                    for (int i = 0; i < line.Length; i++)
                    {

                        if ((line[i] >= 48 && line[i] <= 57) || line[i] == ';' || line[i] == '.')
                        {
                            coordinates.Append(line[i]);
                        }
                    }
                    string[] coordStr = coordinates.ToString().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    double[] coord = new double[3];
                    for(int i = 0 ; i < coordStr.Length;i++)
                    {
                        coord[i] = double.Parse(coordStr[i]);
                    }

                    Point3D toAdd = new Point3D(coord[0], coord[1], coord[2]);
                    path.AddPoint(toAdd);
                    line = reader.ReadLine();
                }

                return path;
            }
        }
    }
}
