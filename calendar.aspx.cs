using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calendar : System.Web.UI.Page
{
    // declare two dimensional array named books at class level to be available anywhere
    string[,] books = new String[5, 2]; // , declares two dimensional array - 4 elements, 2 arrays 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack) // keeps selection selected
        //{
            books[0, 0] = "John Steinbeck";
            books[0, 1] = "The Grapes of Wrath";
            books[1, 0] = "Ray Bradbury";
            books[1, 1] = "The Martian Chronicles";
            books[2, 0] = "Isaac Asimov";
            books[2, 1] = "I Robot";
            books[3, 0] = " JRR Tolkein";
            books[3, 1] = "The Hobbit";
            books[4, 0] = "Ray Bradbury";
            books[4, 1] = "Something Wicked This Way Comes";


            if (!IsPostBack)
            FillAuthor();
       // }
    }

    //populate author
    protected void FillAuthor()
    {
        for (int i = 0; i < 5; i++) // declaring i variable - loop counter 
        {
            AuthorsDropDownList.Items.Add(books[i, 0]); // i matches counter, 0 is author
        }

        ListItem item = new ListItem("Choose An Author");
        AuthorsDropDownList.Items.Insert(0, item); // created new list item with text and inserting at zero position
    }


    protected void AuthorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        ResultLabel.Text = "";
        string author;
        author = AuthorsDropDownList.SelectedItem.Text; // calling selected items text - calendar.selecteddate
        for (int i = 0; i < 5; i++)
        {
            if (books[i, 0].Equals(author))
            {
                ResultLabel.Text += books[i, 1] + "<br />";
            }
        }
    }
}
