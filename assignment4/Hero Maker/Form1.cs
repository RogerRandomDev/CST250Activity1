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
    public partial class Form1 : Form
    {
        private SuperHeroList superHeroList;
        string colorName;
        public Form1()
        {
            InitializeComponent();
            superHeroList = new SuperHeroList();
        }

        private void button_CapeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                this.colorName = selectedColor.Name;
                button_CapeColor.BackColor = selectedColor;
            }
        }
        private void CheckTotalValue()
        {
            int totalValue = hScrollBar_Speed.Value + hScrollBar_Stamina.Value + hScrollBar_Strength.Value;
            if (totalValue > 100)
            {
                MessageBox.Show("Total value cannot exceed 100!");
                hScrollBar_Speed.Value = 0;
                hScrollBar_Stamina.Value = 0;
                hScrollBar_Strength.Value = 0;
                label_Speed.Text = "Speed: " + hScrollBar_Speed.Value.ToString();
                label_Stamina.Text = "Stamina: " + hScrollBar_Stamina.Value.ToString();
                label_Strength.Text = "Strength: " + hScrollBar_Strength.Value.ToString();
            }
        }

        private void hScrollBar_Speed_Scroll(object sender, ScrollEventArgs e)
        {
            CheckTotalValue();
            label_Speed.Text = "Speed: " + hScrollBar_Speed.Value.ToString();
        }

        private void hScrollBar_Stamina_Scroll(object sender, ScrollEventArgs e)
        {
            CheckTotalValue();
            label_Stamina.Text = "Stamina: " + hScrollBar_Stamina.Value.ToString();
        }

        private void hScrollBar_Strength_Scroll(object sender, ScrollEventArgs e)
        {
            CheckTotalValue();
            label_Strength.Text = "Strength: " + hScrollBar_Strength.Value.ToString();
        }

        private void trackBar_DarkSidePropensity_Scroll(object sender, EventArgs e)
        {
            label_DarkSidePropensity.Text = "Dark Side Propensity: " + trackBar_DarkSidePropensity.Value.ToString();
        }

        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return string.Empty;
        }

        private void button_CreateMe_Click(object sender, EventArgs e)
        {

            SuperHero hero = new SuperHero();

            // Get values from the form controls and assign them to the hero object
            hero.Name = textBox_HeroName.Text;

            hero.SpecialAbilities = new List<string>();
            foreach (CheckBox checkBox in groupBox_SpecialAbilities.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    hero.SpecialAbilities.Add(checkBox.Text);
                }
            }

            hero.Birthday = dateTimePicker_Birthday.Value;
            hero.SuperPowerDiscovery = dateTimePicker_SuperPowerDiscovery.Value;
            hero.FatefulDay = dateTimePicker_FatefulDay.Value;

            hero.OfficeLocations = new List<string>();
            foreach (var item in listBox_OfficeLocations.SelectedItems)
            {
                hero.OfficeLocations.Add(item.ToString());
            }

            hero.PreferredTransportation = GetSelectedRadioButtonText(groupBox_PreferredTransport);

            hero.YearsOfExperience = (int)numericUpDown_YearsExperience.Value;

            hero.CapeColor = this.colorName;
            hero.DarkSidePropensity = trackBar_DarkSidePropensity.Value;
            hero.Speed = hScrollBar_Speed.Value;
            hero.Stamina = hScrollBar_Stamina.Value;
            hero.Strength = hScrollBar_Strength.Value;

            // Add the hero object to the SuperHeroList
            SuperHeroList superHeroList = new SuperHeroList();
            SuperHeroList.listOfHeroes.Add(hero);

            // Show the second form
            Form2 f2 = new Hero_Maker.Form2(superHeroList);
            this.Hide();
            f2.Show();
        }
    }
}
