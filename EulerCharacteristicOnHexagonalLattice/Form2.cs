using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EulerCharacteristicOnHexagonalLattice
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private List<int[,]> equalsConnectedSetsList = new List<int[,]>();
        /// <summary>
        /// 
        /// </summary>
        private int setIndex = -1;
        /// <summary>
        /// 
        /// </summary>
        private ConnectedSetGenerator connectedSet = new ConnectedSetGenerator();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectedSetList"></param>
        public Form2(List<int[,]> connectedSetList)
        {
            InitializeComponent();
            this.equalsConnectedSetsList = connectedSet.GetEqualsSet(connectedSetList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousSet_Button_Click(object sender, EventArgs e)
        {
            // TODO event handler
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextSet_Button_Click(object sender, EventArgs e)
        {
            // TODO event handler
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToFirstSet_Button_Click(object sender, EventArgs e)
        {
            // TODO event handler
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToLastSet_Button_Click(object sender, EventArgs e)
        {
            // TODO event handler
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInfo_Button_Click(object sender, EventArgs e)
        {
            // TODO event handler
        }
    }
}