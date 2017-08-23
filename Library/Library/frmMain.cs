﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmMain : BlackForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember addMemberForm = new frmAddMember();
            addMemberForm.MdiParent = this;
            addMemberForm.Show();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBooks addBooksForm = new frmAddBooks();
            addBooksForm.MdiParent = this;
            addBooksForm.Show();
        }
    }
}
