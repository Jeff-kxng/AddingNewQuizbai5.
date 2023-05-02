using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingNewQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controls.Add(AddNewQuizForm_HeadingLbl);
            Controls.Add(AddNewQuizForm_GeneralLbl);
            Controls.Add(AddNewQuizForm_NameTxt);
            Controls.Add(AddNewQuizFormTxt_Description);
            Controls.Add(AddNewQuizForm_NameLbl);
            Controls.Add(AddNewQuizFormLbl_Description);
            Controls.Add(AddNewQuizForm_DisplayTbt);
            Controls.Add(AddNewQuizForm_DisplayLbl);
            Controls.Add(AddNewQuizForm_LineLbl);
            Controls.Add(AddNewQuizForm_TiminglLbl);
            Controls.Add(AddNewQuizForm_OpenthequizLbl);
            Controls.Add(AddNewQuizForm_ClosethequizLbl);
            Controls.Add(AddNewQuizForm_Timelimit);
            Controls.Add(AddNewQuizForm_Timeexpires);
        }
    }
}