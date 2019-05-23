using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HedgeLib.RFL;
using HedgeLib.Misc;

namespace Sonic_Forces_Caption_Editor
{
    public partial class Form1 : Form
    {
        //Setup Variables
        ForcesText textCaption = new ForcesText();
        ForcesText textCaptionDLC = new ForcesText();

        ForcesCaptionParam captionRFL = new ForcesCaptionParam();
        int captionIndex = 0;
        int lineIndex = 0;

        public Form1()
        {
            //textCaption.Load(@"G:\Utilities\Hedgehog Engine Titles\Sonic Forces Dump\text\text_caption_en\text_caption.cnvrs-text");
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog rflBrowser = new OpenFileDialog();
            rflBrowser.Title = "Select Caption RFL";
            rflBrowser.Filter = "Sonic Forces Caption File (*.rfl)|*.rfl";
            rflBrowser.FilterIndex = 1;
            rflBrowser.RestoreDirectory = true;
            if (rflBrowser.ShowDialog() == DialogResult.OK)
            {
                //Load RFL
                captionRFL.Load(rflBrowser.FileName);
                captionIndex = 0;
                lineIndex = 0;

                //Enable Boxes for Editing
                nameBox.Enabled = true;
                typeBox.Enabled = true;
                talkingBox.Enabled = true;
                delayBox.Enabled = true;
                firstCharBox.Enabled = true;
                firstCharAnimBox.Enabled = true;
                secondCharBox.Enabled = true;
                secondCharAnimBox.Enabled = true;
                nextButton.Enabled = true;
                nextLineButton.Enabled = true;

                loadCaptionParams();
            }
        }

