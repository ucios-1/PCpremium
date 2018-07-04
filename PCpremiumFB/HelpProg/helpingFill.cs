using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCpremiumFB.HelpProg
{
    public class helpingFill : UIform
    {
        public void fComCase(UIform uif, string needle)
        {
            if (needle == "USFF") { uif.rbUSFF.Checked = true; }
            else if (needle == "SFF") { uif.rbSFF.Checked = true; }
            else if (needle == "Desktop") { uif.rbDesktop.Checked = true; }
            else if (needle == "Tower") { uif.rbTower.Checked = true; }
        }

        public void fDisc1Type(UIform uif, string needle)
        {
            if (needle == "SSD") { uif.rbSSD.Checked = true; }
            else if (needle == "HDD") { uif.rbHDD.Checked = true; }
            else if (needle == "SSHD") { uif.rbSSHD.Checked = true; }
        }

        public void fDisc1Old(UIform uif, string needle)
        {
            if (needle == "nowy") { uif.rbNowy.Checked = true; }
            else if (needle == "używany") { uif.rbUzywany.Checked = true; }
        }

        public void fDisc2Type(UIform uif, string needle)
        {
            if (needle == "SSD") { uif.rbSSD2.Checked = true; }
            else if (needle == "HDD") { uif.rbHDD2.Checked = true; }
            else if (needle == "SSHD") { uif.rbSSHD2.Checked = true; }
        }

        public void fDisc2Old(UIform uif, string needle)
        {
            if (needle == "nowy") { uif.rbNowy2.Checked = true; }
            else if (needle == "używany") { uif.rbUzywany2.Checked = true; }
        }

        public void fCD(UIform uif, string needle)
        {
            if (needle == "Brak") { uif.rbBrak.Checked = true; }
            else if (needle == "COMBO") { uif.rbCombo.Checked = true; }
            else if (needle == "DVD") { uif.rbDVD.Checked = true; }
            else if (needle == "DVD-RW") { uif.rbDVD_RW.Checked = true; }
        }

        public void fComSystem(UIform uif, string needle)
        {
            if (needle == "OS") { uif.rbOS.Checked = true; }
            else if (needle == "7") { uif.rb7.Checked = true; }
            else if (needle == "8") { uif.rb8.Checked = true; }
            else if (needle == "10") { uif.rb10.Checked = true; }
            else if (needle == "XP") { uif.rbXP.Checked = true; }
            else if (needle == "VISTA") { uif.rbVISTA.Checked = true; }
        }

        public void fComSystemBit(UIform uif, string needle)
        {
            if (needle == "64") { uif.rb64.Checked = true; }
            else if (needle == "32") { uif.rb32.Checked = true; }
        }

        public void fComSystemHmPr(UIform uif, string needle)
        {
            if (needle == "PRO") { uif.rbPro.Checked = true; }
            else if (needle == "HOME") { uif.rbHome.Checked = true; }
        }

        public void fComSystemB(UIform uif, string needle)
        {
            if (needle == "BI") { uif.rbBI.Checked = true; }
            else if (needle == "BL") { uif.rbBL.Checked = true; }
        }

        public void fComSystemOrig(UIform uif, string needle)
        {
            if (needle == "Original") { uif.rbOriginal.Checked = true; }
            else if (needle == "MAR") { uif.rbMAR.Checked = true; }
            else if (needle == "OEM") { uif.rbOEM.Checked = true; }
        }

        public void fPayment(UIform uif, string needle)
        {
            if (needle == "sklep") { uif.rbSklep.Checked = true; }
            else if (needle == "e-sklep") { uif.rbESklep.Checked = true; }
            else if (needle == "allegro") { uif.rbAllegro.Checked = true; }
            else if (needle == "mail") { uif.rbMail.Checked = true; }
            else if (needle == "telefon") { uif.rbTelefon.Checked = true; }
        }

        public void fOrder(UIform uif, string needle)
        {
            if (needle == "paragon") { uif.rbParagon.Checked = true; }
            else if (needle == "faktura") { uif.rbFaktura.Checked = true; }
        }
    }
}
