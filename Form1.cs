using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment12_PavelGolovan
{
    public partial class Form1 : Form
    {
        private List<ProductionWorker> productionWorkerList =
            new List<ProductionWorker>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile()
        {
            StreamReader inputFile;
            string line;

            char[] delim = { '-' };

            try
            {
                inputFile = File.OpenText("ProductionWorkers.txt");
            }
            catch
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("ProductionWorkers.txt");
                outputFile.Close();
                inputFile = File.OpenText("ProductionWorkers.txt");
            }

            while (!inputFile.EndOfStream)
            {
                try
                {
                    ProductionWorker productionWorker = new ProductionWorker();
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    productionWorker.Name = tokens[0];
                    productionWorker.Number = int.Parse(tokens[1]);
                    productionWorker.Shift = int.Parse(tokens[2]);
                    productionWorker.PayRate = double.Parse(tokens[3]);
                    productionWorkerList.Add(productionWorker);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            inputFile.Close();
        }

        private void DisplayNames()
        {
            productionWorkerListBox.Items.Clear();
            foreach (ProductionWorker productionWorker in productionWorkerList)
            {
                productionWorkerListBox.Items.Add(productionWorker.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nameTextBox.Text) &&
                !String.IsNullOrWhiteSpace(numberTextBox.Text) &&
                !String.IsNullOrWhiteSpace(shiftTextBox.Text) &&
                !String.IsNullOrWhiteSpace(payRateTextBox.Text))
            {
                ProductionWorker productionWorker = new ProductionWorker();
                productionWorker.Name = nameTextBox.Text;

                try
                {
                    productionWorker.Number = int.Parse(numberTextBox.Text);
                    productionWorker.Shift = int.Parse(shiftTextBox.Text);
                    productionWorker.PayRate = double.Parse(payRateTextBox.Text);

                    if (int.Parse(shiftTextBox.Text) == 1 ||
                    int.Parse(shiftTextBox.Text) == 2)
                    {
                        productionWorkerList.Add(productionWorker);

                        StreamWriter outputFile;
                        outputFile = File.AppendText("ProductionWorkers.txt");
                        outputFile.WriteLine(productionWorker.Name + "-" + productionWorker.Number.ToString() + "-" + productionWorker.Shift.ToString() + "-" + productionWorker.PayRate.ToString());
                        outputFile.Close();
                        DisplayNames();
                    }
                    else
                    {
                        MessageBox.Show("Shift number must be 1 or 2:\n\nDay shift - 1;\nNight shift - 2.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter full details.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            numberTextBox.Text = "";
            shiftTextBox.Text = "";
            payRateTextBox.Text = "";
            nameTextBox.Focus();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = productionWorkerListBox.SelectedIndex;
                MessageBox.Show(productionWorkerList[index].Show());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}