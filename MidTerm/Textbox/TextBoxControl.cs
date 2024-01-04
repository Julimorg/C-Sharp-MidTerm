using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Midterm
{
    public partial class TextBoxControl : Form
    {
        bool isSubpanelBaoVisible = false;
        bool isSubpanelQuanVisible = false;
        bool isSubpanelTuanAnhVisible = false;
        bool isSubpanelTrungHuyVisible = false;
        int SpaceCount = 0;

        public bool change = false;
        int length = 0;
        string Tlbl4 = "The number of characters you enter textBox is: ";

        public TextBoxControl()
        {
            InitializeComponent();

            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRun.Hide();
            lblWrapped.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();

            
            //txtRead.Hide();
            //txtAcceptTab.Hide();
            //txtFont.Hide();

            btnDropDownBao.FlatStyle = FlatStyle.Flat;
            btnDropDownBao.FlatAppearance.BorderSize = 0;

            BtnQHuy.FlatStyle = FlatStyle.Flat;
            BtnQHuy.FlatAppearance.BorderSize = 0;
            
            btnDropDownQuan.FlatStyle = FlatStyle.Flat;
            btnDropDownQuan.FlatAppearance.BorderSize = 0;

            BtnDropDownTuanAnh.FlatStyle = FlatStyle.Flat;
            BtnDropDownTuanAnh.FlatAppearance.BorderSize = 0;

            btnDropDownTHuy.FlatStyle = FlatStyle.Flat;
            btnDropDownTHuy.FlatAppearance.BorderSize = 0;

        }

        //Menu drop down
        private void timerSubPanelBao_Tick(object sender, EventArgs e)
        {
            
            if (isSubpanelBaoVisible)
            {
                subPanelBao.Height += 10;
                if(subPanelBao.Height == subPanelBao.MaximumSize.Height)
                {
                    isSubpanelBaoVisible = false;
                    timerSubPanelBao.Stop();
                }
            }
            else
            {
                subPanelBao.Height -= 10;
                if (subPanelBao.Height == subPanelBao.MinimumSize.Height)
                {
                    isSubpanelBaoVisible = true;
                    timerSubPanelBao.Stop();
                }
            }
        }
        private void timerSubPanelQuan_Tick(object sender, EventArgs e)
        {

            if (isSubpanelQuanVisible)
            {
                subPanelQuan.Height += 10;
                if (subPanelQuan.Height == subPanelQuan.MaximumSize.Height)
                {
                    isSubpanelQuanVisible = false;
                    timerSubPanelQuan.Stop();
                }
            }
            else
            {
                subPanelQuan.Height -= 10;
                if (subPanelQuan.Height == subPanelQuan.MinimumSize.Height)
                {
                    isSubpanelQuanVisible = true;
                    timerSubPanelQuan.Stop();
                }
            }
        }

        private void btnDropDownQuan_Click(object sender, EventArgs e)
        {
            timerSubPanelQuan.Start();
        }
        private void btnDropDownBao_Click(object sender, EventArgs e)
        {
            timerSubPanelBao.Start();
        }

        //Scroll Bars property
        private void btnScrollBar_Click(object sender, EventArgs e)
        {
            
            lblTitle.Text = "Scroll Bar";
            
            string text = "The ScrollBars property of the TextBox determines whether and which scroll bars are displayed" + Environment.NewLine +
              "User can choose: None, Vertical, Horizontal and Both\n\n"+
              "Example: \n"+
              "Show horizontal Scroll bars\n"+
              "TextBox.ScrollBars = ScrollBars.Horizontal;\n\n"+
              "Show Both Scroll bars\n"+
              "TextBox.ScrollBars = ScrollBars.Both;";

            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("TextBox.ScrollBars = ScrollBars.Horizontal;") -1, 43);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");

            richTxtDes.Select(text.IndexOf("TextBox.ScrollBars = ScrollBars.Both;")-1,37);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");

            TextBox.Text = "In 1965, David Lewis, a physician and experienced yachtsman, set to work using his own unique philosophy: he took the yacht he had owned for many years and navigated through the islands in order to contact those men who still find their way at sea using traditional methods. He then accompanied these men, in their traditional canoes, on test voyages from which all modern instruments were banished from sight, though Lewis secretly used them to confirm the navigator’s calculations. His most famous such voyage was a return trip of around 1,000 nautical miles between two islands in mid­ocean. Far from drifting, as proposed by Sharp, Lewis found that ancient navigators would have known which course to steer by memorizing which stars rose and set in certain positions along the horizon and this gave them fixed directions by which to steer their boats.";
            btnRun.Hide();
            TextBox.WordWrap = false;
            lblWrapped.Hide();
            RBtnNone.Show();
            RBtnVertical.Show();
            RBtnHorizontal.Show();
            RBtnBoth.Show();
            btnLowercase.Hide();
            btnUppercase.Hide();
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
        }

        private void RBtnVertical_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnVertical.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void RBtnHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnHorizontal.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Horizontal;
            }
            
        }

        private void RBtnBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnBoth.Checked)
            {
                TextBox.ScrollBars = ScrollBars.Both;
            }
        }

        private void RBtnNone_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnNone.Checked)
            {
                TextBox.ScrollBars = ScrollBars.None;
            }
        }

        //WordWrap property
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblWrapped.Show();
            lblTitle.Text = "WordWrap";
            richTxtDes.Text = "";
            string text = "In the previous example (Scroll bar), the text exceeded the length of the textbox, make it hard to read. This example will use WordWrap to prevent that."+
                          "Word wrap help adjusting the position of words at the end of a line to the next line, fit the text only in textbox.\n\n"+
                          "Set property to true: Words will break line if exceed the width.\n"+
                          "Example:\n"+
                          "TextBox.WordWrap = true;\n\n"+
                          "*Note: If this property is set to true, horizontal scroll bars are not displayed regardless of the ScrollBars property setting.";
            TextBox.Text = "In 1965, David Lewis, a physician and experienced yachtsman, set to work using his own unique philosophy: he took the yacht he had owned for many years and navigated through the islands in order to contact those men who still find their way at sea using traditional methods. He then accompanied these men, in their traditional canoes, on test voyages from which all modern instruments were banished from sight, though Lewis secretly used them to confirm the navigator’s calculations. His most famous such voyage was a return trip of around 1,000 nautical miles between two islands in mid­ocean. Far from drifting, as proposed by Sharp, Lewis found that ancient navigators would have known which course to steer by memorizing which stars rose and set in certain positions along the horizon and this gave them fixed directions by which to steer their boats.";

            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("TextBox.WordWrap = true;") - 1, 24);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");

            richTxtDes.Select(text.IndexOf("*Note:") - 1, 5);
            richTxtDes.SelectionFont = new Font(richTxtDes.Font, FontStyle.Bold );
            btnRun.Text = "Activate WordWrap";
            btnRun.Show();
            lblWrapped.Text = "Word Wrap: Off";

            RBtnNone.Show();
            RBtnVertical.Show();
            RBtnHorizontal.Show();
            RBtnBoth.Show();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text == "WordWrap")
            {
                if (lblWrapped.Text == "Word Wrap: Off")
                {
                    TextBox.WordWrap = true;
                    lblWrapped.Text = "Word Wrap: On";
                }
                else if (lblWrapped.Text == "Word Wrap: On")
                {
                    TextBox.WordWrap = false;
                    lblWrapped.Text = "Word Wrap: Off";
                }
            } 
            else if (lblTitle.Text == "DoubleClick")
            {
                if (lblWrapped.Text == "Copy to clipboard")
                {
                    lblWrapped.Text = "MenuStrip";
                }
                else
                {
                    lblWrapped.Text = "Copy to clipboard";
                }
            } 
            else if (lblTitle.Text == "PasswordChar")
            {
                if (change == true)
                {
                    if (TextBox.PasswordChar == '*')
                    {
                        TextBox.PasswordChar = '\0';
                        change = false;
                    }
                }
                else
                {
                    if (TextBox.PasswordChar == '\0' && TextBox.Text != TextBox.Tag.ToString())
                    {
                        TextBox.PasswordChar = '*';
                        change = true;
                    }
                }
            }
            else if(lblTitle.Text == "CharacterCasing")
            {
                TextBox.CharacterCasing = CharacterCasing.Normal;
            }
            if (lblTitle.Text == "Size")
            {
                TextBox.Height -= 40;
            }
            if (lblTitle.Text == "BackColor")
            {
                TextBox.BackColor = Color.Black;
                TextBox.ForeColor = Color.White;
            }
            if (lblTitle.Text == "Text Align")
            {
                if(lblWrapped.Text == "Text Align: left")
                {
                    TextBox.TextAlign = HorizontalAlignment.Center;
                    lblWrapped.Text = "Text Align: center";
                }
                else
                {
                    TextBox.TextAlign = HorizontalAlignment.Left;
                    lblWrapped.Text = "Text Align: left";
                }
                
            }
            if (lblTitle.Text == "MaxLength")
            {
                if(lblWrapped.Text == "Maxlength: none")
                {
                    string maxlength = "\nTextbox above maxlength is 5 now, so user can't enter new word";
                    richTxtDes.Text += maxlength;
                    TextBox.MaxLength = 5;
                    lblWrapped.Text = "Maxlength: 5";
                }
                else 
                {
                    TextBox.MaxLength = 5000;
                    lblWrapped.Text = "Maxlength: none";
                }
                
            }
            if(lblTitle.Text == "Read Only")
            {
                if (lblWrapped.Text == "Read-only : false")
                {
                    TextBox.ReadOnly = true;
                    lblWrapped.Text = "Read-only : true";
                }
                else
                {
                    TextBox.ReadOnly = false;
                    lblWrapped.Text = "Read-only : false";
                }   
            }
            if(lblTitle.Text == "Accept Tab")
            {
                if(lblWrapped.Text == "Accept Tab: Off")
                {
                    TextBox.AcceptsTab = true;
                    lblWrapped.Text = "Accept Tab: On";
                }
                else
                {
                    TextBox.AcceptsTab = false;
                    lblWrapped.Text = "Accept Tab: Off";
                }
            }
            if(lblTitle.Text == "Font")
            {
                Font myFont = new Font("Consolas", 12, FontStyle.Bold | FontStyle.Italic);
                TextBox.Font = myFont;
            }
        }

        //DoubleClick event
        private void btnDoubleClick_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "DoubleClick";
            btnRun.Text = "Change mode";
            TextBox.Text = "In 1965, David Lewis, a physician and experienced yachtsman, set to work using his own unique philosophy: he took the yacht he had owned for many years and navigated through the islands in order to contact those men who still find their way at sea using traditional methods. He then accompanied these men, in their traditional canoes, on test voyages from which all modern instruments were banished from sight, though Lewis secretly used them to confirm the navigator’s calculations. His most famous such voyage was a return trip of around 1,000 nautical miles between two islands in mid­ocean. Far from drifting, as proposed by Sharp, Lewis found that ancient navigators would have known which course to steer by memorizing which stars rose and set in certain positions along the horizon and this gave them fixed directions by which to steer their boats.";
            string text = "DoubleClick event triggers when a user clicks on the TextBox twice.\n" +
                "Example: When double click the text in the textbox, it will select all and copy to clipboard.\n" +
                "Example2: Show ContextMenuStrip when double click.";
            richTxtDes.Text = text;
            lblWrapped.Text = "Copy to clipboard";
            lblWrapped.Show();
            btnRun.Show();

            RBtnNone.Show();
            RBtnVertical.Show();
            RBtnHorizontal.Show();
            RBtnBoth.Show();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }
        

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            if(lblWrapped.Text == "Copy to clipboard")
            {
                TextBox.SelectAll();
                Clipboard.SetText(TextBox.Text);
            }else if(lblWrapped.Text == "MenuStrip")
            {
                Point cursor = new Point((Size)Cursor.Position);
                ctxtMenuStrip.Show(cursor);
            }
        }

        //Character Casing property
        private void btnCharCasing_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "CharacterCasing";
            btnRun.Text = "Normal";
            btnRun.Show();

            string text = "Character casing refers to the way letters are written in terms of their uppercase or lowercase form.\n"+
                          "Types of Character Casing: Uppercase, Lowercase and Normal\n\n"+
                          "Example:\n"+
                          "Change word in textbox to Uppercase.\n"+
                          "TextBox.CharacterCasing = CharacterCasing.Upper;\n\n"+
                          "Lowercase.\n"+
                          "textBox.CharacterCasing = CharacterCasing.Lower;";

            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("TextBox.CharacterCasing = CharacterCasing.Upper;") - 1, 48);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");

            richTxtDes.Select(text.IndexOf("textBox.CharacterCasing = CharacterCasing.Lower;") -1 , 48);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");

            btnUppercase.Show();
            btnLowercase.Show();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            RBtnNone.Hide();
        }
        private void btnUppercase_Click(object sender, EventArgs e)
        {
            TextBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnLowercase_Click(object sender, EventArgs e)
        {
            TextBox.CharacterCasing = CharacterCasing.Lower;
        }

        //Q.Huy | PasswordChar, enter - leave event 
        private void BtnQHuy_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            btnRun.Text = "Show/Hide word";
            
            string text = "Use Textchange to count number of character on text Box\n" +
                          "Use PasswordChar to hide the characters the user enters";
            richTxtDes.Text = text;
            lblTitle.Text = "PasswordChar";
            lblWrapped.Text = "The number of characters you enter textBox is:";
            btnRun.Show();
            lblWrapped.Show();

            RBtnNone.Hide();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.Text == TextBox.Tag.ToString())
            {
                length = 0;
            }
            else
            {
                length = TextBox.Text.Length;
            }

            lblWrapped.Text = Tlbl4 + length;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if(btnRun.Text == "Show/Hide word")
            {
                if (TextBox.Text == TextBox.Tag.ToString())
                {
                    TextBox.Text = "";
                    TextBox.ForeColor = Color.Black;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (btnRun.Text == "Show/Hide word")
            {
                if (TextBox.Text.Trim() == "")
                {
                    TextBox.Text = TextBox.Tag.ToString();
                    TextBox.ForeColor = Color.Silver;
                }
                lblWrapped.Text = Tlbl4 + length;
            }
        }

        //Minh Quan - Properties
        
        private void TextBox_MouseHover(object sender, EventArgs e)
        {
            if (lblTitle.Text == "ForeColor")
            {
                TextBox.ForeColor = Color.Red;
            }
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            if (lblTitle.Text == "ForeColor")
            {
                TextBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "Size";
            if (lblTitle.Text == "Size")
            {
                TextBox.Size = new Size(510, 131);
                TextBox.ForeColor = SystemColors.ControlText;
                TextBox.BackColor = SystemColors.Window;
            }
            btnRun.Show();
            btnRun.Text = "Run";
            lblWrapped.Hide();
            richTxtDes.Text = "To set the size of a TextBox in WinForms, you can use the Size " +
                "\n or width and Height properties " +
                "\n expamle:  textBox1.Height -= 40";

            RBtnNone.Hide();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "ForeColor";
            if (lblTitle.Text == "ForeColor")
            {
                TextBox.Size = new Size(510, 131);
                TextBox.ForeColor = SystemColors.ControlText;
                TextBox.BackColor = SystemColors.Window;
            }
            btnRun.Hide();
            richTxtDes.Text = "-To set the foreground color of a TextBox in WinForms," +
                "\n     you can use the ForeColor property." +
                "\n     Adjust text color in MouseEnter and MouseLeave events" +
                "\n     textBox1.ForeColor = SystemColors.ControlText;" +
                "\n" +
                "\n private void textBox1_MouseHover(object sender, EventArgs e)" +
                "\n     if (lblTitle.Text == \"ForeColor\"){" +
                "\n         textBox1.ForeColor = Color.Red; }" +
                "\n     }" +
                "\n" +
                "\n private void textBox1_MouseLeave(object sender, EventArgs e) {" +
                "\n     if (lblTitle.Text == \"ForeColor\"){ " +
                "\n         textBox1.ForeColor = SystemColors.ControlText; }" +
                "\n     }";

            RBtnNone.Hide();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            lblWrapped.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "BackColor";
            if (lblTitle.Text == "BackColor")
            {
                TextBox.Size = new Size(510, 131);
                TextBox.ForeColor = SystemColors.ControlText;
                TextBox.BackColor = SystemColors.Window;
            }
            btnRun.Show();
            richTxtDes.Text = "In WinForms, the BackColor property of a control " +
                "\n such as TextBox is used to set the background color of that control." +
                "\n You can change the value of BackColor to customize the control's background color as desired." +
                "\n" +
                "\n textBox1.BackColor = Color.Black;" +
                "\n textBox1.ForeColor = SystemColors.ControlText;";

            RBtnNone.Hide();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            lblWrapped.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }

        private void btnTextAlign_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "Text Align";
            if (lblTitle.Text == "Text Align")
            {
                TextBox.Size = new Size(510, 131);
                TextBox.ForeColor = SystemColors.ControlText;
                TextBox.BackColor = SystemColors.Window;
            }
            lblWrapped.Show();
            lblWrapped.Text = "Text Align: left";
            btnRun.Show();
            btnRun.Text = "Run";
            richTxtDes.Text = "The WinForms TextAlign property is used to set the alignment of text inside a control" +
                " \n such as a TextBox or Label." +
                "\n The value of TextAlign can be one of the values of the ContentAlignment or HorizontalAlign data type " +
                "\n Common values include:" +
                "\n TopLeft: Align text to the top and left." +
                "\n TopCenter: Aligns text at the top and center horizontally." +
                "\n TopRight: Align text above and to the right." +
                "\n MiddleLeft: Aligns text vertically to the middle and to the left." +
                "\n MiddleCenter: Aligns text to the center in both dimensions." +
                "\n MiddleRight: Align text vertically center and right." +
                "\n BottomLeft: Align text to the bottom and left." +
                "\n BottomCenter: Aligns text at the bottom and center horizontally." +
                "\n BottomRight: Align text to the bottom and right." +
                "\n" +
                "\n textBox1.TextAlign = HorizontalAlignment.Center;";
            RBtnNone.Hide();
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            btnLowercase.Hide();
            btnUppercase.Hide();
        }

        //Tuan Anh
        private void timerSubPanelTuanAnh_Tick(object sender, EventArgs e)
        {
            if (isSubpanelTuanAnhVisible)
            {
                subPanelTuanAnh.Height += 10;
                if (subPanelTuanAnh.Height == subPanelTuanAnh.MaximumSize.Height)
                {
                    isSubpanelTuanAnhVisible = false;
                    timerSubPanelTuanAnh.Stop();
                }
            }
            else
            {
                subPanelTuanAnh.Height -= 10;
                if (subPanelTuanAnh.Height == subPanelTuanAnh.MinimumSize.Height)
                {
                    isSubpanelTuanAnhVisible = true;
                    timerSubPanelTuanAnh.Stop();
                }
            }
        }

        private void BtnDropDownTuanAnh_Click(object sender, EventArgs e)
        {
            timerSubPanelTuanAnh.Start();
        }

        private void btnTabIndex_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = true;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;


            string text = "The index value of the control within the set of controls within its container. The controls in the container are included in the tab order.\n" +
                "Textbox1.TabIndex = 1;\nTextbox1.TabStop = true;";


            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("Textbox1.TabIndex = 1;\nTextbox1.TabStop = true;") - 1, 48);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
        }
        private void btnMouseEvent_Click(object sender, EventArgs e)
        {
            pnlMouseEvent.Show();

            pnlMouseEvent.Visible = true;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;

            string text = "List of common Mouse Event:\n" +
                "private void textBox1_Enter(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n" +
                "private void textBox1_Hover(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n" +
                "private void textBox1_Click(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n" +
                "private void textBox1_DoubleClick(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n" +
                "private void textBox1_Leave(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n";


            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("private void textBox1_Enter(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n") - 1, 60);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
            richTxtDes.Select(text.IndexOf("private void textBox1_Hover(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n") - 1, 60);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
            richTxtDes.Select(text.IndexOf("private void textBox1_Click(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n") - 1, 60);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
            richTxtDes.Select(text.IndexOf("private void textBox1_DoubleClick(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n") - 1, 60);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
            richTxtDes.Select(text.IndexOf("private void textBox1_Leave(object sender, EventArgs e)\r\n        {\r\n\r\n        \n}\n") - 1, 60);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
        }

        private void btnKeyEvent_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = true;
            pnlVisible.Visible = false;

            string text = "Key Event consists of 4 events: KeyDown, KeyPress, KeyUp and PreviewKeyDown\n" +
                "A key event will be orcurred when an approriate key is pressed, held or released\n" +
                "To set an event to a key, use the ASCII character number\n" +
                "if (e.KeyChar == 32)\r\n            {\r\n                SpaceCount += 1;\r\n                lblSpaceCount.Text = \"You Press Spacebar \" + SpaceCount + \" time (s)!\";\r\n            }";

            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("if (e.KeyChar == 32)\r\n            {\r\n                SpaceCount += 1;\r\n                lblSpaceCount.Text = \"You Press Spacebar \" + SpaceCount + \" time (s)!\";\r\n            }") - 1, 1000);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = true;

            string text = "A textbox can be visible or not due to property change\n" +
                "You can change the visible property via code\n" +
                "if(textBox12.Text==\"YES\")\r\n            {\r\n                label5.Visible = true;\r\n            }";

            richTxtDes.Text = text;
            richTxtDes.Select(text.IndexOf("if(textBox12.Text==\"YES\")\r\n            {\r\n                label5.Visible = true;\r\n            }") - 1, 1000);
            richTxtDes.SelectionFont = new Font("Consolas", richTxtDes.Font.Size, richTxtDes.Font.Style);
            richTxtDes.SelectionColor = ColorTranslator.FromHtml("#0077A");
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBoxIndex2.Text = "Hello! If you press Tab with my Textbox TabStop == true. You can Press Tab again to switch to Tab Index = 3";
            textBoxIndex3.Text = "My tab Index = 3!";
            textBoxIndex4.Text = "My tab Index = 4!";


        }

        private void textBoxIndex1_Enter(object sender, EventArgs e)
        {
            textBoxIndex1.Text = "Press Tab in me!";
        }

        private void textBoxIndex4_Enter(object sender, EventArgs e)
        {
            textBoxIndex5.Text = "My tab Index = 5! But you can't press Tab to switch to me due to my TabStop == false";
        }
        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Text = "Hello!";
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "Hello!";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "Hello!";
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = "You leave me!";
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "Hello!";
        }

        private void textBox1_MouseLeave_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                SpaceCount += 1;
                lblSpaceCount.Text = "You Press Spacebar " + SpaceCount + " time (s)!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpaceCount = 0;
            lblSpaceCount.Text = "Press Space in Textbox!";
            textBox11.Text = "";
            textBox11.Focus();
        }

        private void chkAcpt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcpt.Checked)
            {
                textBox12.Visible = true;
                lblYES.Visible = true;
                btnSubmit.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "YES")
            {
                label5.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
        }
        //Trung Huy
        private void timerSubPanelTrungHuy_Tick(object sender, EventArgs e)
        {
            if (isSubpanelTrungHuyVisible)
            {
                subPanelTrungHuy.Height += 10;
                if (subPanelTrungHuy.Height == subPanelTrungHuy.MaximumSize.Height)
                {
                    isSubpanelTrungHuyVisible = false;
                    timerSubPanelTrungHuy.Stop();
                }
            }
            else
            {
                subPanelTrungHuy.Height -= 10;
                if (subPanelTrungHuy.Height == subPanelTrungHuy.MinimumSize.Height)
                {
                    isSubpanelTrungHuyVisible = true;
                    timerSubPanelTrungHuy.Stop();
                }
            }
        }

        private void btnDropDownTHuy_Click(object sender, EventArgs e)
        {
            timerSubPanelTrungHuy.Start();
        }

        private void btnMaxLength_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "MaxLength";
            btnRun.Show();
            TextBox.Text = "// Set the maximum length of text in the control to 5"+ Environment.NewLine +
                "textBox1.MaxLength = 5;"+ Environment.NewLine +
                "-This code will limit the characters entered in the textbox"+ Environment.NewLine +
                "-You can press run to run the code and type something in the box below";
            richTxtDes.Text = "Example";
            lblWrapped.Text = "Maxlength: none";
            lblWrapped.Show();
            btnRun.Text = "Run";

            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            RBtnNone.Hide();

        }

        private void btnReadOnly_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblWrapped.Show();
            lblTitle.Text = "Read Only";
            richTxtDes.Text = "This will set the textbox to read-only mode and will not be able to edit content" + Environment.NewLine +
                            "Set read-only property to true" + Environment.NewLine +
                           "TextBox.ReadOnly = true;";
            lblWrapped.Text = "Read-only : false";
            btnRun.Show();
            btnRun.Text = "Run";
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnBoth.Hide();
            RBtnNone.Hide();
        }

        private void btnAcceptTab_Click(object sender, EventArgs e)
        {
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
            lblTitle.Text = "Accept Tab";
            lblWrapped.Show();
            lblWrapped.Text = "Accept Tab: Off";
            btnRun.Text = "Run";
            btnRun.Show();

            richTxtDes.Text = "Accept tab allows user to use Tab key in the textBox\n" +
                              "TextBox.AcceptTab = false; //deativate Accept Tab and user won't be able to use Tab in textbox ";
            
            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnNone.Hide();
            RBtnBoth.Hide();
        }

        private void btnFontsize_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Font";
            
            lblWrapped.Hide();
            richTxtDes.Text = "//Example code\n" +
                "Font myFont = new Font(\"Arial\", 12, FontStyle.Bold | FontStyle.Italic);\n\n" +
                "-In the example above:\n " +
                "Arial is the font name\n" +
                "12 is the font size.\n" +
                "FontStyle.Bold | FontStyle.Italic defines the font style, which in this field is bold and italic.";


            RBtnVertical.Hide();
            RBtnHorizontal.Hide();
            RBtnNone.Hide();
            RBtnBoth.Hide();
            pnlTabIndex.Visible = false;
            pnlMouseEvent.Visible = false;
            pnlKeyEvent.Visible = false;
            pnlVisible.Visible = false;
        }
    }
}
