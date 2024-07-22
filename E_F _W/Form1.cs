
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
namespace E_F
{
    public partial class Form1 : Form
    {
        AuthorContext context = new AuthorContext();

        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = context.Posts.Select(e => new { e.Id, e.Title, e.Description, author = e.Author_ID.Name, cate = e.Category_ID.Name }).ToList();
            details.DataSource = result;

            cd_author.DataSource = context.Authors.ToList();
            cd_author.DisplayMember = "Name";
            cd_author.ValueMember = "ID";
        }
    }
}