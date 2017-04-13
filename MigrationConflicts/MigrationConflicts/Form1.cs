using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationConflicts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var configuration = new Migrations.Configuration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new BlogContext())
            {

                //Exception message: The model backing the 'BlogContext' context has changed since the database was created.
                //Consider using Code First Migrations to update the database (http://go.microsoft.com/fwlink/?LinkId=238269).
                foreach (var blog in db.Blogs)
                {
                    MessageBox.Show(blog.Name);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new BlogContext())
            {
                db.Blogs.Add(new Blog() { Name = "blog1", Rating = 23, Readers = 43 });
                db.SaveChanges();
            }
        }
    }
}
