using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class Validator
    {
        // test if a text box is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text == "" || tb.Text == null)  // empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        // tests if a comboc box is not empty (Required Field)
        public static bool IsProvided(ComboBox cb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (cb.SelectedItem == null)  // empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                cb.Focus();
            }
            return result;
        }

        // tests if input is a non-negative integar
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {

            bool result = true;
            int num;    // parsed number

            if (!Int32.TryParse(tb.Text, out num))  // if not integar
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative integar", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else    // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + "needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }

        public static bool IsNonString(TextBox tb, string name)
        {

            bool result = true;
            decimal num;    // parsed number
           
            if (!Decimal.TryParse(tb.Text, out num))  // if not integar
            {
                result = false;
                MessageBox.Show(name + " has to be a number", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else    // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + "needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }
        public static bool IsNonStringEmpty(TextBox tb, string name)
        {

            bool result = true;
            decimal num;    // parsed number
            if (tb.Text == "" || tb.Text == " ")
            {
                result = true;
            }
            else if (!Decimal.TryParse(tb.Text, out num))  // if not integar
            {
                result = false;
                MessageBox.Show(name + " has to be a number", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }            
            else    // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + "needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }

            return result;
        }
    }
}

