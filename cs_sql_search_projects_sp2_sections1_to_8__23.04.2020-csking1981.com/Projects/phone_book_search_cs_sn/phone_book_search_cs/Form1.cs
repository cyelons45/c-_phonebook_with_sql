using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_search_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_ds);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pb_ds.phone_book_table' table. You can move, or remove it, as needed.
           // this.phone_book_tableTableAdapter.Fill(this.pb_ds.phone_book_table);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.phone_book_tableTableAdapter.Fill(this.pb_ds.phone_book_table);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.phone_book_tableTableAdapter.FillBy_last_name(this.pb_ds.phone_book_table,this.search_tb.Text );
            //------------- Find similar last names start with my value in sql server database----------------------- 
           // this.phone_book_tableTableAdapter.FillBy_like_last_name(this.pb_ds.phone_book_table, this.search_tb.Text+"%");
            //-------------------------------------------------------------------------------------------------------
            //------------- Find similar last names end with my value in sql server database----------------------- 
            //this.phone_book_tableTableAdapter.FillBy_like_last_name(this.pb_ds.phone_book_table,"%"+ this.search_tb.Text  );
            //-------------------------------------------------------------------------------------------------------
            //------------- Find similar last names anywhere with my value in sql server database----------------------- 
            this.phone_book_tableTableAdapter.FillBy_like_last_name(this.pb_ds.phone_book_table, "%" + this.search_tb.Text + "%");
            //-------------------------------------------------------------------------------------------------------
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            long r;
            long.TryParse(this.id_tb.Text, out r);
            this.phone_book_tableTableAdapter.FillBy_id(this.pb_ds.phone_book_table,r);
        }
    }
}
