﻿using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
/// <summary>
/// Represents a Windows text box control with a cue banner.
/// </summary>
public class CueTextBox : MaskedTextBox
{


    /// <summary>
    /// REGULAR EXPRESSION
    /// </summary>
    private string _regEx;

    /// <summary>
    /// REGULAR EXPRESSION
    /// </summary>
    public string RegEx
    {
        get
        {
            return _regEx;
        }

        set
        {
            _regEx = value;

        }
    }
    /// <summary>
    /// Required
    /// </summary>
    private bool _required;

    /// <summary>
    /// Required
    /// </summary>
    public bool Required
    {
        get
        {
            return _required;
        }

        set
        {
            _required = value;

        }
    }
    /// <summary>
    /// The cue banner text.
    /// </summary>
    private string _cueText;

    /// <summary>
    /// Gets or sets the cue banner text.
    /// </summary>
    public string CueText
    {
        get
        {
            return _cueText;
        }

        set
        {
            _cueText = value;
            Invalidate();
        }
    }


    /// <summary>
    /// Processes Windows messages.
    /// </summary>
    /// <param name="m">A Windows Message object.</param>
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        const int WM_PAINT = 0xF;
        if (m.Msg == WM_PAINT)
        {
            if (!Focused && string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(CueText))
            {
                using (var graphics = CreateGraphics())
                {
                    TextRenderer.DrawText(
                        dc: graphics,
                        text: CueText,
                        font: Font,
                        bounds: ClientRectangle,
                        foreColor: SystemColors.GrayText,
                        backColor: Enabled ? BackColor : SystemColors.Control,
                        flags: TextFormatFlags.Top | TextFormatFlags.Left);
                }
            }
        }
    }
    public void CheckString(object sender, System.ComponentModel.CancelEventArgs e)
    {

        CueTextBox lol = sender as CueTextBox;
        string ch = _check(sender, false);
        if (!(string.IsNullOrEmpty(ch)))
        {
            lol.ForeColor = Color.Red;
            if (!(new Regex(@lol.Tag.ToString()).IsMatch(lol.Parent.FindForm().Tag.ToString())))
                lol.Parent.FindForm().Tag += ch + ",";
            
        }
        else
        {
            lol.ForeColor = Color.Black;
            lol.Parent.FindForm().Tag = Regex.Replace(lol.Parent.FindForm().Tag.ToString(), lol.Tag.ToString() + ",", string.Empty);
            
        }





        /*if (lol.RegEx != null && lol.Tag != null)
        {
            if ((new Regex(@lol.RegEx.ToString())).IsMatch(lol.Text))
            {
                lol.ForeColor = Color.Black;
                lol.Parent.FindForm().Tag = Regex.Replace(lol.Parent.FindForm().Tag.ToString(), " "+@lol.Tag.ToString(), String.Empty);
            }
            else
            {
                lol.ForeColor = Color.Red;
                if (lol.Tag != null)
                {
                    if (!(new Regex(@lol.Tag.ToString()).IsMatch(lol.Parent.FindForm().Tag.ToString())) || (lol.Required && String.IsNullOrWhiteSpace(lol.Text)))
                    {
                        lol.Parent.FindForm().Tag += lol.Tag.ToString() + ",";
                    }
                }

            }
        }*/

    }
    public string _check(object sender, bool checkmode)
    {
        CueTextBox lol = sender as CueTextBox;
        if (lol.Required && (string.IsNullOrWhiteSpace(lol.Text) || lol.Text == "__.__.____")) return lol.Tag.ToString();
        if (checkmode) return string.Empty;
        if ((lol.RegEx != null && !((new Regex(@lol.RegEx.ToString())).IsMatch(lol.Text)) && !(string.IsNullOrWhiteSpace(lol.Text))))
        {
            if (lol.Tag != null)
                return lol.Tag.ToString();
            else
                return lol.Name;
            /*lol.ForeColor = Color.Black;
            lol.Parent.FindForm().Tag = Regex.Replace(lol.Parent.FindForm().Tag.ToString(), " " + @lol.Tag.ToString(), String.Empty);*/
        }
        else
        {
            /*lol.ForeColor = Color.Red;
            if (lol.Tag != null)
            {
                if (!(new Regex(@lol.Tag.ToString()).IsMatch(lol.Parent.FindForm().Tag.ToString())) || (lol.Required && String.IsNullOrWhiteSpace(lol.Text)))
                {
                    lol.Parent.FindForm().Tag += lol.Tag.ToString() + ",";
                }
            }*/

            return string.Empty;


        }

    }
}