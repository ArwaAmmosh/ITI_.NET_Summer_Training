
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace E_F
{
    public partial class Form1 : Form
    {
        AuthorContext context = new AuthorContext();

        public Form1()
        {
            InitializeComponent();



        }
        int id = 0;

        void ButtonsDisplay(bool visible)
        {
            bt_add.Visible = visible;
            bt_del.Visible = visible;
            bt_edit.Visible = visible;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = context.Posts.Select(e => new { e.Id, e.Title, e.Description, Author = e.Author_ID.Name, Category = e.Category_ID.Name }).ToList();
            details.DataSource = result;

            cd_category.DataSource = context.Categories.ToList();
            cd_category.DisplayMember = "Name";
            cd_category.ValueMember = "ID";
            cd_author.DataSource = context.Authors.ToList();
            cd_author.DisplayMember = "Name";
            cd_author.ValueMember = "ID";
            ButtonsDisplay(true);

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                Post post = new Post()
                {
                    Title = title.Text,
                    Description = description.Text,
                    Author_id = (int)cd_author.SelectedValue,
                    Categoy_id = (int)cd_category.SelectedValue,
                };
                context.Posts.Add(post);
                context.SaveChanges();
                MessageBox.Show("Data have been added");
                details.DataSource = context.Posts.Select(e => new { e.Id, e.Title, e.Description, Author = e.Author_ID.Name, Category = e.Category_ID.Name }).ToList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
            ButtonsDisplay(true);


        }
        private void details_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)details.SelectedRows[0].Cells[0].Value;

            Post post = context.Posts.Where(e => e.Id == id).SingleOrDefault();
            title.Text = post.Title;
            description.Text = post.Description;
            cd_author.SelectedValue = post.Author_id;
            cd_category.SelectedValue = post.Categoy_id;
            ButtonsDisplay(false);
            bt_del.Visible = true;
            bt_edit.Visible = true;
        }
      
       
      
        void ClearInputs()
        {
            title.Text = description.Text = "";
            cd_category.SelectedValue = cd_author.SelectedValue = 0;
        }

        private void bt_del_Click_1(object sender, EventArgs e)
        {
            try
            {
                Post post = context.Posts.Where(e => e.Id == id).SingleOrDefault();
                context.Posts.Remove(post);
                context.SaveChanges();
                MessageBox.Show("Data have been deleted");
                details.DataSource = context.Posts.Select(e => new { e.Id, e.Title, e.Description, Author = e.Author_ID.Name, Category = e.Category_ID.Name }).ToList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
            ButtonsDisplay(true);
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            try
            {

                Post post = context.Posts.Where(e => e.Id == id).SingleOrDefault();
                title.Text = post.Title;
                description.Text = post.Description;
                cd_author.SelectedValue = post.Author_id;
                cd_category.SelectedValue = post.Categoy_id;

                context.SaveChanges();
                MessageBox.Show("Data have been updated");
                details.DataSource = context.Posts.Select(e => new { e.Id, e.Title, e.Description, Author = e.Author_ID.Name, Category = e.Category_ID.Name }).ToList(); ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n {ex}");
            }
            ButtonsDisplay(true);
        }
    }
}