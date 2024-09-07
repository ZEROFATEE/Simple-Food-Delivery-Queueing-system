using System.Collections;


//This imports the System.Collections namespace,
//which provides the Queue class, a collection
//type used in this code
using System.Collections.Generic;



namespace QueueForm
{
    public partial class Form1 : Form
    {
        //Declares a queue called Orderlist that
        //will be used to store the list of orders.
        private Queue Orderlist;
        public Form1()
        {
            // 
            InitializeComponent();
            Orderlist = new Queue();
        }

        public void DisplayQueue()
        {
            //This method is used to show all the orders in the queue on the form.
            //The code loops through the Orderlist and
            //adds each item (order) to the ORLIST(ListBox).
            ORLIST.Items.Clear();
            int count = 1;
            foreach (object getList in Orderlist)
            {
                ORLIST.Items.Add("Order #" + count.ToString() + ": " + getList);

                count++;
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {

            Orderlist.Enqueue(Input.Text.ToString()); // Enqueue adds a new item to the end of the queue.
            DisplayQueue();
        }

        private void REMOVE_Click(object sender, EventArgs e)
        {
            if (Orderlist.Count > 0)
            {

                Orderlist.Dequeue(); //it removes the first item in the queue 
                DisplayQueue(); //to update the list on the screen.
            }
            else
            {
                MessageBox.Show("Queue is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

      
    }
}

