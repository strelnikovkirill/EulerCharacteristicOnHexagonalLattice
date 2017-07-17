namespace EulerCharacteristicOnHexagonalLattice
{
    /// <summary>
    /// Класс, считающий Эйлерову характеристику на гексогональной сетке
    /// </summary>
    public class EulerCharacteristic
    {
        /// <summary>
        /// Массив фрагметнов 2х2, по которым производится подсчет Эйлеровой характеристики
        /// </summary>
        private int [,] characterSet = { { 0, 0, 0, 0 },
                                         { 1 ,0, 0, 0 },
                                         { 0, 1, 0, 0 },
                                         { 0, 0, 1, 0 },
                                         { 0, 0, 0, 1 },
                                         { 1, 1, 0, 0 },
                                         { 0, 0, 1, 1 },
                                         { 1, 0, 1, 0 },
                                         { 0, 1, 0, 1 },
                                         { 0, 1, 1 ,0 },
                                         { 1, 0, 0, 1 },
                                         { 0, 1, 1, 1 },
                                         { 1, 0, 1, 1 },
                                         { 1, 1, 0, 1 },
                                         { 1, 1, 1, 0 },
                                         { 1, 1, 1, 1 } };
        /// <summary>
        /// Двумерный массив, содержащий фигуру (множество) на гексональной сетке
        /// </summary>
        private int[,] hexagonalLatticeArray = new int[10, 10];
        /// <summary>
        /// Массив счётчиков для элементов массива "characterSet"
        /// </summary>
        private int[] characterSetCounter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// Инициализация массива "hexagonalLatticeArray" и подсчёт Эйлеровой характеристики
        /// </summary>
        /// <param name="hexagonalLatticeArray">Массив фигуры, полученный на гексогональной сетке</param>
        public EulerCharacteristic(int[,] hexagonalLatticeArray)
        {
            this.hexagonalLatticeArray = hexagonalLatticeArray;
            HexagonalLatticeArrayMovement();
        }

        /// <summary>
        /// Сравнение массива со всеми фрагментами 2х2 из массива "characterSet"
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <param name="kNumber">Номер фрагмента</param>
        /// <returns></returns>
        private bool CompareArrays(int[] array, int characterSetNumber)
        {
            for(int i = 0; i < 4; i++)
            {
                if (array[i] != characterSet[characterSetNumber, i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Подсчёт Эйлеровой характеристики
        /// </summary>
        /// <param name="array">Массив 2х2 для сравнения с массивом фрагментов "characterSet"</param>
        private void CalculateEulerCharacteristic(int[] array)
        {
            for (int i = 0; i < characterSetCounter.Length; i++)
            {
                if (CompareArrays(array, i))
                {
                    characterSetCounter[i]++;
                }            
            }
        }

        /// <summary>
        /// Прогод по всем фрагментам 2х2 массива "hexagonalLatticeArray"
        /// </summary>
        private void HexagonalLatticeArrayMovement()
        {
            int k = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
                for (int j = 0; j < 9; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j != 8)
                        {
                            if (j == 0)
                            {
                                int[] array1 = { 0, hexagonalLatticeArray[i, j],
                                                hexagonalLatticeArray[i + 1, j], hexagonalLatticeArray[i + 1, j + 1] };
                                CalculateEulerCharacteristic(array1);
                            }
                            int[] array = { hexagonalLatticeArray[i, j], hexagonalLatticeArray[i, j + 1],
                                                hexagonalLatticeArray[i + 1, j + k], hexagonalLatticeArray[i + 1, j + 1 + k] };
                            CalculateEulerCharacteristic(array);
                        }
                    }
                    else
                    {
                        int[] array = { hexagonalLatticeArray[i, j], hexagonalLatticeArray[i, j + 1],
                                            hexagonalLatticeArray[i + 1, j], hexagonalLatticeArray[i + 1, j + 1] };
                        CalculateEulerCharacteristic(array);
                    }
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий массив "characterSetCounter"
        /// </summary>
        /// <returns></returns>
        public int[] GetCharacterSetCounter()
        {
            return characterSetCounter;
        }

        public int GetEulerCharacteristic()
        {
            return characterSetCounter[4] - characterSetCounter[9] + characterSetCounter[10] - characterSetCounter[11];
        }

        /// <summary>
        /// Метод, возвращающий массив "hexagonalLatticeArray"
        /// </summary>
        /// <returns></returns>
        public int[,] GetHexagonalLatticeArray()
        {
            return hexagonalLatticeArray;
        }
    }
}