using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CramOMatic
{
    public partial class FormMain : Form
    {
        private List<PokemonType> pokemonTypes;
        private List<OutputItem> outputItems;
        private List<InputItem> inputItems;
        private BindingList<Recipe> specialRecipes;
        private BindingList<ApricornBallRate> apricornBallRates;
        private BindingList<Recipe> calculatedRecipes;
        private List<ApricornData> apricornChoices;
        private List<InputItem> descInputs;
        private Random randomSeed;

        public FormMain()
        {
            InitializeComponent();
            GenerateTypes();
            GenerateOutputs();
            GenerateInputs();
            GenerateSpecialRecipes();
            GenerateApricornResults();

            randomSeed = new Random();

            ChangeIcon();

            calculatedRecipes = new BindingList<Recipe>();

            apricornBallRates = new BindingList<ApricornBallRate>();

            descInputs = new List<InputItem>(inputItems);
            descInputs.Sort(InputItem.CompareValueDesc);

            List<OutputItem> sortedOutputs = new List<OutputItem>(outputItems);
            sortedOutputs.Sort(OutputItem.CompareName);

            List<InputItem> sortedInputs = new List<InputItem>(inputItems);
            sortedInputs.Sort(InputItem.CompareName);

            comboOutput.DataSource = new List<OutputItem>(sortedOutputs);
            comboInput1.DataSource = new List<InputItem>(sortedInputs);
            comboInput2.DataSource = new List<InputItem>(sortedInputs);
            comboInput3.DataSource = new List<InputItem>(sortedInputs);
            comboInput4.DataSource = new List<InputItem>(sortedInputs);
            comboOutput.SelectedIndex = randomSeed.Next(pokemonTypes.Count);
            comboInput1.SelectedIndex = randomSeed.Next(sortedInputs.Count);
            comboInput2.SelectedIndex = randomSeed.Next(sortedInputs.Count);
            comboInput3.SelectedIndex = randomSeed.Next(sortedInputs.Count);
            comboInput4.SelectedIndex = randomSeed.Next(sortedInputs.Count);

            comboApricorn1.DataSource = new List<ApricornData>(apricornChoices);
            comboApricorn2.DataSource = new List<ApricornData>(apricornChoices);
            comboApricorn3.DataSource = new List<ApricornData>(apricornChoices);
            comboApricorn4.DataSource = new List<ApricornData>(apricornChoices);
            comboApricorn1.SelectedIndex = randomSeed.Next(apricornChoices.Count);
            comboApricorn2.SelectedIndex = randomSeed.Next(apricornChoices.Count);
            comboApricorn3.SelectedIndex = randomSeed.Next(apricornChoices.Count);
            comboApricorn4.SelectedIndex = randomSeed.Next(apricornChoices.Count);

            dataRecipes.DataSource = calculatedRecipes;
            dataRecipes.Columns["Output"].DefaultCellStyle.BackColor = Color.LightGreen;

            dataInputData.DataSource = inputItems;
            dataInputData.Columns["Name"].Width = 125;
            dataInputData.Columns["Value"].Width = 50;
            dataInputData.Columns["PokemonType"].Width = 80;

            dataSpecialRecipes.DataSource = specialRecipes;
            dataSpecialRecipes.Columns["Output"].DefaultCellStyle.BackColor = Color.LightGreen;

            dataApricornRecipes.DataSource = apricornBallRates;
            dataApricornRecipes.Columns["Rate"].Width = 50;
            dataApricornRecipes.Columns["Rate"].DefaultCellStyle.Format = "#0.00 %";
            dataApricornRecipes.Columns["Rate"].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void ChangeIcon()
        {
            int iconId = randomSeed.Next(3);
            switch (iconId)
            {
                case 0: Icon = Properties.Resources.cramorant_0; break;
                case 1: Icon = Properties.Resources.cramorant_1; break;
                case 2: Icon = Properties.Resources.cramorant_2; break;
            }
        }

        private void GenerateTypes()
        {
            pokemonTypes = new List<PokemonType>();
            pokemonTypes.Add(new PokemonType("Bug", Color.FromArgb(0x90, 0xC1, 0x2C), PokemonTypeEnum.Bug));
            pokemonTypes.Add(new PokemonType("Dark", Color.FromArgb(0x5A, 0x53, 0x66), PokemonTypeEnum.Dark));
            pokemonTypes.Add(new PokemonType("Dragon", Color.FromArgb(0x0A, 0x6D, 0xC4), PokemonTypeEnum.Dragon));
            pokemonTypes.Add(new PokemonType("Electric", Color.FromArgb(0xF3, 0xD2, 0x3B), PokemonTypeEnum.Electric));
            pokemonTypes.Add(new PokemonType("Fairy", Color.FromArgb(0xEC, 0x8F, 0xE6), PokemonTypeEnum.Fairy));
            pokemonTypes.Add(new PokemonType("Fighting", Color.FromArgb(0xCE, 0x40, 0x69), PokemonTypeEnum.Fighting));
            pokemonTypes.Add(new PokemonType("Fire", Color.FromArgb(0xFF, 0x9C, 0x54), PokemonTypeEnum.Fire));
            pokemonTypes.Add(new PokemonType("Flying", Color.FromArgb(0x8F, 0xA8, 0xDD), PokemonTypeEnum.Flying));
            pokemonTypes.Add(new PokemonType("Ghost", Color.FromArgb(0x52, 0x69, 0xAC), PokemonTypeEnum.Ghost));
            pokemonTypes.Add(new PokemonType("Grass", Color.FromArgb(0x63, 0xBB, 0x5B), PokemonTypeEnum.Grass));
            pokemonTypes.Add(new PokemonType("Ground", Color.FromArgb(0xD9, 0x77, 0x46), PokemonTypeEnum.Ground));
            pokemonTypes.Add(new PokemonType("Ice", Color.FromArgb(0x74, 0xCE, 0xC0), PokemonTypeEnum.Ice));
            pokemonTypes.Add(new PokemonType("Normal", Color.FromArgb(0x90, 0x99, 0xA1), PokemonTypeEnum.Normal));
            pokemonTypes.Add(new PokemonType("Poison", Color.FromArgb(0xAB, 0x6A, 0xC8), PokemonTypeEnum.Poison));
            pokemonTypes.Add(new PokemonType("Psychic", Color.FromArgb(0xF9, 0x71, 0x76), PokemonTypeEnum.Psychic));
            pokemonTypes.Add(new PokemonType("Rock", Color.FromArgb(0xC7, 0xB7, 0x8B), PokemonTypeEnum.Rock));
            pokemonTypes.Add(new PokemonType("Steel", Color.FromArgb(0x5A, 0x8E, 0xA1), PokemonTypeEnum.Steel));
            pokemonTypes.Add(new PokemonType("Water", Color.FromArgb(0x4D, 0x90, 0xD5), PokemonTypeEnum.Water));
        }

        private void GenerateOutputs()
        {
            outputItems = new List<OutputItem>();
            int index;

            index = (int)PokemonTypeEnum.Bug;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR60 X-Scissor"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR18 Leech Life"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Bright Powder"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Silver Powder"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR61 Bug Buzz"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Shed Shell"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR96 Pollen Puff"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR28 Megahorn"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Bug)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Bug)"));

            index = (int)PokemonTypeEnum.Dark;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR37 Taunt"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Wide Lens"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "TR68 Nasty Plot"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Dark)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Star Piece (Dark)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Dark)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR81 Foul Play"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Scope Lens"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR95 Throat Chop"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR58 Dark Pulse"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR32 Crunch"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR93 Darkest Lariat"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Dark)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Dark)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Dark)"));
            
            index = (int)PokemonTypeEnum.Dragon;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR47 Dragon Claw"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Dragon Fang"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Big Mushroom (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Star Piece (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Dragon Scale"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Life Orb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR62 Dragon Pulse"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "King's Rock"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR51 Dragon Dance"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR24 Outrage"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Dragon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Dragon)"));

            index = (int)PokemonTypeEnum.Electric;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Electric Seed"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR80 Electro Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Cell Battery"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Electric)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Magnet"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR86 Wild Charge"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Upgrade"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Light Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Electric)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "Dubious Disc"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR08 Thunderbolt"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR09 Thunder"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Electric)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Electric)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Electric)"));

            index = (int)PokemonTypeEnum.Fairy;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Stardust (Fairy)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Misty Seed"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Big Mushroom (Fairy)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Fairy)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Satchet"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Room Service"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Whipped Dream"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Destiny Knot"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Common Sweet (Strawberry/Love/Berry/Clover/Flower)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR92 Dazzling Gleam"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Rare Sweet (Strawberry/Star/Ribbon)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR90 Play Rough"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Fairy)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Fairy)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Fairy)"));

            index = (int)PokemonTypeEnum.Fighting;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR07 Low Kick"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR56 Aura Sphere"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Muscle Band"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Fighting)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR48 Bulk Up"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR21 Reversal"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Macho Brace"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "TR99 Body Press"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Expert Belt"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR64 Focus Blast"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR39 Superpower"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR53 Close Combat"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Fighting)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Fighting)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Fighting)"));

            index = (int)PokemonTypeEnum.Fire;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR88 Heat Crash"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Flame Orb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "TR41 Blaze Kick"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Fire)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR02 Flamethrower"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Fire)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR36 Heat Wave"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Red Card"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR15 Fire Blast"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "Charcoal"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR55 Flare Blitz"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR43 Overheat"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Fire)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Fire)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Fire)"));

            index = (int)PokemonTypeEnum.Flying;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Pretty Feather"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Sharp Beak"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Big Mushroom (Flying)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Flying)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Air Balloon (Flying 51-60)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Blunder Policy"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Grip Claw"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Air Balloon (Flying 81-90)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Weakness Policy"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR89 Hurricane"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Flying)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR66 Brave Bird"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Flying)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Flying)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Flying)"));

            index = (int)PokemonTypeEnum.Ghost;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Odd Incense"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Adrenaline Orb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Ring Target"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Star Piece (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Cleanse Tag"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Spell Tag"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Cracked Pot"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "Reaper Cloth"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR33 Shadow Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Ghost)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Ghost)"));

            index = (int)PokemonTypeEnum.Grass;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Grassy Seed"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR59 Seed Bomb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "White Herb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Grass)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR77 Grass Knot"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR50 Leaf Blade"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR65 Energy Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Absorb Bulb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Grass)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR72 Power Whip"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Grass)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR71 Leaf Storm"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Grass)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Grass)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Grass)"));

            index = (int)PokemonTypeEnum.Ground;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Stardust (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR23 Spikes"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Big Mushroom (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Light Clay"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR87 Drill Run"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR67 Earth Power"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Terrain Extender"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR94 High Horsepower"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR10 Earthquake"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Ground)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Ground)"));

            index = (int)PokemonTypeEnum.Ice;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Snowball (Ice 1-20)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Icy Rock"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Never-Melt Ice"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Star Piece (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Balm Mushroom (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Razor Claw"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Snowball (Ice 81-90)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR05 Ice Beam"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "Comet Shard (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR06 Blizzard"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Ice)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Ice)"));

            index = (int)PokemonTypeEnum.Normal;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR85 Work Up"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR14 Metronome"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "TR26 Endure"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "TR13 Focus Energy"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR27 Sleep Talk"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR35 Uproar"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR01 Body Slam"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "TR19 Tri Attack"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR29 Baton Pass"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR30 Encore"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR20 Substitute"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR00 Swords Dance"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "TR42 Hyper Voice"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Normal)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Normal)"));

            index = (int)PokemonTypeEnum.Poison;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Black Sludge"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Toxic Orb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "TR91 Venom Drench"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Poison)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR54 Toxic Spikes"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Smoke Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR57 Poison Jab"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Quick Powder"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Poison Barb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR22 Sludge Bomb"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR78 Sludge Wave"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR73 Gunk Shot"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Poison)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Poison)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Poison)"));

            index = (int)PokemonTypeEnum.Psychic;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR12 Agility"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR34 Future Sight"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "TR40 Skill Swap"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "TR82 Stored Power"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR44 Cosmic Power"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR83 Ally Switch"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR25 Psyshock"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "TR69 Zen Headbutt"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR17 Amnesia"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR38 Trick"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR49 Calm Mind"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR97 Psychic Fangs"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "TR11 Psychic"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Psychic)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Psychic)"));

            index = (int)PokemonTypeEnum.Rock;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Float Stone"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "Oval Stone"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Hard Stone"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Rock 41-50)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Everstone"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Protector"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Rocky Helmet"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "TR63 Power Gem"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Wishing Piece (Rock 91-100)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "Eviolite"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR76 Stealth Rock"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR75 Stone Edge"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Rock)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Rock)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Rock)"));

            index = (int)PokemonTypeEnum.Steel;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "TR31 Iron Tail"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR46 Iron Defense"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Metal Powder"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Steel)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "Utility Umbrella"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "Metal Coat"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "TR52 Gyro Ball"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Assault Vest"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "TR79 Heavy Slam"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "Amulet Coin"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR70 Flash Cannon"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR74 Iron Head"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Steel)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Steel)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Steel)"));

            index = (int)PokemonTypeEnum.Water;
            outputItems.Add(new OutputItem(pokemonTypes[index], 1, 20, "Sea Incense"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 21, 30, "TR04 Surf"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 31, 40, "Shell Bell"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 41, 50, "Wishing Piece (Water)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 51, 60, "TR16 Waterfall"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 61, 70, "TR98 Liquidation"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 71, 80, "Prism Scale"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 81, 90, "Mystic Water"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 91, 100, "Pearl String (Water)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 101, 110, "TR45 Muddy Water"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 111, 120, "TR84 Scald"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 121, 130, "TR03 Hydro Pump"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 131, 140, "Rare Candy (Water)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 141, 150, "Bottle Cap (Water)"));
            outputItems.Add(new OutputItem(pokemonTypes[index], 151, 160, "PP Up (Water)"));
        }

        private void GenerateInputs()
        {
            inputItems = new List<InputItem>();
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 40, "Ability Capsule"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 8, "Absorb Bulb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Adamant Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 12, "Adrenaline Orb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 4, "Aguav Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 20, "Air Balloon"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 32, "Amulet Coin"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 12, "Apicot Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 28, "Armorite Ore"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 2, "Aspear Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 20, "Assault Vest"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 4, "Babiri Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 24, "Balm Mushroom"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Berry Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 14, "Big Mushroom"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 38, "Big Nugget"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 12, "Big Pearl"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 8, "Big Root"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 8, "Binding Band"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 0, "Black Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 14, "Black Belt"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 14, "Black Glasses"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 10, "Black Sludge"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 0, "Blue Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 24, "Blunder Policy"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Bold Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 40, "Bottle Cap"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Brave Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 14, "Bright Powder"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 40, "Bug Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Calcium"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Calm Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Carbos"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Careful Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 14, "Cell Battery"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 32, "Charcoal"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 4, "Charti Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 2, "Cheri Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 2, "Chesto Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 4, "Chilan Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Choice Band"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 20, "Choice Scarf"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 20, "Choice Specs"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Chople Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 24, "Cleanse Tag"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Clever Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Clover Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 4, "Coba Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 4, "Colbur Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 34, "Comet Shard"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 30, "Cracked Pot"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 12, "Damp Rock"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 40, "Dark Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 6, "Dawn Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 28, "Destiny Knot"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 18, "Dragon Fang"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 40, "Dragon Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 18, "Dragon Scale"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 32, "Dubious Disc"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 6, "Dusk Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 6, "Dynamax Candy"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 16, "Eject Button"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 16, "Eject Pack"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 40, "Electric Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 8, "Electric Seed"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 20, "Everstone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 32, "Eviolite"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 8, "Exp. Candy L"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 6, "Exp. Candy M"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 4, "Exp. Candy S"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 10, "Exp. Candy XL"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 2, "Exp. Candy XS"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 32, "Expert Belt"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 40, "Fairy Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 40, "Fighting Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 4, "Figy Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 40, "Fire Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 6, "Fire Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 14, "Flame Orb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 8, "Float Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Flower Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 40, "Flying Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 12, "Focus Band"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 12, "Focus Sash"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 10, "Fossilized Bird"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 10, "Fossilized Dino"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 10, "Fossilized Drake"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 10, "Fossilized Fish"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 2, "Full Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 18, "Galarica Cuff"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 4, "Galarica Twig"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 12, "Ganlon Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Genius Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Gentle Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 40, "Ghost Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 40, "Gold Bottle Cap"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 40, "Grass Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 8, "Grassy Seed"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 0, "Green Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Grepa Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 26, "Grip Claw"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 40, "Ground Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 4, "Haban Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 14, "Hard Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Hasty Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Health Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 12, "Heat Rock"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 16, "Heavy-Duty Boots"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 6, "Hondew Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 2, "Honey"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "HP Up"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 4, "Iapapa Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 40, "Ice Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 6, "Ice Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 12, "Icy Rock"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Impish Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Iron"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 16, "Iron Ball"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Jolly Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 4, "Kasib Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 4, "Kebia Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 6, "Kee Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 6, "Kelpsy Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 32, "King's Rock"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 10, "Lagging Tail"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 2, "Lax Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Lax Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 6, "Leaf Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 18, "Leek"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 20, "Leftovers"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 2, "Leppa Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 12, "Liechi Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dragon], 20, "Life Orb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 20, "Light Ball"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 20, "Light Clay"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Lonely Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Love Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 2, "Luck Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 20, "Lucky Egg"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 2, "Lum Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 8, "Luminous Moss"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 26, "Macho Brace"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 20, "Magnet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 4, "Mago Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 6, "Maranga Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 2, "Max Repel"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 14, "Mental Herb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 24, "Metal Coat"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 14, "Metal Powder"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 22, "Metronome"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Mild Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 14, "Miracle Seed"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 8, "Misty Seed"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Modest Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 6, "Moon Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 14, "Muscle Band"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Muscle Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 10, "Mystic Water"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Naive Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Naughty Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 14, "Never-Melt Ice"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 8, "Normal Gem"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 16, "Nugget"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 4, "Occa Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 2, "Odd Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 2, "Oran Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 12, "Oval Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 4, "Passho Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 4, "Payapa Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 6, "Pearl"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 30, "Pearl String"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 2, "Pecha Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 2, "Persim Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 12, "Petaya Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 0, "Pink Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 32, "Poison Barb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 40, "Poison Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 6, "Pomeg Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Power Anklet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Power Band"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Power Belt"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Power Bracer"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 10, "Power Herb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 20, "Power Lens"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 20, "Power Weight"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 40, "PP Max"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 38, "PP Up"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Pretty Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 26, "Prism Scale"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 12, "Protective Pads"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 24, "Protector"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Protein"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 40, "Psychic Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 8, "Psychic Seed"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 2, "Pure Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 6, "Qualot Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 26, "Quick Claw"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 28, "Quick Powder"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Quiet Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 12, "Rare Bone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 40, "Rare Candy"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Rash Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 2, "Rawst Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 26, "Razor Claw"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 32, "Reaper Cloth"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 0, "Red Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 16, "Red Card"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Relaxed Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 2, "Repel"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Resist Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Ribbon Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 4, "Rindo Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 14, "Ring Target"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 2, "Rock Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 40, "Rock Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 26, "Rocky Helmet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 24, "Room Service"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 2, "Rose Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 4, "Roseli Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 20, "Sachet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 10, "Safety Goggles"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 12, "Salac Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Sassy Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 12, "Scope Lens"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 2, "Sea Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Serious Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 10, "Sharp Beak"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 10, "Shed Shell"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 14, "Shell Bell"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 6, "Shiny Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 4, "Shuca Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 22, "Silk Scarf"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 10, "Silver Powder"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 2, "Sitrus Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 22, "Smoke Ball"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 12, "Smooth Rock"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 8, "Snowball"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 20, "Soft Sand"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 14, "Soothe Bell"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ghost], 26, "Spell Tag"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 20, "Star Piece"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Star Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 8, "Stardust"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Steel], 40, "Steel Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 10, "Sticky Barb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 30, "Strawberry Sweet"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fire], 6, "Sun Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 2, "Super Repel"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 30, "Sweet Apple"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 6, "Swift Feather"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 6, "Tamato Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Bug], 4, "Tanga Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 30, "Tart Apple"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 12, "Terrain Extender"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ground], 18, "Thick Club"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 12, "Throat Spray"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 6, "Thunder Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 16, "Timid Mint"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 2, "Tiny Mushroom"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 14, "Toxic Orb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 18, "Twisted Spoon"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 30, "Upgrade"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Flying], 20, "Utility Umbrella"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 4, "Wacan Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 40, "Water Memory"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 6, "Water Stone"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Water], 2, "Wave Incense"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 30, "Weakness Policy"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fairy], 26, "Whipped Dream"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Normal], 0, "White Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Grass], 14, "White Herb"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 22, "Wide Lens"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Rock], 4, "Wiki Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Psychic], 10, "Wise Glasses"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Poison], 28, "Wishing Piece"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Ice], 4, "Yache Berry"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Electric], 0, "Yellow Apricorn"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Fighting], 4, "Zinc"));
            inputItems.Add(new InputItem(pokemonTypes[(int)PokemonTypeEnum.Dark], 22, "Zoom Lens"));
        }

        private void GenerateSpecialRecipes()
        {
            specialRecipes = new BindingList<Recipe>();

            InputItem anyItem = new InputItem(null, -1, "Any Item");
            InputItem rareCandyItem = new InputItem(null, -1, "Rare Candy");
            InputItem armoriteOreItem = new InputItem(null, -1, "Armorite Ore");
            InputItem bottleCapItem = new InputItem(null, -1, "Bottle Cap");
            InputItem nuggetItem = new InputItem(null, -1, "Nugget");
            InputItem tinyMushroomItem = new InputItem(null, -1, "Tiny Mushroom");
            InputItem bigMushroomItem = new InputItem(null, -1, "Big Mushroom");
            InputItem stardustItem = new InputItem(null, -1, "Stardust");
            InputItem starPieceItem = new InputItem(null, -1, "Star Piece");
            InputItem pearlItem = new InputItem(null, -1, "Pearl");
            InputItem bigPearlItem = new InputItem(null, -1, "Big Pearl");

            OutputItem abilityCapsuleOutput = new OutputItem(null, -1, -1, "Ability Capsule");
            OutputItem ppUpOutput = new OutputItem(null, -1, -1, "PP Up");
            OutputItem goldBottleCapOutput = new OutputItem(null, -1, -1, "Gold Bottle Cap");
            OutputItem bigNuggetOutput = new OutputItem(null, -1, -1, "Big Nugget");
            OutputItem bigMushroomOutput = new OutputItem(null, -1, -1, "Big Mushroom");
            OutputItem balmMushroomOutput = new OutputItem(null, -1, -1, "Balm Mushroom");
            OutputItem starPieceOutput = new OutputItem(null, -1, -1, "Star Piece");
            OutputItem cometShardOutput = new OutputItem(null, -1, -1, "Comet Shard");
            OutputItem bigPearlOutput = new OutputItem(null, -1, -1, "Big Pearl");
            OutputItem pearlStringOutput = new OutputItem(null, -1, -1, "Pearl String");

            specialRecipes.Add(new Recipe(rareCandyItem, anyItem, rareCandyItem, rareCandyItem, abilityCapsuleOutput));
            specialRecipes.Add(new Recipe(armoriteOreItem, anyItem, armoriteOreItem, armoriteOreItem, ppUpOutput));
            specialRecipes.Add(new Recipe(bottleCapItem, anyItem, bottleCapItem, bottleCapItem, goldBottleCapOutput));
            specialRecipes.Add(new Recipe(nuggetItem, anyItem, nuggetItem, nuggetItem, bigNuggetOutput));
            specialRecipes.Add(new Recipe(tinyMushroomItem, anyItem, tinyMushroomItem, tinyMushroomItem, bigMushroomOutput));
            specialRecipes.Add(new Recipe(bigMushroomItem, anyItem, bigMushroomItem, bigMushroomItem, balmMushroomOutput));
            specialRecipes.Add(new Recipe(stardustItem, anyItem, stardustItem, stardustItem, starPieceOutput));
            specialRecipes.Add(new Recipe(starPieceItem, anyItem, starPieceItem, starPieceItem, cometShardOutput));
            specialRecipes.Add(new Recipe(pearlItem, anyItem, pearlItem, pearlItem, bigPearlOutput));
            specialRecipes.Add(new Recipe(bigPearlItem, anyItem, bigPearlItem, bigPearlItem, pearlStringOutput));
        }

        private void GenerateApricornResults()
        {
            apricornChoices = new List<ApricornData>();
            apricornChoices.Add(new ApricornData("Black Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Dusk Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Luxury Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Heavy Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("Blue Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Dive Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Net Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Lure Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("Green Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Ultra Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Nest Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Friend Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("Pink Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Ultra Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Heal Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Love Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("Red Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Ultra Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Repeat Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Level Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("White Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Premier Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Timer Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Fast Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));

            apricornChoices.Add(new ApricornData("Yellow Apricorn"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Pokéball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Great Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Ultra Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.247, "Quick Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.010, "Moon Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Safari Ball"));
            apricornChoices[apricornChoices.Count - 1].AddBall(new ApricornBallRate(0.001, "Sport Ball"));
        }

        private int CalculateFirstRecipe(OutputItem output)
        {
            calculatedRecipes.Clear();
            if (output != null)
            {
                int currentTotal = 0;

                //First Item
                InputItem item1 = null;
                foreach (InputItem it in descInputs)
                {
                    if (it.PokemonType != null)
                    {
                        if (it.PokemonType.Id == output.PokemonType.Id && it.Value <= output.Max && it.Value != -1)
                        {
                            item1 = it;
                            currentTotal += it.Value;
                            break;
                        }
                    }
                }

                //Second Item
                InputItem item2 = null;
                foreach (InputItem it in descInputs)
                {
                    if (it.Value + currentTotal <= output.Max && it.Value != -1)
                    {
                        item2 = it;
                        currentTotal += it.Value;
                        break;
                    }
                }

                //Third Item
                InputItem item3 = null;
                foreach (InputItem it in descInputs)
                {
                    if (it.Value + currentTotal <= output.Max && it.Value != -1)
                    {
                        item3 = it;
                        currentTotal += it.Value;
                        break;
                    }
                }

                //Fourth Item
                InputItem item4 = null;
                foreach (InputItem it in descInputs)
                {
                    if (it.Value + currentTotal <= output.Max && it.Value != -1)
                    {
                        item4 = it;
                        currentTotal += it.Value;
                        break;
                    }
                }

                //Matching Recipe
                if (currentTotal >= output.Min && currentTotal <= output.Max)
                {
                    if (item1 != null && item2 != null && item3 != null && item4 != null) calculatedRecipes.Add(new Recipe(item1, item2, item3, item4, output));
                    /*dataRecipes.Update();
                    dataRecipes.Refresh();*/
                }
            }

            return 1;
        }

        private Recipe CalculateRandomRecipe(OutputItem output)
        {
            if (output != null)
            {
                //First Item
                int id1 = randomSeed.Next(descInputs.Count);
                for (int i=id1; i<id1+descInputs.Count; i++)
                {
                    InputItem it1 = descInputs[i % descInputs.Count];
                    if (it1.PokemonType != null)
                    {
                        if (it1.PokemonType.Id == output.PokemonType.Id && it1.Value <= output.Max && it1.Value != -1)
                        {
                            //Second Item
                            int id2 = randomSeed.Next(descInputs.Count);
                            for (int j=id2; j<id2+descInputs.Count; j++)
                            {
                                InputItem it2 = descInputs[j % descInputs.Count];
                                if (it2.Value + it1.Value <= output.Max && it2.Value != -1)
                                {
                                    //Third Item
                                    int id3 = randomSeed.Next(descInputs.Count);
                                    for (int k=id3; k<id3 +descInputs.Count; k++)
                                    {
                                        InputItem it3 = descInputs[k % descInputs.Count];
                                        if (it3.Value + it2.Value + it1.Value <= output.Max && it3.Value != -1)
                                        {
                                            //Fourth Item
                                            int id4 = randomSeed.Next(descInputs.Count);
                                            for (int l=id4; l<id4+descInputs.Count; l++)
                                            {
                                                InputItem it4 = descInputs[l % descInputs.Count];
                                                //Matching Recipe
                                                if (it4.Value != -1 && it4.Value + it3.Value + it2.Value + it1.Value >= output.Min && it4.Value + it3.Value + it2.Value + it1.Value <= output.Max)
                                                {
                                                    return new Recipe(it1, it2, it3, it4, output);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        private int CalculateAllRecipes(OutputItem output)
        {
            calculatedRecipes.Clear();

            int totalRecipes = 0;

            if (output != null)
            {
                //First Item
                foreach (InputItem it1 in descInputs)
                {
                    if (it1.PokemonType != null)
                    {
                        if (it1.PokemonType.Id == output.PokemonType.Id && it1.Value <= output.Max && it1.Value != -1)
                        {
                            //Second Item
                            foreach (InputItem it2 in descInputs)
                            {
                                if (it2.Value + it1.Value <= output.Max && it2.Value != -1)
                                {
                                    //Third Item
                                    foreach (InputItem it3 in descInputs)
                                    {
                                        if (it3.Value + it2.Value + it1.Value <= output.Max && it3.Value != -1)
                                        {
                                            //Fourth Item
                                            foreach (InputItem it4 in descInputs)
                                            {
                                                //Matching Recipe
                                                if (it4.Value != -1 && it4.Value + it3.Value + it2.Value + it1.Value >= output.Min && it4.Value + it3.Value + it2.Value + it1.Value <= output.Max)
                                                {
                                                    if (totalRecipes < 1000)
                                                    {
                                                        calculatedRecipes.Add(new Recipe(it1, it2, it3, it4, output));
                                                    }
                                                    totalRecipes++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return totalRecipes;
        }

        private void comboOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputItem item = null;
            if (comboOutput.SelectedIndex != -1)
            {
                item = (OutputItem)comboOutput.SelectedItem;
                if (item.PokemonType != null)
                {
                    lbInfo.Text = item.PokemonType.Name + " " + item.Min + "-" + item.Max;
                    lbInfo.ForeColor = item.PokemonType.DisplayColor;
                }
                else
                {
                    lbInfo.Text = "UNKNOWN ???-???";
                    lbInfo.ForeColor = Color.Black;
                }
            }

            DateTime startTime = DateTime.UtcNow;
            bool keepSearching = false;
            calculatedRecipes.Clear();
            for (int i=0; i<numRecipeAmount.Value; i++)
            {
                Recipe recipe = CalculateRandomRecipe(item);
                if (recipe != null) calculatedRecipes.Add(recipe);
                else
                {
                    MessageBox.Show("No recipe could be found for this item.\nThis usually occurs for items with high values like Bottle Cap and PP Up. Otherwise, please let me know.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

                //If it has been more than ten seconds and more recipes need to be generated and yes has not yet been pressed
                TimeSpan timeElapsed = DateTime.UtcNow.Subtract(startTime);
                if (timeElapsed.TotalSeconds > 10.0 && i+1 < numRecipeAmount.Value && !keepSearching)
                {
                    string msg = "More than 10 seconds have passed, and only " + (i + 1).ToString() + " recipes have been generated.\nThis usually occurs for items with high values like Bottle Cap and PP Up. Otherwise, please let me know.\nWould you like to keep going? This could take a while.";
                    if (MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        keepSearching = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            lbRecipes.Text = "Showing " + calculatedRecipes.Count + " possible recipes:";

            ChangeIcon();
        }

        private void comboInputAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboInput1.SelectedIndex != -1 && comboInput2.SelectedIndex != -1 && comboInput3.SelectedIndex != -1 && comboInput4.SelectedIndex != -1)
            {
                InputItem item1 = inputItems[comboInput1.SelectedIndex];
                InputItem item2 = inputItems[comboInput2.SelectedIndex];
                InputItem item3 = inputItems[comboInput3.SelectedIndex];
                InputItem item4 = inputItems[comboInput4.SelectedIndex];
                PokemonType type = item1.PokemonType;
                string typeName;
                int total = 0;
                bool totalAccuracy = item1.Value != -1 && item2.Value != -1 && item3.Value != -1 && item4.Value != -1;

                if (type != null)
                {
                    typeName = item1.PokemonType.Name;
                    lbResultInfo.ForeColor = item1.PokemonType.DisplayColor;
                }
                else
                {
                    typeName = "UNKNOWN";
                    lbResultInfo.ForeColor = Color.Black;
                }

                total += item1.Value != -1 ? item1.Value : 0;
                total += item2.Value != -1 ? item2.Value : 0;
                total += item3.Value != -1 ? item3.Value : 0;
                total += item4.Value != -1 ? item4.Value : 0;

                lbResultInfo.Text = typeName + " " + total;

                lbAccuracy.Visible = !totalAccuracy;

                if (type != null)
                {
                    if (total > 0)
                    {
                        if (total >= 1 && total <= 10) total += 10;
                        int outputIndex = ((int)type.Id * 15) + ((total - 11) / 10);
                        OutputItem output = null;
                        if (outputIndex >= 0 && outputIndex < outputItems.Count) output = outputItems[outputIndex];

                        if (output != null)
                        {
                            lbResultName.Text = output.Name;
                            lbResultName.ForeColor = output.PokemonType.DisplayColor;
                        }
                        else
                        {
                            lbResultName.Text = "UNKNOWN";
                            lbResultName.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        lbResultName.Text = "Some Pokéball";
                        lbResultName.ForeColor = Color.Black;
                    }
                }
                else
                {
                    lbResultName.Text = "UNKNOWN";
                    lbResultName.ForeColor = Color.Black;
                }

                ChangeIcon();
            }
        }

        private void CalculateRateForApricorn(ApricornData apricorn, List<ApricornBallRate> list)
        {
            foreach (ApricornBallRate newRate in apricorn.PossibleBalls)
            {
                ApricornBallRate foundRate = null;
                foreach (ApricornBallRate addedRate in list)
                {
                    if (newRate.Name == addedRate.Name)
                    {
                        foundRate = addedRate;
                        break;
                    }
                }
                if (foundRate != null)
                {
                    //Exists
                    foundRate.Rate += newRate.Rate * 0.25;
                }
                else
                {
                    //New
                    list.Add(newRate.CloneQuarter());
                }
            }
        }

        private void comboApricornAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboApricorn1.SelectedIndex != -1 && comboApricorn2.SelectedIndex != -1 && comboApricorn3.SelectedIndex != -1 && comboApricorn4.SelectedIndex != -1)
            {
                apricornBallRates.Clear();

                List<ApricornBallRate> tempList = new List<ApricornBallRate>();
                CalculateRateForApricorn(apricornChoices[comboApricorn1.SelectedIndex], tempList);
                CalculateRateForApricorn(apricornChoices[comboApricorn2.SelectedIndex], tempList);
                CalculateRateForApricorn(apricornChoices[comboApricorn3.SelectedIndex], tempList);
                CalculateRateForApricorn(apricornChoices[comboApricorn4.SelectedIndex], tempList);

                tempList.Sort(ApricornBallRate.CompareRateDesc);
                apricornBallRates = new BindingList<ApricornBallRate>(tempList);
                dataApricornRecipes.DataSource = apricornBallRates;
            }
        }

        private void dataInputData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i=e.RowIndex; i<e.RowIndex+e.RowCount; i++)
            {
                dataInputData.Rows[i].Cells["PokemonType"].Style.ForeColor = inputItems[i].PokemonType.DisplayColor;
            }
        }
    }
}
