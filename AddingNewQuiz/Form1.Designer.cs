using System.Drawing;
using System.Windows.Forms;

namespace AddingNewQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            //  
            // AddNewQuiz_HeadingLbl
            //
            
            AddNewQuizForm_HeadingLbl = new Label();
            AddNewQuizForm_HeadingLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_HeadingLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuizForm_HeadingLbl.Location = new Point(13, 13); 
            AddNewQuizForm_HeadingLbl.Name = "AddNewQuizForm_HeadingLbl";
            AddNewQuizForm_HeadingLbl.Size = new Size(533, 46);
            AddNewQuizForm_HeadingLbl.TabIndex = 0;
            AddNewQuizForm_HeadingLbl.Text = "Adding a new Quiz";
            
            //
            //AddNewQuizForm_GeneralLbl
            //

            AddNewQuizForm_GeneralLbl = new Label();
            AddNewQuizForm_GeneralLbl.AutoSize = true;
            AddNewQuizForm_GeneralLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_GeneralLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuizForm_GeneralLbl.Location = new Point(46, 59);
            AddNewQuizForm_GeneralLbl.Name = "AddNewQuizForm_GeneralLbl";
            AddNewQuizForm_GeneralLbl.Size = new Size(96, 28);
            AddNewQuizForm_GeneralLbl.TabIndex = 1;
            AddNewQuizForm_GeneralLbl.Text = "General";
            
            //
            //AddNewQuizForm_NameLbl
            //
            
            AddNewQuizForm_NameLbl = new Label();
            AddNewQuizForm_NameLbl.AutoSize = true;
            AddNewQuizForm_NameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_NameLbl.Location = new Point(13, 100);
            AddNewQuizForm_NameLbl.Name = "AddNewQuizForm_NameLbl";
            AddNewQuizForm_NameLbl.Size = new Size(56, 23);
            AddNewQuizForm_NameLbl.TabIndex = 3;
            AddNewQuizForm_NameLbl.Text = "Name";
           
            //
            // AddNewQuizForm_NameTxt
            //
            
            AddNewQuizForm_NameTxt = new TextBox();
            AddNewQuizForm_NameTxt.Location = new Point(205, 100);
            AddNewQuizForm_NameTxt.Multiline = true;
            AddNewQuizForm_NameTxt.Size = new Size(276, 27);
            AddNewQuizForm_NameTxt.Name = "AddNewQuizForm_NameTxt";
            AddNewQuizForm_NameTxt.TabIndex = 4;
            
            //
            //AddNewQuizFormLbl_DecriptionLbl
            //
            
            AddNewQuizFormLbl_Description = new Label();
            AddNewQuizFormLbl_Description.AutoSize = true;
            AddNewQuizFormLbl_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizFormLbl_Description.Location = new Point(13, 140);
            AddNewQuizFormLbl_Description.Name = "AddNewQuizFormLbl";
            AddNewQuizFormLbl_Description.Size = new Size(113, 23);
            AddNewQuizFormLbl_Description.TabIndex = 5;
            AddNewQuizFormLbl_Description.Text = "Description";
            
            //
            // AddNewQuizFormTxt_Description
            //
            
            AddNewQuizFormTxt_Description = new TextBox();
            AddNewQuizFormTxt_Description.Location = new Point(205, 140);
            AddNewQuizFormTxt_Description.Multiline = true;
            AddNewQuizFormTxt_Description.Name = "AddNewQuizForm_Description";
            AddNewQuizFormTxt_Description.Size = new Size(400, 200);
            AddNewQuizFormTxt_Description.TabIndex = 6;
            
            //
            // AddNewQuizForm_DisplayTbt
            //

            AddNewQuizForm_DisplayTbt = new TextBox();
            AddNewQuizForm_DisplayTbt.Location = new Point(205, 350);
            AddNewQuizForm_DisplayTbt.Multiline = true;
            AddNewQuizForm_DisplayTbt.Name = "AddNewQuizForm_DisplayTbt";
            AddNewQuizForm_DisplayTbt.Size = new Size(15, 15);
            AddNewQuizForm_DisplayTbt.TabIndex = 7;
            
            //
            //   AddNewQuizForm_DisplayLbl
            //
            
            AddNewQuizForm_DisplayLbl = new Label();
            AddNewQuizForm_DisplayLbl.AutoSize = true;
            AddNewQuizForm_DisplayLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_DisplayLbl.Location = new Point(220, 350); 
            AddNewQuizForm_DisplayLbl.Size = new Size(500, 46);
            AddNewQuizForm_DisplayLbl.Name = "AddNewQuizForm_DisplayLbl";
            AddNewQuizForm_DisplayLbl.TabIndex = 8;
            AddNewQuizForm_DisplayLbl.Text = "Display description on course page";
            //
            // AddNewQuizForm_LineLbl
            //
            AddNewQuizForm_LineLbl = new Label();
            AddNewQuizForm_LineLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AddNewQuizForm_LineLbl.AutoSize = false;
            AddNewQuizForm_LineLbl.Name = "AddNewQuizForm_LineLbl";
            AddNewQuizForm_LineLbl.TabIndex = 9;
            AddNewQuizForm_LineLbl.Location = new Point(13, 375);
            AddNewQuizForm_LineLbl.Size = new Size(595, 2);

            //
            // AddNewQuizForm_TiminglLbl
            //
            
            AddNewQuizForm_TiminglLbl = new Label();
            AddNewQuizForm_TiminglLbl.AutoSize = true;
            AddNewQuizForm_TiminglLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_TiminglLbl.ForeColor = Color.FromArgb(194, 36, 36);
            AddNewQuizForm_TiminglLbl.Location = new Point(46, 380);
            AddNewQuizForm_TiminglLbl.Name = "AddNewQuizForm_GeneralLbl";
            AddNewQuizForm_TiminglLbl.Size = new Size(96, 28);
            AddNewQuizForm_TiminglLbl.TabIndex = 10;
            AddNewQuizForm_TiminglLbl.Text = "Timing";
            
            //
            //  AddNewQuizForm_OpenthequizLbl
            //
            
            AddNewQuizForm_OpenthequizLbl = new Label();
            AddNewQuizForm_OpenthequizLbl.AutoSize = true;
            AddNewQuizForm_OpenthequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_OpenthequizLbl.Location = new Point(13, 410);
            AddNewQuizForm_OpenthequizLbl.Name = "AddNewQuizForm_OpenthequizLbl";
            AddNewQuizForm_OpenthequizLbl.Size = new Size(113, 23);
            AddNewQuizForm_OpenthequizLbl.TabIndex = 11;
            AddNewQuizForm_OpenthequizLbl.Text = "Open the quiz";
            
            //
            //AddNewQuizForm_ClosethequizLbl
            //
            
            AddNewQuizForm_ClosethequizLbl = new Label();
            AddNewQuizForm_ClosethequizLbl.AutoSize = true;
            AddNewQuizForm_ClosethequizLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_ClosethequizLbl.Location = new Point(13, 445);
            AddNewQuizForm_ClosethequizLbl.Name = "AddNewQuizForm_ClosethequizLbl";
            AddNewQuizForm_ClosethequizLbl.Size = new Size(113, 23);
            AddNewQuizForm_ClosethequizLbl.TabIndex = 12;
            AddNewQuizForm_ClosethequizLbl.Text = "Close the quiz";
                
            //
            // AddNewQuizForm_Timelimit
            // 
            
            AddNewQuizForm_Timelimit = new Label();
            AddNewQuizForm_Timelimit.AutoSize = true;
            AddNewQuizForm_Timelimit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_Timelimit.Location = new Point(13, 485);
            AddNewQuizForm_Timelimit.Name = "AddNewQuizForm_Timelimit";
            AddNewQuizForm_Timelimit.Size = new Size(113, 23);
            AddNewQuizForm_Timelimit.TabIndex = 13;
            AddNewQuizForm_Timelimit.Text = "Time limit";

            //
            //AddNewQuizForm_Timeexpires
            //
            
            AddNewQuizForm_Timeexpires = new Label();
            AddNewQuizForm_Timeexpires.AutoSize = true;
            AddNewQuizForm_Timeexpires.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewQuizForm_Timeexpires.Location = new Point(13, 525);
            AddNewQuizForm_Timeexpires.Name = "AddNewQuizForm_Timeexpires"; 
            AddNewQuizForm_Timeexpires.Size = new Size(113, 23);
            AddNewQuizForm_Timeexpires.TabIndex = 14;
            AddNewQuizForm_Timeexpires.Text = "When time expire";
            
            //
            // AddNewQuizForm
            // 
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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

        #endregion
        private Label AddNewQuizForm_HeadingLbl;
        private Label AddNewQuizForm_GeneralLbl;
        private TextBox AddNewQuizForm_NameTxt;
        private Label AddNewQuizForm_NameLbl;
        private TextBox AddNewQuizFormTxt_Description;
        private Label AddNewQuizFormLbl_Description;
        private TextBox AddNewQuizForm_DisplayTbt;
        private Label AddNewQuizForm_DisplayLbl;
        private Label AddNewQuizForm_LineLbl;
        private Label AddNewQuizForm_TiminglLbl;
        private Label AddNewQuizForm_OpenthequizLbl;
        private Label AddNewQuizForm_ClosethequizLbl;
        private Label AddNewQuizForm_Timelimit;
        private Label AddNewQuizForm_Timeexpires;
    }
}