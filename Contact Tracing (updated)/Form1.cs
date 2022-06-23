using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing__updated_
{
    public partial class ContactTracing : Form
    {
        public ContactTracing()
        {
            InitializeComponent();
        }

        private void CTbtnSave_Click(object sender, EventArgs e)
        {
            string Name = TxtBoxFN.Text + " " + TxtBoxMN.Text + " " + TxtBoxSN.Text + " " + TxtBoxSufix.Text;
            string Age = TxtBoxAge.Text;
            string Birthday = CTcboxMonth.SelectedItem.ToString() + " " + CTcboxDay.SelectedItem.ToString() + " " + CTcboxYear.SelectedItem.ToString();
            string SexFM = CTcboxSexFM.SelectedItem.ToString();
            string PNumber = TxtBoxPN.Text;
            string Email = TxtBoxEmail.Text;
            string BirthPlace = TxtBoxBP.Text;
            string CurrentAdd = TxtBoxCA.Text;
            string MName = TxtBoxMotherFN.Text + " " + TxtBoxMotherMN.Text + " " + TxtBoxMotherSN.Text + " " + TxtBoxMotherSuffix.Text;
            string MPNumber = TxtBoxMotherPN.Text;
            string MCurrentAdd = TxtBoxMotherCA.Text;
            string FName = TxtBoxFatherFN.Text + " " + TxtBoxFatherMN.Text + " " + TxtBoxFatherSN.Text + " " + TxtBoxFatherSuffix.Text;
            string FPNumber = TxtBoxFatherPN.Text;
            string FCurrentAdd = TxtBoxFatherCA.Text;

        }
    }
}
