﻿// Team: Joshua and Rhys
// Date: 07/04/2022
// Description

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalProcessing
{
    public partial class frmAstronomicalProcessing : Form
    {
        // Create neutrinoData array with length 24
        static int arrayLength = 24;
        int[] neutrinoData = new int[arrayLength];
        public frmAstronomicalProcessing() {
            InitializeComponent();
        }
        
        // Fill the array with random values, to simulate the data
        public void FillArray() {
            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++) {
                neutrinoData[i] = rand.Next(10, 99);
            }
            // Enable buttons that do not need the list to be sorted, but do
            // need items to be in the list.
            btnSort.Enabled = true;
            btnAvg.Enabled = true;
            btnSeqSearch.Enabled = true;
        }

        // Clear the list box and reprint the array
        public void RefreshArray() {
            lstArray.Items.Clear();
            for (int i = 0; i < arrayLength; i++) {
                lstArray.Items.Add(neutrinoData[i]);
            }
        }

        // Perform the FillArray() and RefreshArray() methods when btnRandomise is clicked
        private void RandomiseArray(object sender, EventArgs e)
        {
            FillArray();
            RefreshArray();
            RefreshTxtBoxes();
            DisableButtons();
        }

        // Sort the array using the bubble sorting algorithm when btnSort is clicked
        private void BubbleSort(object sender, EventArgs e) {
            int numLength = arrayLength;
            bool flag = true;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++) {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++) {
                    if (neutrinoData[j + 1] < neutrinoData[j]) {
                        int temp = neutrinoData[j];
                        neutrinoData[j] = neutrinoData[j + 1];
                        neutrinoData[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            RefreshArray();
            EnableButtons();
        }

        // Perform a Binary Search when txtSearch has an integer value and btnSearch is clicked
        private void BinarySearch(object sender, EventArgs e)
        {
            // Locally declare minimum and maximum array values
            int min = 0;
            int max = arrayLength - 1;
            if (!(Int32.TryParse(txtSearch.Text, out int target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }

            while (min <= max)
            {
                // Write the mean of min and max to mid
                int mid = (min + max) / 2;

                if (target == neutrinoData[mid])
                {
                    MessageBox.Show(target + " Found at index " + mid);
                    return;
                }
                else if (neutrinoData[mid] >= target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            MessageBox.Show(target + " not found in array");
        }

        // Search through the array until the target is found, or the array is fully searched
        private void SequentialSearch(object sender, EventArgs e) {
            if (!(Int32.TryParse(txtSearch.Text, out int target))) {
                MessageBox.Show("You must enter a valid number");
                return;
            }

            for (int i = 0; i < arrayLength; i++) {
                if (neutrinoData[i] == target) {
                    MessageBox.Show(target + " Found at index " + i);
                    return;
                }
            }
            MessageBox.Show(target + " not found in array");
        }

        // Checks both text boxes if there are any non-integer characters
        private void IntegerCheck(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; 
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                // If the test fails, handle the event and don't input non-integer character
                e.Handled = true;
            }
        }
        
        // Edit the selected item within the array and then sort the array
        private void EditData(object sender, EventArgs e)
        {
            if (!(Int32.TryParse(txtEdit.Text, out int editData)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            else if (lstArray.SelectedItem == null)
            {
                MessageBox.Show("You must select an item in the array");
                return;
            }
            else
            {
                string currentItem = lstArray.SelectedItem.ToString();
                int index = lstArray.FindString(currentItem);
                neutrinoData[index] = editData;
                BubbleSort(this, e);
            }
        }

        // Check if the Enter key is pressed in both text boxes, then run the correct method
        private void EnterKeyCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Focused)
                {
                    MessageBox.Show("You must click on any search button");
                }
                else if (txtEdit.Focused)
                {
                    EditData(this, e);
                }
                else
                {
                    MessageBox.Show("You must enter an integer in the box");
                }
            }
        }

        // Enable or disable buttons and text boxes that require the list to be sorted
        private void EnableButtons() {
            btnBinSearch.Enabled = true;
            btnMidExtr.Enabled = true;
            btnMode.Enabled = true;
            btnRange.Enabled = true;
            btnEdit.Enabled = true;
            btnMidExtr.Enabled = true;
        }
        private void DisableButtons() {
            btnBinSearch.Enabled = false;
            btnMidExtr.Enabled = false;
            btnMode.Enabled = false;
            btnRange.Enabled = false;
            btnEdit.Enabled = false;
            btnMidExtr.Enabled = false;
        }

        private void RefreshTxtBoxes() {
            txtAvg.Text = "";
            txtEdit.Text = "";
            txtMidExtr.Text = "";
            txtMode.Text = "";
            txtRange.Text = "";
        }

        // This method calculates the average of a sorted array using btnAvg
        private void Average(object sender, EventArgs e)
        {
            double sum = 0;
            double average = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sum += neutrinoData[i];
            }

            average = Math.Round((sum / arrayLength), 2); // Round the average by 2 decimal places
            txtAvg.Text = average.ToString();
        }

        // This method calculates the mid-extreme of a sorted array using btnMidExtr
        private void MidExtreme(object sender, EventArgs e)
        {
            double smallest = 0;
            double largest = 0;
            double midExtreme = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (i == 0)
                {
                    smallest = neutrinoData[i];
                }
                else if (i == (arrayLength - 1))
                {
                    largest = neutrinoData[i];
                }
            }

            midExtreme = Math.Round(((smallest + largest) / 2 ), 2);
            txtMidExtr.Text = midExtreme.ToString();
        }

        // This method calculates the range of a sorted array using btnRange
        private void Range(object sender, EventArgs e)
        {
            double smallest = 0;
            double largest = 0;
            double range = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == 0)
                {
                    smallest = neutrinoData[i];
                }
                else if (i == (arrayLength - 1))
                {
                    largest = neutrinoData[i];
                }
            }

            range = Math.Round((largest - smallest), 2);
            txtRange.Text = range.ToString();
        }

        // This method calculates the mode of a sorted array using btnMode
        private void Mode(object sender, EventArgs e)
        {
            double mode = 0;
            int countArrayMax = neutrinoData.Max();
            int[] countArray = new int[++countArrayMax];

            // Create a count array and initialise with zero values
            for (int i = 0; i < countArrayMax; i++)
            {
                countArray[i] = 0;
            }

            // Add 1 to the count array for each element of netrinoData 
            for (int i = 0; i < arrayLength; i++)
            {
                countArray[neutrinoData[i]]++;
            }

            // Find the first mode in the count array (index with highest element)
            int currentCount = countArray[0];
            for (int i = 1; i < countArrayMax; i++)
            {
                if ((countArray[i] > currentCount) && (countArray[i] > 0))
                {
                    currentCount = countArray[i];
                    mode = i;
                }
            }

            // Perform a bubble sort on the count array
            int countLength = countArray.Length;
            bool flag = true;
            for (int i = 1; i <= (countLength - 1) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (countLength - 1); j++)
                {
                    if (countArray[j + 1] < countArray[j])
                    {
                        int temp = countArray[j];
                        countArray[j] = countArray[j + 1];
                        countArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            // If the last index of the sorted count array is equal to the second last,
            // the mode is not unimodal and is set to zero. Display a warning to the user.
            if (countArray[countLength - 1] == countArray[countLength - 2])
            {
                mode = 0;
                // This warning is displayed if every number in the array is unique
                if (countArray[countLength - 1] == 1)
                {
                    MessageBox.Show("The mode cannot be found in the array.");
                }
                // This warning is displayed when there are two or more modes (not unimodal)
                else
                {
                    MessageBox.Show("The mode of the array is not unimodal.");
                }
            }

            txtMode.Text = mode.ToString();
        }
    }
}