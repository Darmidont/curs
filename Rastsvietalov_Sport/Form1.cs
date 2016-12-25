using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastsvietalov_Sport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Sport_MainDataSet.Competitions' table. You can move, or remove it, as needed.
            this.competitionsTableAdapter.Fill(this.dB_Sport_MainDataSet.Competitions);
            // TODO: This line of code loads data into the 'dB_Sport_MainDataSet.TypesOfSport' table. You can move, or remove it, as needed.
            this.typesOfSportTableAdapter.Fill(this.dB_Sport_MainDataSet.TypesOfSport);
            // TODO: This line of code loads data into the 'dB_Sport_MainDataSet.Sportsmens' table. You can move, or remove it, as needed.
            this.sportsmensTableAdapter.Fill(this.dB_Sport_MainDataSet.Sportsmens);

        }

        private void AddSportsmenButton_Click(object sender, EventArgs e)
        {
            SportsmenEditForm form = new SportsmenEditForm();
            form.ShowDialog();
        }

        private void EditSportsmenButton_Click(object sender, EventArgs e)
        {
            SportsmenEditForm form = new SportsmenEditForm((int)SportsmensDGV.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            sportsmensViewTableAdapter.Fill(dB_Sport_MainDataSet.SportsmensView);
        }

        private void DeleteSportsmenButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               
            {
                sportsmensTableAdapter.DeleteQuery((int)SportsmensDGV.SelectedRows[0].Cells[0].Value);
                sportsmensViewTableAdapter.Fill(dB_Sport_MainDataSet.SportsmensView);
            }
        }

        private void ResetSportsmenFilterButton_Click(object sender, EventArgs e)
        {
            sportsmensBindingSource.Filter = String.Empty;
        }

        private void SportsmenSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SportsmenSearchTextBox.Text != "")
            {
                switch (SportsmenSearchCritereaCombo.Text)
                {
                    case "ФИО":
                        if (new Regex(@"\d").IsMatch(SportsmenSearchTextBox.Text))
                            sportsmensViewTableAdapter.FillByNameLike(dB_Sport_MainDataSet.SportsmensView,SportsmenSearchTextBox.Text);
                                
                        break;

                    case "Возраст":
                        
                        sportsmensViewTableAdapter.FillByNumLike(dB_Sport_MainDataSet.SportsmensView,SportsmenSearchTextBox.Text);          
                        break;

                    case "Вид спорта":
                       
                        break;

                    case "Название соревнования":

                       
                           
                        break;
                    case "Количество побед":

                      
                        break;
                    case "Национальность":



                        break;
                    case "Страна":

                        break;
                    case "Биография":

                        break;
                    //   case "":



                }
            }
            else sportsmensViewTableAdapter.Fill(dB_Sport_MainDataSet.SportsmensView);
        }

        private void SportsmenSearchCritereaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
