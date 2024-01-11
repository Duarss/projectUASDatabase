﻿using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormTambahGenre : Form
    {
        public FormTambahGenre()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Genre g = new Genre();
                g.Nama = textBoxGenre.Text;
                g.Deskripsi = textBoxDeskripsi.Text;

                Genre.TambahData(g);
                MessageBox.Show("Tambah data berhasil");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Tambah data gagal. Error: " + x.Message);
            }
        }

        private void FormTambahGenre_Load(object sender, EventArgs e)
        {

        }
    }
}
