using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WinFormsCRUD_WebAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupListView();
        }


        #region List Functions
        private void SetupListView()
        {
            // Ensure the ListView is in Details view mode
            listView1.View = View.Details;

            // Add columns to the ListView
            listView1.Columns.Clear(); // Clear any existing columns
            listView1.Columns.Add("Product Name", 400);  // Add "Product Name" column
            listView1.Columns.Add("Description", 400);   // Add "Description" column

            // Clear any ImageList, as we are no longer using images
            listView1.SmallImageList = null;

            PrepareEcomData();

            // Hook into the custom drawing events
            // listView1.DrawItem += new DrawListViewItemEventHandler(listView1_DrawItem);
            listView1.DrawSubItem += new DrawListViewSubItemEventHandler(listView1_DrawSubItem);
            listView1.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(listView1_DrawColumnHeader);
        }


        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Draw the default column headers
            e.DrawDefault = true;
        }

        //private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        //{
        //    // Draw the background of the item
        //    //e.DrawBackground();

        //    // Draw the image (on the left side)
        //    // e.Graphics.DrawImage(imageList1.Images[e.Item.ImageIndex], e.Bounds.Left, e.Bounds.Top, 64, 64);
        //}

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Font productFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font descriptionFont = new Font("Segoe UI", 8);

            if (e.ColumnIndex == 0) // Draw the product name in the first column
            {
                // Draw the product name slightly below the top to leave room for description
                e.Graphics.DrawString(e.SubItem.Text, productFont, Brushes.Black, e.Bounds.Left + 10, e.Bounds.Top);
            }
            else if (e.ColumnIndex == 1) // Draw the description in the second column
            {
                // Draw the description lower, giving enough space for visibility
                e.Graphics.DrawString(e.SubItem.Text, descriptionFont, Brushes.Gray, e.Bounds.Left + 10, e.Bounds.Top + 10);
            }
        }
        #endregion

        #region Prepare App Data
        private void PrepareEcomData()
        {
            // Add items to the ListView (without specifying an image index)
            ListViewItem item1 = new ListViewItem(new[] { "Electronics - iPhone 13", "This is the latest iPhone model with advanced features" });
            ListViewItem item2 = new ListViewItem(new[] { "Fashion - Nike Air Max", "A popular running shoe with a sleek design" });
            ListViewItem item3 = new ListViewItem(new[] { "Home - IKEA Sofa", "A comfortable and affordable sofa for your living room" });
            ListViewItem item4 = new ListViewItem(new[] { "Electronics - Samsung TV", "A high-definition TV with advanced features" });
            ListViewItem item5 = new ListViewItem(new[] { "Fashion - Gucci Handbag", "A stylish and luxurious handbag for women" });
            ListViewItem item6 = new ListViewItem(new[] { "Home - KitchenAid Mixer", "A high-quality mixer for baking and cooking" });
            ListViewItem item7 = new ListViewItem(new[] { "Electronics - Sony Headphones", "A pair of high-quality headphones for music lovers" });
            ListViewItem item8 = new ListViewItem(new[] { "Fashion - Adidas Sneakers", "A pair of comfortable and stylish sneakers" });
            ListViewItem item9 = new ListViewItem(new[] { "Home - West Elm Bed", "A stylish and comfortable bed for your bedroom" });
            ListViewItem item10 = new ListViewItem(new[] { "Electronics - Apple Watch", "A smartwatch with advanced features" });
            ListViewItem item11 = new ListViewItem(new[] { "Fashion - Levi's Jeans", "A pair of classic and comfortable jeans" });
            ListViewItem item12 = new ListViewItem(new[] { "Home - Kitchen Appliances", "A set of high-quality kitchen appliances" });
            ListViewItem item13 = new ListViewItem(new[] { "Electronics - Google Pixel", "A high-end smartphone with advanced features" });
            ListViewItem item14 = new ListViewItem(new[] { "Fashion - Ray-Ban Sunglasses", "A pair of stylish and protective sunglasses" });
            ListViewItem item15 = new ListViewItem(new[] { "Home - Patio Furniture", "A set of comfortable and stylish patio furniture" });
            ListViewItem item16 = new ListViewItem(new[] { "Electronics - Amazon Echo", "A smart speaker with advanced features" });
            ListViewItem item17 = new ListViewItem(new[] { "Fashion - Calvin Klein Underwear", "A set of comfortable and stylish underwear" });
            ListViewItem item18 = new ListViewItem(new[] { "Home - Bathroom Fixtures", "A set of high-quality bathroom fixtures" });
            ListViewItem item19 = new ListViewItem(new[] { "Electronics - Fitbit Tracker", "A fitness tracker with advanced features" });
            ListViewItem item20 = new ListViewItem(new[] { "Fashion - Tommy Hilfiger Shirt", "A stylish and comfortable shirt" });
            ListViewItem item21 = new ListViewItem(new[] { "Home - Living Room Decor", "A set of stylish and comfortable living room decor" });
            ListViewItem item22 = new ListViewItem(new[] { "Electronics - Oculus VR", "A virtual reality headset with advanced features" });
            ListViewItem item23 = new ListViewItem(new[] { "Fashion - Ugg Boots", "A pair of comfortable and stylish boots" });
            ListViewItem item24 = new ListViewItem(new[] { "Home - Bedroom Furniture", "A set of comfortable and stylish bedroom furniture" });
            ListViewItem item25 = new ListViewItem(new[] { "Electronics - Xbox Console", "A gaming console with advanced features" });
            ListViewItem item26 = new ListViewItem(new[] { "Fashion - Michael Kors Handbag", "A stylish and luxurious handbag for women" });
            ListViewItem item27 = new ListViewItem(new[] { "Home - Outdoor Furniture", "A set of comfortable and stylish outdoor furniture" });
            ListViewItem item28 = new ListViewItem(new[] { "Electronics - PlayStation Console", "A gaming console with advanced features" });
            ListViewItem item29 = new ListViewItem(new[] { "Fashion - Ralph Lauren Polo", "A stylish and comfortable polo shirt" });
            ListViewItem item30 = new ListViewItem(new[] { "Home - Home Office Furniture", "A set of comfortable and stylish home office furniture" });

            ListViewItem[] items = new ListViewItem[] {
                item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15,
                item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29, item30 };

            foreach (ListViewItem item in items)
            {
                listView1.Items.Add(item);
            }
        }
        #endregion

        #region CRUD Operations
        private void AddProduct()
        {
            string itxtProductName = Interaction.InputBox("Enter Product Name:", "Input Box");
            //if (itxtProductName != string.Empty)
            //{
            //    MessageBox.Show("You entered: " + itxtProductName);
            //}
            //else
            //{
            //    MessageBox.Show("You didn't enter anything.");
            //}

            string itxtDescription = Interaction.InputBox("Enter Product Discription:", "Input Box");
            //if (itxtDescription != string.Empty)
            //{
            //    MessageBox.Show("You entered: " + itxtDescription);
            //}
            //else
            //{
            //    MessageBox.Show("You didn't enter anything.");
            //}

            string productName = itxtProductName;
            string description = itxtDescription;

            // Ensure that the input fields are not empty
            if (!string.IsNullOrWhiteSpace(productName) && !string.IsNullOrWhiteSpace(description))
            {
                // Add a new item to the ListView
                ListViewItem newItem = new ListViewItem(new[] { productName, description });
                listView1.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Please enter both a product name and a description.");
            }
        }
        #endregion

        #region Additional Functions

        private void CreateEditForm(ListViewItem selectedItem)
        {
            // Create a new form for editing the product name and description
            Form editForm = new Form();
            editForm.Text = "Edit Product";
            editForm.Width = 300;
            editForm.Height = 200;

            // Create input fields for product name and description
            TextBox productNameTextBox = new TextBox();
            productNameTextBox.Location = new Point(10, 10);
            productNameTextBox.Width = 250;
            productNameTextBox.Text = selectedItem.SubItems[0].Text;

            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Location = new Point(10, 40);
            descriptionTextBox.Width = 250;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Text = selectedItem.SubItems[1].Text;

            // Create a button to save the changes
            Button saveButton = new Button();
            saveButton.Location = new Point(10, 120);
            saveButton.Text = "Save";
            saveButton.Click += (s, args) =>
            {
                // Update the selected item's product name and description
                selectedItem.SubItems[0].Text = productNameTextBox.Text;
                selectedItem.SubItems[1].Text = descriptionTextBox.Text;

                // Close the edit form
                editForm.Close();
            };

            // Add the input fields and button to the edit form
            editForm.Controls.Add(productNameTextBox);
            editForm.Controls.Add(descriptionTextBox);
            editForm.Controls.Add(saveButton);

            // Show the edit form as a dialog box
            editForm.ShowDialog();
        }

        #endregion

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                CreateEditForm(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Confirm deletion with the user
                if (MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Remove the selected item from the ListView
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
