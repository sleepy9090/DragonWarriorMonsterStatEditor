using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2018+
 */
namespace DragonWarriorMonsterStatEditor
{
    class Backend
    {
        string path;

        public Backend(string gamePath)
        {
            path = gamePath;
        }

        public Dictionary<string, string> getDefaultSpecial1Data()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("0", "0h - None");
            items.Add("1", "1h - SLEEP");
            items.Add("2", "2h - SLEEP");
            items.Add("3", "3h - SLEEP");
            items.Add("4", "4h - None");
            items.Add("5", "5h - STOPSPELL");
            items.Add("6", "6h - STOPSPELL");
            items.Add("7", "7h - STOPSPELL");
            items.Add("8", "8h - None");
            items.Add("9", "9h - HEAL");
            items.Add("A", "Ah - HEAL");
            items.Add("B", "Bh - HEAL");
            items.Add("C", "Ch - None");
            items.Add("D", "Dh - HEALMORE");
            items.Add("E", "Eh - HEALMORE");
            items.Add("F", "Fh - HEALMORE");

            return items;
        }

        public Dictionary<string, string> getDefaultSpecial2Data()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("0", "0h - None");
            items.Add("1", "1h - HURT");
            items.Add("2", "2h - HURT");
            items.Add("3", "3h - HURT");
            items.Add("4", "4h - None");
            items.Add("5", "5h - HURTMORE");
            items.Add("6", "6h - HURTMORE");
            items.Add("7", "7h - HURTMORE");
            items.Add("8", "8h - None");
            items.Add("9", "9h - Breath Fire");
            items.Add("A", "Ah - Breath Fire");
            items.Add("B", "Bh - Breath Fire");
            items.Add("C", "Ch - None");
            items.Add("D", "Dh - Breath Fire II");
            items.Add("E", "Eh - Breath Fire II");
            items.Add("F", "Fh - Breath Fire II");

