using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2018+
 */
namespace DragonWarriorMonsterStatEditor
{
    public partial class FormMain : Form
    {
        string path;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadDefaultComboBoxesData();
            enableDisableFormControls(false);
        }

        #region buttons
        private void buttonOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textBoxFilename.Text = path;

                loadRom();
            }
        }

        private void buttonUpdateMonsterStats_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);
            int offset = 0x0;
            int selectedMonsterIndex = comboBoxMonsters.SelectedIndex;
            string strength = comboBoxStrength.SelectedValue.ToString();
            string agility = comboBoxAgility.SelectedValue.ToString();
            string maxHP = comboBoxMaxHP.SelectedValue.ToString();
            string special1 = comboBoxSpecial1.SelectedValue.ToString();
            string special2 = comboBoxSpecial2.SelectedValue.ToString();
            
            string sleepResistance = comboBoxSleepResistance.SelectedValue.ToString();
            sleepResistance = sleepResistance.Substring(1, 1);

            string stopResistance = comboBoxStopResistance.SelectedValue.ToString();
            stopResistance = stopResistance.Substring(1, 1);

            string hurtResistance = comboBoxHurtResistance.SelectedValue.ToString();
            hurtResistance = hurtResistance.Substring(1, 1);

            string evasion = comboBoxEvasion.SelectedValue.ToString();
            evasion = evasion.Substring(1, 1);

            string experience = comboBoxExperience.SelectedValue.ToString();
            
            string maxGold = comboBoxMaxGold.SelectedValue.ToString();

            string monsterStatData = strength + agility + maxHP + special1 + special2 + sleepResistance + stopResistance + hurtResistance + evasion + experience + maxGold;

            switch (selectedMonsterIndex)
            {
                case 0:
                    offset = 0x5E5B; // Slime
                    break;
                case 1:
                    offset = 0x5E6B; // Red Slime
                    break;
                case 2:
                    offset = 0x5E7B; // Drakee
                    break;
                case 3:
                    offset = 0x5E8B; // Ghost
                    break;
                case 4:
                    offset = 0x5E9B; // Magician
                    break;
                case 5:
                    offset = 0x5EAB; // Magidrakee
                    break;
                case 6:
                    offset = 0x5EBB; // Scorpion
                    break;
                case 7:
                    offset = 0x5ECB; // Druin
                    break;
                case 8:
                    offset = 0x5EDB; // Poltergeist
                    break;
                case 9:
                    offset = 0x5EEB; // Droll
                    break;
                case 10:
                    offset = 0x5EFB; // Drakeema
                    break;
                case 11:
                    offset = 0x5F0B; // Skeleton
                    break;
                case 12:
                    offset = 0x5F1B; // Warlock
                    break;
                case 13:
                    offset = 0x5F2B; // Metal Scorpion
                    break;
                case 14:
                    offset = 0x5F3B; // Wolf
                    break;
                case 15:
                    offset = 0x5F4B; // Wraith
                    break;
                case 16:
                    offset = 0x5F5B; // Metal Slime
                    break;
                case 17:
                    offset = 0x5F6B; // Specter
                    break;
                case 18:
                    offset = 0x5F7B; // Wolflord
                    break;
                case 19:
                    offset = 0x5F8B; // Druinlord
                    break;
                case 20:
                    offset = 0x5F9B; // Drollmagi
                    break;
                case 21:
                    offset = 0x5FAB; // Wyvern
                    break;
                case 22:
                    offset = 0x5FBB; // Rogue Scorpion
                    break;
                case 23:
                    offset = 0x5FCB; // Wraith Knight
                    break;
                case 24:
                    offset = 0x5FDB; // Golem
                    break;
                case 25:
                    offset = 0x5FEB; // Goldman
                    break;
                case 26:
                    offset = 0x5FFB; // Knight
                    break;
                case 27:
                    offset = 0x600B; // Magiwyvern
                    break;
                case 28:
                    offset = 0x601B; // Demon Knight
                    break;
                case 29:
                    offset = 0x602B; // Werewolf
                    break;
                case 30:
                    offset = 0x603B; // Green Dragon
                    break;
                case 31:
                    offset = 0x604B; // Starwyvern
                    break;
                case 32:
                    offset = 0x605B; // Wizard
                    break;
                case 33:
                    offset = 0x606B; // Axe Knight
                    break;
                case 34:
                    offset = 0x607B; // Blue Dragon
                    break;
                case 35:
                    offset = 0x608B; // Stoneman
                    break;
                case 36:
                    offset = 0x609B; // Armored Knight
                    break;
                case 37:
                    offset = 0x60AB; // Red Dragon
                    break;
                case 38:
                    offset = 0x60BB; // Dragonlord
                    break;
                case 39:
                    offset = 0x60CB; // Dragonlord (True Form)
                    break;
                default:
                    offset = 0x5E5B;
                    break;
            }

            bool result = backend.setMonsterStats(offset, monsterStatData);

            if (result)
            {
                MessageBox.Show("ROM updated!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("ROM update failed.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        private void loadRom()
        {
            getROMData();
            enableDisableFormControls(true);
        }

        private void getROMData()
        {
            Backend backend = new Backend(path);
            int offset = 0x5E5B; // Slime
            getComboBoxIndexes(backend, offset);
        }

        private void getComboBoxIndexes(Backend backend, int offset)
        {
            
            comboBoxStrength.SelectedIndex = backend.getComboboxIndexViaOffset(offset);
            comboBoxAgility.SelectedIndex = backend.getComboboxIndexViaOffset(offset += 0x1);
            comboBoxMaxHP.SelectedIndex = backend.getComboboxIndexViaOffset(offset += 0x1);

            // string special = backend.getComboboxIndex255(offset += 0x1).ToString();
            string special = backend.getHexString(offset += 0x1);
            string special1 = backend.convertHexStringToDecStringOneChar15(special.Substring(0, 1));
            string special2 = backend.convertHexStringToDecStringOneChar15(special.Substring(1, 1));

            comboBoxSpecial1.SelectedIndex = int.Parse(special1);
            comboBoxSpecial2.SelectedIndex = int.Parse(special2);

            string sleepStopResistance = backend.getHexString(offset += 1);
            string sleepStopResistance1 = backend.convertHexStringToDecStringOneChar15(sleepStopResistance.Substring(0, 1));
            string sleepStopResistance2 = backend.convertHexStringToDecStringOneChar15(sleepStopResistance.Substring(1, 1));

            comboBoxSleepResistance.SelectedIndex = int.Parse(sleepStopResistance1);
            comboBoxStopResistance.SelectedIndex = int.Parse(sleepStopResistance2);

            string hurtResistanceAndEvasion = backend.getHexString(offset += 1);
            string hurtResistance = backend.convertHexStringToDecStringOneChar15(hurtResistanceAndEvasion.Substring(0, 1));
            string evasion = backend.convertHexStringToDecStringOneChar15(hurtResistanceAndEvasion.Substring(1, 1));

            comboBoxHurtResistance.SelectedIndex = int.Parse(hurtResistance);
            comboBoxEvasion.SelectedIndex = int.Parse(evasion);

            comboBoxExperience.SelectedIndex = backend.getComboboxIndexViaOffset(offset += 0x1);
            comboBoxMaxGold.SelectedIndex = backend.getComboboxIndexViaOffset(offset += 0x1);
        }

        #region load combobox defaults
        private void loadDefaultComboBoxesData()
        {
            Backend backend = new Backend(path);
            loadComboBoxMonsters(backend);
            loadComboBoxStrength(backend);
            loadComboBoxAgility(backend);
            loadComboBoxMaxHP(backend);
            loadComboSpecial1(backend);
            loadComboSpecial2(backend);
            loadComboSleepResistance(backend);
            loadComboStopResistance(backend);
            loadComboHurtResistance(backend);
            loadComboBoxEvasion(backend);
            loadComboBoxExperience(backend);
            loadComboBoxMaxGold(backend);
        }

        private void loadComboBoxMonsters(Backend backend)
        {
            Dictionary<string, string> monsterData = backend.getDefaultMonsterData();

            comboBoxMonsters.DataSource = new BindingSource(monsterData, null);
            comboBoxMonsters.DisplayMember = "Value";
            comboBoxMonsters.ValueMember = "Key";
        }

        private void loadComboBoxStrength(Backend backend)
        {
            Dictionary<string, string> strengthData = backend.getDefault255();

            comboBoxStrength.DataSource = new BindingSource(strengthData, null);
            comboBoxStrength.DisplayMember = "Value";
            comboBoxStrength.ValueMember = "Key";
        }

        private void loadComboBoxAgility(Backend backend)
        {
            Dictionary<string, string> agilityData = backend.getDefault255();

            comboBoxAgility.DataSource = new BindingSource(agilityData, null);
            comboBoxAgility.DisplayMember = "Value";
            comboBoxAgility.ValueMember = "Key";
        }

        private void loadComboBoxMaxHP(Backend backend)
        {
            Dictionary<string, string> maxHPData = backend.getDefault255();

            comboBoxMaxHP.DataSource = new BindingSource(maxHPData, null);
            comboBoxMaxHP.DisplayMember = "Value";
            comboBoxMaxHP.ValueMember = "Key";
        }

        private void loadComboSpecial1(Backend backend)
        {
            Dictionary<string, string> special1Data = backend.getDefaultSpecial1Data();

            comboBoxSpecial1.DataSource = new BindingSource(special1Data, null);
            comboBoxSpecial1.DisplayMember = "Value";
            comboBoxSpecial1.ValueMember = "Key";
        }

        private void loadComboSpecial2(Backend backend)
        {
            Dictionary<string, string> special2Data = backend.getDefaultSpecial2Data();

            comboBoxSpecial2.DataSource = new BindingSource(special2Data, null);
            comboBoxSpecial2.DisplayMember = "Value";
            comboBoxSpecial2.ValueMember = "Key";
        }

        private void loadComboSleepResistance(Backend backend)
        {
            Dictionary<string, string> sleepResistanceData = backend.getDefault15();

            comboBoxSleepResistance.DataSource = new BindingSource(sleepResistanceData, null);
            comboBoxSleepResistance.DisplayMember = "Value";
            comboBoxSleepResistance.ValueMember = "Key";
        }

        private void loadComboStopResistance(Backend backend)
        {
            Dictionary<string, string> stopResistanceData = backend.getDefault15();

            comboBoxStopResistance.DataSource = new BindingSource(stopResistanceData, null);
            comboBoxStopResistance.DisplayMember = "Value";
            comboBoxStopResistance.ValueMember = "Key";
        }

        private void loadComboHurtResistance(Backend backend)
        {
            Dictionary<string, string> hurtResistanceData = backend.getDefault15();

            comboBoxHurtResistance.DataSource = new BindingSource(hurtResistanceData, null);
            comboBoxHurtResistance.DisplayMember = "Value";
            comboBoxHurtResistance.ValueMember = "Key";
        }

        private void loadComboBoxEvasion(Backend backend)
        {
            Dictionary<string, string> evasionData = backend.getDefault15();

            comboBoxEvasion.DataSource = new BindingSource(evasionData, null);
            comboBoxEvasion.DisplayMember = "Value";
            comboBoxEvasion.ValueMember = "Key";
        }

        private void loadComboBoxExperience(Backend backend)
        {
            Dictionary<string, string> experienceData = backend.getDefault255();

            comboBoxExperience.DataSource = new BindingSource(experienceData, null);
            comboBoxExperience.DisplayMember = "Value";
            comboBoxExperience.ValueMember = "Key";
        }

        private void loadComboBoxMaxGold(Backend backend)
        {
            Dictionary<string, string> mapGoldData = backend.getDefault255();

            comboBoxMaxGold.DataSource = new BindingSource(mapGoldData, null);
            comboBoxMaxGold.DisplayMember = "Value";
            comboBoxMaxGold.ValueMember = "Key";
        }
        #endregion

        private void enableDisableFormControls(bool isEnabled)
        {
            updateMonsterStatsToolStripMenuItem.Enabled = isEnabled;
            buttonUpdateMonsterStats.Enabled = isEnabled;
            groupBox1.Enabled = isEnabled;
        }

        #region tool strip menu items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOpenRom_Click(sender, e);
        }

        private void updateMonsterStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonUpdateMonsterStats_Click(sender, e);
        }
        #endregion

        private void comboBoxMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This triggers on form load so check the path isn't null.
            if (path != null)
            {
                Backend backend = new Backend(path);
                int offset = 0x0;
                int selectedMonsterIndex = comboBoxMonsters.SelectedIndex;

                switch (selectedMonsterIndex)
                {
                    case 0:
                        offset = 0x5E5B; // Slime
                        break;
                    case 1:
                        offset = 0x5E6B; // Red Slime
                        break;
                    case 2:
                        offset = 0x5E7B; // Drakee
                        break;
                    case 3:
                        offset = 0x5E8B; // Ghost
                        break;
                    case 4:
                        offset = 0x5E9B; // Magician
                        break;
                    case 5:
                        offset = 0x5EAB; // Magidrakee
                        break;
                    case 6:
                        offset = 0x5EBB; // Scorpion
                        break;
                    case 7:
                        offset = 0x5ECB; // Druin
                        break;
                    case 8:
                        offset = 0x5EDB; // Poltergeist
                        break;
                    case 9:
                        offset = 0x5EEB; // Droll
                        break;
                    case 10:
                        offset = 0x5EFB; // Drakeema
                        break;
                    case 11:
                        offset = 0x5F0B; // Skeleton
                        break;
                    case 12:
                        offset = 0x5F1B; // Warlock
                        break;
                    case 13:
                        offset = 0x5F2B; // Metal Scorpion
                        break;
                    case 14:
                        offset = 0x5F3B; // Wolf
                        break;
                    case 15:
                        offset = 0x5F4B; // Wraith
                        break;
                    case 16:
                        offset = 0x5F5B; // Metal Slime
                        break;
                    case 17:
                        offset = 0x5F6B; // Specter
                        break;
                    case 18:
                        offset = 0x5F7B; // Wolflord
                        break;
                    case 19:
                        offset = 0x5F8B; // Druinlord
                        break;
                    case 20:
                        offset = 0x5F9B; // Drollmagi
                        break;
                    case 21:
                        offset = 0x5FAB; // Wyvern
                        break;
                    case 22:
                        offset = 0x5FBB; // Rogue Scorpion
                        break;
                    case 23:
                        offset = 0x5FCB; // Wraith Knight
                        break;
                    case 24:
                        offset = 0x5FDB; // Golem
                        break;
                    case 25:
                        offset = 0x5FEB; // Goldman
                        break;
                    case 26:
                        offset = 0x5FFB; // Knight
                        break;
                    case 27:
                        offset = 0x600B; // Magiwyvern
                        break;
                    case 28:
                        offset = 0x601B; // Demon Knight
                        break;
                    case 29:
                        offset = 0x602B; // Werewolf
                        break;
                    case 30:
                        offset = 0x603B; // Green Dragon
                        break;
                    case 31:
                        offset = 0x604B; // Starwyvern
                        break;
                    case 32:
                        offset = 0x605B; // Wizard
                        break;
                    case 33:
                        offset = 0x606B; // Axe Knight
                        break;
                    case 34:
                        offset = 0x607B; // Blue Dragon
                        break;
                    case 35:
                        offset = 0x608B; // Stoneman
                        break;
                    case 36:
                        offset = 0x609B; // Armored Knight
                        break;
                    case 37:
                        offset = 0x60AB; // Red Dragon
                        break;
                    case 38:
                        offset = 0x60BB; // Dragonlord
                        break;
                    case 39:
                        offset = 0x60CB; // Dragonlord (True Form)
                        break;
                    default:
                        offset = 0x5E5B;
                        break;
                }

                getComboBoxIndexes(backend, offset);
            }
        }
    }
}
