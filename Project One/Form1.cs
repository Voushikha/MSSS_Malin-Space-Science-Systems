using Galileo6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project_One
{
    public partial class Form1 : Form
    {
        #region Global Methods
        //4.1 // Global LinkedLists.
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
            try
            {
                SensorALinkedList.Clear();
                SensorBLinkedList.Clear();
                ReadData sensorData = new ReadData();
                double sigma = double.Parse(numericUpDown_Sigma.Text);
                double mu = double.Parse(numericUpDown_Mu.Text);

                for (int i = 0; i < 400; i++)
                {
                    double sensorAValue = sensorData.SensorA(mu, sigma);
                    double sensorBValue = sensorData.SensorB(mu, sigma);

                    SensorALinkedList.AddLast(sensorAValue);
                    SensorBLinkedList.AddLast(sensorBValue);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error loading Galileo library: {ex.Message}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //4.3 ShowAllSensorData Method
        private void ShowAllSensorData()
        {
            SensorAB_listBox.Items.Clear();
            var sensorAEnumerator = SensorALinkedList.GetEnumerator();
            var sensorBEnumerator = SensorBLinkedList.GetEnumerator();

            while (sensorAEnumerator.MoveNext() && sensorBEnumerator.MoveNext())
            {
                var item = new System.Windows.Forms.ListViewItem(new[] { sensorAEnumerator.Current.ToString(), sensorBEnumerator.Current.ToString() });
                SensorAB_listBox.Items.Add(item);
            }
        }

        // 4.4 Button Click Event for Loading Data
        private void Load_Btn_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
        }
        //4.4 ListViEW
       
        #endregion

        #region Utility Methods
        //4.5 NumberOfNodes Method
        private void NumberOfNodes()
        {
           

        }

        //4.6 DisplayListboxData Method
        private void DisplayListboxData()
        {
            SensorAB_listBox.Items.Clear();
            foreach (var item in SensorALinkedList)
            {
                SensorAB_listBox.Items.Add((string)item.ToString());
            }    
            foreach (var item in SensorBLinkedList)
            {
                SensorAB_listBox.Items.Add((string)item.ToString());
            }
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
        //Binary Iterative Search A METHOD
        // Returns index of x if it is present in sortedList[]
        private int BinarySearchIterative(List<double> sortedList, double target)
        {
            int minimum = 0;
            int maximum = sortedList.Count - 1;

            while (minimum <= maximum)
            {
                int middle = (minimum + maximum) / 2;
                //Check if target is presnt at middle
                if (sortedList[middle] == target)
                {
                    return middle;
                }
                //check if target is smaller, ignore lef thalf
                else if (sortedList[middle] > target)
                {
                    maximum = middle - 1;
                }
                //check if target is greater, ignore right half
                else
                {
                    minimum = middle + 1;
                }
            }

            return -1; // Not found
        }

        //Binary Recursive Search A METHOD
        // Returns index of x if it is present in
        // arr[low..high], else return -1
        private int BinarySearchRecursive(List<double> sortedList, double target, int minimum, int maximum)
        {
            if (minimum <= maximum)
            {
                int middle = (minimum + maximum) / 2;
                // If the element is present at the
                // middle itself
                if (sortedList[middle] == target)
                {
                    return middle;
                }
                
                else if (sortedList[middle] > target)
                {// If element is smaller than mid, then
                 // it can only be present in left subarray
                    return BinarySearchRecursive(sortedList, target, minimum, middle - 1);
                }
                else
                {// Else the element can only be present
                 // in right subarray
                    return BinarySearchRecursive(sortedList, target, middle + 1, maximum);
                }
            }

            return -1; // Not found
        }
        //https://www.geeksforgeeks.org/binary-search/#applications-of-binary-search 

        //Binary Iterative Search B METHOD


        //Binary Recursive Search B METHOD
        #endregion


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
