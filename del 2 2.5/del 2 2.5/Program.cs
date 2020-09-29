using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

private void KeyUpEvent_DateFormat(object sender, KeyEventArgs e)
{
    TextBox txt = sender as TextBox;

    #region Number Pressed - Have done nothing with it still
    if (Control.ModifierKeys.ToString() == "None" && ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue <= 105))) //Digit
    {

    }
    #endregion
    #region Right/Left arrow pressed
    else if (e.KeyValue == 39 || e.KeyValue == 37) //Right || Left
    {
        // Checks whhere the cursor was before the function was called
        int InitialSelection = -1;
        if (e.KeyValue == 39) { InitialSelection = txt.SelectionStart - 1; }
        if (e.KeyValue == 37) { InitialSelection = txt.SelectionStart + 1; }

        // Year was Selected:     Right -> Year;       Left -> Month
        if (InitialSelection > 5 && e.KeyValue == 39) { txt.Select(6, 0); }
        else if (InitialSelection > 5 && e.KeyValue == 37) { txt.Select(4, 0); }

        // Month was Selected:    Right -> Year;       Left -> Day
        else if (InitialSelection > 3 && e.KeyValue == 39) { txt.Select(6, 0); }
        else if (InitialSelection > 3 && e.KeyValue == 37) { txt.Select(1, 0); }

        // Day was Selected:      Right -> Month;      Left -> Day
        else if (InitialSelection < 4 && e.KeyValue == 39) { txt.Select(4, 0); }
        else if (InitialSelection < 4 && e.KeyValue == 37) { txt.Select(1, 0); }

        // Calls this to select the characters
        Date_FieldSelection(sender, null);
    }
    #endregion
    #region Character Pressed (Includes SHIFT)
    else if (
        (e.KeyValue >= 65 && e.KeyValue <= 90) || // Letter
        (Control.ModifierKeys.ToString() == "Shift" && ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue <= 105))) // SpecialChar
    )
    {
        if (txt.SelectionStart > 0) { txt.Select(txt.SelectionStart - 1, 1); }
        else { txt.Select(0, 1); }
        if (txt.SelectedText != "/")
        {
            // txt.SelectedText = "_";
            string BackTxt = ""; // Text before selection
            string FrontTxt = ""; // Text after selection

            // gets BackTxt and FrontTxt
            if (txt.SelectionStart < txt.Text.Length) { BackTxt = txt.Text.Remove(txt.SelectionStart); }
            else { BackTxt = txt.Text; }
            if (txt.SelectionStart > 0) { FrontTxt = txt.Text.Remove(0, txt.SelectionStart); }
            else { FrontTxt = txt.Text; }

            // This is a mess, I know...
            // Char1 and Char 2 are the last and first chars from BackTxt and FrontTxt
            // SelectedIndex is the current position of the cursor, before any change
            int SelectedIndex = txt.SelectionStart;
            char Char1 = new char();// BackTxt.ToCharArray()[BackTxt.Length - 1];
            char Char2 = new char();//FrontTxt.ToCharArray()[0];


            // Replaces written character with "_" in BackTxt
            if (BackTxt.Length > 0)
            {
                Char1 = BackTxt.ToCharArray()[BackTxt.Length - 1];
                if (!char.IsNumber(Char1) && Char1 != '_' && Char1 != '/') { Char1 = '_'; char[] CharArray = BackTxt.ToCharArray(); CharArray[CharArray.Length - 1] = Char1; BackTxt = new string(CharArray); }
                if (BackTxt.EndsWith("/")) { BackTxt += "_"; }
            }

            // Replaces written character with "_" in FrontTxt
            if (FrontTxt.Length > 0)
            {
                Char2 = FrontTxt.ToCharArray()[0];
                if (!char.IsNumber(Char2) && Char2 != '_' && Char2 != '/') { Char2 = '_'; char[] CharArray = FrontTxt.ToCharArray(); CharArray[0] = Char2; FrontTxt = new string(CharArray); }
                if (FrontTxt.StartsWith("/")) { FrontTxt = "_" + FrontTxt; }
            }

            // This is a bugfix for when you write the day
            if (BackTxt.Length == 0 && !FrontTxt.StartsWith("__")) { BackTxt = "_"; }

            //Joins everything
            txt.Text = BackTxt + FrontTxt;

