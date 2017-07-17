using System;
using System.Collections.Generic;
using System.Drawing;

namespace EulerCharacteristicOnHexagonalLattice
{
    /// <summary>
    /// Класс, создающий гексогональную сетку
    /// </summary>
    public class HexagonalLattice
    {
        /// <summary>
        /// Радиус гексогона
        /// </summary>
        private int radius = 35;
        /// <summary>
        /// Количество сторон гексогона
        /// </summary>
        private const int sidesCount = 6;
        /// <summary>
        /// Угол между сторонами гексогона
        /// </summary>
        private const double angle = -Math.PI * 0.5;
        /// <summary>
        /// Количество гексогонов по горизонтали и по вертикали
        /// </summary>
        private int n;
        /// <summary>
        /// Двумерный список, содержащий гексогональную сетку
        /// </summary>
        private List<List<Point[]>> hexagonList = new List<List<Point[]>>();

        /// <summary>
        /// Инициализация списка гексогональной сетки и его размерности
        /// </summary>
        /// <param name="hexagonList">Двумерный список, содержащий гексогональную сетку</param>
        /// <param name="n">Количество гексогонов по горизонтали и по вертикали</param>
        public HexagonalLattice(List<List<Point[]>> hexagonList, int n)
        {
            this.n = n;
            this.hexagonList = hexagonList;
        }

        /// <summary>
        /// Создание гексагональной сетки
        /// </summary>
        /// <returns></returns>
        public List<List<Point[]>> CreateHexagonList()
        {
            for (int i = 0; i < n; i++)
            {
                hexagonList.Add(CreatePoints(i));
            }
            return hexagonList;
        }

        /// <summary>
        /// Определение принадлежности координат точки отдельному гексогону
        /// </summary>
        /// <param name="cursorX">Координаты точки по оси X</param>
        /// <param name="cursorY">Координаты точки по оси Y</param>
        /// <param name="hexagonPoints">Координаты точек гексогона</param>
        /// <returns></returns>
        public bool isPointOfHexagon(int cursorX, int cursorY, Point[] hexagonPoints)
        {
            double k = ((double)hexagonPoints[1].Y - (double)hexagonPoints[0].Y) / ((double)hexagonPoints[1].X - (double)hexagonPoints[0].X);
            double b = ((double)hexagonPoints[1].X * (double)hexagonPoints[0].Y - (double)hexagonPoints[0].X * (double)hexagonPoints[1].Y) /
                       ((double)hexagonPoints[1].X - (double)hexagonPoints[0].X);
            double result = k * cursorX + b;

            if (cursorY > result)
            {
                k = ((double)hexagonPoints[3].Y - (double)hexagonPoints[2].Y) / ((double)hexagonPoints[3].X - (double)hexagonPoints[2].X);
                b = ((double)hexagonPoints[3].X * (double)hexagonPoints[2].Y - (double)hexagonPoints[2].X * (double)hexagonPoints[3].Y) /
                    ((double)hexagonPoints[3].X - (double)hexagonPoints[2].X);
                result = k * cursorX + b;
                if (cursorY < result)
                {
                    k = ((double)hexagonPoints[1].Y - (double)hexagonPoints[0].Y) / ((double)hexagonPoints[1].X - (double)hexagonPoints[0].X);
                    b = ((double)hexagonPoints[1].X * (double)hexagonPoints[0].Y - (double)hexagonPoints[0].X * (double)hexagonPoints[1].Y) /
                        ((double)hexagonPoints[1].X - (double)hexagonPoints[0].X);
                    result = k * cursorX + b + 2 * radius;
                    if (cursorY < result)
                    {
                        k = ((double)hexagonPoints[3].Y - (double)hexagonPoints[2].Y) / ((double)hexagonPoints[3].X - (double)hexagonPoints[2].X);
                        b = ((double)hexagonPoints[3].X * (double)hexagonPoints[2].Y - (double)hexagonPoints[2].X * (double)hexagonPoints[3].Y) /
                            ((double)hexagonPoints[3].X - (double)hexagonPoints[2].X);
                        result = k * cursorX + b - 2 * radius;
                        if (cursorY > result)
                        {
                            if (cursorX < hexagonPoints[1].X)
                            {
                                if (cursorX > hexagonPoints[4].X)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

            }
            return false;
        }

        /// <summary>
        /// Создание строки гексогонов
        /// </summary>
        /// <param name="rowNumber">Номер строки гексогональной сетки</param>
        /// <returns></returns>
        private List<Point[]> CreatePoints(int rowNumber)
        {
            List<Point[]> hexagonRow = new List<Point[]>();

            for (int i = 0; i < n; i++)
            {
                hexagonRow.Add(this.CreateHexagon(i, rowNumber));
            }
            return hexagonRow;
        }

        /// <summary>
        /// Создание одного гексогона
        /// </summary>
        /// <param name="columnNumber">Номер столбца гексогональной сетки</param>
        /// <param name="rowNumber">Номер строки гексогональной сетки</param>
        /// <returns></returns>
        private Point[] CreateHexagon(int columnNumber, int rowNumber)
        {
            int error = 0;
            Point[] HexagonPoints = new Point[sidesCount];

            for (int i = 0; i < sidesCount; i++)
            {
                if (i == 2)
                {
                    error = -1;
                }
                if (rowNumber % 2 == 0)
                {
                    HexagonPoints[i] = new Point(100 + 60 * columnNumber + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * i / sidesCount) * radius),
                        130 + 53 * rowNumber - error - 35 + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * i / sidesCount) * radius));
                }
                else
                {
                    HexagonPoints[i] = new Point(70 + 60 * columnNumber + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * i / sidesCount) * radius),
                        130 + 53 * (rowNumber - 1) - error + 18 + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * i / sidesCount) * radius));
                }
                if (i == 2)
                {
                    error = 0;
                }
            }
            return HexagonPoints;
        }
    }
}