            return items;
        }

        public Dictionary<string, string> getDefaultMonsterData()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("00", "Slime");
            items.Add("01", "Red Slime");
            items.Add("02", "Drakee");
            items.Add("03", "Ghost");
            items.Add("04", "Magician");
            items.Add("05", "Magidrakee");
            items.Add("06", "Scorpion");
            items.Add("07", "Druin");
            items.Add("08", "Poltergeist");
            items.Add("09", "Droll");

            items.Add("0A", "Drakeema");
            items.Add("0B", "Skeleton");
            items.Add("0C", "Warlock");
            items.Add("0D", "Metal Scorpion");
            items.Add("0E", "Wolf");
            items.Add("0F", "Wraith");
            items.Add("10", "Metal Slime");
            items.Add("11", "Specter");
            items.Add("12", "Wolflord");
            items.Add("13", "Druinlord");

            items.Add("14", "Drollmagi");
            items.Add("15", "Wyvern");
            items.Add("16", "Rogue Scorpion");
            items.Add("17", "Wraith Knight");
            items.Add("18", "Golem");
            items.Add("19", "Goldman");
            items.Add("1A", "Knight");
            items.Add("1B", "Magiwyvern");
            items.Add("1C", "Demon Knight");
            items.Add("1D", "Werewolf");

            items.Add("1E", "Green Dragon");
            items.Add("1F", "Starwyvern");
            items.Add("20", "Wizard");
            items.Add("21", "Axe Knight");
            items.Add("22", "Blue Dragon");
            items.Add("23", "Stoneman");
            items.Add("24", "Armored Knight");
            items.Add("25", "Red Dragon");
            items.Add("26", "Dragonlord");
            items.Add("27", "Dragonlord (True Form)");

            return items;
        }

        public Dictionary<string, string> getDefault255()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int x = 0; x < 256; x++)
            {
                string hexString = convertDecStringToHexString(x.ToString());
                items.Add(hexString.PadLeft(2, '0'), x.ToString().PadLeft(2, '0'));
            }

            return items;
        }

        public Dictionary<string, string> getDefault63()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int x = 0; x < 64; x++)
            {
                string hexString = convertDecStringToHexString(x.ToString());
                items.Add(hexString.PadLeft(2, '0'), x.ToString().PadLeft(2, '0'));
            }

            return items;
        }

        public Dictionary<string, string> getDefault15()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int x = 0; x < 16; x++)
            {
                string hexString = convertDecStringToHexString(x.ToString());
                items.Add(hexString.PadLeft(2, '0'), x.ToString().PadLeft(2, '0'));
            }

            return items;
        }

        public bool setMonsterStats(int offset, string hexValue)
        {
            string value = hexValue;
            return writeByteArrayToFile(this.path, offset, StringToByteArray(hexValue));
        }

        public string convertHexStringToDecStringTwoCharPublic(String hexString)
        {
            return convertHexStringToDecStringTwoChar(hexString);
        }

        public string convertDecStringToHexStringPublic(String decString)
        {
            return convertDecStringToHexString(decString);
        }

        #region common methods
        private static string convertHexStringToDecStringFourChar(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 4)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 4);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    // char character = System.Convert.ToChar(decval);
                    ascii += decval;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private static string convertHexStringToDecStringTwoChar(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    // char character = System.Convert.ToChar(decval);
                    ascii += decval;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private static string convertHexStringToDecStringOneChar(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 1)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 1);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    ascii += decval;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private static string convertDecStringToHexString(String decString)
        {
            int value = Convert.ToInt32(decString);
            string hexValue = String.Format("{0:X}", value);

            return hexValue;
        }

        private string getHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for (int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool writeByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }

        public int getComboboxIndexViaOffset(int offset)
        {
            string hexString = getHexStringFromFile(offset, 1);
            int index = 0;

            hexString = hexString.ToUpper();
            switch (hexString)
            {
                case "00":
                    index = 0x00;
                    break;
                case "01":
                    index = 0x01;
                    break;
                case "02":
                    index = 0x02;
                    break;
                case "03":
                    index = 0x03;
                    break;
                case "04":
                    index = 0x04;
                    break;
                case "05":
                    index = 0x05;
                    break;
                case "06":
                    index = 0x06;
                    break;
                case "07":
                    index = 0x07;
                    break;
                case "08":
                    index = 0x08;
                    break;
                case "09":
                    index = 0x09;
                    break;
                case "0A":
                    index = 0x0A;
                    break;
                case "0B":
                    index = 0x0B;
                    break;
                case "0C":
                    index = 0x0C;
                    break;
                case "0D":
                    index = 0x0D;
                    break;
                case "0E":
                    index = 0x0E;
                    break;
                case "0F":
                    index = 0x0F;
                    break;
                case "10":
                    index = 0x10;
                    break;
                case "11":
                    index = 0x11;
                    break;
                case "12":
                    index = 0x12;
                    break;
                case "13":
                    index = 0x13;
                    break;
                case "14":
                    index = 0x14;
                    break;
                case "15":
                    index = 0x15;
                    break;
                case "16":
                    index = 0x16;
                    break;
                case "17":
                    index = 0x17;
                    break;
                case "18":
                    index = 0x18;
                    break;
                case "19":
                    index = 0x19;
                    break;
                case "1A":
                    index = 0x1A;
                    break;
                case "1B":
                    index = 0x1B;
                    break;
                case "1C":
                    index = 0x1C;
                    break;
                case "1D":
                    index = 0x1D;
                    break;
                case "1E":
                    index = 0x1E;
                    break;
                case "1F":
                    index = 0x1F;
                    break;
                case "20":
                    index = 0x20;
                    break;
                case "21":
                    index = 0x21;
                    break;
                case "22":
                    index = 0x22;
                    break;
                case "23":
                    index = 0x23;
                    break;
                case "24":
                    index = 0x24;
                    break;
                case "25":
                    index = 0x25;
                    break;
                case "26":
                    index = 0x26;
                    break;
                case "27":
                    index = 0x27;
                    break;
                case "28":
                    index = 0x28;
                    break;
                case "29":
                    index = 0x29;
                    break;
                case "2A":
                    index = 0x2A;
                    break;
                case "2B":
                    index = 0x2B;
                    break;
                case "2C":
                    index = 0x2C;
                    break;
                case "2D":
                    index = 0x2D;
                    break;
                case "2E":
                    index = 0x2E;
                    break;
                case "2F":
                    index = 0x2F;
                    break;
                case "30":
                    index = 0x30;
                    break;
                case "31":
                    index = 0x31;
                    break;
                case "32":
                    index = 0x32;
                    break;
                case "33":
                    index = 0x33;
                    break;
                case "34":
                    index = 0x34;
                    break;
                case "35":
                    index = 0x35;
                    break;
                case "36":
                    index = 0x36;
                    break;
                case "37":
                    index = 0x37;
                    break;
                case "38":
                    index = 0x38;
                    break;
                case "39":
                    index = 0x39;
                    break;
                case "3A":
                    index = 0x3A;
                    break;
                case "3B":
                    index = 0x3B;
                    break;
                case "3C":
                    index = 0x3C;
                    break;
                case "3D":
                    index = 0x3D;
                    break;
                case "3E":
                    index = 0x3E;
                    break;
                case "3F":
                    index = 0x3F;
                    break;
                case "40":
                    index = 0x40;
                    break;
                case "41":
                    index = 0x41;
                    break;
                case "42":
                    index = 0x42;
                    break;
                case "43":
                    index = 0x43;
                    break;
                case "44":
                    index = 0x44;
                    break;
                case "45":
                    index = 0x45;
                    break;
                case "46":
                    index = 0x46;
                    break;
                case "47":
                    index = 0x47;
                    break;
                case "48":
                    index = 0x48;
                    break;
                case "49":
                    index = 0x49;
                    break;
                case "4A":
                    index = 0x4A;
                    break;
                case "4B":
                    index = 0x4B;
                    break;
                case "4C":
                    index = 0x4C;
                    break;
                case "4D":
                    index = 0x4D;
                    break;
                case "4E":
                    index = 0x4E;
                    break;
                case "4F":
                    index = 0x4F;
                    break;
                case "50":
                    index = 0x50;
                    break;
                case "51":
                    index = 0x51;
                    break;
                case "52":
                    index = 0x52;
                    break;
                case "53":
                    index = 0x53;
                    break;
                case "54":
                    index = 0x54;
                    break;
                case "55":
                    index = 0x55;
                    break;
                case "56":
                    index = 0x56;
                    break;
                case "57":
                    index = 0x57;
                    break;
                case "58":
                    index = 0x58;
                    break;
                case "59":
                    index = 0x59;
                    break;
                case "5A":
                    index = 0x5A;
                    break;
                case "5B":
                    index = 0x5B;
                    break;
                case "5C":
                    index = 0x5C;
                    break;
                case "5D":
                    index = 0x5D;
                    break;
                case "5E":
                    index = 0x5E;
                    break;
                case "5F":
                    index = 0x5F;
                    break;
                case "60":
                    index = 0x60;
                    break;
                case "61":
                    index = 0x61;
                    break;
                case "62":
                    index = 0x62;
                    break;
                case "63":
                    index = 0x63;
                    break;
                case "64":
                    index = 0x64;
                    break;
                case "65":
                    index = 0x65;
                    break;
                case "66":
                    index = 0x66;
                    break;
                case "67":
                    index = 0x67;
                    break;
                case "68":
                    index = 0x68;
                    break;
                case "69":
                    index = 0x69;
                    break;
                case "6A":
                    index = 0x6A;
                    break;
                case "6B":
                    index = 0x6B;
                    break;
                case "6C":
                    index = 0x6C;
                    break;
                case "6D":
                    index = 0x6D;
                    break;
                case "6E":
                    index = 0x6E;
                    break;
                case "6F":
                    index = 0x6F;
                    break;
                case "70":
                    index = 0x70;
                    break;
                case "71":
                    index = 0x71;
                    break;
                case "72":
                    index = 0x72;
                    break;
                case "73":
                    index = 0x73;
                    break;
                case "74":
                    index = 0x74;
                    break;
                case "75":
                    index = 0x75;
                    break;
                case "76":
                    index = 0x76;
                    break;
                case "77":
                    index = 0x77;
                    break;
                case "78":
                    index = 0x78;
                    break;
                case "79":
                    index = 0x79;
                    break;
                case "7A":
                    index = 0x7A;
                    break;
                case "7B":
                    index = 0x7B;
                    break;
                case "7C":
                    index = 0x7C;
                    break;
                case "7D":
                    index = 0x7D;
                    break;
                case "7E":
                    index = 0x7E;
                    break;
                case "7F":
                    index = 0x7F;
                    break;
                case "80":
                    index = 0x80;
                    break;
                case "81":
                    index = 0x81;
                    break;
                case "82":
                    index = 0x82;
                    break;
                case "83":
                    index = 0x83;
                    break;
                case "84":
                    index = 0x84;
                    break;
                case "85":
                    index = 0x85;
                    break;
                case "86":
                    index = 0x86;
                    break;
                case "87":
                    index = 0x87;
                    break;
                case "88":
                    index = 0x88;
                    break;
                case "89":
                    index = 0x89;
                    break;
                case "8A":
                    index = 0x8A;
                    break;
                case "8B":
                    index = 0x8B;
                    break;
                case "8C":
                    index = 0x8C;
                    break;
                case "8D":
                    index = 0x8D;
                    break;
                case "8E":
                    index = 0x8E;
                    break;
                case "8F":
                    index = 0x8F;
                    break;
                case "90":
                    index = 0x90;
                    break;
                case "91":
                    index = 0x91;
                    break;
                case "92":
                    index = 0x92;
                    break;
                case "93":
                    index = 0x93;
                    break;
                case "94":
                    index = 0x94;
                    break;
                case "95":
                    index = 0x95;
                    break;
                case "96":
                    index = 0x96;
                    break;
                case "97":
                    index = 0x97;
                    break;
                case "98":
                    index = 0x98;
                    break;
                case "99":
                    index = 0x99;
                    break;
                case "9A":
                    index = 0x9A;
                    break;
                case "9B":
                    index = 0x9B;
                    break;
                case "9C":
                    index = 0x9C;
                    break;
                case "9D":
                    index = 0x9D;
                    break;
                case "9E":
                    index = 0x9E;
                    break;
                case "9F":
                    index = 0x9F;
                    break;
                case "A0":
                    index = 0xA0;
                    break;
                case "A1":
                    index = 0xA1;
                    break;
                case "A2":
                    index = 0xA2;
                    break;
                case "A3":
                    index = 0xA3;
                    break;
                case "A4":
                    index = 0xA4;
                    break;
                case "A5":
                    index = 0xA5;
                    break;
                case "A6":
                    index = 0xA6;
                    break;
                case "A7":
                    index = 0xA7;
                    break;
                case "A8":
                    index = 0xA8;
                    break;
                case "A9":
                    index = 0xA9;
                    break;
                case "AA":
                    index = 0xAA;
                    break;
                case "AB":
                    index = 0xAB;
                    break;
                case "AC":
                    index = 0xAC;
                    break;
                case "AD":
                    index = 0xAD;
                    break;
                case "AE":
                    index = 0xAE;
                    break;
                case "AF":
                    index = 0xAF;
                    break;
                case "B0":
                    index = 0xB0;
                    break;
                case "B1":
                    index = 0xB1;
                    break;
                case "B2":
                    index = 0xB2;
                    break;
                case "B3":
                    index = 0xB3;
                    break;
                case "B4":
                    index = 0xB4;
                    break;
                case "B5":
                    index = 0xB5;
                    break;
                case "B6":
                    index = 0xB6;
                    break;
                case "B7":
                    index = 0xB7;
                    break;
                case "B8":
                    index = 0xB8;
                    break;
                case "B9":
                    index = 0xB9;
                    break;
                case "BA":
                    index = 0xBA;
                    break;
                case "BB":
                    index = 0xBB;
                    break;
                case "BC":
                    index = 0xBC;
                    break;
                case "BD":
                    index = 0xBD;
                    break;
                case "BE":
                    index = 0xBE;
                    break;
                case "BF":
                    index = 0xBF;
                    break;
                case "C0":
                    index = 0xC0;
                    break;
                case "C1":
                    index = 0xC1;
                    break;
                case "C2":
                    index = 0xC2;
                    break;
                case "C3":
                    index = 0xC3;
                    break;
                case "C4":
                    index = 0xC4;
                    break;
                case "C5":
                    index = 0xC5;
                    break;
                case "C6":
                    index = 0xC6;
                    break;
                case "C7":
                    index = 0xC7;
                    break;
                case "C8":
                    index = 0xC8;
                    break;
                case "C9":
                    index = 0xC9;
                    break;
                case "CA":
                    index = 0xCA;
                    break;
                case "CB":
                    index = 0xCB;
                    break;
                case "CC":
                    index = 0xCC;
                    break;
                case "CD":
                    index = 0xCD;
                    break;
                case "CE":
                    index = 0xCE;
                    break;
                case "CF":
                    index = 0xCF;
                    break;
                case "D0":
                    index = 0xD0;
                    break;
                case "D1":
                    index = 0xD1;
                    break;
                case "D2":
                    index = 0xD2;
                    break;
                case "D3":
                    index = 0xD3;
                    break;
                case "D4":
                    index = 0xD4;
                    break;
                case "D5":
                    index = 0xD5;
                    break;
                case "D6":
                    index = 0xD6;
                    break;
                case "D7":
                    index = 0xD7;
                    break;
                case "D8":
                    index = 0xD8;
                    break;
                case "D9":
                    index = 0xD9;
                    break;
                case "DA":
                    index = 0xDA;
                    break;
                case "DB":
                    index = 0xDB;
                    break;
                case "DC":
                    index = 0xDC;
                    break;
                case "DD":
                    index = 0xDD;
                    break;
                case "DE":
                    index = 0xDE;
                    break;
                case "DF":
                    index = 0xDF;
                    break;
                case "E0":
                    index = 0xE0;
                    break;
                case "E1":
                    index = 0xE1;
                    break;
                case "E2":
                    index = 0xE2;
                    break;
                case "E3":
                    index = 0xE3;
                    break;
                case "E4":
                    index = 0xE4;
                    break;
                case "E5":
                    index = 0xE5;
                    break;
                case "E6":
                    index = 0xE6;
                    break;
                case "E7":
                    index = 0xE7;
                    break;
                case "E8":
                    index = 0xE8;
                    break;
                case "E9":
                    index = 0xE9;
                    break;
                case "EA":
                    index = 0xEA;
                    break;
                case "EB":
                    index = 0xEB;
                    break;
                case "EC":
                    index = 0xEC;
                    break;
                case "ED":
                    index = 0xED;
                    break;
                case "EE":
                    index = 0xEE;
                    break;
                case "EF":
                    index = 0xEF;
                    break;
                case "F0":
                    index = 0xF0;
                    break;
                case "F1":
                    index = 0xF1;
                    break;
                case "F2":
                    index = 0xF2;
                    break;
                case "F3":
                    index = 0xF3;
                    break;
                case "F4":
                    index = 0xF4;
                    break;
                case "F5":
                    index = 0xF5;
                    break;
                case "F6":
                    index = 0xF6;
                    break;
                case "F7":
                    index = 0xF7;
                    break;
                case "F8":
                    index = 0xF8;
                    break;
                case "F9":
                    index = 0xF9;
                    break;
                case "FA":
                    index = 0xFA;
                    break;
                case "FB":
                    index = 0xFB;
                    break;
                case "FC":
                    index = 0xFC;
                    break;
                case "FD":
                    index = 0xFD;
                    break;
                case "FE":
                    index = 0xFE;
                    break;
                case "FF":
                    index = 0xFF;
                    break;
                default:
                    index = 0;
                    break;
            }

            return index;
        }

        public string getHexString(int offset)
        {
            string hexString = getHexStringFromFile(offset, 1);
            return hexString.ToUpper();
        }

        public string convertHexStringToDecStringOneChar15(String hexString)
        {
            return convertHexStringToDecStringOneChar(hexString);
        }
        #endregion
    }
}
