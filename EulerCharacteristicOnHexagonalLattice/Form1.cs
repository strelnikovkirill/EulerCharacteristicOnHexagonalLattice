using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EulerCharacteristicOnHexagonalLattice
{
    /// <summary>
    /// Класс, описывающий функционал формы "Form1"
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Количество гексогонов по горизонтали и по вертикали
        /// </summary>
        private const int n = 10;
        /// <summary>
        /// Количество сторон гексогона
        /// </summary>
        private const int sidesCount = 6;
        /// <summary>
        /// Двумерный список, содержащий гексогональную сетку
        /// </summary>
        private static List<List<Point[]>> hexagonList = new List<List<Point[]>>();
        /// <summary>
        /// Двумерный массив, содержащий фигуру (множество) на гексональной сетке
        /// </summary>
        private int[,] hexagonalLatticeArray = new int[n, n];
        /// <summary>
        /// Перо чёрного цвета
        /// </summary>
        private Pen blackPen = Pens.Black;
        /// <summary>
        /// Перо белого цвета
        /// </summary>
        private Pen whitePen = Pens.White;
        /// <summary>
        /// Заливка чёрного цвета
        /// </summary>
        private SolidBrush blackBrush = new SolidBrush(Color.Black);
        /// <summary>
        /// Заливка белого цвета
        /// </summary>
        private SolidBrush whiteBrush = new SolidBrush(Color.White);
        /// <summary>
        /// Заливка светло-серого цвета
        /// </summary>
        private SolidBrush lightGrayBrush = new SolidBrush(Color.LightGray);

        /// <summary>
        /// Инициализация компонентов Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Изначальная инициализация массива "hexagonalLatticeArray"
        /// </summary>
        private void ArrayInitialization()
        {
            for (int i = 0; i < n+2; i++)
            {
                for (int j = 0; j < n+2; j++)
                {
                    hexagonalLatticeArray[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Рисование гексогональной сетки
        /// </summary>
        /// <param name="g">Экземпляр класса Graphics</param>
        private void DrawHexagonalLattice(Graphics g)
        {
            HexagonalLattice hexagonalLattice = new HexagonalLattice(hexagonList, n);
            hexagonList = hexagonalLattice.CreateHexagonList();
            ClearPictureBox(g);
        }

        /// <summary>
        /// Рисование объектов на pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawHexagonalLattice(e.Graphics);
        }

        /// <summary>
        /// Обработка события при нажатии правой и левой кнопок мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics g = Graphics.FromHwnd(((PictureBox)sender).Handle))
            {
                HexagonalLattice hexagonalLattice = new HexagonalLattice(hexagonList, n);
                int columnNumber = -1;
                int rowNumber = -1;
                Point[] hexagonPoints = new Point[sidesCount];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        hexagonPoints = hexagonList[i][j].ToArray();
                        if (hexagonalLattice.isPointOfHexagon(e.Location.X, e.Location.Y, hexagonPoints))
                        {
                            columnNumber = i;
                            rowNumber = j;
                            break;
                        }
                    }
                }
                if (columnNumber != -1 && rowNumber != -1)
                {
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            {
                                if (columnNumber < n - 1 && columnNumber > 0 && rowNumber < n - 1 && rowNumber > 0)
                                {
                                    g.FillPolygon(blackBrush, hexagonList[columnNumber][rowNumber]);
                                    g.DrawPolygon(whitePen, hexagonList[columnNumber][rowNumber]);
                                    hexagonalLatticeArray[columnNumber, rowNumber] = 1;
                                }
                            }
                            break;
                        case MouseButtons.Right:
                            {
                                if (columnNumber < n - 1 && columnNumber > 0 && rowNumber < n - 1 && rowNumber > 0)
                                {
                                    g.FillPolygon(whiteBrush, hexagonList[columnNumber][rowNumber]);
                                    g.DrawPolygon(blackPen, hexagonList[columnNumber][rowNumber]);
                                    hexagonalLatticeArray[columnNumber, rowNumber] = 0;
                                }
                            }
                            break;
                        default: break;
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события при нажатии кнопки "CALCULATE"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Button_Click(object sender, System.EventArgs e)
        {
            EulerCharacteristic eulerCharacteristic = new EulerCharacteristic(hexagonalLatticeArray);
            InitializeLabels(eulerCharacteristic.GetCharacterSetCounter());
        }

        /// <summary>
        /// Инициализация лейблов после нажания кнопки "CALCULATE"
        /// </summary>
        /// <param name="array">Массив, содержащий значения для инициализации лейблов</param>
        public void InitializeLabels(int[] array)
        {
            int eulerCharacteristic = array[4] - array[9] + array[10] - array[11];
            x0_Label.Text = array[0].ToString();
            x1_Label.Text = array[1].ToString();
            x2_Label.Text = array[2].ToString();
            x3_Label.Text = array[3].ToString();
            x4_Label.Text = array[4].ToString();
            x5_Label.Text = array[5].ToString();
            x6_Label.Text = array[6].ToString();
            x7_Label.Text = array[7].ToString();
            x8_Label.Text = array[8].ToString();
            x9_Label.Text = array[9].ToString();
            x10_Label.Text = array[10].ToString();
            x11_Label.Text = array[11].ToString();
            x12_Label.Text = array[12].ToString();
            x13_Label.Text = array[13].ToString();
            x14_Label.Text = array[14].ToString();
            x15_Label.Text = array[15].ToString();
            eulerCharacteristic_Label.Text = eulerCharacteristic.ToString();
        }

        /// <summary>
        /// Обработка события при нажатии на элемент меню "About"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        /// <summary>
        /// Очистка элемента "PictureBox"
        /// </summary>
        /// <param name="g"></param>
        private void ClearPictureBox(Graphics g)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    g.FillPolygon(whiteBrush, hexagonList[i][j]);
                    g.DrawPolygon(blackPen, hexagonList[i][j]);
                    hexagonalLatticeArray[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                g.FillPolygon(lightGrayBrush, hexagonList[0][i]);
                g.FillPolygon(lightGrayBrush, hexagonList[i][0]);
                g.FillPolygon(lightGrayBrush, hexagonList[i][n - 1]);
                g.FillPolygon(lightGrayBrush, hexagonList[n - 1][i]);
                g.DrawPolygon(blackPen, hexagonList[0][i]);
                g.DrawPolygon(blackPen, hexagonList[i][0]);
                g.DrawPolygon(blackPen, hexagonList[n - 1][i]);
                g.DrawPolygon(blackPen, hexagonList[i][n - 1]);
            }
        }

        /// <summary>
        /// Обработка события при нажатии на кнопку "CLEAR"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Button_Click(object sender, System.EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            ClearPictureBox(g);
        }

        /// <summary>
        /// Обработка события при нажатии на элемент меню "Show Set"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ConnectedSetGenerator set = new ConnectedSetGenerator();
            Form2 form = new Form2(set.Generate3x3Sets());
            form.Owner = this;
            form.ShowDialog();
        }

        /// <summary>
        /// Рисование на объекте "PictureBox" по заданному массиву
        /// </summary>
        /// <param name="array">Искомый массив</param>
        public void DrawSet(int[,] array)
        {
            Graphics g = pictureBox.CreateGraphics();
            ClearPictureBox(g);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1)
                    {
                        g.FillPolygon(blackBrush, hexagonList[i][j]);
                        g.DrawPolygon(whitePen, hexagonList[i][j]);
                    }
                }
            }
        }
    }
}