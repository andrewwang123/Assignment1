using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Pokemon
        {
            public string pokeName { get; set; }
            public int pokeLevel { get; set; }
            public int pokeID { get; set; }
        }

        class Information
        {
            public string pokeNature { get; set; }
            public char pokeGender { get; set; }
            public string pokeMoves { get; set; }
        }


        private void btnAddPokemon_Click(object sender, EventArgs e)
        {



            List<Pokemon> items = new List<Pokemon>()
            {
                new Pokemon() { pokeName = "Charizard", pokeLevel = 100 , pokeID = 6 },
                new Pokemon() { pokeName = "Eevee", pokeLevel = 25 , pokeID = 133},
                new Pokemon() { pokeName = "Pikachu", pokeLevel = 75, pokeID =  25},


        };



            var query = from s in items
                        where s.pokeName == "Charizard"
                        select s;






            foreach (Pokemon list in items)
            {
                txtResult.AppendText(list.pokeName + "is currently level " + list.pokeLevel);
            }
            
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            List<Pokemon> items = new List<Pokemon>()
            {
                new Pokemon() { pokeName = "Charizard", pokeLevel = 100 , pokeID = 6 },
                new Pokemon() { pokeName = "Eevee", pokeLevel = 25 , pokeID = 133},
                new Pokemon() { pokeName = "Pikachu", pokeLevel = 75, pokeID =  25},


        };

            List<Information> info = new List<Information>()
            {
                new Information() { pokeNature = "Bold", pokeGender= '♀' , pokeMoves = "FireBlast and Fly" },
                new Information() { pokeNature = "Rash", pokeGender = '♂' , pokeMoves = "Quick Attack" },
                new Information() { pokeNature = "Lonely", pokeGender = '♀', pokeMoves =  "Volt Tackle and Iron Tail" },
        };




            var query = info.Join(
                items,

                showMoves => showMoves.pokeMoves,
                showID => showID.pokeID,
                (showMoves, showID) => new
                {
                    ShowNature = showMoves.pokeNature,
                    showName = showID.pokeName,

                }).Where(s => s.FeatureName == "Clubs");

            foreach (var res in query)
            {
               txtResult.AppendText( "This Pokemon is named " + res.FeatureID + "and is " + res.pokeNature + "nature" + Environment.NewLine);
            }
        }
    }
}
