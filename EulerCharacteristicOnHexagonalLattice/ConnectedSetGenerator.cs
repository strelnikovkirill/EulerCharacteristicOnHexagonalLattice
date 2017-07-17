using System.Collections.Generic;
using System.IO;

namespace EulerCharacteristicOnHexagonalLattice
{
    /// <summary>
    /// 
    /// </summary>
    public class ConnectedSetGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int[,]> Generate2x2Sets()
        {
            int[,] a = new int[2, 2];
            List<int[,]> list = new List<int[,]>();
            // TODO generate alls 2x2 sets
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int[,]> Generate3x3Sets()
        {
            int[,] a = new int[3, 3];
            List<int[,]> list = new List<int[,]>();
            // TODO generate alls 3x3 sets
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int[,]> Generate4x4Sets()
        {
            int[,] a = new int[4, 4];
            List<int[,]> list = new List<int[,]>();
            // TODO generate alls 4x4 sets
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int[,]> Generate5x5Sets()
        {
            int[,] a = new int[5, 5];
            List<int[,]> list = new List<int[,]>();
            // TODO generate alls 5x5 sets
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[,] GetRightSizeArray(int[,] array)
        {
            int[,] trueArray = new int[10, 10];
            for (int i=0; i < trueArray.GetLength(0); i++)
            {
                for (int j = 0; j < trueArray.GetLength(1); j++)
                {
                    trueArray[i, j] = 0;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    trueArray[i + 1, j + 1] = array[i, j];
                }
            }
            return trueArray;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private bool IsConnectedSet(int[,] array)
        {
            EulerCharacteristic eulerCharacteristic = new EulerCharacteristic(array);
            if (eulerCharacteristic.GetEulerCharacteristic() < 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private bool IsLocatedInEdge(int[,] array)
        {
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[1, i] == 1)
                {
                    result++;
                    break;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 1] == 1)
                {
                    result++;
                    break;
                }
            }
            if (result == 2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        /// <returns></returns>
        public bool CharacterSetCountersEquals(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                if (firstArray[i] != secondArray[i]) return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArray"></param>
        /// <param name="secondArray"></param>
        /// <returns></returns>
        private bool RightSizeArraysEquals(int[,] firstArray, int[,] secondArray)
        {
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(0); j++)
                {
                     if (firstArray[i, j] != secondArray[i, j]) return false;
                }
               
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool FindArrayInList(int[,] array, List<int[,]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (RightSizeArraysEquals(array, list[i]))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="setsList"></param>
        /// <returns></returns>
        public List<int[,]> GetEqualsSet(List<int[,]> setsList)
        {
            List<int[,]> equalsSetsList = new List<int[,]>();
            bool flag;
            for (int i = 0; i < setsList.Count; i++)
            {
                flag = true;
                EulerCharacteristic fixedEulerCharacteristic = new EulerCharacteristic(setsList[i]);
                for (int j = 0; j < setsList.Count; j++)
                {
                    if (i != j)
                    {
                        EulerCharacteristic currentEulerCharacteristic = new EulerCharacteristic(setsList[j]);
                        if (CharacterSetCountersEquals(fixedEulerCharacteristic.GetCharacterSetCounter(), 
                                currentEulerCharacteristic.GetCharacterSetCounter()))
                        {
                            if (FindArrayInList(setsList[j], equalsSetsList))
                            {
                                if (flag)
                                {
                                    equalsSetsList.Add(setsList[i]);
                                    equalsSetsList.Add(setsList[j]);
                                    flag = false;
                                }
                                else
                                {
                                    equalsSetsList.Add(setsList[j]);
                                }
                            }
                        }
                    }
                }
            }
            return equalsSetsList;
        }
    }
}