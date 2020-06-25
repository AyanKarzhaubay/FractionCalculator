using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractionCalculator
{
    public partial class FractionCalculator : Form
    {
        public FractionCalculator()
        {
            
            InitializeComponent();
        }
        //panel1 elements events
        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction f1 = new Fraction
                {
                    n = Convert.ToInt32(f1nTextBox.Text),
                    d = Convert.ToInt32(f1dTextBox.Text)
                };
                Fraction f2 = new Fraction
                {
                    n = Convert.ToInt32(f2nTextBox.Text),
                    d = Convert.ToInt32(f2dTextBox.Text)
                };
                Fraction r = new Fraction();
                string selectedOperation = operationsComboBox.SelectedItem.ToString();
                switch (selectedOperation)
                {
                    case "+": r = f1 + f2; break;
                    case "-": r = f1 - f2; break;
                    case "*": r = f1 * f2; break;
                    case "/": r = f1 / f2; break;
                }
                rnTextBox.Text = r.n.ToString();
                rdTextBox.Text = r.d.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeFromMixedToImprorer_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction f = new Fraction
                {
                    a = Convert.ToInt32(integerPartTextBox.Text),
                    n = Convert.ToInt32(mfnTextBox.Text),
                    d = Convert.ToInt32(mfdTextBox.Text)
                };
                f.ConvertToImprorerFraction();
                rImprorerfnTextBox.Text = f.n.ToString();
                rImprorerfdTextBox.Text = f.d.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeFromImprorerToMixed_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction f = new Fraction
                {
                    n = Convert.ToInt32(improrerfnTextBox.Text),
                    d = Convert.ToInt32(improrerfdTextBox.Text)
                };
                f.ConvertToMixedFraction();
                rintegerPartTextBox.Text = f.a.ToString();
                rmfnTextBox.Text = f.n.ToString();
                rmfdTextBox.Text = f.d.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                executeButton.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void exeFMTI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeFromMixedToImprorer.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void exeFITM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeFromImprorerToMixed.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        //panel2 elements events
        private void exeGCF_Click(object sender, EventArgs e)
        {
            try
            {
                rGCFTextBox.Text = MathHelper.GCF(Convert.ToInt32(aGCFTextBox.Text), Convert.ToInt32(bGCFTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeLCM_Click(object sender, EventArgs e)
        {
            try
            {
                rLCMTextBox.Text = MathHelper.LCM(Convert.ToInt32(aLCMTextBox.Text), Convert.ToInt32(bLCMTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeGCFForThreeNumber_Click(object sender, EventArgs e)
        {
            try
            {
                threeRGCFTextBox.Text = MathHelper.GCF(MathHelper.GCF(Convert.ToInt32(threeAGCFTextBox.Text), Convert.ToInt32(threeBGCFTextBox.Text)), Convert.ToInt32(threeCGCFTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeLCMFForThreeNumber_Click(object sender, EventArgs e)
        {
            try
            {
                threeRLCMTextBox.Text = MathHelper.LCM(MathHelper.LCM(Convert.ToInt32(threeALCMTextBox.Text), Convert.ToInt32(threeBLCMTextBox.Text)), Convert.ToInt32(threeCLCMTextBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeGCFForFourNumber_Click(object sender, EventArgs e)
        {
            try
            {
                fourRGCFTextBox.Text = MathHelper.GCF(MathHelper.GCF(Convert.ToInt32(fourAGCFTextBox.Text), Convert.ToInt32(fourBGCFTextBox.Text)), MathHelper.GCF(Convert.ToInt32(fourCGCFTextBox.Text), Convert.ToInt32(fourDGCFTextBox.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exeLCMForFourNumber_Click(object sender, EventArgs e)
        {
            try
            {
                fourRLCMTextBox.Text = MathHelper.LCM(MathHelper.LCM(Convert.ToInt32(fourALCMTextBox.Text), Convert.ToInt32(fourBLCMTextBox.Text)), MathHelper.LCM(Convert.ToInt32(fourCLCMTextBox.Text), Convert.ToInt32(fourDLCMTextBox.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void twoGCFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeGCF.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void twoLCMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeLCM.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void threeGCFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeGCFForThreeNumber.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void threeLCMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeLCMFForThreeNumber.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void fourGCFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeGCFForFourNumber.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        private void fourLCMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                exeLCMForFourNumber.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                clearToolStripMenuItem.PerformClick();
            }
        }

        //main events
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1
            f1IntegerPartTextBox.Text = "0";
            f1nTextBox.Text = "";
            f1dTextBox.Text = "";

            f1IntegerPartTextBox.Text = "0";
            f2nTextBox.Text = "";
            f2dTextBox.Text = "";

            rnTextBox.Text = "";
            rdTextBox.Text = "";

            integerPartTextBox.Text = "";
            mfnTextBox.Text = "";
            mfdTextBox.Text = "";
            rImprorerfnTextBox.Text = "";
            rImprorerfdTextBox.Text = "";

            improrerfnTextBox.Text = "";
            improrerfdTextBox.Text = "";
            rintegerPartTextBox.Text = "";
            rmfnTextBox.Text = "";
            rmfdTextBox.Text = "";

            //panel2
            rGCFTextBox.Text = "";
            aGCFTextBox.Text = "";
            bGCFTextBox.Text = "";

            rLCMTextBox.Text = "";
            aLCMTextBox.Text = "";
            bLCMTextBox.Text = "";

            threeRGCFTextBox.Text = "";
            threeAGCFTextBox.Text = "";
            threeBGCFTextBox.Text = "";
            threeCGCFTextBox.Text = "";

            threeRLCMTextBox.Text = "";
            threeALCMTextBox.Text = "";
            threeBLCMTextBox.Text = "";
            threeCLCMTextBox.Text = "";

            fourRGCFTextBox.Text = "";
            fourAGCFTextBox.Text = "";
            fourBGCFTextBox.Text = "";
            fourCGCFTextBox.Text = "";
            fourDGCFTextBox.Text = "";

            fourRLCMTextBox.Text = "";
            fourALCMTextBox.Text = "";
            fourBLCMTextBox.Text = "";
            fourCLCMTextBox.Text = "";
            fourDLCMTextBox.Text = "";
        }

        private void gCFAndLCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(12, 32);
            panel2.Size = new System.Drawing.Size(815, 460);
            panel1.Location = new Point(1000, 500);
            panel1.Size = new System.Drawing.Size(1, 1);
        }

        private void fractionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 32);
            panel1.Size = new System.Drawing.Size(815, 460);
            panel2.Location = new Point(1000, 500);
            panel2.Size = new System.Drawing.Size(1, 1);
        }

        private void FractionCalculator_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 32);
            panel2.Location = new Point(1000, 500);
            panel2.Size = new System.Drawing.Size(1, 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
