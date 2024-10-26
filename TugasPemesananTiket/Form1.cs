using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPemesananTiket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var errorList = new List<string>();
            if (textBoxName.Text == "") 
            {
                errorList.Add("Nama harus diisi!");
            } 
            if (comboBoxFilm.Text == "") 
            {
                errorList.Add("Film harus dipilih!");
            }
            var seatValidation = flowLayoutPanelSeat.Controls
                .OfType<RadioButton>()
                .Any(r=>r.Checked); 
            if (!seatValidation) 
            {
                errorList.Add("Seat harus dipilih!");
            }
            if (errorList.Count > 0) 
            {
                MessageBox.Show(string.Join("\n", errorList));
                return;
            }

            ISeat seat;
            var seatRadioButton =
                flowLayoutPanelSeat.Controls.OfType<RadioButton>().Where(r => r.Checked).Single();
            switch (seatRadioButton.Name)
            {
                case "radioButtonRegular":
                    seat = new RegularSeat();
                    break;
                case "radioButtonVip":
                    seat = new VipSeat();
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }

            
            var filmType = (FilmType)comboBoxFilm.SelectedIndex;

            var ticket = new Ticket(textBoxName.Text, seat, filmType);
            var isAnyAdditionalService = flowLayoutPanelAdditionalServices.Controls.OfType<CheckBox>().Any(r => r.Checked);
            
            decimal totalPrice = 0;
            if (isAnyAdditionalService)
            {
                var additionalServices = new List<AdditionalService>();
                foreach (var checkBox in flowLayoutPanelAdditionalServices.Controls.OfType<CheckBox>()
                             .Where(r => r.Checked))
                {
                    switch (checkBox.Name) 
                    {
                        case "checkBoxFood":
                            additionalServices.Add(AdditionalService.Food);
                            break;
                        case "checkBoxDrink":
                            additionalServices.Add(AdditionalService.Drink);
                            break;
                    }
                }
                totalPrice = ticket.CalculateTotalPrice(additionalServices.ToArray());
            } else {
                totalPrice = ticket.CalculateTotalPrice();
            }
            
            labelPrice.Text = totalPrice.ToString("C");
        }
    }
}