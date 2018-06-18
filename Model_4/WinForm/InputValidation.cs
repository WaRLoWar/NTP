using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinForm
{
    public abstract class InputValidation
    {
        #region CheckKeyPress

        /// <summary>
        /// Function that allows you to enter only numbers and symbols of the English alphabet
        /// </summary>        
        /// <param name="symbol"></param>
        ///   /// <returns></returns>
        public static bool IsEnglishAndNumberSymbol(char symbol)
        {
            return (IsEnglishSymbol(symbol) || IsNumberSymbol(symbol) || IsSpecialSymbols(symbol)) && (symbol != ',' && symbol != '.');
        }

        /// <summary>
        /// Function that allows you to enter only numbers 
        /// </summary>        
        /// <param name="symbol"></param>
        ///   /// <returns></returns>
        public static bool IsOnlyNumberSymbol(char symbol)
        {
            return (IsNumberSymbol(symbol) || IsSpecialSymbols(symbol)) && (symbol != ',' && symbol != '.');
        }

        /// <summary>
        /// Function that allows you to enter only symbols of the English alphabet
        /// </summary>
        /// <param name="symbol"></param>
        ///   /// <returns></returns>
        public static bool IsOnlyEnglishSymbol(char symbol)
        {
            return IsEnglishSymbol(symbol) || IsSpecialSymbols(symbol) || (symbol != '.' && symbol != ',');
        }

        /// <summary>
        /// Checking whether the symbol is a decimal digit
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static bool IsNumberSymbol(char symbol)
        {
            return (char.IsDigit((symbol)));
        }

        /// <summary>
        /// Checking whether a character is an English alphabet character
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static bool IsEnglishSymbol(char symbol)
        {
            return (symbol >= 'A' && symbol <= 'Z');
        }
        /// <summary>
        /// Check whether the key pressed is a Backspace or Delete button
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static bool IsSpecialSymbols(char symbol)
        {
            return ((symbol == (char)Keys.Back) || (symbol == (char)Keys.Delete));
        }
        /// <summary>
        /// Checks the string for more than one comma in the field 'Cost'
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="textBoxt"></param>
        /// <returns></returns>
        public static bool IsCorrectLine(char symbol, string textBoxt)
        {
            char[] text = textBoxt.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    if (symbol == ',' || symbol == '.' || (text.Length - i) > 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Checking the pressed key in the field 'Tb_Cost'
        /// </summary>
        /// <param name="text"></param>
        /// <param name="e"></param>
        public static void Tb_Cost_KeyPress(string text, KeyPressEventArgs e)
        {
            if (!IsCorrectLine(e.KeyChar, text))
            {
                e.Handled = true;
            }
            if (text == "" && (e.KeyChar == ',' || e.KeyChar == '.') || !IsNumberSymbol(e.KeyChar) && !IsSpecialSymbols(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = '.';
            }
        }
        #endregion CheckKeyPress

        public static bool IsGeneralEmptyField(string name, string serialNumber, string cost)
        {
            return (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(serialNumber) ||
                    string.IsNullOrWhiteSpace(cost));
        }

        public static DateTime CheckDateTime(DateTime date)
        {
            DateTime minDate = new DateTime(1900,01,01);
            DateTime maxDate = DateTime.Today;
            if (date >= minDate && date <= maxDate)
            {
                return date;
            }
            return minDate;
        }       
        

    }
}
