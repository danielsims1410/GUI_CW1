using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW1
{
    public partial class Form1 : Form
    {
        Form2 form2; //Initialises the second form (info window)
        public Form1()
        {
            InitializeComponent(); //Initialises this Form1
            picDelete.AllowDrop = true; //Allow drag effects on picDelete
            lstNumbers.AllowDrop = true; //Allow drag effects on the list box
        }

        private int FindMaxValue() //Function to find & return the maximum value in the list
        {
            int max = Convert.ToUInt16(lstNumbers.Items[0]); //Converts the first item in the list to an integer - this will be changed frequently later on

            for (int i = 1; i < lstNumbers.Items.Count; i++) //For loop that runs the same amount of times as there are entries
            {
                int x = Convert.ToUInt16(lstNumbers.Items[i]); //Converts item i (which increments per loop) into another integer
                if (x > max) max = x; //If item i is larger than the current max, it now becomes the max number
            }
            return max; //Once all items have been compared, returns the current max value
        }

        private int FindMinValue() //Function to find & return the minimum value in the list
        {
            int min = Convert.ToUInt16(lstNumbers.Items[0]); //Converts the first item in the list to an integer - this will be changed frequently later on

            for (int i = 1; i < lstNumbers.Items.Count; i++) //For loop that runs the same amount of times as there are entries
            {
                int x = Convert.ToUInt16(lstNumbers.Items[i]); //Converts item i (which increments per loop) into another integer
                if (x < min) min = x; //If item i is lower than the current min, it now becomes the min number
            }
            return min; //Returns min
        }

        private void SortAlgorithm() //Function that runs a bubble sort - to sort the list in ascending order
        {
            for (int i = 0; i < lstNumbers.Items.Count; i++)
            {
                for (int j = 0; j < lstNumbers.Items.Count - 1; j++)
                {
                    int a = Convert.ToUInt16(lstNumbers.Items[j]); //item 1
                    int b = Convert.ToUInt16(lstNumbers.Items[j + 1]); //item 2 (which will be directly underneath item 1)

                    if (a > b) //If the first item is more than the second item, then they must be switched
                    {
                        lstNumbers.Items[j + 1] = a.ToString() ;
                        lstNumbers.Items[j] = b.ToString(); //The two items are swapped around
                    }
                }//One loop will not be sufficient, by the end not every entry will be sorted, only in pairs
            }//This outer for loop assures that the entire list will be sorted
        }

        private void FindInsertPoint()//Function to determine where an entry should be inserted in a sorted list
        {
            if (lstNumbers.Items.Count > 0) //Verification
            {
                int firstEntry = Convert.ToUInt16(lstNumbers.Items[0]); //firstEntry = Top of the list
                int lastEntry = Convert.ToUInt16(lstNumbers.Items[lstNumbers.Items.Count - 1]); //lastEntry = Bottom of the list
                int userInput = Convert.ToUInt16(txtInsert.Text); //userinput = Number the user is inserting

                if (userInput < firstEntry) //If the user attemps to insert a number that's less than the first entry
                {
                    lstNumbers.Items.Add(lstNumbers.Items[lstNumbers.Items.Count - 1]); //Duplicates the last entry - creating another element in the list to make room for the new number

                    for (int i = lstNumbers.Items.Count - 1; i > 0; i--) //i begins as the highest index, and decrements per loop
                    {
                        int a = Convert.ToUInt16(lstNumbers.Items[i - 1]);
                        lstNumbers.Items[i] = a.ToString(); //The element below item[i] (item[i-1]) now becomes item[i], essentially being "moved up"
                                                            //However this overrides item[i], rather than swaps
                    }//This leaves the first entry being duplicated (it will be item[0] AND item[1])
                    lstNumbers.Items[0] = userInput.ToString(); //The first entry is now the user's number, as it is lower than the initial first entry
                }

                else if (userInput > firstEntry && userInput < lastEntry)//If the user attempts to insert a number that's between the first and last entry
                {
                    lstNumbers.Items.Add(lstNumbers.Items[lstNumbers.Items.Count - 1]); //Duplicates the last entry - creating another element in the list to make room for the new number

                    for (int i = lstNumbers.Items.Count - 1; i > 0; i--) //i begins as the highest index, and decrements per loop
                    {
                        int a = Convert.ToUInt16(lstNumbers.Items[i - 1]);
                        int b = Convert.ToUInt16(lstNumbers.Items[i]); //Defines int a, b - which will both be compared to the user entry
                        if (userInput > a && userInput < b) //Once the point is found where a is less than the user input and b is more than...
                        {
                            lstNumbers.SetSelected(i, true); //Selects item[i] as reference, as this will be the last number to be "moved up"
                            for (int j = lstNumbers.Items.Count - 1; j > lstNumbers.SelectedIndex; j--) //int j begins as the last entry and decrements per loop until j = the selected index
                            {
                                lstNumbers.Items[j] = lstNumbers.Items[j - 1];//Item[j - 1] is moved up and replaces item[j]
                            }
                            lstNumbers.ClearSelected();//Deselects the item as it is no longer needed
                            lstNumbers.Items[i] = userInput.ToString();//item[i] will now be duplicated, and so can be replaced with the user input
                        }
                    }
                }

                else if (userInput > lastEntry) //If the user's input is the higher than every number in the list...
                {
                    lstNumbers.Items.Add(userInput.ToString()); //Simply needs adding onto the end
                }
            }

            else if (lstNumbers.Items.Count == 0) //If the list is currently empty...
            {
                int insertValue = Convert.ToUInt16(txtInsert.Text);
                lstNumbers.Items.Add(insertValue.ToString()); //Also simply adds into the list
            }
        }

        private void SearchShowResults(int value, int probeCount) //Function to display the message box confirming a successful search
        {
            lstNumbers.SetSelected(value, true); //Selects the found value, passed in by either search function below
            int listPosition = value + 1; //Defines the position of the number, which will be one above the index
            MessageBox.Show("Number " + lstNumbers.SelectedItem + " Found!", "Search Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information); //Messagebox
            lblSuccessTrueFalse.Text = "Found!"; //Changes the "Found" label to confirm the successful search
            lblProbesVal.Text = probeCount.ToString(); //Displays the probe count, passed in by either search function
            lblPositionVal.Text = listPosition.ToString(); //Displays the list position, defined above
        }

        private void SearchFailed(int probeCount)//Function to display the message box confirming a failed search
        {
            MessageBox.Show("Search Failed!", "Search Unsuccessful!", MessageBoxButtons.OK, MessageBoxIcon.Information); //Messagebox
            lblSuccessTrueFalse.Text = "Failed!"; //Confirming the failure
            lblProbesVal.Text = probeCount.ToString(); //Displays the probe count
            lblPositionVal.Text = "Not in list!"; //Reiterating that the item does not exist
        }

        private void LinearSearch() //Function to perform a linear search
        {
            bool found = false; //Sets the bool found to false - used later
            int probeCount = 0; //Declares and defines probeCount - which will keep track of the number of probes (increment with each comparison to an entry)
            int searchVal;
            int.TryParse(txtSearch.Text, out searchVal); //The value the user is searching for

            for (int i = 0; i < lstNumbers.Items.Count; i++) //Runs until i = the number of items in the list
            {
                probeCount++; //Increments the probe count
                int selectedNumber = Convert.ToUInt16(lstNumbers.Items[i]); //Converts the item currently being compared to the search value into an integer

                if (selectedNumber == searchVal) //If the search value and the item are equal...
                {
                    SearchShowResults(i, probeCount);//Runs the function to confirm the find
                    found = true; //found = true so as not to runt the function to declare a failed search
                    txtSearch.Text = ""; //Clears the textbox
                    break; //No more need for the loop, break out of it
                    
                }
            }

            if (found == false) //If no entry equals the value being searched for, 'found' will not become true, and runs the failed search function
            {
                SearchFailed(probeCount);
            }

        }
        
        private void BinarySearch() //function to performa binary search
        {
            bool found = false; //Sets the bool found to false - used later
            int probeCount = 0; //Declares and defines probeCount - which will keep track of the number of probes (increment with each comparison to an entry)
            int low = 0; //Declares the lowest parameter of the current search range (which will be [0, number of entries] to begin with)
            int high = lstNumbers.Items.Count - 1; //Declares the highest parameter of the current search range
            int num;
            int.TryParse(txtSearch.Text, out num); //Converts the value the user is searching for into an integer

            while (low <= high) //While the range remains true (that the lower parameter is less than the higher)
            {
                int mid = (low + high) / 2; //Calculates the middle value to be compared to (initially the middle of the list)
                                            //The range narrows per loop, recalculating mid every loop
                int item = Convert.ToUInt16(lstNumbers.Items[mid]); //Converts the value of the middle entry of the range to an integer (allowing it to be compared to)

                if (item < num) //If the middle value is less than the value being searched for
                {
                    probeCount++; //Probe count increments
                    low = mid + 1; //The lower parameter now becomes the item above the middle value - halving the range for the next loop
                }

                else if (item > num) //If the middle value is more than the value being searched for
                {
                    probeCount++; //Probe count increments
                    high = mid - 1; //The higher parameter now becomes the item below the middle value - halving the range for the next loop
                }

                else //If neither condition above are met, then the value being searched for must equal the current middle found, thus has been found 
                {
                    probeCount++; //Probe count is incremented
                    SearchShowResults(mid, probeCount); //Runs the function to confirm the success
                    found = true; 
                    txtSearch.Text = ""; //Clears the textbox for the user
                    break; //Breaks from the while loop - no longer needed
                }
            }

            if (found == false) //If item wasn't found (and thus, found was never switched to true)...
            {
                SearchFailed(probeCount); //Confirms the failed search
            }
        }

        private void DeleteEntry()//Function to delete an entry from the list
        {
            DialogResult yesnoselected;
            yesnoselected = MessageBox.Show("Remove Number " + lstNumbers.SelectedItem + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//Confirms with the user that they want to delete the entry

            if (yesnoselected.ToString() == "Yes") //If user selects yes...
            {
                if (lstNumbers.SelectedIndex > -1) //Confirms that the user has selected an index first
                {
                    for (int i = lstNumbers.SelectedIndex; i < lstNumbers.Items.Count - 1; i++) //i begins as the index of the selected item, and increments until it equals the number of items (essentially the last item's index)
                    {
                        if (i < lstNumbers.Items.Count - 1)
                        {
                            int tmp = Convert.ToUInt16(lstNumbers.Items[i]); //Holds item[i] while it is overridden, making a swap possible
                            lstNumbers.Items[i] = lstNumbers.Items[i + 1];
                            lstNumbers.Items[i + 1] = tmp.ToString(); //Performs a swap
                        }
                        else break; //Breaks from the for loop
                    }//Loop will run through the entire list
                     //Moving the selected item up the list until it becomes the final entry
                     //During the duration of the for loop, item[i] will always be the item that the user's selected to delete
                    lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1); //Removes the final entry of the list, which is now the selected item
                }
            }

            if (lstNumbers.SelectedIndex > -1) lstNumbers.ClearSelected(); //Deselects the item

            if (lstNumbers.SelectedIndex == -1) //If there is no item selected
            {
                btnDelete.Enabled = false;
                btnClearSel.Enabled = false;
            }

        }

        private void ClearList() //Deletes every entry in the list
        {
            int initialCount = Convert.ToUInt16(lstNumbers.Items.Count - 1); //Declares the amount of items in the list
            for (int i = initialCount; i >= 0; i--) //Begins with the number of items in the list and decrements as they're deleted
            {
                lstNumbers.Items.RemoveAt(i); //Removes item[i]
            }
        }

        private void ShuffleAlgorithm() //Function to shuffle the entries in the list
        {
            if (lstNumbers.Items.Count == 2) //Performs if there are only two entries in the list
            {
                int temp = Convert.ToUInt16(lstNumbers.Items[0]); 
                lstNumbers.Items[0] = lstNumbers.Items[1];
                lstNumbers.Items[1] = temp.ToString(); //Both items are swapped, ensuring a guaranteed 'shuffle' of the two items
            }

            else //Otherwise, if there are more than 2 (no need to check for no entries, as the button used to run the function is disabled in this condition).
            {
                Random rand = new Random(); //Initialises a new random number
                for (int i = lstNumbers.Items.Count - 1; i > 0; i--) //Runs through the entire list
                {
                    int randomIndex = rand.Next(i + 1); //Generates the random number
                    int temp = Convert.ToUInt16(lstNumbers.Items[i]);//Stores the current value being looked at by the program
                    lstNumbers.Items[i] = lstNumbers.Items[randomIndex];
                    lstNumbers.Items[randomIndex] = temp.ToString(); //Swaps the item being looked at with the item in the index of the random number
                }
            }
        }

        private void UpdateStats() //Run after every event, this function will update the statistics on the interface dynamically
        {
            if (lstNumbers.Items.Count > 0) //Under the circumstance that the list has entries
            {
                lblCountVal.Text = lstNumbers.Items.Count.ToString(); //Displays the number of entries in the list
                lblFirstEntryVal.Text = lstNumbers.Items[0].ToString(); //Displays the first entry in the list
                lblLastEntryVal.Text = lstNumbers.Items[lstNumbers.Items.Count - 1].ToString(); //Displays the last entry in the list
                lblMaxVal.Text = FindMaxValue().ToString(); //Executes the FindMaxValue() function and returns its result
                lblMinVal.Text = FindMinValue().ToString(); //Executes the FindMinValue() function and returns its result
            }

            else //Otherwise...
            {
                lblCountVal.Text = "0";
                lblFirstEntryVal.Text = "N/A";
                lblLastEntryVal.Text = "N/A";
                lblMaxVal.Text = "N/A";
                lblMinVal.Text = "N/A";
            }
        }

        private void MinusEntriesButtons() //This function is used to change which buttons are enabled or not when a number is REMOVED
        {
            btnDelete.Enabled = false; //Once a number's been deleted, the delete button must be disabled as there is no item selected
            if (lstNumbers.Items.Count == 0) //If every number's been deleted, the following buttons are disabled...
            {
                btnClear.Enabled = false;
                btnSearch.Enabled = false;
                txtSearch.Enabled = false;
                btnInitialise.Enabled = true;
                btnClearSel.Enabled = false;
                btnFill.Enabled = false;
            }

            if (lstNumbers.Items.Count < 2) btnShuffle.Enabled = false; //The shuffle has its own special circumstance, as there must be 2 or more entries
                                                                        //for the shuffle to work

            if (lstNumbers.Items.Count < 30) //If there are less than 30 entries
            {
                btnInsert.Enabled = true;
                txtInsert.Enabled = true; //Insert function is enabled
                if (lstNumbers.Items.Count > 0) btnFill.Enabled = true; //If there are less than 30 and more than 0, Fill is enabled
            }
        }

        private void PlusEntriesButtons() //Updates the program's buttons when a number is added to the list
        {
            btnClear.Enabled = true;
            btnInitialise.Enabled = false;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
            //Clear, and Search Functions are enabled, Initialise is disabled

            if (lstNumbers.Items.Count > 0) //If there are now entries...
            {
                if (lstNumbers.Items.Count > 1) btnShuffle.Enabled = true; //If there are more than 1 entries, shuffle is enabled
                btnFill.Enabled = true; //Fill is enabled
            }

            if (lstNumbers.Items.Count == 30) //If the list is now full...
            {
                btnInsert.Enabled = false;
                txtInsert.Enabled = false;
                btnFill.Enabled = false;
                //Insert and Fill are disabled
            }

            if (rdSorted.Checked) //If "Sorted" is selected
            {
                btnShuffle.Enabled = false; //Disables the Shuffle button
            }
           
        }

        private void UpdateInterface(bool entries) //Updates the entire interface (Stats and Buttons).
                                                   //After every event, a bool is passed into this function - true or false
                                                   //False when a number is removed, true when a number is added
        {
            UpdateStats(); //Runs the UpdateStats() function
            if (entries == false) MinusEntriesButtons(); //If 'false' is passed into this function, run the Minus function above
            if (entries == true) PlusEntriesButtons(); //If 'true' is passed into this function, run the Plus function above
        }

        private bool SearchDuplicate(int entry, bool selectIndex) //Function that searches for a duplicate in the list and returns a bool
        {
            bool duplicate = false; //Initialises duplicate as a false - saying it hasn't been found (yet)
            for (int i = 0; i < lstNumbers.Items.Count; i++) //For loop that searches the entire list
            {
                int listboxNumber = Convert.ToUInt16(lstNumbers.Items[i]); //Converts the item being looked at into an integer
                if (listboxNumber == entry) //If a match is found...
                {
                    duplicate = true; //duplicate is now true
                    if (selectIndex == true) //When the function is called, another bool will be passed into it which
                                             //decides whether the event needs the duplicated item selected or not
                                             //to show the user.
                    {
                        lstNumbers.SetSelected(i, true); //Selects the item
                    }
                }
            }
            return duplicate; //Returns the duplicate - true if the duplicate is found, false otherwise
        }

        private void btnInitialise_Click(object sender, EventArgs e) //"Initialise" Button is pressed
        {
            Random rand = new Random(); //Initialises a random class
            int entry;
            string entryString;

            while (lstNumbers.Items.Count < 30) //While the number of entries in the list is less than 30
            {
                entry = rand.Next(0, 101); //Generates a random number between 0 and 101.
                entryString = entry.ToString(); //Converts the random number into a string to be entered into the list
                if (SearchDuplicate(entry, false) == true) { } //Searches for a duplicate - if one is found, the loop does no more
                else lstNumbers.Items.Add(entryString); //Otherwise, if no duplicates exist, it's added into the list
            }

            if (rdSorted.Checked)
            {
                SortAlgorithm(); //If "Sorted" is selected beforehand, the program will sort the list in ascending order
            }
            
            UpdateInterface(true); //Items have been added, so update the interface after adding an entry
        }

        private void btnClear_Click(object sender, EventArgs e) //"Clear" button is pressed
        {
            ClearList(); //Executes the ClearList() function above
            UpdateInterface(false); //Updates the interface, when entries were removed
        }

        private void btnDelete_Click(object sender, EventArgs e) //"Delete" button is pressed
        {
            if (lstNumbers.SelectedIndex == -1) //If no item is selected...
            {
                MessageBox.Show("Please Select an Item!", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else //Otherwise (i.e, an item is selected)
            {
                DeleteEntry(); //DeleteEntry() function is executed to delete the selected item
            }
            UpdateInterface(false); //Updates the interface, having deleted an entry
        }

        private void btnExit_Click(object sender, EventArgs e) //"Exit" button is pressed
        {
            DialogResult yesnoselected = MessageBox.Show("Are you sure you wish to Exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //Confirms with the user as to whether they definitely want to exit the program or not

            if (yesnoselected.ToString() == "Yes") //If "Yes" was selected...
            {
                Close(); //Closes the form
            }//No other code is run; if "No" is selected, nothing will happen
        }

        private void rdSorted_CheckedChanged(object sender, EventArgs e) //When the Sorted radio button is changed
        {
            if (rdSorted.Checked) //If the Sorted option is selected...
            {
                lstNumbers.ClearSelected(); //If an item is selected, it will be deselected
                SortAlgorithm(); //The sorting algorithm is executed and the list is put in ascending order
                rdBinary.Enabled = true; //Enables the Binary radio button - now available to be selected
                btnShuffle.Enabled = false; //Shuffle is disabled, as it cannot be used while the list is sorted
            }

            else if (rdUnsorted.Checked) //If the Unsorted option is selected...
            {
                btnShuffle.Enabled = true; //The shuffle option is now available to use
                rdBinary.Enabled = false;  //The binary option is disabled
                rdLinear.Checked = true;   //The Linear option is forced (in case Binary is still selected)
                lstNumbers.ClearSelected();//The selected item (if any) is deselected
            }

            UpdateStats(); //All necessary buttons have been changed already, so only have to update the statistics
        }

        private void btnInsert_Click(object sender, EventArgs e) //"Insert" button is pressed
        {
            int a;
            if (int.TryParse(txtInsert.Text, out a)) //Attempts to convert the user's entry into an integer
            {
                if (a >= 0 && a <= 100) //If a is within the correct range for the list ([0, 100])
                {
                    if (SearchDuplicate(a, true) == true) //If a duplicate is found...
                    {
                        MessageBox.Show("List Already Contains " + a.ToString() + "!", "Insert Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        lstNumbers.ClearSelected();
                        //Shows a message box explaining the error, and deselects the item (the duplicate is selected in the SearchDuplicate() function)
                    }
                    else //Otherwise, if no duplicate exists...
                    {
                        if (rdSorted.Checked) //If "Sorted" is selected...
                        {
                            FindInsertPoint(); //The function is executed to find the point where the number should be and inserts it
                        }
                        else lstNumbers.Items.Add(a.ToString()); //Otherwise it is added to the end (if it is unsorted)
                    }
                }
                else //If the number that's being inserted isn't within the range [0, 100]
                {
                    MessageBox.Show("Please Enter a Number Between 0 and 100!", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else //If the user's entry cannot be converted to an integer (i.e, isn't a number)
            {
                MessageBox.Show("Please Enter an Integer!", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtInsert.Clear(); //Clears the text box
            UpdateInterface(true); //Updates the interface, having added an entry
        }

        private void btnSearch_Click(object sender, EventArgs e) //"Search" is pressed
        {
            lstNumbers.ClearSelected(); //Any selected item is deselected
            int verifySearch; 
            if (int.TryParse(txtSearch.Text, out verifySearch)) //Program attempts to convert the text box's entry into an integer
            {
                if (verifySearch >= 0 && verifySearch <= 100) //If the number is within the range [0, 100]...
                {
                    if (rdLinear.Checked) LinearSearch(); //If "Linear" is selected, the LinearSearch() function is executed
                    else if (rdBinary.Checked) BinarySearch(); //If "Binary" is selected, the BinarySearch() function is executed
                    lstNumbers.ClearSelected(); //The searched item has been selected in the above functions - it now deselects
                }

                else //If the number is out of range...
                {
                    MessageBox.Show("Please Enter a Number Between 0 and 100!", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Clear(); //Empties the text box
                }
            }

            else //If the user's entry isn't an integer...
            {
                MessageBox.Show("Please Enter an Integer!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
            }
        }

        private void lstNumbers_MouseDown(object sender, MouseEventArgs e) //When the mouse is pressed down on the list box
        {
            if (lstNumbers.Items.Count > 0) //If there are entries in the list...
            {
                lstNumbers.DoDragDrop(lstNumbers.Items, DragDropEffects.Move); //Allows Drag & Drop on an item
            }
            if (lstNumbers.SelectedIndex > -1) //When an item is selected...
            {
                btnDelete.Enabled = true; //Delete is enabled
                btnClearSel.Enabled = true; //Deselect is enabled
            }
            if (lstNumbers.SelectedIndex == -1) //If no index/item is selected...
            {
                btnDelete.Enabled = false; //Delete button is disabled
                btnClearSel.Enabled = false; //Deselect button is disabled
            }
        }

        private void picDelete_DragEnter(object sender, DragEventArgs e) //When an item from the list box is dragged over the image (without releasing)
        {
            e.Effect = DragDropEffects.Move; //Changes the cursor image to "move"
            lblRelease.Visible = true; //Reveals the text underneath the bin image - prompting user to release

        }

        private void picDelete_DragDrop(object sender, DragEventArgs e) //When an item from the list box is dropped onto the image
        {
            DeleteEntry(); //DeleteEntry() function is executed
            lblRelease.Visible = false; //The text prompting the user to release disappears
            UpdateInterface(false); //Interface updates, having deleted an entry

        }

        private void btnShuffle_Click(object sender, EventArgs e) //"Shuffle" is clicked
        {
            lstNumbers.ClearSelected(); //If an item is selected, it is now deselected
            ShuffleAlgorithm(); //Shuffle Algorithm is executed, and the list is 'shuffled'
            UpdateStats(); //No need to change any buttons, so only statistics are updated
        }

        private void btnClearSel_Click(object sender, EventArgs e) //"Deselect" is clicked
        {
            lstNumbers.ClearSelected(); //The selected item in the list is deselected
            btnClearSel.Enabled = false; //"Deselect" button is now disabled, no longer needed now that the selection's been cleared
            btnDelete.Enabled = false; //"Delete" button is now disabled, impossible to use without any item selected
        }

        private void picHelp_Click(object sender, EventArgs e) //User clicks the "?" icon next to the main buttons
        {
            form2 = new Form2(); //Initialises a new form of Form2
            form2.Show(); //Shows this new Form2 (non-modal, so that the user can continue to use this Form1)
        }
    }
}
