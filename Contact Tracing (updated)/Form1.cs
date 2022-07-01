using System;
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
    public partial class ContactTracingF1 : Form
    {
        public static ContactTracingF1 instance;
        public TextBox FName;
        public TextBox MName;
        public TextBox Surname;
        public TextBox Age;
        public TextBox Number;
        public TextBox Email;
        public TextBox BPlace;
        public TextBox CAddress;
        public TextBox MFName;
        public TextBox MMName;
        public TextBox MSurname;
        public TextBox MNumber;
        public TextBox MCAddress;
        public TextBox FFName;
        public TextBox FMName;
        public TextBox FSurname;
        public TextBox FNumber;
        public TextBox FCAdress;
        public TextBox P1Name;
        public TextBox P1Date;
        public TextBox P1Time;
        public TextBox P1Loc;
        public TextBox P2Name;
        public TextBox P2Date;
        public TextBox P2Time;
        public TextBox P2Loc;
        public TextBox P3Name;
        public TextBox P3Date;
        public TextBox P3Time;
        public TextBox P3Loc;
        public TextBox P4Name;
        public TextBox P4Date;
        public TextBox P4Time;
        public TextBox P4Loc;
        public TextBox P5Name;
        public TextBox P5Date;
        public TextBox P5Time;
        public TextBox P5Loc;

        public ContactTracingF1()
        {
            InitializeComponent();
            instance = this;
            FName = TxtBoxFN;
            MName = TxtBoxMN;
            Surname = TxtBoxSN;
            Age = TxtBoxAge;
            Number = TxtBoxPN;
            Email = TxtBoxEmail;
            BPlace = TxtBoxBP;
            CAddress = TxtBoxCA;
            MFName = TxtBoxMotherFN;
            MMName = TxtBoxMotherMN;
            MSurname = TxtBoxMotherSN;
            MNumber = TxtBoxMotherPN;
            MCAddress = TxtBoxMotherCA;
            FFName = TxtBoxFatherFN;
            FMName = TxtBoxFatherMN;
            FSurname = TxtBoxFatherSN;
            FNumber = TxtBoxFatherPN;
            FCAdress = TxtBoxFatherCA;
            P1Name = TxtBoxName1;
            P2Name = TxtBoxName2;
            P3Name = TxtBoxName3;
            P4Name = TxtBoxName4;
            P5Name = TxtBoxName5;
            P1Date = TxtBoxDate1;
            P2Date = TxtBoxDate2;
            P3Date = TxtBoxDate3;
            P4Date = TxtBoxDate4;
            P5Date = TxtBoxDate5;
            P1Time = TxtBoxTime1;
            P2Time = TxtBoxTime2;
            P3Time = TxtBoxTime3;
            P4Time = TxtBoxTime4;
            P5Time = TxtBoxTime5;
            P1Loc = TxtBoxLoc1;
            P2Loc = TxtBoxLoc2;
            P3Loc = TxtBoxLoc3;
            P4Loc = TxtBoxLoc4;
            P5Loc = TxtBoxLoc5;
        }

        private void CTbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = (TxtBoxFN.Text + " " + TxtBoxMN.Text + " " + TxtBoxSN.Text + " " + TxtBoxSuffix.Text);
                string Age = TxtBoxAge.Text;
                string Birthday = (CTcboxMonth.SelectedItem + " " + CTcboxDay.SelectedItem + " " + CTcboxYear.SelectedItem);
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

                if ((Name == "") || (Age == "") || (Birthday == "") || (SexFM == "") || (PNumber == "") || (BirthPlace == "") || (CurrentAdd == "") || ((CTcheckboxYes1.Checked == false) && (CTcheckbocNo1.Checked == false)) || ((CTcheckboxYes2.Checked == false) && (CTcheckboxNo2.Checked == false)) || ((CTcheckboxYes3.Checked == false) && (CTcheckboxNo3.Checked == false)) || ((CTcheckboxYes4.Checked == false) && (CTcheckboxNo4.Checked == false) && (CTcheckboxIDK1.Checked == false)))
                {
                    MessageBox.Show("Please complete the form", "Incomplete");
                }
                else
                {
                    StreamWriter saveContact = new StreamWriter(@"C:\Users\Santos\Documents\Records\" + Date + ".txt", true);
                    saveContact.WriteLine(Date + "\r\n" + "Name: " + Name + "\r\n" + "Age: " + Age + "\r\n" + "Birthday: " + Birthday + "\r\n" + "Sex: " + SexFM + "\r\n" + "Phone Number: " + PNumber + "\r\n" + "Email: " + Email + "\r\n" + "Birth Place: " + BirthPlace + "\r\n" + "Current Address: " + CurrentAdd + "\r\n");
                    saveContact.WriteLine("Mother's Info:" + "\r\n" + "Name: " + MName + "\r\n" + "Phone Number: " + MPNumber + "\r\n" + "Current Address: " + MCurrentAdd + "\r\n");
                    saveContact.WriteLine("Father's Info:" + "\r\n" + "Name: " + FName + "\r\n" + "Phone Number: " + FPNumber + "\r\n" + "Current Address: " + FCurrentAdd + "\r\n");

                    saveContact.WriteLine(CTlabelAbout3.Text + "\r\n" + "1. " + CTlabelQ1.Text + "- " + "\r\n" + "\t" + CTcheckboxYes1.Text + ": " + CTcheckboxYes1.Checked.ToString() + " " + CTcheckbocNo1.Text + ": " + CTcheckbocNo1.Checked.ToString() + "\r\n");
                    saveContact.WriteLine("2. " + CTlabelQ2.Text + "- " + "\r\n" + "\t" + CTcheckboxYes2.Text + ": " + CTcheckboxYes2.Checked.ToString() + " " + CTcheckboxNo2.Text + ": " + CTcheckboxNo2.Checked.ToString() + "\r\n");
                    saveContact.WriteLine(CTlabelAbout4.Text + "\r\n" + "3. " + CTlabelQ3.Text + "- " + "\r\n" + "\t" + CTcheckboxYes3.Text + ": " + CTcheckboxYes3.Checked.ToString() + " " + CTcheckboxNo3.Text + ": " + CTcheckboxNo3.Checked.ToString() + "\r\n");
                    saveContact.WriteLine("4. " + CTlabelQ4.Text + "- " + "\r\n" + "\t" + CTcheckboxYes4.Text + ": " + CTcheckboxYes4.Checked.ToString() + " " + CTcheckboxNo4.Text + ": " + CTcheckboxNo4.Checked.ToString() + " " + CTcheckboxIDK1.Text + ": " + CTcheckboxIDK1.Checked.ToString() + "\r\n");

                    saveContact.WriteLine(CTlabelAbout5.Text + "\r\n" + "1. " + Person1);
                    saveContact.WriteLine("2. " + Person2);
                    saveContact.WriteLine("3. " + Person3);
                    saveContact.WriteLine("4. " + Person4);
                    saveContact.WriteLine("5. " + Person5 + "\r\n");
                    saveContact.Close();

                    MessageBox.Show("File Saved");
                }
            }
            catch 
            {
                MessageBox.Show("Please complete the form.");
            }
            try
            {
                string recordDate = (CTcboxDateM.SelectedItem.ToString() + " " + CTcboxDateD.SelectedItem.ToString() + " " + CTcboxDateY.SelectedItem.ToString());
                StreamReader displayContact = new StreamReader(@"C:\Users\Santos\Documents\Records\" + recordDate + ".txt");
                CTList1.Items.Add("Entry: " + displayContact.ReadLine());
                displayContact.Close();
            }
            catch
            {
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

        private void CTbtnFilter_Click(object sender, EventArgs e)
        {
            CTList2.Items.Clear();
            try
            {
                string Date_Find = CTcboxFilterM.SelectedItem.ToString() + " " + CTcboxFilterD.SelectedItem.ToString() + " " + CTcboxFilterY.SelectedItem.ToString();
                string file_name_record = (@"C:\Users\Santos\Documents\Records\" + Date_Find + ".txt");

                if (File.Exists(file_name_record) == true)
                {
                    StreamReader filterContact = new StreamReader(@"C:\Users\Santos\Documents\Records\" + Date_Find + ".txt", true);
                    CTList2.Items.Add("There is file available, click the Open button to view the record: ");
                    CTList2.Items.Add(filterContact.ReadLine());
                }
                else
                {
                    MessageBox.Show("No record available for " + Date_Find);
                    CTList2.Items.Add("There is no accessible record");
                }
            }
            catch
            {
                MessageBox.Show("Please input date to filter.");
            }
        }

        private void CTbtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string Date_Find = CTcboxFilterM.SelectedItem.ToString() + " " + CTcboxFilterD.SelectedItem.ToString() + " " + CTcboxFilterY.SelectedItem.ToString();
                StreamReader openFile = new StreamReader(@"C:\Users\Santos\Documents\Records\" + Date_Find + ".txt");
                while (!openFile.EndOfStream)
                {
                    string record = openFile.ReadToEnd();
                    CTrichtxtbox1.Text = record;
                }          
            }
            catch
            {
                MessageBox.Show("No file available");
            }
        }

        private void CTbtnNext_Click(object sender, EventArgs e)
        {
            ContactTracingF2 form2 = new ContactTracingF2();
            form2.Show();
        }
    }
}
