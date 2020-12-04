using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Human_Relations.Pages
{
    public partial class payrollReport : Form
    {
        private User userinfo;
        private double minutesWorked;
        private double hoursWorked;
        private double amountEarned;
        private int UserID;
        public payrollReport(int userID)
        {
            InitializeComponent();
            userinfo = new User(userID);
            UserID = userID;
        }

// DESCRIPTION: Loads comboBox data
        private void payrollReport_Load(object sender, EventArgs e)
        {
            // loads data
            this.payperiodsTableAdapter.Fill(this.dboDataSet.payperiods);

        }

 // DESCRIPTION: Logs the user out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedActivity loginActivity = new LoggedActivity();
            loginActivity.logActivity(13, UserID, 0, DateTime.Now, UserID);
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

// DESCRIPTION: Returns to the menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// DESCRIPTION: Pulls name, total hours, and total amount earned for user for selected pay Period
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            // SQL Query pulls total minutes worked and total amount earned for payPeriod and userID
            DBConnect payrollReportConn = new DBConnect();
            MySqlCommand payrollReportCmd = new MySqlCommand(@"SELECT IFNULL(SUM(TIMESTAMPDIFF(minute, inDateTime, outDateTime)), 0) AS 'Minutes',
                                                            IFNULL(SUM(totalPay), 0) as 'TotalPay'
                                                            from dbo.timetracking
                                                            where userID = @userID
                                                            and payPeriodID = @payPeriodID;");
            payrollReportCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userinfo.userID;
            payrollReportCmd.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = cBoxPayPeriodID.SelectedValue;

            MySqlDataReader dataReader = payrollReportConn.ExecuteReader(payrollReportCmd);

            //Read the data and store them in values
            while (dataReader.Read())
            {
                minutesWorked = Convert.ToDouble(dataReader["Minutes"]);
                amountEarned = Convert.ToDouble(dataReader["TotalPay"]);
            }
            //close Data Reader
            dataReader.Close(); ;

            // divide minutesWorked by 60 to get hoursWorked
            hoursWorked = minutesWorked / 60;

            // fill text boxes
            txtName.Text = userinfo.firstName + " " + userinfo.lastName;
            txtHoursWorked.Text = String.Format("{0:F1}", hoursWorked);
            txtAmtMade.Text = (amountEarned.ToString("C", CultureInfo.CurrentCulture));

            //view personal attendance
            DBConnect connection = new DBConnect();
            DataTable attendance = new DataTable();
            BindingSource bindingSource = new BindingSource();
            MySqlCommand cmd = new MySqlCommand();

            // SQL query
            cmd.CommandText = @"SELECT 
                                DATE(inDateTime) AS 'In Date',
                                TIME(inDateTime) AS 'In Time',
                                DATE(outDateTime) AS 'Out Date',
                                TIME(outDateTime) AS 'Out Time'
                                FROM dbo.timetracking
                                WHERE userID = @userID
                                AND payPeriodID = @payPeriodID
                                order by outDateTime desc";
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = this.userinfo.userID;
            cmd.Parameters.Add("@payperiodID", MySqlDbType.Int32).Value = Int32.Parse(cBoxPayPeriodID.SelectedIndex.ToString()) + 1;
            attendance = connection.ExecuteDataTable(cmd);
            bindingSource.DataSource = attendance;
            personalAttendanceDataGrid.DataSource = bindingSource;
            personalAttendanceDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnPrintPayroll_Click(object sender, EventArgs e)
        {
            ////create a document
            //Document pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);


            //PdfWriter.GetInstance(pdfDoc, new FileStream("Test.pdf", FileMode.Create));
            ////open doc to write
            //pdfDoc.Open();

            ////write to the pdf
            //Paragraph par = new Paragraph("how are your");
            //pdfDoc.Add(par);
            //pdfDoc.Close();

            try
            {
                string role="";
                switch (userinfo.roleID)
                {
                    case 1:
                        role = "Associate Staff";
                        break;
                    case 2:
                        role = "Intermediate Staff";
                        break;
                    case 3:
                        role = "Senior Staff";
                        break;
                    case 4:
                        role = "Manager";
                        break;
                    case 5:
                        role = "Senior Manager";
                        break;
                    case 6:
                        role = "Advisor";
                        break;
                    case 7:
                        role = "Senior Advisor";
                        break;
                    case 8:
                        role = "Executive";
                        break;
                    case 9:
                        role = "Senior Executive";
                        break;
                    case 10:
                        role = "Director";
                        break;
                    case 11:
                        role = "Senior Director";
                        break;
                }
                #region Common Part
                PdfPTable pdfPTableBlank = new PdfPTable(1);
                //footer section
                PdfPTable pdfTableFooter = new PdfPTable(1);
                pdfTableFooter.DefaultCell.BorderWidth = 0;
                pdfTableFooter.WidthPercentage = 100;
                pdfTableFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                Chunk cnkFooter = new Chunk(" Pay Period Payroll ", FontFactory.GetFont(" Times New Roman"));
                cnkFooter.Font.Size = 15;
                pdfTableFooter.AddCell(new Phrase(cnkFooter));

                pdfPTableBlank.AddCell(new Phrase(" "));
                pdfPTableBlank.DefaultCell.Border = 0;
                #endregion

                #region Page
                #region Section-1 <Header FORM>
                PdfPTable pdfTable1 = new PdfPTable(1);
                PdfPTable pdfTable2 = new PdfPTable(1);
                PdfPTable pdfTable3 = new PdfPTable(2);

                //font style
                System.Drawing.Font fontH = new System.Drawing.Font("Currier", 16);
                //table1
                pdfTable1.WidthPercentage = 80;
                pdfTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdfTable1.DefaultCell.BorderWidth = 0;
                //table2
                pdfTable2.WidthPercentage = 80;
                pdfTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdfTable2.DefaultCell.BorderWidth = 0;
                //table3
                pdfTable3.DefaultCell.Padding = 5;
                pdfTable3.WidthPercentage = 80;
                pdfTable3.DefaultCell.BorderWidth = 0.5f;


                Chunk c2 = new Chunk(" Thank For Working Hard ", FontFactory.GetFont(" Times New Roman"));
                c2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c2.Font.SetStyle(0);
                c2.Font.Size = 11;
                Phrase p2 = new Phrase();
                p2.Add(c2);
                pdfTable2.AddCell(p2);

                Chunk c3 = new Chunk(" Human Recources ", FontFactory.GetFont(" Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p3 = new Phrase();
                p3.Add(c3);
                pdfTable2.AddCell(p3);
                #endregion


                #region Section-Image
                string image = @"C:\Users\husse\Desktop\4321.png";
                iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(image);
                png.ScaleToFit(540f, 80f);
                png.SpacingBefore = 5f;
                png.SpacingAfter = 5f;
                png.Alignment = Element.ALIGN_CENTER;
                #endregion
                string na = userinfo.firstName +" "+ userinfo.lastName;
                #region section Table
                pdfTable3.AddCell(new Phrase("FULL NAME "));
                pdfTable3.AddCell(new Phrase(na));
                pdfTable3.AddCell(new Phrase("JOB TITLE "));
                pdfTable3.AddCell(new Phrase( role ));
                pdfTable3.AddCell(new Phrase("HOURS WORKED"));
                pdfTable3.AddCell(new Phrase(txtHoursWorked.Text));
                pdfTable3.AddCell(new Phrase("AMOUNT MADE"));
                pdfTable3.AddCell(new Phrase(txtAmtMade.Text));
                #endregion
                #endregion
                #region PDF Generation
                string folderPath = "C:\\PDF\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                //File name
                int fileCount = Directory.GetFiles(@"C:\\PDF").Length;
                string strFileName = "Payroll_" + (fileCount + 1) + ".pdf";

                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    #region PAGE-1
                    pdfDoc.Add(png);
                    pdfDoc.Add(pdfTable1);
                    pdfDoc.Add(pdfTable2);
                    pdfDoc.Add(pdfTable3);
                    pdfDoc.Add(pdfTableFooter);
                    pdfDoc.NewPage();
                    #endregion

                    pdfDoc.Close();
                    stream.Close();
                }
                #endregion
                #region Display PDF
                System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
                #endregion
            }
            catch(Exception ex)
            {
                throw;
            }


        }

    }
}

