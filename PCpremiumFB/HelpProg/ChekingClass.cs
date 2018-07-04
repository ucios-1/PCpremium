using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCpremiumFB.HelpProg
{
    public class ChekingClass : UIform
    {
        public string comCase(UIform uif)
        {
            if (uif.rbUSFF.Checked) { return "USFF"; }
            else if (uif.rbSFF.Checked) { return "SFF"; }
            else if (uif.rbDesktop.Checked) { return "Desktop"; }
            else if (uif.rbTower.Checked) { return "Tower"; }
            else { return null; }
        }
        public string disc1Type(UIform uif)
        {
            if (uif.rbSSD.Checked) { return "SSD"; }
            else if (uif.rbHDD.Checked) { return "HDD"; }
            else if (uif.rbSSHD.Checked) { return "SSHD"; }
            else { return null; }
        }

        public string disc1Old(UIform uif)
        {
            if (uif.rbNowy.Checked) { return "nowy"; }
            else if (uif.rbUzywany.Checked) { return "używany"; }
            else { return null; }
        }

        public string disc2Type(UIform uif)
        {
            if (uif.rbSSD2.Checked) { return "SSD"; }
            else if (uif.rbHDD2.Checked) { return "HDD"; }
            else if (uif.rbSSHD2.Checked) { return "SSHD"; }
            else { return "brak"; }
        }

        public string disc2Old(UIform uif)
        {
            if (uif.rbNowy2.Checked) { return "nowy"; }
            else if (uif.rbUzywany2.Checked) { return "używany"; }
            else { return "brak"; }
        }

        public string CD(UIform uif)
        {
            if (uif.rbBrak.Checked) { return "Brak"; }
            else if (uif.rbCombo.Checked) { return "COMBO"; }
            else if (uif.rbDVD.Checked) { return "DVD"; }
            else if (uif.rbDVD_RW.Checked) { return "DVD-RW"; }
            else { return null; }
        }

        public string comSystem(UIform uif)
        {
            if (uif.rbOS.Checked) { return "OS"; }
            else if (uif.rb7.Checked) { return "7"; }
            else if (uif.rb8.Checked) { return "8"; }
            else if (uif.rb10.Checked) { return "10"; }
            else if (uif.rbXP.Checked) { return "XP"; }
            else if (uif.rbVISTA.Checked) { return "VISTA"; }
            else { return null; }
        }

        public string comSystemBit(UIform uif)
        {
            if (uif.rb64.Checked) { return "64"; }
            else if (uif.rb32.Checked) { return "32"; }
            else { return null; }
        }

        public string comSystemB(UIform uif)
        {
            if (uif.rbBI.Checked) { return "BI"; }
            else if (uif.rbBL.Checked) { return "BL"; }
            else { return null; }
        }

        public string comSystemHmPr(UIform uif)
        {
            if (uif.rbPro.Checked) { return "PRO"; }
            else if (uif.rbHome.Checked) { return "HOME"; }
            else { return null; }
        }

        public string comSystemOrig(UIform uif)
        {
            if (uif.rbOriginal.Checked) { return "Original"; }
            else if (uif.rbMAR.Checked) { return "MAR"; }
            else if (uif.rbOEM.Checked) { return "OEM"; }
            else { return null; }
        }

        public string payment(UIform uif)
        {
            if (uif.rbSklep.Checked) { return "sklep"; }
            else if (uif.rbESklep.Checked) { return "e-sklep"; }
            else if (uif.rbAllegro.Checked) { return "allegro"; }
            else if (uif.rbMail.Checked) { return "mail"; }
            else if (uif.rbTelefon.Checked) { return "telefon"; }
            else { return null; }
        }

        public string order(UIform uif)
        {
            if (uif.rbParagon.Checked) { return "paragon"; }
            else if (uif.rbFaktura.Checked) { return "faktura"; }
            else { return null; }
        }
    }
}
