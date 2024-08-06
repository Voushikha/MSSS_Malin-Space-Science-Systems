using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_One
{
    public partial class Form1 : Form
    {
        #region Global Methods
        //4.1 // Global LinkedLists
        public static LinkedList<double> SensorALinkedList = new LinkedList<double>();
        public static LinkedList<double> SensorBLinkedList = new LinkedList<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // 4.2 LoadData Method
        private void LoadData()
        {
           
        }
        //4.3 ShowAllSensorData Method
        private void ShowAllSensorData()
        {  

        }
        //4.4

        #endregion

        #region Utility Methods
        //4.5 NumberOfNodes Method
        private void NumberOfNodes()
        {

        }

        //4.6 DisplayListboxData Method
        private void DisplayListboxData()
        {

        }
        #endregion

        #region Sort and Search Methods
        //4.7 SelectionSort Method
        private void SelectionSort()
        {

        }

        //4.8 InsertionSort Method
        private void InsertionSort()
        {

        }

        //4.9 BinarySearchIterative Method
        private void BinarySearchIterative()
        {

        }

        //4.10 BinarySearchRecursive Method
        private void BinarySearchRecursive()
        {

        }

        #endregion

        #region UI Button Methods
        //4.11 UI Button Methods Method

        #endregion

      
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