        private void loadCaptionParams()
        {
            infoLabel.Text = "Caption " + captionIndex + "/" + 9; //Show which Caption is loaded.
            lineInfoLabel.Text = "Line " + lineIndex + "/" + 19; //Show which Line of the Caption is loaded.
            nameBox.Text = captionRFL.Captions[captionIndex].Lines[lineIndex].Name; //Show the name of the voice file to play.
            typeBox.SelectedIndex = typeBox.FindStringExact(captionRFL.Captions[captionIndex].Lines[lineIndex].LineType.ToString()); //Show the type of subtitle to use.
            talkingBox.Text = captionRFL.Captions[captionIndex].Lines[lineIndex].TalkingCharacter.ToString(); //Show the talking character, used for World Map conversations
            delayBox.Text = captionRFL.Captions[captionIndex].Lines[lineIndex].UnknownFloat1.ToString(); //Show the unknown float 1 value, which appears to be delay between lines.
            firstCharBox.SelectedIndex = firstCharBox.FindStringExact(captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter.ToString()); //Show the First Character.
            firstCharAnimBox.SelectedIndex = firstCharAnimBox.FindStringExact(captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation.ToString()); //Show the First Character's animation.
            secondCharBox.SelectedIndex = secondCharBox.FindStringExact(captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter.ToString()); //Show the Second Character, used for World Map conversations
            secondCharAnimBox.SelectedIndex = secondCharAnimBox.FindStringExact(captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation.ToString()); //Show the Second Character's animation, used for World Map conversations

            var foundLine = false;

            if (textCaption != null)
            {
                foreach (var sheet in textCaption.Sheets)
                {
                    foreach (var cell in sheet.Cells)
                    {
                        if (cell.Name == captionRFL.Captions[captionIndex].Lines[lineIndex].Name)
                        {
                            foundLine = true;
                            subtitleLabel.Text = cell.Data;
                        }
                    }
                }
                if (!foundLine)
                {
                    subtitleLabel.Text = "Unknown/Empty Line";
                }
            }

            if (textCaptionDLC != null)
            {
                foreach (var sheet in textCaptionDLC.Sheets)
                {
                    foreach (var cell in sheet.Cells)
                    {
                        if (cell.Name == captionRFL.Captions[captionIndex].Lines[lineIndex].Name)
                        {
                            foundLine = true;
                            subtitleLabel.Text = cell.Data;
                        }
                    }
                }
                if (!foundLine)
                {
                    subtitleLabel.Text = "Unknown/Empty Line";
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            lineIndex = 0;
            captionIndex++;
            previousLineButton.Enabled = false;
            nextLineButton.Enabled = true;

            if (captionIndex == 9)
            {
                nextButton.Enabled = false;
            }
            previousButton.Enabled = true;
            loadCaptionParams();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            lineIndex = 0;
            captionIndex--;
            previousLineButton.Enabled = false;
            nextLineButton.Enabled = true;

            if (captionIndex == 0)
            {
                previousButton.Enabled = false;
            }
            nextButton.Enabled = true;
            loadCaptionParams();
        }

        private void NextLineButton_Click(object sender, EventArgs e)
        {
            lineIndex++;
            if (lineIndex == 19)
            {
                nextLineButton.Enabled = false;
            }
            previousLineButton.Enabled = true;
            loadCaptionParams();
        }

        private void PreviousLineButton_Click(object sender, EventArgs e)
        {
            lineIndex--;
            if (lineIndex == 0)
            {
                previousLineButton.Enabled = false;
            }
            nextLineButton.Enabled = true;
            loadCaptionParams();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            captionRFL.Captions[captionIndex].Lines[lineIndex].Name = nameBox.Text;
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeBox.SelectedIndex == 0) { captionRFL.Captions[captionIndex].Lines[lineIndex].LineType = ForcesCaptionParam.Line.LineTypes.Subtitle; }
            if (typeBox.SelectedIndex == 1) { captionRFL.Captions[captionIndex].Lines[lineIndex].LineType = ForcesCaptionParam.Line.LineTypes.Radio; }
            if (typeBox.SelectedIndex == 2) { captionRFL.Captions[captionIndex].Lines[lineIndex].LineType = ForcesCaptionParam.Line.LineTypes.SoundEffect; }
        }

        private void TalkingBox_TextChanged(object sender, EventArgs e)
        {
            captionRFL.Captions[captionIndex].Lines[lineIndex].TalkingCharacter = UInt64.Parse(talkingBox.Text);
        }

        private void DelayBox_TextChanged(object sender, EventArgs e)
        {
            captionRFL.Captions[captionIndex].Lines[lineIndex].UnknownFloat1 = UInt64.Parse(delayBox.Text);
        }

        private void FirstCharBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstCharBox.SelectedIndex == 0) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Amy; }
            if (firstCharBox.SelectedIndex == 1) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Charmy; }
            if (firstCharBox.SelectedIndex == 2) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Eggman; }
            if (firstCharBox.SelectedIndex == 3) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Espio; }
            if (firstCharBox.SelectedIndex == 4) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Knuckles; }
            if (firstCharBox.SelectedIndex == 5) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Rouge; }
            if (firstCharBox.SelectedIndex == 6) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Shadow; }
            if (firstCharBox.SelectedIndex == 7) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Silver; }
            if (firstCharBox.SelectedIndex == 8) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Sonic; }
            if (firstCharBox.SelectedIndex == 9) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Tails; }
            if (firstCharBox.SelectedIndex == 10) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Vector; }
            if (firstCharBox.SelectedIndex == 11) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Soldier; }
            if (firstCharBox.SelectedIndex == 12) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.BirdSoldier; }
            if (firstCharBox.SelectedIndex == 13) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.MustacheSoldier; }
            if (firstCharBox.SelectedIndex == 14) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.CustomHero; }
            if (firstCharBox.SelectedIndex == 15) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.ClassicSonic; }
            if (firstCharBox.SelectedIndex == 16) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Infinite; }
            if (firstCharBox.SelectedIndex == 17) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.Omega; }
            if (firstCharBox.SelectedIndex == 18) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharacter = ForcesCaptionParam.Line.CharacterTypes.None; }
        }

        private void FirstCharAnimBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstCharAnimBox.SelectedIndex == 0) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.AngryTalk; }
            if (firstCharAnimBox.SelectedIndex == 1) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.BaseTalk; }
            if (firstCharAnimBox.SelectedIndex == 2) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SadTalk; }
            if (firstCharAnimBox.SelectedIndex == 3) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.HappyTalk; }
            if (firstCharAnimBox.SelectedIndex == 4) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SurpriseTalk; }
            if (firstCharAnimBox.SelectedIndex == 5) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.AngryIdle; }
            if (firstCharAnimBox.SelectedIndex == 6) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.BaseIdle; }
            if (firstCharAnimBox.SelectedIndex == 7) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SadIdle; }
            if (firstCharAnimBox.SelectedIndex == 8) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.HappyIdle; }
            if (firstCharAnimBox.SelectedIndex == 9) { captionRFL.Captions[captionIndex].Lines[lineIndex].FirstCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SurpriseIdle; }
        }

        private void SecondCharBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondCharBox.SelectedIndex == 0) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Amy; }
            if (secondCharBox.SelectedIndex == 1) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Charmy; }
            if (secondCharBox.SelectedIndex == 2) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Eggman; }
            if (secondCharBox.SelectedIndex == 3) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Espio; }
            if (secondCharBox.SelectedIndex == 4) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Knuckles; }
            if (secondCharBox.SelectedIndex == 5) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Rouge; }
            if (secondCharBox.SelectedIndex == 6) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Shadow; }
            if (secondCharBox.SelectedIndex == 7) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Silver; }
            if (secondCharBox.SelectedIndex == 8) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Sonic; }
            if (secondCharBox.SelectedIndex == 9) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Tails; }
            if (secondCharBox.SelectedIndex == 10) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Vector; }
            if (secondCharBox.SelectedIndex == 11) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Soldier; }
            if (secondCharBox.SelectedIndex == 12) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.BirdSoldier; }
            if (secondCharBox.SelectedIndex == 13) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.MustacheSoldier; }
            if (secondCharBox.SelectedIndex == 14) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.CustomHero; }
            if (secondCharBox.SelectedIndex == 15) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.ClassicSonic; }
            if (secondCharBox.SelectedIndex == 16) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Infinite; }
            if (secondCharBox.SelectedIndex == 17) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.Omega; }
            if (secondCharBox.SelectedIndex == 18) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharacter = ForcesCaptionParam.Line.CharacterTypes.None; }
        }

        private void SecondCharAnimBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondCharAnimBox.SelectedIndex == 0) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.AngryTalk; }
            if (secondCharAnimBox.SelectedIndex == 1) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.BaseTalk; }
            if (secondCharAnimBox.SelectedIndex == 2) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SadTalk; }
            if (secondCharAnimBox.SelectedIndex == 3) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.HappyTalk; }
            if (secondCharAnimBox.SelectedIndex == 4) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SurpriseTalk; }
            if (secondCharAnimBox.SelectedIndex == 5) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.AngryIdle; }
            if (secondCharAnimBox.SelectedIndex == 6) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.BaseIdle; }
            if (secondCharAnimBox.SelectedIndex == 7) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SadIdle; }
            if (secondCharAnimBox.SelectedIndex == 8) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.HappyIdle; }
            if (secondCharAnimBox.SelectedIndex == 9) { captionRFL.Captions[captionIndex].Lines[lineIndex].SecondCharAnimation = ForcesCaptionParam.Line.AnimationTypes.SurpriseIdle; }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog captionSave = new SaveFileDialog();
            captionSave.Title = "Save Caption RFL";
            captionSave.Filter = "Sonic Forces Caption File (*.rfl)|*.rfl";
            captionSave.FilterIndex = 1;
            captionSave.RestoreDirectory = true;
            if (captionSave.ShowDialog() == DialogResult.OK)
            {
                captionRFL.Save(captionSave.FileName, true);
            }
        }

        private void BaseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog cnvrsBrowser = new OpenFileDialog();
            cnvrsBrowser.Title = "Select Base Game CNVRS";
            cnvrsBrowser.Filter = "Sonic Forces Text File (*.cnvrs-text)|*.cnvrs-text";
            cnvrsBrowser.FilterIndex = 1;
            cnvrsBrowser.RestoreDirectory = true;
            if (cnvrsBrowser.ShowDialog() == DialogResult.OK)
            {
                //Load RFL
                baseGameToolStripMenuItem.Checked = true;
                textCaption.Load(cnvrsBrowser.FileName);

                //if (captionRFL != null) { loadCaptionParams(); }
            }
        }

        private void EpisodeShadowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog cnvrsBrowser = new OpenFileDialog();
            cnvrsBrowser.Title = "Select Episode Shadow CNVRS";
            cnvrsBrowser.Filter = "Sonic Forces Text File (*.cnvrs-text)|*.cnvrs-text";
            cnvrsBrowser.FilterIndex = 1;
            cnvrsBrowser.RestoreDirectory = true;
            if (cnvrsBrowser.ShowDialog() == DialogResult.OK)
            {
                //Load RFL
                episodeShadowToolStripMenuItem.Checked = true;
                textCaptionDLC.Load(cnvrsBrowser.FileName);

                //if (captionRFL != null) { loadCaptionParams(); }
            }
        }
    }
}
