﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string Name = (TxtBoxFN.Text + " " + TxtBoxMN.Text + " " + TxtBoxSN.Text + " " + TxtBoxSuffix.Text);
            string Age = TxtBoxAge.Text;
            string Birthday = (CTcboxMonth.SelectedItem.ToString() + " " + CTcboxDay.SelectedItem.ToString() + " " + CTcboxYear.SelectedItem.ToString());
            string SexFM = CTcboxSexFM.SelectedItem.ToString();
            string PNumber = TxtBoxPN.Text;
            string Email = TxtBoxEmail.Text;
            string BirthPlace = TxtBoxBP.Text;
            string CurrentAdd = TxtBoxCA.Text;
            string MName = (TxtBoxMotherFN.Text + " " + TxtBoxMotherMN.Text + " " + TxtBoxMotherSN.Text + " " + TxtBoxMotherSuffix.Text);
            string MPNumber = TxtBoxMotherPN.Text;
            string MCurrentAdd = TxtBoxMotherCA.Text;
            string FName = (TxtBoxFatherFN.Text + " " + TxtBoxFatherMN.Text + " " + TxtBoxFatherSN.Text + " " + TxtBoxFatherSuffix.Text);
            string FPNumber = TxtBoxFatherPN.Text;
            string FCurrentAdd = TxtBoxFatherCA.Text;
            string Date = (CTcboxDateM.SelectedItem.ToString() + " " + CTcboxDateD.SelectedItem.ToString() + " " + CTcboxDateY.SelectedItem.ToString());
            string Person1 = (TxtBoxName1.Text + " " + TxtBoxDate1.Text + " " + TxtBoxTime1.Text + " " + TxtBoxLoc1.Text);
            string Person2 = (TxtBoxName2.Text + " " + TxtBoxDate2.Text + " " + TxtBoxTime2.Text + " " + TxtBoxLoc2.Text);
            string Person3 = (TxtBoxName3.Text + " " + TxtBoxDate3.Text + " " + TxtBoxTime3.Text + " " + TxtBoxLoc3.Text);
            string Person4 = (TxtBoxName4.Text + " " + TxtBoxDate4.Text + " " + TxtBoxTime4.Text + " " + TxtBoxLoc4.Text);
            string Person5 = (TxtBoxName5.Text + " " + TxtBoxDate5.Text + " " + TxtBoxTime5.Text + " " + TxtBoxLoc5.Text);

            if ((Name == "") || (Age == "") || (Birthday == "") || (SexFM == "") || (PNumber == "") || (BirthPlace == "") || (CurrentAdd == "") || ((CTcheckboxYes1.Checked == false)&&(CTcheckbocNo1.Checked == false)) || ((CTcheckboxYes2.Checked == false)&&(CTcheckboxNo2.Checked == false)) || ((CTcheckboxYes3.Checked == false)&&(CTcheckboxNo3.Checked == false)) || ((CTcheckboxYes4.Checked == false)&&(CTcheckboxNo4.Checked == false)&&(CTcheckboxIDK1.Checked == false)))
            {
                MessageBox.Show("Please complete the form", "Incomplete");
            }
            else 
            {
                StreamWriter saveContact = new StreamWriter(@"C:\Users\Santos\Documents\New folder\" + Date + ".txt", true);
                saveContact.WriteLine("Date: " + Date + "\r\n" + "Name: " + Name + "\r\n" + "Age: " + Age + "\r\n" + "Birthday: " + Birthday + "\r\n" + "Sex: " + SexFM + "\r\n" + "Phone Number: " + PNumber + "\r\n" + "Email: " + Email + "\r\n" + "Birth Place: " + BirthPlace + "\r\n" + "Current Address: " + CurrentAdd + "\r\n");
                saveContact.WriteLine(MName + "\r\n" + MPNumber + "\r\n" + MCurrentAdd + "\r\n");
                saveContact.WriteLine(FName + "\r\n" + FPNumber + "\r\n" + FCurrentAdd + "\r\n");

                saveContact.WriteLine(CTlabelAbout3.Text + "\r\n" + "1. " + CTlabelQ1.Text + "- " + "\r\n" + "\t" + CTcheckboxYes1.Text + ": " + CTcheckboxYes1.Checked.ToString() + " " + CTcheckbocNo1.Text + ": " + CTcheckbocNo1.Checked.ToString() + "\r\n");
                saveContact.WriteLine("2. " + CTlabelQ2.Text + "- " + "\r\n" + "\t" + CTcheckboxYes2.Text + ": " + CTcheckboxYes2.Checked.ToString() + " " + CTcheckboxNo2.Text + ": " + CTcheckboxNo2.Checked.ToString() + "\r\n");
                saveContact.WriteLine(CTlabelAbout4.Text + "\r\n" + "3. " + CTlabelQ3.Text + "- " + "\r\n" + "\t" + CTcheckboxYes3.Text + ": " + CTcheckboxYes3.Checked.ToString() + " " + CTcheckboxNo3.Text + ": " + CTcheckboxNo3.Checked.ToString() + "\r\n");
                saveContact.WriteLine("4. " + CTlabelQ4.Text + "- " + "\r\n" + "\t" + CTcheckboxYes4.Text + ": " + CTcheckboxYes4.Checked.ToString() + " " + CTcheckboxNo4.Text + ": " + CTcheckboxNo4.Checked.ToString() + " " + CTcheckboxIDK1.Text + CTcheckboxIDK1.Checked.ToString() + "\r\n");

                saveContact.WriteLine(CTlabelAbout5.Text + "\r\n" + "1. " + Person1);
                saveContact.WriteLine("2. " + Person2);
                saveContact.WriteLine("3. " + Person3);
                saveContact.WriteLine("4. " + Person4);
                saveContact.WriteLine("5. " + Person5);
                saveContact.Close();

                MessageBox.Show("File Saved");
            }
        }

        private void CTbtnClear_Click(object sender, EventArgs e)
        {
            //TextBox
            TxtBoxFN.Text = "";
            TxtBoxMN.Text = "";
            TxtBoxSN.Text = "";
            TxtBoxSuffix.Text = "";
            TxtBoxAge.Text = "";
            TxtBoxPN.Text = "";
            TxtBoxEmail.Text = "";
            TxtBoxBP.Text = "";
            TxtBoxCA.Text = "";
            TxtBoxMotherFN.Text = "";
            TxtBoxMotherMN.Text = "";
            TxtBoxMotherSN.Text = "";
            TxtBoxMotherSuffix.Text = "";
            TxtBoxMotherPN.Text = "";
            TxtBoxMotherCA.Text = "";
            TxtBoxFatherFN.Text = "";
            TxtBoxFatherMN.Text = "";
            TxtBoxFatherSN.Text = "";
            TxtBoxFatherSuffix.Text = "";
            TxtBoxFatherPN.Text = "";
            TxtBoxFatherCA.Text = "";
            TxtBoxName1.Text = "";
            TxtBoxName2.Text = "";
            TxtBoxName3.Text = "";
            TxtBoxName4.Text = "";
            TxtBoxName5.Text = "";
            TxtBoxDate1.Text = "";
            TxtBoxDate2.Text = "";
            TxtBoxDate3.Text = "";
            TxtBoxDate4.Text = "";
            TxtBoxDate5.Text = "";
            TxtBoxTime1.Text = "";
            TxtBoxTime2.Text = "";
            TxtBoxTime3.Text = "";
            TxtBoxTime4.Text = "";
            TxtBoxTime5.Text = "";
            TxtBoxLoc1.Text = "";
            TxtBoxLoc2.Text = "";
            TxtBoxLoc3.Text = "";
            TxtBoxLoc4.Text = "";
            TxtBoxLoc5.Text = "";

            //CheckBox
            CTcheckboxYes1.Checked = false;
            CTcheckboxYes2.Checked = false;
            CTcheckboxYes3.Checked = false;
            CTcheckboxYes4.Checked = false;
            CTcheckbocNo1.Checked = false;
            CTcheckboxNo2.Checked = false;
            CTcheckboxNo3.Checked = false;
            CTcheckboxNo4.Checked = false;
            CTcheckboxIDK1.Checked = false;
        }
    }
}
