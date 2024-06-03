using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Maker
{
    public partial class Form2 : Form
    {
        private SuperHeroList superHeroList;
        public Form2(SuperHeroList heroList)
        {
            InitializeComponent();
            superHeroList = heroList;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Load the list of superheroes into the listBox_Heroes control
            foreach (SuperHero hero in SuperHeroList.listOfHeroes)
            {
                listBox_Heroes.Items.Add(hero.Name);
            }
        }

        private void listBox_Heroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the user clicks on a line in the listBox_Heroes control,
            // display a summary of all the superhero's properties in the textBox_Dossier control.
            if (listBox_Heroes.SelectedIndex >= 0)
            {
                SuperHero selectedHero = (SuperHero)SuperHeroList.listOfHeroes[listBox_Heroes.SelectedIndex];
                string dossierText = $"Name: {selectedHero.Name}\r\n" +
                                     $"Special Abilities: {string.Join(", ", selectedHero.SpecialAbilities)}\r\n" +
                                     $"Birthday: {selectedHero.Birthday.ToShortDateString()}\r\n" +
                                     $"Super Power Discovery: {selectedHero.SuperPowerDiscovery.ToShortDateString()}\r\n" +
                                     $"Fateful Day: {selectedHero.FatefulDay.ToShortDateString()}\r\n" +
                                     $"Office Locations: {string.Join(", ", selectedHero.OfficeLocations)}\r\n" +
                                     $"Preferred Transportation: {selectedHero.PreferredTransportation}\r\n" +
                                     $"Years of Experience: {selectedHero.YearsOfExperience}\r\n" +
                                     $"Cape Color: {selectedHero.CapeColor}\r\n" +
                                     $"Dark Side Propensity: {selectedHero.DarkSidePropensity}\r\n" +
                                     $"Speed: {selectedHero.Speed}\r\n" +
                                     $"Stamina: {selectedHero.Stamina}\r\n" +
                                     $"Strength: {selectedHero.Strength}";
                textBox_Dossier.Text = dossierText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Hero_Maker.Form1();
            this.Hide();
            f1.Show();
        }
    }
}
