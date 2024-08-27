using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Galileo6;
using System.Globalization;
using CsvHelper;
using System.Numerics;
using System.Windows.Markup;
using System.Runtime.Remoting.Messaging;


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
        //https://ironsoftware.com/csharp/excel/blog/using-ironxl/csharp-read-csv-file-into-list-tutorial/ 
        //https://memgraph.com/docs/data-migration/csv
        private void LoadData()
        {
            // Clear the ListBox before loading new data
            SensorAB_listBox.Items.Clear();

            try
            {
                using (var reader = new StreamReader(@"D:\Diploma\Complex Data Structure\Assessment\Data Processing\MalinStaffNamesV3.csv"))
                      {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length >= 2)
                        {
                            // Combine the two values and add them to the ListBox
                            string displayText = $"{values[0],-10} {values[1]}";
                            SensorAB_listBox.Items.Add(displayText);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void ShowAllSensorData()
        {

            SensorA_listView.Items.Clear();
            SensorB_listView.Items.Clear();

            // Ensure both LinkedLists have the same number of elements
            var nodeA = SensorALinkedList.First;
            var nodeB = SensorBLinkedList.First;

            while (nodeA != null && nodeB != null)
            {
                // Format the display string with both sensor values side by side
                string displayText = $"{nodeA.Value,-20} {nodeB.Value}";
                SensorA_listView.Items.Add(displayText);
                SensorB_listView.Items.Add(displayText);

                nodeA = nodeA.Next;
                nodeB = nodeB.Next;
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

        private void SensorAB_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
