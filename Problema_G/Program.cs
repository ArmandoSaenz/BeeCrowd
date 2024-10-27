using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_G
{
    internal class Program
    {
        static int[,] image, imagetmp;
        static int[] vecindad4 = new int[4], vecindad8 = new int[8];
        static double fire = 0;
        const int invalid = -1;
        static List<(int, int)> positionsToUpdate = new List<(int, int)>();

        static void ActualizarVecindad(int i, int j)
        {
            vecindad8[0] = (i > 0 && j > 0) ? image[i - 1, j - 1] : invalid;
            vecindad4[0] = vecindad8[1] = (j > 0) ? image[i, j - 1] : invalid;
            vecindad8[2] = (i < image.GetLength(0) - 1 && j > 0) ? image[i + 1, j - 1] : invalid;
            vecindad4[1] = vecindad8[3] = (i > 0) ? image[i - 1, j] : invalid;
            vecindad4[2] = vecindad8[4] = (i < image.GetLength(0) - 1) ? image[i + 1, j] : invalid;
            vecindad8[5] = (i > 0 && j < image.GetLength(1) - 1) ? image[i - 1, j + 1] : invalid;
            vecindad4[3] = vecindad8[6] = (j < image.GetLength(1) - 1) ? image[i, j + 1] : invalid;
            vecindad8[7] = (i < image.GetLength(0) - 1 && j < image.GetLength(1) - 1) ? image[i + 1, j + 1] : invalid;
        }

        static void ActualizarPixel(int i, int j)
        {
            int originalValue = image[i, j];
            if (originalValue == 1)
            {
                imagetmp[i, j] = Array.Exists(vecindad8, item => item == 0) ? Math.Sign(++fire) - 1 : 1;
            }
            else
            {
                int cnt = 0;
                for (int k = 0; k < 4; k++) if (vecindad4[k] == 0) cnt++;
                imagetmp[i, j] = cnt > (originalValue - 2) ? Math.Sign(++fire) - 1 : originalValue;
            }
        }

        static void ProcesarImagen(int N, int M)
        {
            imagetmp = new int[N,M];
            Array.Copy(image, imagetmp, image.Length);
            positionsToUpdate.RemoveAll(pos =>
            {
                int i = pos.Item1, j = pos.Item2;
                ActualizarVecindad(i, j);
                ActualizarPixel(i, j);

                // Si el pixel ha cambiado, agregamos las posiciones vecinas para actualizar en la siguiente iteración
                return imagetmp[i, j] == 0;
             });

            image = imagetmp;
        }

        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int N = int.Parse(data[0]);
            int M = int.Parse(data[1]);
            int T = int.Parse(data[2]);

            image = new int[N, M];
            for (int i = 0; i < N; ++i)
            {
                var tmp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < M; ++j)
                {
                    image[i, j] = tmp[j];
                    if (tmp[j] == 0) fire++;
                    else if (tmp[j] != 5) positionsToUpdate.Add((i, j));  // Solo agregamos posiciones no cero
                }
            }

            int time = 0;
            while (T > time++ && positionsToUpdate.Count > 0) // Se detiene si no hay más cambios
            {
                ProcesarImagen(N, M);
                //PrintMatrix(image);
                //Console.ReadLine(); 
            }


            Console.WriteLine(fire);
            //Console.ReadLine();
        }
        static void PrintMatrix(int[,] image)
        {
            int N = image.GetLength(0);
            int M = image.GetLength(1);
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                    Console.Write(image[i, j]);
                Console.WriteLine();
            }
        }
    }
}




//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Problema_G
//{
//    internal class Program
//    {

