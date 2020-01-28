
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Drawing.Printing;
using SparseCollections;
using Mathematics;
using System.IO;

namespace csEquationSolver
{
    public partial class EquationsSolverForm : Form
    {
        string[] Data;

        private static readonly string m_documentPathFileName= "Equations.csv";
       
        private bool m_dirty;

     

        /// <summary>
        /// Constructor
        /// </summary>
        public EquationsSolverForm(string pathFileName)
        {
            InitializeComponent();

          
         
            m_dirty = false;

         

        }

        // Event handlers
        private void EquationsSolverForm_Load(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(m_documentPathFileName))
            {
                LoadDocumentFromFile(m_documentPathFileName);
            }
        }

        private void EquationsSolverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Save the form state, size, and location.
            Properties.Settings.Default.FormWindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.FormSize = this.Size;
                Properties.Settings.Default.FormLocation = this.Location;
            }
            else
            {
                Properties.Settings.Default.FormSize = this.RestoreBounds.Size;
                Properties.Settings.Default.FormLocation = this.RestoreBounds.Location;
            }

            Properties.Settings.Default.Save();
        }

        private void EquationsSolverForm_Resize(object sender, EventArgs e)
        {
            ResizeMainFormControls();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm Form = new QueryForm();
            Form.Data = Data;
            Form.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
           LoadDocumentFromFile(m_documentPathFileName);
        }

     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }


        private void solveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solve();
        }

      


        // OnBeginPrint 
       
  // This was added by the automatic form designer. Perhaps someday I will use it.
        private void mainToolStripStatusLabel_Click(object sender, EventArgs e)
        {
        }

        // End of handlers

        /// <summary>
        /// This method resizes and repositions form controls when the main window is resized.
        /// </summary>
        private void ResizeMainFormControls()
        {
            int x = mainMenuStrip.Location.X;
            int y = mainMenuStrip.Location.Y + mainMenuStrip.Height;
            equationsRichTextBox.Location = new System.Drawing.Point(x, y);
            int cx = this.ClientSize.Width;
            int cy = this.ClientSize.Height - mainMenuStrip.Height - mainStatusStrip.Height;
            equationsRichTextBox.Size = new System.Drawing.Size(cx, cy);
        }

        /// <summary>
        /// This methods tests whether data is present.
        /// </summary>
        /// <returns>'true' if and only if data is present</returns>
        public bool HaveData()
        {
            return (!string.IsNullOrEmpty(equationsRichTextBox.Text) && !string.IsNullOrEmpty(txtcity.Text)
                   && !string.IsNullOrEmpty(txtfname.Text) && !string.IsNullOrEmpty(txtlname.Text)
                   &&!string.IsNullOrEmpty(txtage.Text));
        }

        /// <summary>
        /// This methods tests whether data is present.
        /// </summary>
        public void New()
        {
            AvoidLosingData();
            equationsRichTextBox.Text = "";
            mainToolStripStatusLabel.Text = "";
           m_dirty = false;
        }

        /// <summary>
        /// Method to avoid losing data. If data is present and it
        /// has not been saved, then prompt the user to save the data.
        /// </summary>
        private void AvoidLosingData()
        {
            // If data is present and it has not been saved,
            // then prompt the user to save the data.
            if (HaveData() && (m_dirty))
            {
                DialogResult result = MessageBox.Show(
                                          Properties.Resources.IDS_DO_YOU_WANT_TO_SAVE_QUERY,
                                          Properties.Resources.IDS_SAVE_ON_EXIT_PROMPT,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        /// <summary>
        /// Load the file.
        /// </summary>
        /// <param name="pathFileName">The path and file name</param>
        private void LoadDocumentFromFile(string pathFileName)
        {
            // Open and read the file into the rich text control.
            Data = File.ReadAllLines(m_documentPathFileName, Encoding.UTF8);


            m_dirty = false;
        }

        /// <summary>
        /// Save the file.
        /// </summary>
        /// <param name="pathFileName">The path and file name</param>
        private void SaveDocumentToFile(string pathFileName)
        {
            
            string Fname = txtfname.Text;
            string Lname = txtlname.Text;
            string Age = txtage.Text;
            string City = txtcity.Text;
            string Equation = equationsRichTextBox.Text;
            string csvRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", Fname, Lname, Age, City, Equation.Split('\n')[0], Equation.Split('\n')[1], Equation.Split('\n')[2], Equation.Split('\n')[3], Equation.Split('\n')[4], Equation.Split('\n')[5]);
               int before = 0;
            string all = "";
            foreach(string data in Data)
            {
                all += data + "\n";
                if (csvRow.ToUpper() == data.ToUpper())
                {
                  
                    
                    MessageBox.Show("This Data is Entered Before!");
                    before = 1;
                    break;
                }
            }
            if (before == 0)
            {
                File.WriteAllText(pathFileName, all+csvRow, Encoding.UTF8);
                string[] TempData =new string[Data.Count()+1];
                int ij = 0;
                for(ij=0;ij<Data.Count();ij++)
                {
                    TempData[ij] = Data[ij];
                }
                TempData[ij] = csvRow;
                MessageBox.Show("Data Entered SuccessFully!");
            }

            m_dirty = false;
        }

        /// <summary>
        /// Launch the open file dialog and open a file.
        /// </summary>
      
        /// <summary>
        /// Save the document to a file. If the document currently
        /// has no name then call the SaveAs method to prompt for a file name.
        /// </summary>
        private void Save()
        {
            // Is there anything to save?
            if (HaveData())
            {
                 SaveDocumentToFile(m_documentPathFileName);
              
              
            }
            else
            {
                MessageBox.Show(Properties.Resources.IDS_NOTHING_TO_SAVE);
            }
        }

     


        /// <summary>
        /// Method to cause the application to close.
        /// </summary>
        private void Exit()
        {
            AvoidLosingData();
            Application.Exit();
        }

      
        

        private void Solve()
        {
            mainToolStripStatusLabel.Text = Properties.Resources.IDS_SOLVING_EQUATIONS;

            Sparse2DMatrix<int, int, double> aMatrix = new Sparse2DMatrix<int, int, double>();
            SparseArray<int, double> bVector = new SparseArray<int, double>();
            SparseArray<string, int> variableNameIndexMap = new SparseArray<string, int>();
            int numberOfEquations = 0;

            LinearEquationParser parser = new LinearEquationParser();
            LinearEquationParserStatus parserStatus = LinearEquationParserStatus.Success;

            foreach (string inputLine in equationsRichTextBox.Lines)
            {
                parserStatus = parser.Parse(inputLine,
                                            aMatrix,
                                            bVector,
                                            variableNameIndexMap,
                                            ref numberOfEquations);

                if (parserStatus != LinearEquationParserStatus.Success)
                {
                    break;
                }
            }

            // Assume success.
            string mainStatusBarText = Properties.Resources.IDS_EQUATIONS_SOLVED;

            // Did an error occur?
            if (parserStatus == LinearEquationParserStatus.Success)
            {
                // Are there the same number of equations as variables?
                if (numberOfEquations == variableNameIndexMap.Count)
                {
                    // Create a solution vector.
                    SparseArray<int, double> xVector = new SparseArray<int, double>();

                    // Solve the simultaneous equations.
                    LinearEquationSolverStatus solverStatus =
                        LinearEquationSolver.Solve(numberOfEquations,
                                                   aMatrix,
                                                   bVector,
                                                   xVector);

                    if (solverStatus == LinearEquationSolverStatus.Success)
                    {
                        string solutionString = "";

                        foreach (KeyValuePair<string, int> pair in variableNameIndexMap)
                        {
                            solutionString += string.Format("{0} = {1}", pair.Key, xVector[pair.Value]);
                            solutionString += "\n";
                        }

                        equationsRichTextBox.Text += "\n" + solutionString;
                    }
                    else if (solverStatus == LinearEquationSolverStatus.IllConditioned)
                    {
                        mainStatusBarText = Properties.Resources.IDS_ILL_CONDITIONED_SYSTEM_OF_EQUATIONS;
                    }
                    else if (solverStatus == LinearEquationSolverStatus.Singular)
                    {
                        mainStatusBarText = Properties.Resources.IDS_SINGULAR_SYSTEM_OF_EQUATIONS;
                    }
                }
                else if (numberOfEquations < variableNameIndexMap.Count)
                {
                    mainStatusBarText = string.Format(Properties.Resources.IDS_TOO_FEW_EQUATIONS,
                                                      numberOfEquations, variableNameIndexMap.Count);
                }
                else if (numberOfEquations > variableNameIndexMap.Count)
                {
                    mainStatusBarText = string.Format(Properties.Resources.IDS_TOO_MANY_EQUATIONS,
                                                      numberOfEquations, variableNameIndexMap.Count);
                }
            }
            else
            {
                // An error occurred. Report the error in the status bar.
                mainStatusBarText = LinearEquationParserStatusInterpreter.GetStatusString(parserStatus);
            }

            mainToolStripStatusLabel.Text = mainStatusBarText;
        }

        private void mainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
