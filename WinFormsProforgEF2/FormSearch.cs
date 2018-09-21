using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProforgDataEF;


namespace WinFormsProforgEF2
{
    public partial class FormSearch : Form
    {
        private int dstud_id;
        private readonly string dstud_name;
        private DBLibraryEntities ctx_student;
        
        public FormSearch()
        {
            InitializeComponent();
        }
        public FormSearch(int stud_id, string stud_name)
        {
            InitializeComponent();
            dstud_id = stud_id;
            dstud_name = stud_name;

            ctx_student = new ProforgDataEF.DBLibraryEntities();
            Text = String.Concat(Text, "", dstud_name);
            FindGroup();
        }

        private void btnSearchGroup_Click(object sender, EventArgs e)
        {
            
            
            string FindGroup = "%" + textBox1.Text + "%";
            ctx_student = new ProforgDataEF.DBLibraryEntities();
            var query = (from c in ctx_student.tab_students  select c);

            if (!String.IsNullOrWhiteSpace(FindGroup))
                query = query.Where(c => c.groups.group_name.Contains(FindGroup));

            query.Load();
            //taborderBindingSource.DataSource = ctx_student.tab_students.Local.ToBindingList();
            taborderBindingSource.DataSource = query.ToList();
        }

        private void FindGroup()
        {
            //ctx_student.Dispose();
            ctx_student = new ProforgDataEF.DBLibraryEntities();

            var query = (from c in ctx_student.groups
                         where c.group_name == textBox1.Text
                         select c);
            //if (!String.IsNullOrWhiteSpace(Search_NAME))
            //    query = query.Where(c => c.)
            taborderBindingSource.DataSource = query.ToList();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