//        static int[,] image, imagetmp;
//        static int[] vecindad4 = new int[4], vecindad8 = new int[8];
//        static int fire = 0;
//        const int invalid = -1;
//        static void ActualizarPixel(int i, int j)
//        {
//            if (image[i, j] == 1)
//            {
//                imagetmp[i, j] = vecindad8.Count(item => item == 0) > 0 ? Math.Sign(++fire) - 1 : 1;
//            }
//            else
//            {
//                int cnt = vecindad4.Count(item => item == 0);
//                switch (image[i, j])
//                {
//                    case 2:
//                        imagetmp[i, j] = cnt > 0 ? Math.Sign(++fire) - 1 : 2;
//                        break;
//                    case 3:
//                        imagetmp[i, j] = cnt > 1 ? Math.Sign(++fire) - 1 : 3;
//                        break;
//                    case 4:
//                        imagetmp[i, j] = cnt > 2 ? Math.Sign(++fire) - 1 : 4;
//                        break;
//                }
//            }
//        }
//        static void PrintMatrix(int[,] image)
//        {
//            int N = image.GetLength(0);
//            int M = image.GetLength(1);
//            for (int i = 0; i < N; ++i)
//            {
//                for (int j = 0; j < M; ++j)
//                    Console.Write(image[i, j]);
//                Console.WriteLine();
//            }
//        }
//        static void Main(string[] args)
//        {
//            int N, M, T, time = 0;
//            string line;
//            string[] data;
//            line = Console.ReadLine();
//            data = line.Split(' ');
//            N = int.Parse(data[0]);
//            M = int.Parse(data[1]);
//            T = int.Parse(data[2]);
//            image = new int[N, M];
//            for (int i = 0; i < N; ++i)
//            {
//                line = Console.ReadLine();
//                var tmp = Array.ConvertAll<string, int>(line.Split(' '), int.Parse).Select((pixel, idx) => image[i, idx] = pixel).ToArray();
//                fire += tmp.Count(item => item == 0);
//            }
//            do
//            {
//                //Operación Convolución
//                imagetmp = new int[N, M];
//                Array.Copy(image, imagetmp, image.Length);
//                for (int i = 1; i < N - 1; ++i)
//                {
//                    for (int j = 1; j < M - 1; ++j)
//                    {
//                        if (image[i, j] == 0 || image[i, j] == 5)
//                            continue;
//                        vecindad8[0] = image[i - 1, j - 1];
//                        vecindad4[0] = vecindad8[1] = image[i, j - 1];
//                        vecindad8[2] = image[i + 1, j - 1];
//                        vecindad4[1] = vecindad8[3] = image[i - 1, j];
//                        vecindad4[2] = vecindad8[4] = image[i + 1, j];
//                        vecindad8[5] = image[i - 1, j + 1];
//                        vecindad4[3] = vecindad8[6] = image[i, j + 1];
//                        vecindad8[7] = image[i + 1, j + 1];
//                        ActualizarPixel(i, j);
//                    }
//                }
//                for (int i = 1; i < N - 1; ++i)
//                {
//                    if (image[i, 0] != 0 && image[i, 0] != 50)
//                    {
//                        vecindad8[0] = invalid;
//                        vecindad4[0] = vecindad8[1] = invalid;
//                        vecindad8[2] = invalid;
//                        vecindad4[1] = vecindad8[3] = image[i - 1, 0];
//                        vecindad4[2] = vecindad8[4] = image[i + 1, 0];
//                        vecindad8[5] = image[i - 1, 1];
//                        vecindad4[3] = vecindad8[6] = image[i, 1];
//                        vecindad8[7] = image[i + 1, 1];
//                        ActualizarPixel(i, 0);
//                    }
//                    if (image[i, M - 1] != 0 && image[i, M - 1] != 5)
//                    {
//                        vecindad8[0] = image[i - 1, M - 2];
//                        vecindad4[0] = vecindad8[1] = image[i, M - 2];
//                        vecindad8[2] = image[i + 1, M - 2]; ;
//                        vecindad4[1] = vecindad8[3] = image[i - 1, M - 1];
//                        vecindad4[2] = vecindad8[4] = image[i + 1, M - 1];
//                        vecindad8[5] = invalid;
//                        vecindad4[3] = invalid;
//                        vecindad8[7] = invalid;
//                        ActualizarPixel(i, M - 1);
//                    }
//                }
//                for (int j = 1; j < M - 1; ++j)
//                {
//                    if (image[0, j] != 0 && image[0, j] != 5)
//                    {
//                        vecindad8[0] = invalid;
//                        vecindad4[0] = vecindad8[1] = image[0, j - 1];
//                        vecindad8[2] = image[1, j - 1];
//                        vecindad4[1] = vecindad8[3] = invalid;
//                        vecindad4[2] = vecindad8[4] = image[1, j];
//                        vecindad8[5] = invalid;
//                        vecindad4[3] = vecindad8[6] = image[0, j + 1];
//                        vecindad8[7] = image[1, j + 1];
//                        ActualizarPixel(0, j);
//                    }
//                    if (image[N - 1, j] != 0 && image[N - 1, j] != 5)
//                    {
//                        vecindad8[0] = image[N - 2, j - 1];
//                        vecindad4[0] = vecindad8[1] = image[N - 1, j - 1];
//                        vecindad8[2] = invalid;
//                        vecindad4[1] = vecindad8[3] = image[N - 2, j];
//                        vecindad4[2] = vecindad8[4] = invalid;
//                        vecindad8[5] = image[N - 2, j + 1];
//                        vecindad4[3] = vecindad8[6] = image[N - 1, j + 1];
//                        vecindad8[7] = invalid;
//                        ActualizarPixel(N - 1, j);
//                    }
//                }
//                //celda superior izquierda
//                if (image[0, 0] != 0 && image[N - 1, M - 1] != 5)
//                {
//                    vecindad8[0] = invalid;
//                    vecindad4[0] = vecindad8[1] = invalid;
//                    vecindad8[2] = invalid;
//                    vecindad4[1] = vecindad8[3] = invalid;
//                    vecindad4[2] = vecindad8[4] = image[1, 0];
//                    vecindad8[5] = invalid;
//                    vecindad4[3] = vecindad8[6] = image[0, 1];
//                    vecindad8[7] = image[1, 1];
//                    ActualizarPixel(0, 0);
//                }
//                //celda superior derecha
//                if (image[N - 1, 0] != 0 && image[N - 1, M - 1] != 5)
//                {
//                    vecindad8[0] = invalid;
//                    vecindad4[0] = vecindad8[1] = invalid;
//                    vecindad8[2] = invalid;
//                    vecindad4[1] = vecindad8[3] = image[N - 2, 0];
//                    vecindad4[2] = invalid;
//                    vecindad8[5] = image[N - 2, 1];
//                    vecindad4[3] = image[N - 1, 1];
//                    vecindad8[7] = invalid;
//                    ActualizarPixel(N - 1, 0);
//                }
//                //celda inferior izquierda
//                if (image[0, M - 1] != 0 && image[N - 1, M - 1] != 5)
//                {
//                    vecindad8[0] = invalid;
//                    vecindad4[0] = vecindad8[1] = image[0, M - 2];
//                    vecindad8[2] = image[1, M - 2];
//                    vecindad4[1] = vecindad8[3] = invalid;
//                    vecindad4[2] = vecindad8[4] = image[1, M - 1];
//                    vecindad8[5] = invalid;
//                    vecindad4[3] = vecindad8[6] = invalid;
//                    vecindad8[7] = invalid;
//                    ActualizarPixel(0, M - 1);
//                }
//                //celda inferior derecha
//                if (image[N - 1, M - 1] != 0 && image[N - 1, M - 1] != 5)
//                {
//                    vecindad8[0] = image[N - 2, M - 2];
//                    vecindad4[0] = vecindad8[1] = image[N - 1, M - 2];
//                    vecindad8[2] = invalid;
//                    vecindad4[1] = vecindad8[3] = image[N - 2, M - 1]; ;
//                    vecindad4[2] = vecindad8[4] = invalid;
//                    vecindad8[5] = invalid;
//                    vecindad4[3] = vecindad8[6] = invalid;
//                    vecindad8[7] = invalid;
//                    ActualizarPixel(N - 1, M - 1);
//                }
//                image = imagetmp;
//                //PrintMatrix(image);

//                //Console.ReadLine();
//                ++time;
//            }
//            while (T > time);
//            Console.WriteLine(fire);
//            Console.ReadLine();
//        }
//    }
//}
