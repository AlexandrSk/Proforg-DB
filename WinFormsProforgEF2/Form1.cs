using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProforgDataEF;

namespace WinFormsProforgEF2
{
    public partial class FrmProforg : Form
    {
        private ProforgDataEF.DBLibraryEntities ctx;

        public FrmProforg()
        {
            InitializeComponent();

            ctx = new ProforgDataEF.DBLibraryEntities();

            ctx.groups.Load();
            this.groupsBindingSource.DataSource = ctx.groups.Local.ToBindingList();

            ctx.tab_tickets.Load();
            this.tabticketsBindingSource.DataSource = ctx.tab_tickets.Local.ToBindingList();

            ctx.tab_order.Load();
            this.taborderBindingSource.DataSource = ctx.tab_order.Local.ToBindingList();

            ctx.tab_students.Load();
            this.tabstudentsBindingSource.DataSource = ctx.tab_students.Local.ToBindingList();

            ctx.ticket_type.Load();
            this.tickettypeBindingSource.DataSource = ctx.ticket_type.Local.ToBindingList();

        }

        private void btnSaveStud_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnSaveTick_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnSaveOrd_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            tabstudentsBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void btnDelTick_Click(object sender, EventArgs e)
        {
            tabticketsBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void btnDelOrd_Click(object sender, EventArgs e)
        {
            taborderBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void btnGroupStud_Click(object sender, EventArgs e)
        {
            FormSearch SearchDialog = new FormSearch();
            SearchDialog.ShowDialog(this);
            SearchDialog.Dispose();
        }
    }
}
